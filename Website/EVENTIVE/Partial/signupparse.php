<?php

    include_once 'Resource/Database.php';
if(isset($_POST['signupBtn'])){
    //initialize an array to store any error message from the form
    $form_errors = array();

    //Form validation
    $required_fields = array('signup_email', 'signup_username', 'signup_password');

    //call the function to check empty field and merge the return data into form_error array
    $form_errors = array_merge($form_errors, check_empty_fields($required_fields));

    //Fields that requires checking for minimum length
    $fields_to_check_length = array('signup_username' => 4, 'signup_password' => 4);

    //call the function to check minimum required length and merge the return data into form_error array
    $form_errors = array_merge($form_errors, check_min_length($fields_to_check_length));

    //email validation / merge the return data into form_error array
    $form_errors = array_merge($form_errors, check_email($_POST));

    $Semail = $_POST['signup_email'];
    $Susername = $_POST['signup_username'];
    $Spassword = $_POST['signup_password'];
    $DOB =$_POST['DOB'];
    $FirstName=$_POST['FirstName'];
    $LastName=$_POST['LastName'];
    $PhoneNumber=$_POST['PhoneNumber'];
    $Address=$_POST['Address'];
    $Country=$_POST['Country'];

    if (checkDuplicateEntries("VISITOR","UserName",$Susername,$db)){
        $result=flashmessage("Username is already taken");

    }
    else if (checkDuplicateEntries("VISITOR","Email",$Susername,$db)){
        $result=flashmessage("Email is already taken");

    }
    else if (checkDuplicateEntries("VISITOR","PhoneNumber",$Susername,$db)){
        $result=flashmessage("Phone Number is already taken");

    }
    //check if error array is empty, if yes process form data and insert record
    else if(empty($form_errors)){
        //collect form data and store in variables


        //hashing the password
        #$hashed_password = password_hash($Spassword, PASSWORD_DEFAULT);
        try{

            $sqlInsert = "INSERT INTO VISITOR (UserName,Password,FirstName,LastName,Email,DOB,PhoneNumber,Address,Country)
                            values( :Username,:Password,:FirstName,:LastName,:Email,:DOB,:PhoneNumber,:Address,:Country)";

            $statement = $db->prepare($sqlInsert);
            $statement->execute(array(':Username' => $Susername, ':Password' => $Spassword, ':FirstName' => $FirstName, ':LastName' => $LastName, ':Email' => $Semail, ':DOB' => $DOB,
                ':PhoneNumber' => $PhoneNumber, ':Address' => $Address, ':Country' => $Country));
            //check if one new row was created
            if($statement->rowCount() == 1){



                $sqlGet="SELECT * FROM VISITOR WHERE UserName= :UserName";
                $statement= $db->prepare($sqlGet);
                $statement->execute(array(':UserName'=> $Susername));
                $row=$statement ->fetch();
                $VisitorNo=$row['VisitorNo'];

                echo $VisitorNo;
                $sqlEA="INSERT INTO EVENTACCOUNT (VisitorNo,Balance) values (:VisitorNo,'0')";

                $statement = $db->prepare($sqlEA);
                $statement->execute(array(':VisitorNo' => $VisitorNo));

                echo  $welcome="<script type=\"text/javascript\">swal({
                            type: 'success',
                           title: 'Congratulation $Susername  ',
                          text: 'You are registered successfully ',
                         timer: 4000,
                      });
                     setTimeout(function() {
                    window.location.href='index.php';

                   },5000);

                  </script>";




            }
        }catch (PDOException $ex){
            $result = flashmessage(" An error occurred: ".$ex->getMessage());
        }
    }
    else{
        if(count($form_errors) == 1){
            $result =flashmessage("There was an Error in the form");
        }else{
            $result =flashmessage("There were".count($form_errors) ."Error in the form");
        }
    }

}


?>