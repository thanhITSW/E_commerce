
    <!-- // session_start();
    // if (isset($_SESSION['phone'])) {
    //     header('Location: index.php');
    //     exit();
    // } -->

<?php
session_start();
include('connect.php');   


if(isset($_POST['login'])) {
    $phone = $_POST['phone'];
    $password = md5($_POST['password']); #ma hoa password bang md5
    if($phone == '' || $password == '') {
        echo '<p>Please insert your account</p>';
    } else {
        $sql = "SELECT *FROM customer WHERE phoneCustomer='$phone' AND passCustomer='$password'";
       
        $result = $conn->query($sql);

        if($result->num_rows > 0) {
            $row_login = $result->fetch_assoc();
            $_SESSION['idCustomer'] = $row_login['idCustomer'];
            $_SESSION['nameCustomer'] = $row_login['nameCustomer'];
            $_SESSION['phoneCustomer'] = $row_login['phoneCustomer'];
            $_SESSION['addressCustomer'] = $row_login['addressCustomer'];
            $_SESSION['emailCustomer'] = $row_login['emailCustomer'];
            header('Location: index.php');
            exit;
          
        } else {
            echo '<p>Email or Password Wrong</p>';
        }
    }
}
$conn->close();
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
    <link rel="stylesheet"href="css/login.css">
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