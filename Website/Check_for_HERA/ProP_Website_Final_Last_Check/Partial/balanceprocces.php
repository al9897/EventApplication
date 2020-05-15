<?php
include_once '../Resource/Database.php';
include_once '../Resource/session.php';
include_once '../Resource/utilities.php';

echo $_SESSION['Username'];
$sqlQuery="select * from EVENTACCOUNT where VisitorNo= :VisitorNo ";
$statement=$db->prepare($sqlQuery);
$statement->execute(array(':VisitorNo'=>$_SESSION['id']));
while ($row=$statement->fetch()){
    $accountNo=$row['AccountNo'];
    $currentBalance=$row['Balance'];

}

if (isset($_POST['amount'])){$amount=$_POST['amount'];

if (isset($_POST['IdealBtn']))

{

    $currentBalance+=$amount;
    $sqlQuery="UPDATE EVENTACCOUNT SET Balance=$currentBalance WHERE VisitorNo= :VisitorNo  ";
    $statement=$db->prepare($sqlQuery);
    $statement->execute(array(':VisitorNo'=>$_SESSION['id']));

    $sqlQuery="INSERT INTO TRANSACTIONS (AccountNo,DateTime,Amount) values (:AccountNo,:DateTime,:Amount)";
    $statement=$db->prepare($sqlQuery);
    $statement->execute(array(':AccountNo'=>$accountNo,':DateTime'=>date("Y/m/d H:i:s"),':Amount'=>$amount));




    echo "<p class='alert-success'>Ideal: <br> You have added " . $amount . " euro(s) into your account <br>
          new balance is".$currentBalance."</p>";

    redirectTo('../profileeventive2');


}elseif(isset($_POST['PaypalBtn']))
    {

        $currentBalance+=$amount;
        $sqlQuery="UPDATE EVENTACCOUNT SET Balance=$currentBalance WHERE VisitorNo= :VisitorNo  ";
        $statement=$db->prepare($sqlQuery);
        $statement->execute(array(':VisitorNo'=>$_SESSION['id']));

        $sqlQuery="INSERT INTO TRANSACTIONS (AccountNo,DateTime,Amount) values (:AccountNo,:DateTime,:Amount)";
        $statement=$db->prepare($sqlQuery);
        $statement->execute(array(':AccountNo'=>$accountNo,':DateTime'=>date("Y/m/d H:i:s"),':Amount'=>$amount));





        echo "<p class='alert-success'>Paypal: <br> You have added " . $amount . " euro(s) into your account <br>
          new balance is".$currentBalance."</p>";

        redirectTo('../profileeventive2');


    }}else{
    if (isset($_POST['ticketBtn']) ) {
    if (empty(isset($_POST['NrOfTicket']))) {
        echo "Insert your ticket number";
}else{
        $numberOfTicket = $_POST['NrOfTicket'];
        $totalToPay = $numberOfTicket * 55;

        if (empty(isset($_POST['stay']))) {
            if ($currentBalance < $totalToPay) {
                echo "Not enough balance";
            }else{

                $currentBalance -= $totalToPay;

                $sqlQuery = "UPDATE EVENTACCOUNT SET Balance=$currentBalance WHERE VisitorNo= :VisitorNo  ";
                $statement = $db->prepare($sqlQuery);
                $statement->execute(array(':VisitorNo' => $_SESSION['id']));

                $sqlQuery1 = "INSERT INTO TRANSACTIONS (AccountNo,DateTime,Amount) values (:AccountNo,:DateTime,:Amount)";
                $statement1 = $db->prepare($sqlQuery1);
                $statement1->execute(array(':AccountNo' => $accountNo, ':DateTime' => date("Y/m/d H:i:s"), ':Amount' => $totalToPay));

                echo "NO TENT <br>Ticket bought<br>Transaction Suucessfucl<br>CurrentBalance:".$currentBalance;
            }

        }elseif ($currentBalance < $totalToPay) {
            echo "Not enough balance";
        }else{
            $sqlQuery = "select * from CAMPINGSPOT where Booked= :Booked";
            $statement = $db->prepare($sqlQuery);
            $statement->execute(array(':Booked' => "n"));

            while ($row = $statement->fetch()) {

                $campingSpotNo = $row['CampingSpotNo'];
                $tentPrice = $row['Price'];
                $totalToPay += $tentPrice + 20;
            }

            $sqlQuery = "UPDATE CAMPINGSPOT SET Booked='y' WHERE CampingSpotNo=:CampingSpotNo  ";
            $statement = $db->prepare($sqlQuery);
            $statement->execute(array(':CampingSpotNo' => $campingSpotNo ));

            $currentBalance -= $totalToPay;

            $sqlQuery = "UPDATE EVENTACCOUNT SET Balance=$currentBalance ,CampingSpotNo=$campingSpotNo,TicketPaidMethod='O' WHERE VisitorNo= :VisitorNo  ";
            $statement = $db->prepare($sqlQuery);
            $statement->execute(array(':VisitorNo' => $_SESSION['id']));

            $sqlQuery1 = "INSERT INTO TRANSACTIONS (AccountNo,DateTime,Amount) values (:AccountNo,:DateTime,:Amount)";
            $statement1 = $db->prepare($sqlQuery1);
            $statement1->execute(array(':AccountNo' => $accountNo, ':DateTime' => date("Y/m/d H:i:s"), ':Amount' => $totalToPay));
            echo "Tent added".$campingSpotNo."<br>Ticket bought<br>Transaction successful<br>CurrentBalance: ".$currentBalance;

        }
    }
}}