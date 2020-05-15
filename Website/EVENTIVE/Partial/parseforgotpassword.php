<?php
include_once 'Resource/Database.php';
include_once 'Resource/utilities.php';

if (isset($_POST['ressetBtn'])){

$form_errors=array();

$required_fields=array('Email','new_password','confirm_password');

$form_errors=array_merge($form_errors,check_empty_fields($required_fields));
$field_to_check_length=array('new_password'=>6,'confirm_password'=>6);

$form_errors=array_merge($form_errors,check_min_length($field_to_check_length));

$form_errors=array_merge($form_errors,check_email($_POST));


if (empty($form_errors)){

$email=$_POST['Email'];
$newPassword=$_POST['new_password'];
$confirmPassword=$_POST['confirm_password'];

if ($newPassword!=$confirmPassword){
$result="<p style='color: red'>Password and Password confirmation does not match </p>";
}
else{
try{
$sqlQuery="SELECT Email FROM VISITOR WHERE Email= :Email ";
$statement=$db->prepare($sqlQuery);
$statement->execute(array(':Email'=>$email));

if ($statement->rowCount()==1){
$hashed_password=password_hash($newPassword,PASSWORD_DEFAULT);

$sqlUpdate="UPDATE VISITOR SET Password=:Password WHERE Email=:Email";

$statement=$db->prepare($sqlUpdate);
$statement->execute(array(':Password'=>$hashed_password,':Email'=>$email));

$result="<script type=\"text/javascript\">swal({
                                                          type: 'success',
                                                          text: 'Your password changed successfully ',
                                                          timer: 4000,
                                                        });
                                                        setTimeout(function() {
                                                        window.location.href='index.php';
                                                          
                                                        },5000);
                                                        
                                                        </script>";;
}
else{
    $result="<script type=\"text/javascript\">swal({
                                              type: 'error',
                                              title: 'Oops...',
                                              text: 'Email Does NOT existed in our Database!',
                                              footer: '<a href=signup.php>Not a member?Sign up Now!?</a>'
                                                });
                                                        setTimeout(function() {
                                                        window.location.href='index.php';
                                                          
                                                        },10000);
                                                        
                                                        </script>";;
}
}
catch (PDOException $ex){
$result="<p style='color: red'> An error occurred". $ex->getMessage() . "</p>";
}
}
}
else{
if (count($form_errors)==1){
$result="<p style='color: red'>There was an Error in the form  </p>";
}
else{
$result="<p style='color: red'>There were".count($form_errors) ." Errors in the form  </p>";
}
}


}

?>