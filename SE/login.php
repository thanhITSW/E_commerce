<?php
    session_start();
    if (isset($_SESSION['phone'])) {
        header('Location: index.php');
        exit();
    }

    include('connect.php');   
?>

<?php
if(isset($_POST['login'])) {
    $phone = $_POST['phone'];
    $password = md5($_POST['password']); #ma hoa password bang md5
    if($phone == '' || $password == '') {
        echo '<p>Please insert your account</p>';
    }else{
        $sql_select_customer = mysqli_query($conn, "SELECT *FROM customer WHERE phoneCustomer='$phone' AND passCustomer='$password' LIMIT 1");
        $count = mysqli_num_rows($sql_select_customer);
        $row_login = mysqli_fetch_array($sql_select_customer);

        if($count > 0) {
            $_SESSION['login'] = $row_login['customer_name'];
            $_SESSION['customer_id'] = $row_login['idCustomer'];
            header('Location: index.php');
        }else {
            echo'<p>Email or Password Wrong</p>';
        }
    }
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Login Form</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
    <link rel="stylesheet"href="login.css">
</head>
<body>
    <div class="bg-img">
    <div class="content">

        <header>Login</header>
        <form action="" method="post">
            <div class="field">
                <span class="fa fa-user"></span>
                <input name="phone" type="text" required placeholder="Enter Phone Number" />
            </div>
            <div class="field space">
                <span class="fa fa-lock"></span>
                <input name="password" type="password" class="pass" required placeholder="Enter Password" />
            </div>
            <div class="bsubmit">
                <button class="submit" name="login" type="submit">Go</button>
            </div>
        </form>
    </div>
</div>
</body>