<?php
$page_title="Login";
include_once 'Partial/header.php';

include_once 'Partial/loginparse.php';
?>
<section id="main_cont" class="main_cont">
<br>
<br>
    <div
    <?php if (isset($result)) {echo $result;} ?>
    <?php if (!empty($form_errors)){echo show_errors($form_errors);} ?>
    </div>
    <div class="clearfix"></div>

    <form action="" method="post">
        <div class="form-horizontal">
            <label for="UsernameField">Username</label><br>
            <input type="text" class="form-control-static" name="login_username" id="UsernameField" placeholder="Username">
        </div>
        <div class="form-group">
            <label for="PasswordField">Password</label><br>
            <input type="password" class="form-control-static" id="PasswordField" name="login_password" placeholder="Password">
        </div>
        <div class="checkbox">
            <label>
                <input type="checkbox" value="yes" class="checkbox pull-left" name="remember"><br>Remember me!
            </label>
        </div>
        <br>
        <a href="PasswordResset.php" class="">Forgot Password</a><br>
        <button type="submit" name="loginBtn" class="btn btn-primary">Sign In</button>
    </form>


    </section>




<?php include_once 'Partial/footer.php'?>

</body>
</html>
