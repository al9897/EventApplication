<?php
$page_title="Profile";
$page_title="Edit Profile";
include_once 'Partial/header.php';
include_once  'Partial/parseProfile.php';


?>
<section id="main_cont" class="main_cont">
    <br>
    <br>
    <div
    <?php if (isset($result)) {echo $result;} ?>
    <?php if (!empty($form_errors)){echo show_errors($form_errors);} ?>
    </div>

    <?php if (!isset($_SESSION['id'])): ?>

    <p class="bg-warning" style="padding-left: 2%;">You do not have permission to access this page.<br>
        <a href="login.php">Login here</a> Not a member yet? <a href="signup.php">Sign Up now!</a></p>

    <?php else : ?>

    <form action="" method="post">
        <div class="form-horizontal">
            <label for="UsernameField">Username</label><br>
            <input type="text" class="form-control-static" name="edit_username" id="UsernameField" placeholder="Username"
            value="<?php if (isset($username)) echo $username;?>">
        </div>
        <div class="form-horizontal">
            <label for="emailField">Email</label><br>
            <input type="text" class="form-control-static" name="edit_email" id="emailField" placeholder="email"
                   value="<?php if (isset($email)) echo $email;?>">
        </div>
        <div class="form-horizontal">
            <label for="FnameField">First Name</label><br>
            <input type="text" class="form-control-static" name="edit_fname" id="FnameField" placeholder="First Name"
                   value="<?php if (isset($FisrtName)) echo $FirstName;?>">
        </div>
        <div class="form-horizontal">
            <label for="LnameField">Last Name</label><br>
            <input type="text" class="form-control-static" name="edit_Lname" id="LnameField" placeholder="Last Name"
                   value="<?php if (isset($LastName)) echo $LastName;?>">
        </div>
        <div class="form-horizontal">
            <label for="DOBField">Date of birth</label><br>
            <input type="date" class="form-control-static" id="DOBField" name="DOB" placeholder="Date of birth"
            value="<?php if (isset($Edob)) echo $Edob;?>">

        </div>
        <div class="form-horizontal">
            <label for="PhoneNumberField">Phone Number</label><br>
            <input type="text" class="form-control-static" name="PhoneNumber" id="PhoneNumberField" placeholder="Phone Number"
                   value="<?php if (isset($PhoneNumber)) echo $PhoneNumber;?>">
        </div>
        <div class="form-horizontal">
            <label for="AddressField">Address</label><br>
            <input type="text" class="form-control-static" name="Address" id="AddressField" placeholder="Address"
                   value="<?php if (isset($address)) echo $address;?>">
        </div>
        <div class="form-horizontal">
            <label for="CountryField">Country</label><br>
            <input type="text" class="form-control-static" name="Country" id="CountryField" placeholder="Country"
                   value="<?php if (isset($country)) echo $country;?>">
        </div>

        <input type="hidden" name="hidden_id" value="<?php if (isset($id)) echo $id;?>">
        <br>
        <button type="submit" name="EditBtn" class="btn btn-primary">Edit</button>
    </form>


</section>

<?php endif ?>

<a class="pull-right" style="margin: 2%;" href="logout.php">Log out</a>

<?php include_once 'Partial/footer.php'?>

</body>
</html>