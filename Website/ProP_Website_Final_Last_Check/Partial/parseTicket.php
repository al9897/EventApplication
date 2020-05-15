<?php
include_once 'Resource/Database.php';
include_once 'Resource/session.php';
include_once 'Resource/utilities.php';


$con=mysqli_connect('localhost','root','','ProP');
if (!$con){
    echo "database error";
}

$sqlQuery="SELECT count(*) AS available FROM CAMPINGSPOT where booked ='n'";
$res=mysqli_query($con,$sqlQuery);
$availableTents=mysqli_fetch_array($res);

$sqlQuery="SELECT CampingSpotNo FROM CAMPINGSPOT where booked ='n'";
$res=mysqli_query($con,$sqlQuery);
$availableTents=mysqli_fetch_array($res);
$nr=$availableTents;

$totalToPay=0;

if (isset($_POST['ticketBtn'])){

    $nrOfTicket=$_POST['NrOfTicket'];

    $totalToPay=55*$nrOfTicket;
    if (isset($_POST['stay'])){
        $totalToPay+=20;
    }


    $_SESSION['TTP']=$totalToPay;

}

