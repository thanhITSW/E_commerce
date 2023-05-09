<?php 
include "PHPMailer/src/PHPMailer.php";
include "PHPMailer/src/Exception.php";
include "PHPMailer/src/OAuth.php";
include "PHPMailer/src/POP3.php";
include "PHPMailer/src/SMTP.php";

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

class Mailer{
	public function mail($title,$body,$mailCustomer){
	
		$mail = new PHPMailer(true);
		$mail->CharSet = 'UTF-8';
		try {
		    //Server settings
		    $mail->SMTPDebug = 0;                                 // Enable verbose debug output
		    $mail->isSMTP();                                      // Set mailer to use SMTP
		    $mail->Host = 'smtp.gmail.com';  // Specify main and backup SMTP servers
		    $mail->SMTPAuth = true;                               // Enable SMTP authentication
		    $mail->Username = '1lytravai@gmail.com';                 // SMTP username
		    $mail->Password = 'qkirbqvfpdkcwpfi';                           // SMTP password 
		    $mail->SMTPSecure = 'tls';                            // Enable TLS encryption, `ssl` also accepted
		    $mail->Port = 587;                                    // TCP port to connect to
		 
		    //Recipients
		    $mail->setFrom('1lytravai@gmail.com', 'Mailer');
		    
		    $mail->addAddress($mailCustomer, 'Customer');     // Add a recipient
		   
		    // Name is optional
		    // $mail->addReplyTo('info@example.com', 'Information');
		    $mail->addCC('1lytravai@gmail.com');
		    // $mail->addBCC('bcc@example.com');
		 
		    //Attachments
		    // $mail->addAttachment('/var/tmp/file.tar.gz');         // Add attachments
		    // $mail->addAttachment('/tmp/image.jpg', 'new.jpg');    // Optional name
		 
		    //Content
		    $mail->isHTML(true);                                  // Set email format to HTML
		    $mail->Subject = $title;
		    $mail->Body    = $body;
		    // $mail->AltBody = 'This is the body in plain text for non-HTML mail clients';
		 
		    $mail->send();
		    echo 'Message has been sent';

		} catch (Exception $e) {

		    echo 'Message could not be sent. Mailer Error: ', $mail->ErrorInfo;
		}
	}
}
?>