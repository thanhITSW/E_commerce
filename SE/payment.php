<?php 
session_start();

include('connect.php');
require('mail/sendmail.php');

// if (!isset($_SESSION['idCustomer'])) {
//     header("Location: login.php");
//         exit;
//     }
//     $id = $_SESSION['idCustomer'];
//     $name = $_SESSION['nameCustomer'];
//     $phone = $_SESSION['phoneCustomer'];
//     $address = $_SESSION['addressCustomer']; 

$title = "OrderSuccessfull";
$body = "<p>Your comany order successfull</p>";
$mailCustomer = $_SESSION['emailCustomer']; 

$mail = new Mailer();
$mail->mail($title,$body,$mailCustomer);
?>
