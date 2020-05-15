<?php
include_once 'Resource/Database.php';
include_once 'Resource/utilities.php';


if (isset($_SESSION['id'])|| isset($_GET['user_identity']) && !isset($_POST['editBtn'])){

    if (isset($_GET['user_identity'])){

        $url_encoded_id=$_GET['user_identity'];
        $decode_id=base64_decode($url_encoded_id);
        $user_id_array=explode("EncodeUserID",$decode_id);
        $id=$user_id_array[1];

    }else{
        $id=$_SESSION['id'];
    }


    $id=$_SESSION['id'];
    $user=$_SESSION['Username'];

    $sqlQuery="select * from VISITOR where VisitorNo= :VisitorNo ";
    $statement=$db->prepare($sqlQuery);
    $statement->execute(array(':VisitorNo'=>$id));
    while ($rs=$statement->fetch()){

        $id=$rs['VisitorNo'];
        $username=$rs['UserName'];
        $email=$rs['Email'];
        $Edob=$rs['DOB'];
        $dob=strftime("%b %d,%y",strtotime($rs['DOB']));
        $FirstName=$rs['FirstName'];
        $LastName=$rs['LastName'];
        $PhoneNumber=$rs['PhoneNumber'];
        $address=$rs['Address'];
        $country=$rs['Country'];

        $sqlQuery="select * from EVENTACCOUNT where VisitorNo= :VisitorNo ";
        $statement=$db->prepare($sqlQuery);
        $statement->execute(array(':VisitorNo'=>$id));
        while ($rs=$statement->fetch()){
            $currentBalance=$rs['Balance'];
        }

    }

        $encodeID = base64_encode("EncodeUserID{$id}");


}elseif (isset($_POST['EditBtn'])){


    $form_errors = array();

    //Form validation
    $required_fields = array('edit_email', 'edit_username');

    //call the function to check empty field and merge the return data into form_error array
    $form_errors = array_merge($form_errors, check_empty_fields($required_fields));

    //Fields that requires checking for minimum length
    $fields_to_check_length = array('edit_username' => 4);

    //call the function to check minimum required length and merge the return data into form_error array
    $form_errors = array_merge($form_errors, check_min_length($fields_to_check_length));

    //email validation / merge the return data into form_error array
    $form_errors = array_merge($form_errors, check_email($_POST));

    $Eemail = $_POST['edit_email'];
    $Eusername = $_POST['edit_username'];
    $EDOB =$_POST['DOB'];
    $EFirstName=$_POST['edit_fname'];
    $ELastName=$_POST['edit_Lname'];
    $EPhoneNumber=$_POST['PhoneNumber'];
    $EAddress=$_POST['Address'];
    $ECountry=$_POST['Country'];
    $Ehidden_id=$_POST['VisitorNo'];

    if (checkDuplicateEntries("VISITOR","UserName",$Eusername,$db)){
        $result=flashmessage("Username is already taken");

    }
    else if (checkDuplicateEntries("VISITOR","Email",$Eemail,$db)){
        $result=flashmessage("Email is already taken");

    }
    else if (checkDuplicateEntries("VISITOR","PhoneNumber",$EPhoneNumber,$db)){
        $result=flashmessage("Phone Number is already taken");

    }
    //check if error array is empty, if yes process form data and insert record
    else if(empty($form_errors)){
        //collect form data and store in variables


        //hashing the password
        #$hashed_password = password_hash($Spassword, PASSWORD_DEFAULT);
        try{


            echo $Eemail ;
            echo $Eusername ;
            echo $EDOB ;
            echo $EFirstName;
            echo $ELastName;
            echo $EPhoneNumber;
            echo $EAddress;
            echo $ECountry;
            echo $Ehidden_id;

            $sqlInsert = "UPDATE VISITOR set UserName=:UserName,FirstName=:FirstName,LastName=:LastName,Email=:Email,
                          DOB=:DOB,PhoneNumber=:PhoneNumber,Address=:Address,Country=:Country where VisitorNo=:VisitorNo";


            $statement = $db->prepare($sqlInsert);
            $statement->execute(array(':Username' => $Eusername, ':FirstName' => $EFirstName, ':LastName' => $ELastName,
                ':Email' => $Eemail, ':DOB' => $EDOB, ':PhoneNumber' => $EPhoneNumber,
                ':Address' => $EAddress, ':Country' => $ECountry ,'VisitorNo'=>$Ehidden_id));
            //check if one new row was created
            if($statement->rowCount() == 1){

                echo  $welcome="OK!";




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






