<?php

    include_once 'Resource/Database.php';
    include_once 'Resource/utilities.php';
if (isset($_POST['loginBtn'])){
    $form_errors=array();
    $required_fields=array('login_username','login_password');
    $form_errors=array_merge($form_errors,check_empty_fields($required_fields));

    if (empty($form_errors)){

        $user=$_POST['login_username'];
        $LPassword=$_POST['login_password'];

        isset($_POST['remember']) ? $remember= $_POST['remember'] :$remember="";

        $sqlQuery="SELECT * FROM VISITOR WHERE UserName= :UserName";
        $statement= $db->prepare($sqlQuery);
        $statement->execute(array(':UserName'=> $user));

        while ($row = $statement->fetch()){

            $Username=$row['UserName'];
            $password=$row['Password'];
            $id=$row['VisitorNo'];
            $hashed_Password=$row['Password'];


            if (password_verify($LPassword,$hashed_Password)){


                $_SESSION['Username']=$Username;
                $_SESSION['id']=$id;

                $fingerprint=md5($_SERVER['REMOTE_ADDR'].$_SERVER['HTTP_USER_AGENT']);
                $_SESSION['lastActive']=time();
                $_SESSION['fingerprint']=$fingerprint;

                if ($remember=="yes"){
                    rememberMe($Username);
                }
                $result=flashmessage("Welcome back","Pass");

                echo  $welcome="<script type=\"text/javascript\">swal({
                                                          type: 'success',
                                                          title: 'Welcome back ',
                                                          text: 'You are logged in as $Username ',
                                                          timer: 3000,
                                                        });
                                                        setTimeout(function() {
                                                        window.location.href='index.php';
                                                          
                                                        },3100);
                                                        
                                                        </script>";


            }
            else{
                $result=flashmessage("Invalid Username or Password");;
            }

        }


    }

    else{
        if (count($form_errors)==1){
            $result=flashmessage("There was an Error in the form");
        }
        else{
            if (count($form_errors)!=1){
                $result=flashmessage("There were".count($form_errors). "Error in the form");
            }
        }
    }


}
?>