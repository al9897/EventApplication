<?php

function check_empty_fields($required_fields_array){
    //initialize an array to store error messages
    $form_errors = array();

    //loop through the required fields array snd popular the form error array
    foreach($required_fields_array as $name_of_field){
        if(!isset($_POST[$name_of_field]) || $_POST[$name_of_field] == NULL){
            $form_errors[] = $name_of_field . " is a required field";
        }
    }

    return $form_errors;
}


function check_min_length($fields_to_check_length){
    //initialize an array to store error messages
    $form_errors = array();

    foreach($fields_to_check_length as $name_of_field => $minimum_length_required){
        if(strlen(trim($_POST[$name_of_field])) < $minimum_length_required){
            $form_errors[] = $name_of_field . " is too short, must be {$minimum_length_required} characters long";
        }
    }
    return $form_errors;
}

function check_email($data){
    //initialize an array to store error messages
    $form_errors = array();
    $key = 'signup_email';
    //check if the key email exist in data array
    if(array_key_exists($key, $data)){

        //check if the email field has a value
        if($_POST[$key] != null){

            // Remove all illegal characters from email
            $key = filter_var($key, FILTER_SANITIZE_EMAIL);

            //check if input is a valid email address
            if(filter_var($_POST[$key], FILTER_VALIDATE_EMAIL) === false){
                $form_errors[] = $key . " is not a valid email address";
            }
        }
    }
    return $form_errors;
}

function show_errors($form_errors_array){
    $errors = "<p><ul style='color: red;'>";

    //loop through error array and display all items in a list
    foreach($form_errors_array as $the_error){
        $errors .= "<li> {$the_error} </li>";
    }
    $errors .= "</ul></p>";
    return $errors;
}
function flashmessage($message,$passOrFail="Fail"){
    if ($passOrFail=="Pass"){

        $data ="<p class='alert-success'></p>";

    }
    else{
        $data ="<p class='alert alert-danger'>{$message}</p>";


    }

    return $data;
}
function redirectTo($page){
    header("Location: {$page}.php");
}

function checkDuplicateEntries($table ,$coloumName,$value,$db){

    try{
        $sqlQuery="SELECT * FROM" .$table. "WHERE" .$coloumName. "= :$coloumName";
        $statement=$db->prepare($sqlQuery);
        $statement->execute(array(':UserName'=>$value));

        if ($row=$statement->fetch()){
            return true;
        }
        return false;

    }catch (PDOException $ex){};
}


function rememberMe($user_Username){
    $encryoCookieData=base64_encode("RememberMefunctionSecurity{$user_Username}");


    setcookie("rememberUserCookie",$encryoCookieData,time()+60*60*24*99,"/");
}

function isCookieValid($db){

    $isValid=false;

    if (isset($_COOKIE['rememberUserCookie'])){

        $decryptCookieData=base64_decode($_COOKIE['rememberUserCookie']);
        $user_Username=explode("RememberMefunctionSecurity",$decryptCookieData);
        $userName=$user_Username[1];


        $sqlQuery="SELECT * FROM VISITOR where UserName = :UserName";
        $statement=$db->prepare($sqlQuery);
        $statement->execute(array(':UserName'=>$userName));


        if ($row=$statement->fetch()){

            $VisitorNo=$row['VisitorNo'];
            $Name=$row['FirstName'];

            $_SESSION['VisitorNo']=$VisitorNo;
            $_SESSION['FirstName']=$Name;
            $isValid=true;

        }
        else{


            $isValid = false;
            signout();

        }


    }
    return $isValid;
}

function signout(){

    unset($_SESSION['VisitorNo']);
    unset($_SESSION['FirstName']);

    if (isset($_COOKIE['rememberUserCookie'])){
        unset($_COOKIE['rememberUserCookie']);
        setcookie('rememberUserCookie',null,-1,'/');

    }

    session_destroy();
    session_regenerate_id(true);
    redirectTo('index');
}

function guard(){
    $isValid=true;
    $inactive=60*15;
    $fingerprint=md5($_SERVER['REMOTE_ADDR'].$_SERVER['HTTP_USER_AGENT']);

    if (isset($_SESSION['fingerprint']) && $_SESSION['fingerprint']!=$fingerprint){

        $isValid=false;
        signout();
    }else if ((isset($_SESSION['lastActive']) && (time() -$_SESSION['lastActive'])>$inactive) && $_SESSION['Username']){

        $isValid=false;
        signout();

    }
    else{
        $_SESSION['lastActive']=time();
    }

    return $isValid;
}