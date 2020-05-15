<?php

include_once 'Resource/Database.php';
include_once 'Resource/utilities.php';
include_once 'Resource/session.php';


$campingSpotNumber=null;
$number = count($_POST["name"]);
if($number > 1)
{



    $sqlQuery="select * from EVENTACCOUNT where VisitorNo= :VisitorNo ";
    $statement=$db->prepare($sqlQuery);
    $statement->execute(array(':VisitorNo'=>$_SESSION['id']));
    while ($row=$statement->fetch()){
        $accountNo=$row['AccountNo'];
        $campingSpotNumber=$row['CampingSpotNo'];
        $balance=$row['Balance'];
    }

    for($i=0; $i<$number; $i++)
    {

        if(trim($_POST["name"][$i] != ''))
        {


            $GetEmail=$_POST["name"][$i];
            $sql ="SELECT * FROM EVENTACCOUNT WHERE VisitorNo IN (SELECT VisitorNo FROM VISITOR WHERE Email=:Email)";
            $statement=$db->prepare($sql);
            $statement->execute(array(':Email'=>$GetEmail));

            $id=0;
            while($row=$statement->fetch()){

                $id=$row['VisitorNo'];

            }
            $sql="UPDATE  EVENTACCOUNT SET CampingSpotNo=$campingSpotNumber WHERE VisitorNo=:VisitorNo ";
            $statement=$db->prepare($sql);
            $statement->execute(array('VisitorNo'=>$id));



            $newBalance="<script>window.localStorage.getItem('newBalance')</script>";





        }
    }

}
else
{
    echo "Please Enter Email";
}
