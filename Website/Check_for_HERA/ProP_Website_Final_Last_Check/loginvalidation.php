<?php
include_once 'Resource/Database.php';
include_once 'Resource/utilities.php';
include_once 'Resource/session.php';
if (isset($_POST['loginBtn]'])){

    $Lform_errors=array();

    $Lrequired_fields= array('login_username','login_password');

    $Lform_errors=array_merge($Lform_errors,check_empty_fields($Lform_errors));

    if (empty($Lform_errors)){

        echo "its ok !";

    }
    else{
        if(count($Lform_errors) == 1){
            $Lresult = "<p style='color: red;'> There was 1 error in the form<br>";
        }else{
            $Lresult = "<p style='color: red;'> There were " .count($Lform_errors). " errors in the form <br>";
        }
    }
}
