<?php
include_once '../Resource/Database.php';
include_once '../Resource/session.php';
include_once '../Resource/utilities.php';
$user=$_SESSION['Username'];

$REmail=$_POST['REmail'];

$sqlQuery="SELECT * FROM VISITOR WHERE UserName= :UserName";
$statement= $db->prepare($sqlQuery);
$statement->execute(array(':UserName'=> $user));


while ($row = $statement->fetch()){

    $Username=$row['UserName'];
    $FName=$row['FirstName'];
    $DOB=$row['DOB'];
    $Phone=$row['PhoneNumber'];
    $Address=$row['Address'];
    $visitorNr=$row['VisitorNo'];
    $ticketNr=rand(1111,9999).$visitorNr.rand(3333,7777);


}

if (isset($_POST['PaymentBtn'])){
   $mail= mail($REmail, 'Payment Confirmation',
        'Dear' .$FName.'<br>
                    Thank you for purchasing Eventive-FEM ticket.<br>
                    Your ticket number is'.$ticketNr.'
                    
                    Please Check your personal details below <br>'.$Username.'<br>
                    
                    '.$DOB.'<br>');

   echo $mail;

}