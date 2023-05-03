<?php
    session_start();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Trang chủ - Danh sách sản phẩm</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css" integrity="sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <style>
        td {
            vertical-align: middle;
        }
        img {
            max-height: 100px;
        }
        #cart {
            margin-left: auto;
            padding-right: 20px;
        }
        #quantity {
            width: 30px;
        }
        .seetotal {
            width: 100px;
            margin-right: 30px;
            padding-right: 20px;
            text-align: center;
        }
    </style>
</head>
<body>
<?php
// session_destroy();
    include "connect.php";
    if(!isset($_SESSION["cart"])) {
        $_SESSION["cart"] = array();
    }
    if(isset($_GET['action'])) {
        switch($_GET['action']) {
            case "add":
                foreach($_POST['quantity'] as $idItem => $quantity) {
                    $_SESSION["cart"][$idItem] = $quantity;
                    // echo $price;
                    // var_dump($_POST);
                    echo $quantity;
                }
                header("Location: cart.php");
                exit;
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
            <h3 class="my-4 text-center">Card</h3>
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
                $num = 1;
                        while($row = mysqli_fetch_array($product)) {
                        
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
                            $price = number_format(floatval($row['priceItem']) * floatval($quantity));
                            // echo $price;
                            $_SESSION['price'] = $price;                
                    ?>  
                    <td class="align-middle" ><input type="number" id="quantity" value="<?=$_SESSION["cart"][$row['idItem']]?>" name="quantity[<?=$row['idItem']?>]" /></td>    
                    <td class="align-middle" ><?=$_SESSION['price']?>$</td>
                    <td class="align-middle">
                    <input placeholder="Delete" value="Add" type="submit" name="addcart">
                    </td>
                </tr>
                <?php
                $num++;
                }
                ?>
                <tr>
                <td class="product-number">&nbsp;</td>
                <td class="product-name">Total</td>
                <td class="product-img">&nbsp;</td>
                <td class="product-price"></td>
                <td class="product-quantity">&nbsp;</td>
                <td class="total-money"></td>
                <td class="product-delete"></td>
                </tr>
                <tr>
                <td colspan="7" class=""><input class="seetotal" value="See Total" type="submit" name="seetotal"></td>
                </tr>
            </table>
            <table>
                

                
            </table>    
            </form>
            <!-- <p class="text-right">Total products: <strong>2</strong></p> -->
            <!-- <p>Thank you to choose my shop to supply product</p> -->
        </div>
    </div>
</div>

    
</body>
</html>