<?php

$username='root';
$password='';
$dsn='mysql:host=localhost; dbname=dbi334234';
try{
    $db =new PDO($dsn,$username,$password);


    $db->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
}
catch (PDOException $ex){
    echo "Failed connection to Database ".$ex->getMessage();
}
