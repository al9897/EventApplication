<?php
$page_title="Sign Up";
include_once 'Partial/header.php';
include_once 'Partial/signupparse.php';
//process the form
?>


<section id="main_cont" class="main_cont">
    <br>
    <br>
<div>
    <?php if (isset($result)){ echo $result ;}
    if (!empty($form_errors)){ echo show_errors($form_errors);}
    ?>
</div>


    <div class="clearfix"></div>

    <form action="" method="post">
        <div class="form-horizontal">
            <label for="UsernameField">Username</label><br>
            <input type="text" class="form-control-static" name="signup_username" id="UsernameField" placeholder="Username">
        </div>
        <div class="form-horizontal">
            <label for="EmailField">Email</label><br>
            <input type="text" class="form-control-static" name="signup_email" id="EmailField" placeholder="Email">
        </div>
        <div class="form-group">
            <label for="PasswordField">Password</label><br>
            <input type="password" class="form-control-static" id="PasswordField" name="signup_password" placeholder="Password">
        </div>
        <div class="form-horizontal">
            <label for="FnameField">First Name</label><br>
            <input type="text" class="form-control-static" name="FirstName" id="FnameField" placeholder="First Name">
        </div>
        <div class="form-horizontal">
            <label for="LnameField">LastName</label><br>
            <input type="text" class="form-control-static" name="LastName" id="LnameField" placeholder="Last Name">
        </div>
        <div class="form-horizontal">
            <label for="DOBField">Date of birth</label><br>
            <input type="date" class="form-control-static" id="DOBField" name="DOB" placeholder="Date of birth"><br>

        </div>
        <div class="form-horizontal">
            <label for="PhoneNumberField">Phone Number</label><br>
            <input type="text" class="form-control-static" name="PhoneNumber" id="PhoneNumberField" placeholder="Phone Number">
        </div>
        <div class="form-horizontal">
            <label for="AddressField">Address</label><br>
            <input type="text" class="form-control-static" name="Address" id="AddressField" placeholder="Address">
        </div>
        <div class="form-horizontal">
            <label for="CountryField">Country</label><br>
            <input type="text" class="form-control-static" name="Country" id="CountryField" placeholder="Country">
        </div>
        <br>
        <button type="submit" name="signupBtn" class="btn btn-primary">Sign In</button>
    </form>



</section>




<?php include_once 'Partial/footer.php'; ?>
</body>
</html>
