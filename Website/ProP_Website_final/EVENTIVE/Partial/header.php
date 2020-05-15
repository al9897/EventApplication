<?php
include_once 'Resource/Database.php';
include_once 'Resource/session.php';
include_once 'Resource/utilities.php';



?>
<!doctype html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang=""> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8" lang=""> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9" lang=""> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js" lang=""> <!--<![endif]-->
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title><?php if (isset($page_title)) echo $page_title;?></title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="apple-touch-icon" href="apple-touch-icon.png">

    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <!--        <link rel="stylesheet" href="assets/css/bootstrap-theme.min.css">-->
    <link rel="stylesheet" href="assets/css/sweetalert2.css" />
    <script src="assets/js/sweetalert2.min.js"></script>
    <!--For Plugins external css-->
    <link rel="stylesheet" href="assets/css/plugins.css" />
    <link rel="stylesheet" href="assets/css/magnific-popup.css">
    <link rel="stylesheet" href="assets/css/profile1.css" />



    <link rel="stylesheet" href="assets/css/nexa-web-font.css" />
    <link rel="stylesheet" href="assets/css/opensans-web-font.css" />

    <!--Theme custom css -->
    <link rel="stylesheet" href="assets/css/style.css">
    <script src="assets/js/profileeventive.js"></script>


    <!--Theme Responsive css-->
    <link rel="stylesheet" href="assets/css/responsive.css" />

    <script src="assets/js/vendor/modernizr-2.8.3-respond-1.4.2.min.js"></script>
</head>
<body>
<!--[if lt IE 8]>
<p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
<![endif]-->


<nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>

        </div>
        <?php if($page_title=="Profile")  {
            echo "<div class=\"tab\">
        <button style='background-color: #eee' class=\"tablinks\" ><a href='index.php'>Home</a></button>
        <button style='background-color: #eee' class=\"tablinks\"><a href='logout.php'>Log out</a></button>
        <button class=\"tablinks\" onclick=\"openCity(event, 'London')\">Personal information</button>
        <button class=\"tablinks\" onclick=\"openCity(event, 'Paris')\">Account</button>
        <button class=\"tablinks\" onclick=\"openCity(event, 'Tokyo')\">Camping</button>

        
      ";

        }
         else if (isset($_SESSION['Username']) || isCookieValid($db)): ?>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right"><i class="hide"><?php echo guard();?></i>
                <li ><a href="index.php#home">Home</a></li>
                <li><a href="index.php#about">About</a></li>
                <li><a href="index.php#portfolio">Gallery</a></li>
                <li><a href="index.php#contact">Contact</a></li>
                <li><a id="ticket" href="tickets.php">Tickets</a></li>
                <li><a href="profileeventive2.php">Profile</a></li>
                <li><a href="logout.php">Log out</a></li>

            </ul>
        </div><!-- /.navbar-collapse -->

        <?php else: ?>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right">
                <li class="active"><a href="index.php#home">Home</a></li>
                <li><a href="index.php#about">About</a></li>
                <li><a href="index.php#portfolio">Gallery</a></li>
                <li><a href="index.php#contact">Contact</a></li>
                <li><a id="ticket" href="tickets.php">Tickets</a></li>
                <li><a href="login.php">Login</a></li>
                <li><a href="signup.php">Sign up</a></li>


            </ul>
        </div><!-- /.navbar-collapse -->
        <?php endif ?>

    </div><!-- /.container-fluid -->
</nav>
