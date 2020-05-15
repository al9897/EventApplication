<?php
include_once '../Resource/Database.php';
include_once '../Resource/session.php';
include_once '../Resource/utilities.php';

$sqlQuery="select * from EVENTACCOUNT where VisitorNo= :VisitorNo ";
$statement=$db->prepare($sqlQuery);
$statement->execute(array(':VisitorNo'=>$_SESSION['id']));
while ($row=$statement->fetch()){
    $accountNo=$row['AccountNo'];
    $currentBalance=$row['Balance'];
    $ticketNo=$row['TicketNo'];
    $campingSpotNo=$row['CampingSpotNo'];

    $sqlQuery="select * from VISITOR where VisitorNo= :VisitorNo ";
    $statement=$db->prepare($sqlQuery);
    $statement->execute(array(':VisitorNo'=>$_SESSION['id']));
    while ($row=$statement->fetch()){

        $username=$row['UserName'];
        $firstName=$row['FirstName'];
        $email=$row['Email'];


    }

    #if (isset($email)){echo $email;}else{echo "no email";}

}
$sqlQuery="select MAX(TicketNo) as ticketNo from EVENTACCOUNT ";
$statement=$db->prepare($sqlQuery);
$statement->execute(array(':VisitorNo'=>$_SESSION['id']));
while ($row=$statement->fetch()){

    $newTicketNo=$row['ticketNo'];

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

        if (!isset($ticketNo)){
            if (!isset($campingSpotNo)){
                if (empty(isset($_POST['NrOfTicket']))) {
                    echo "Insert your ticket number";
                }else{
                    $numberOfTicket = $_POST['NrOfTicket'];
                    $totalToPay = $numberOfTicket * 55;

                    if (empty(isset($_POST['stay']))) {
                        if ($currentBalance < $totalToPay) {
                            $campingData="No camping. <br> you do not have enough balance. <a href='../tickets.php' >Try again</a>";
                            echo " <script>

                    alert('you do not have enough balance.You will be redirected to profile.');
                    
                    setTimeout(window.location='../profileeventive2.php',1000);
                    
                    
                 </script>";


                        }else{

                            $currentBalance -= $totalToPay;

                            $newTicketNo+=1;
                            $sqlQuery = "UPDATE EVENTACCOUNT SET Balance=$currentBalance ,TicketNo=$newTicketNo WHERE VisitorNo= :VisitorNo  ";
                            $statement = $db->prepare($sqlQuery);
                            $statement->execute(array(':VisitorNo' => $_SESSION['id']));


                            $sqlQuery1 = "INSERT INTO TRANSACTIONS (AccountNo,DateTime,Amount) values (:AccountNo,:DateTime,:Amount)";
                            $statement1 = $db->prepare($sqlQuery1);
                            $statement1->execute(array(':AccountNo' => $accountNo, ':DateTime' => date("Y/m/d H:i:s"), ':Amount' => $totalToPay));




                            $campingData="Congrats!
Transaction Successful
CurrentBalance: '$currentBalance'
You have bought Ticket for FEM
----------------------------------
Please note:
Currently you DO NOT have access to camping spot.You can buy your camping spot under the link: i400406.hera.fhict.nl/tickets.php

Once you have your camping spot, it is possible to add your friends into it through your Profile.

Enjoy!
with best Regards
Your Eventive team  ";
                            mail($email,"Ticket Information ",$campingData);



                            echo "<script>

                    alert('you bought ticket without camping spot');
                    
                    setTimeout(window.location='../profileeventive2.php',1000);
                    
                    
                 </script>";

                        }

                    }elseif ($currentBalance < $totalToPay) {
                        $campingData="No camping. <br> you do not have enough balance. <a href='../tickets.php' >Try again</a>";

                        echo "<script>

                    alert('you do not have enough balance.You will be redirected to profile.');
                    
                    setTimeout(window.location='../profileeventive2.php',1000);
                    
                    
                 </script>";


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

                        $newTicketNo+=1;

                        $sqlQuery = "UPDATE EVENTACCOUNT SET Balance=$currentBalance ,CampingSpotNo=$campingSpotNo,TicketPaidMethod='O',TicketNo=$newTicketNo WHERE VisitorNo= :VisitorNo  ";
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
You have bought Ticket for FEM
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
                        mail($email,"Ticket Information ",$campingData);
                        echo "<script>

                    alert('you bought ticket and camping spot');
                    
                    setTimeout(window.location='../profileeventive2.php',1000);
                    
                    
                 </script>";




                    }
                }
            }

            }
            else{echo "<script>

                    alert('You already have ticket.In case you need camping spot please buy from the link your profile.');
                    
                    setTimeout(window.location='../profileeventive2.php',1000);
                    
                    
                 </script>";
                }
        }
        else{echo "you already have ticket and camping spot";}


    }
