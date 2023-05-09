<?php
    session_start();
    if (!isset($_SESSION['idCustomer'])) {
        // Nếu không có, chuyển hướng về trang đăng nhập
        header("Location: login.php");
            exit;
        }
        $id = $_SESSION['idCustomer'];
        $name = $_SESSION['nameCustomer'];
        $phone = $_SESSION['phoneCustomer'];
        $address = $_SESSION['addressCustomer']; 
        $email = $_SESSION['emailCustomer']; 
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Shopping Cart</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css" integrity="sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="stylesheet" href="css/cart.css">
    
    
</head>
<body>
<?php
// session_destroy();
    include "connect.php";
    if(!isset($_SESSION["cart"])) {
        $_SESSION["cart"] = array();
    }
    $error = false;
    $success = false;
    if(isset($_GET['action'])) {
        function update_cart($add = false) {
            foreach ($_POST['quantity'] as $idItem => $quantity){
                if($quantity <= 0) { #san phẩm có số lượng = 0 thì xóa khỏi giỏ hàng
                    unset( $_SESSION["cart"][$idItem]);
                }else {
                    if($add) { 
                        $_SESSION["cart"][$idItem] += $quantity;
                    }else {
                        $_SESSION["cart"][$idItem] = $quantity;
                    }
                }
            }
        }
        switch($_GET['action']) {
            case "add": 
                update_cart(true);
                // foreach($_POST['quantity'] as $idItem => $quantity) {
                //     $_SESSION["cart"][$idItem] = $quantity;
                //     echo $price;
                //     var_dump($_POST);
                //     echo $quantity;
                    header("Location: ./cart.php");
                    break;
               
            case "delete":
                if(isset($_GET['idItem'])) {
                    unset($_SESSION["cart"][$_GET["idItem"]]);
                }
                header("Location: ./cart.php");
                break;
            case "submit": 
                if(isset($_POST['update_click'])) { #update lại sản phẩm trong giỏ
                    update_cart();
                    header('Location: ./cart.php');
                }else if(isset($_POST['order_click'])) { #nhấn gửi thông tin đặt hàng
                    if(empty($_POST['name'])){
                        $error = "Please input your information";
                    }
                    else if(empty($_POST['phone'])) {
                        $error = "Please input your information";
                    }
                    else if(empty($_POST['address'])) {
                        $error = "Please input your information";
                    }
                    else if(empty($_POST['pay'])) {
                        $error = "Please input your information";
                    }
                    if ($error == false && !empty($_POST['quantity'])) { //Xử lý lưu giỏ hàng vào db
                        $product = mysqli_query($conn, "SELECT * FROM `item` WHERE `idItem` IN ('" . implode("','", array_keys($_POST['quantity'])) . "')");
                        $total = 0;
                        $orderProducts = array();
                        while ($row = mysqli_fetch_array($product)) {
                            $orderProducts[] = $row;
                            $total += $row['priceItem'] * $_POST['quantity'][$row['idItem']]; #tính tổng tiền sản phẩm
                    }
                
                    // INSERT INTO `orders` (`idOrder`, `idCustomer`, `paymentMethod`, `creationDate`, `totalPrice`) VALUES ('1', 'cus1', 'chuyển khoản', '2023-05-02', '400');

                    #gửi về database thông tin đơn hàng
                    $insertOrder = mysqli_query($conn, "INSERT INTO `orders` (`idOrder`, `idCustomer`,  `paymentMethod`, `creationDate`, `totalPrice`) VALUES (NULL, '" . $id . "', '". $_POST['pay']. " ', '" . time() . "','" . $total . "');");
                    $orderID = $conn->insert_id;
                    $insertString = "";
                    foreach ($orderProducts as $key => $product) {
                        $insertString .= "(NULL, '" . $product['idItem'] . "', '" . $orderID . "', '" . $product['priceItem'] . "',  '" . $_POST['quantity'][$product['idItem']] . "')";
                        if ($key != count($orderProducts) - 1) {
                            $insertString .= ",";
                        }
                    }
            
                    $insertOrder = mysqli_query($conn, "INSERT INTO `detailorder` (`id`, `idItem`, `idOrder`, `price`, `quantity`) VALUES " . $insertString . ";");
                    $success = "Successfull";
                    unset($_SESSION['cart']);
                    header("Location: payment.php"); #mua thành công sẽ sang trang payment và thông báo mua hàng về mail
                }
            }
            break;
        } 
        
    }   
    
    if(!empty($_SESSION["cart"])) {
        $ids = array_map(function ($idItem) {
            return "'" . $idItem . "'";
          }, array_keys($_SESSION["cart"])); // Tạo mảng mới bao gồm các ID với giá trị của nó đặt trong dấu ngoặc kép
          
          $idList = implode(",", $ids); // Biến đổi mảng các ID thành chuỗi có dạng "'1', '2'"
          
          $product = mysqli_query($conn, "SELECT * FROM `item` WHERE `idItem` IN (". $idList .")"); // Sử dụng chuỗi chuẩn truy vấn SQL để lấy thông tin của các sản phẩm trong giỏ hàng
        // var_dump($product);
    }
?>
<div class="container">
    <div class="row justify-content-center">
        <div class="col col-md-10">
            <h3 class="my-4 text-center">Cart</h3>
            <div class="d-flex justify-content-between">
                <a class="btn btn-sm btn-secondary mb-4" href="index.php">Return Product List</a>
                <a href="login.php">Logout</a>
            </div>
            
            <table class="table-bordered table table-hover text-center">
                <tr>
                    <th>Number</th>
                    <th>Image</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Total</th>
                    <th>Action</th>
                </tr>

            <?php
                if(!empty($product)){
                    $total = 0;
                    $num = 1;
                    while($row = mysqli_fetch_array($product)) { #vòng lặp sp
            ?>
            <tr>
            <form action="cart.php?action=submit" method="POST">
                <td class="align-middle"><?=$num?></td> 
                <td class="align-middle"><img src="images/<?=$row['image']?>"></td>
                <td class="align-middle"><?php echo $row['nameItem'] ?></td>
                <td class="align-middle"><?=$row['priceItem']?>$</td>
                <?php
                        $quantity = '';
                        if(isset($_POST['quantity'][$row['idItem']])) {
                            $quantity = $_POST['quantity'][$row['idItem']];
                            
                        }
                        if(isset($_GET['addcart'])) {
                            foreach($_POST["quantity"] as $idItem => $quantity) {
                                $_SESSION["cart"][$idItem] = $quantity; // Lưu thông tin giỏ hàng vào session   
                            }         
                        }    
                        // $price = number_format()        
                ?>  
                <td class="align-middle" ><input type="number" min="0" id="quantity" value="<?=$_SESSION["cart"][$row['idItem']]?>" name="quantity[<?=$row['idItem']?>]" /></td>    
                <td class="align-middle"><?= number_format($row['priceItem'] * $_SESSION["cart"][$row['idItem']], 0, ",", ".") ?>$</td> 
                <td class="align-middle"><a href="cart.php?action=delete&idItem=<?=$row['idItem']?>">Delete</a></td>
            </tr>
            <?php
                #tính tổng giỏ hàng
                $total += $row['priceItem'] * $_SESSION["cart"][$row['idItem']];
                $num++;
                }
            ?>
            <tr>
            <td class="product-number">&nbsp;</td>
            <td class="product-name">Total</td>
            <td class="product-img">&nbsp;</td>
            <td class="product-price"></td>
            <td class="product-quantity">&nbsp;</td>
            <td class="total-money"><?= number_format($total, 0, ",", ".") ?>$</td>
            <td class="product-delete"></td>
            </tr>
            <?php 
            }
            ?>
                <tr>
                <td colspan="7" class="">
                    <input class="seetotal" value="update" type="submit" name="update_click">
                </td>
                </tr>
            </table>
            </div>
    </div>
</div>

<div class="info">
            <?php if (!empty($error)) { ?> 
                <div id="notify-msg">
                    <!-- có lỗi thì thông báo -->
                    <?= $error ?>. <a href="javascript:history.back()">return</a>
                </div>
            <?php } else if (!empty($success)) { ?>
                <!-- nếu mua thanh công thì thông báo -->
                <div id="notify-msg">
                    <?= $success ?>. <a href="index.php">Buy More</a>
                </div>
            <?php } else { ?>
            <form action="cart.php?action=submit" method="POST">
            <div class="field">
                <p>Name</p>
                <input name="name" type="text" value="<?=$name?>"></input>
            </div>
            <div class="field">
                <p>Number Phone</p>
                <input name="phone" type="text" value="<?=$phone?>"></input>
            </div>
            <div class="field">
                <p>Address</p>
                <input class="address" name="address" type="text" value="<?=$address?>"></input>
            </div>
            <div class="field">
                <p>Email</p>
                <input class="email" name="email" type="text" value="<?=$email?>"></input>
            </div>
            <div class="field">
                <label for="pay">Payment Method</label>
                <div>
                <label for="qr" class="radio-inline">
                    <input type="radio" name="pay" value="q" id="qr"/>QR</label>
                <label for="money" class="radio-inline">
                    <input type="radio" name="pay" value="m" id="money"/>Cash</label>
            </div>
            <input class="a" type="submit" name="order_click" value="order" />
            </form>
            <!-- <p class="text-right">Total products: <strong>2</strong></p> -->
            <!-- <p>Thank you to choose my shop to supply product</p> -->
     
</div>
<?php } ?>
</body>
</html>