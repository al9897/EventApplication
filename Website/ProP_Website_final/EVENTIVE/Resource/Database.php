<?php

$username='root';
$password='';
$dsn='mysql:host=localhost; dbname=ProPFinal';
try{
    $db =new PDO($dsn,$username,$password);


    $db->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
}
catch (PDOException $ex){
    echo "Failed connection to Database ".$ex->getMessage();
}
