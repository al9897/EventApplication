<?php
include_once 'Resource/Database.php';
include_once 'Resource/session.php';
include_once 'Resource/utilities.php';

$sqlQuery="select * from EVENTACCOUNT where VisitorNo= :VisitorNo ";
$statement=$db->prepare($sqlQuery);
$statement->execute(array(':VisitorNo'=>$_SESSION['id']));
while ($row=$statement->fetch()) {
    $accountNo = $row['AccountNo'];
    $currentBalance = $row['Balance'];
    $ticketNo=$row['TicketNo'];
    $campingSpotNo=$row['CampingSpotNo'];
}
echo $ticketNo;
echo $campingSpotNo;
if (isset($ticketNo)){

    if (!isset($campingSpotNo)){
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

        $sqlQuery10 = "INSERT INTO RESERVATION (CampingSpotNo,AccountNo) values (:CampingSpotNo,:AccountNo)";
        $statement10 = $db->prepare($sqlQuery10);
        $statement10->execute(array(':CampingSpotNo' => $campingSpotNo, ':AccountNo' => $accountNo));







        $campingData="Congrats!
Transaction Successful
CurrentBalance: '$currentBalance'
You have bought Camping Spot.
----------------------------------
Currently you  have access to camping spot 
Your Camping spot no is: '$campingSpotNo'

It is possible to add your friends into it through your Profile.
Please note:
The price for your guest will be reduced from your account.

Enjoy!
with best Regards
Your Eventive team";
        #echo $campingData;
        echo "success";
        mail($email,"Ticket Information ",$campingData);
        echo "<script>

                    alert('you bought camping spot');
                    
                    setTimeout(window.location='../profileeventive2.php',1000);
                    
                    
                 </script>";
    }
    else{
        echo "Already have camping spot";
    }





}
else{
    echo "no ticket yet add ticket first";
}