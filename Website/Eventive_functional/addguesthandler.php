<?php

include_once 'Resource/Database.php';
include_once 'Resource/utilities.php';
include_once 'Resource/session.php';


$sqlQuery="select * from EVENTACCOUNT where VisitorNo= :VisitorNo ";
$statement4=$db->prepare($sqlQuery);
$statement4->execute(array(':VisitorNo'=>$_SESSION['id']));
while ($row=$statement4->fetch()){
    $accountNo=$row['AccountNo'];
    $campingSpotNumber=$row['CampingSpotNo'];
    $balance=$row['Balance'];
}

$number = count($_POST["name"]);
$amount=0;
$newBalance=$balance;
if($number > 0)
{


    for($i=0; $i<$number; $i++)
    {

        if(trim($_POST["name"][$i] != ''))
        {



            $GetEmail=$_POST["name"][$i];
            $sql ="SELECT * FROM EVENTACCOUNT WHERE VisitorNo IN (SELECT VisitorNo FROM VISITOR WHERE Email=:Email)";
            $statement1=$db->prepare($sql);
            $statement1->execute(array(':Email'=>$GetEmail));

            while($row=$statement1->fetch()){

                $id=$row['VisitorNo'];

                if (isset($id)) {



            if ($balance>($i + 1) * 20) {
                $newBalance = $balance - (($i + 1) * 20);
                $amount=($i + 1) * 20;

                $sql = "UPDATE  EVENTACCOUNT SET CampingSpotNo=$campingSpotNumber WHERE VisitorNo=:VisitorNo ";
                $statement3 = $db->prepare($sql);
                $statement3->execute(array('VisitorNo' => $id));

                $sql = "UPDATE  EVENTACCOUNT SET Balance=$newBalance WHERE VisitorNo=:VisitorNo ";
                $statement2 = $db->prepare($sql);
                $statement2->execute(array('VisitorNo' => $_SESSION['id']));

                mail($GetEmail,"FROM: EVENTIVE ","Congrats!<br> You are adde to tent no. ".$campingSpotNumber."Now you can access to camping spot area. 
                
                Enjoy!<br>
<hr>                
                with kind regards <br>
                     Your Eventive Team
                
                
                ");



                echo $GetEmail." is added.<br> invitation is sent!";
            }
            else{
                echo "Not enough balance";
            }
                            }

                            else{

                                echo 'test';
                            }
                        }

                    }
                    else{
                        echo  "field ". ($i+1) ." is empty<br>email can not be empty";
                    }
                }

                $sqlQuery="INSERT INTO TRANSACTIONS (AccountNo,DateTime,Amount) values (:AccountNo,:DateTime,:Amount)";
                $statement=$db->prepare($sqlQuery);
                $statement->execute(array(':AccountNo'=>$accountNo,':DateTime'=>date("Y/m/d H:i:s"),':Amount'=>$amount));

}
else
{
    echo "Please Enter at least one Email";
}
