<?php
ini_set ('display_errors', 1);
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;
require 'vendor/autoload.php';
 
$mail = new PHPMailer(true);
try {
    //Server settings
    $mail->SMTPDebug = 2;
    $mail->isSMTP(true);
    $mail->Host = 'mail.haugikt.eu';
    $mail->SMTPAuth = true;
    $mail->Username = 'redtool@haugikt.eu';
    $mail->Password = 'Klokkeslett2018.';
    $mail->SMTPSecure = 'tls';
    $mail->Port = 465;
 
 
    $mail->setFrom('redtool@haugikt.eu', 'Admin');
    $mail->addAddress('test-s6jy0@mail-tester.com', 'Recipient1');
 
    //Attachments
 
    //Content
    $mail->isHTML(true);
    $mail->Subject = 'Test Mail Subject!';
    $mail->Body    = 'This is SMTP Email Test';
 
    $mail->send();
    echo 'Message has been sent';
} catch (Exception $e) {
    echo 'Message could not be sent.';
    echo 'Mailer Error: ' . $mail->ErrorInfo;
}
