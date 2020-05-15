<?php
$page_title="Password Recovery";
include_once 'Partial/header.php';
include_once 'Partial/parseforgotpassword.php';
?>


<section id="main_cont" class="main_cont">
<br>
<br>
    <div>
        <?php if (isset($result)){ echo $result ;}
        if (!empty($form_errors)){ echo show_errors($form_errors);}
        ?>
    </div>


    <div class="clearfix"></div>    <form action="" method="post">

        <div class="form-horizontal">
            <label for="EmailField">Email</label><br>
            <input type="text" class="form-control-static" name="Email" id="EmailField" placeholder="Email">
        </div>
        <div class="form-group">
            <label for="PasswordField">Password</label><br>
            <input type="password" class="form-control-static" id="PasswordField" name="new_password" placeholder="Password">
        </div>
        <div class="form-group">
            <label for="CPasswordField">Password</label><br>
            <input type="password" class="form-control-static" id="CPasswordField" name="confirm_password" placeholder="Confirm Password">
        </div>

        <br>
        <a href="PasswordResset.php" class="">Forgot Password</a><br>
        <button type="submit" name="ressetBtn" class="btn btn-primary">Resset</button>
    </form>

    </section>




<?php include_once 'Partial/footer.php'?>

</body>
</html>
