<!doctype html>
<html>
    <head>
        <meta charset="utf-8">
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title></title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="apple-touch-icon" href="apple-touch-icon.png">

        <link rel="stylesheet" href="assets/css/bootstrap.min.css">
        <!--        <link rel="stylesheet" href="assets/css/bootstrap-theme.min.css">-->


        <!--For Plugins external css-->
        <link rel="stylesheet" href="assets/css/plugins.css" />
        <link rel="stylesheet" href="assets/css/magnific-popup.css">

        <link rel="stylesheet" href="assets/css/nexa-web-font.css" />
        <link rel="stylesheet" href="assets/css/opensans-web-font.css" />

        <!--Theme custom css -->
        <link rel="stylesheet" href="assets/css/style.css">

        <!--Theme Responsive css-->
        <link rel="stylesheet" href="assets/css/responsive.css" />

        <script src="assets/js/vendor/modernizr-2.8.3-respond-1.4.2.min.js"></script>
        <title>Time To party like FEM</title>
<link href="https://fonts.googleapis.com/css?family=Kaushan+Script" rel="stylesheet">
        <style type="text/css">
            body,html{
              height: 100%;
                margin: 0;
                padding: 0;
            }
        .bgimg{
            background-image: url("assets/images/bgi.jpg");
            height:100%;
            background-position: center;
            background-size: cover;
            position: relative;
            color: #fff;  
            font-family: 'Kaushan Script', cursive;
        }
            .middle{
                position: absolute;
                top: 50%;
                left: 50%;
                transform: translate(-50%,-50%);
                text-align: center;
            }
            h2{
                font-weight: 100;
                letter-spacing: 20px;
                font-size: 50px;
            }
            #demo{
                font-weight: lighter;
                word-spacing: 20px;
                font-size: 40px;
            }
            a{
                color: #fff
            }
            a:hover{
                color: #843177;
            }

        </style>
    </head>
<body>
<div class="bgimg">
    <div class="middle">
        <h2>FEM is waiting...</h2>
        <hr>
        <p  id="demo" style="text-align: center;"></p>
        <h3><a href="tickets.html">Tickets</a></h3>
    
    
    </div>        
</div>
    
    <script>
    
    var eventDate=new Date("Dec 31 2018 15:51:30:00").getTime();
        
    var countdownoption =setInterval(function() {
        
    var now =new Date().getTime();
    var remTime= eventDate -now;
    var day =Math.floor(remTime/(1000*60*60*24));
    var hour =Math.floor((remTime%(1000*60*60*24))/(1000*60*60));
    var minutes =Math.floor((remTime%(1000*60*60))/(1000*60));
    var seconds =Math.floor((remTime%(1000*60))/(1000));
    
    document.getElementById("demo").innerHTML=day+" d "+ hour +" h " +minutes +" m "+seconds +" s ";
    if(remTime<0){
        clearInterval(countdownoption);
        document.getElementById("demo").innerHTML="EXPIRED";
        
    }
    },1000);
    
    </script>
<?php include_once 'Partial/footer.php'?>


</body>
</html>
