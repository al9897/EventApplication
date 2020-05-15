<?php
$page_title="Payment";
include_once 'Partial/header.php';




?>


        <!-- Sections -->
        <section id="tickets" class="ticket sections" style="text-align: center;">
            <div class="container" style="text-align: center;">

                <!-- Example row of columns -->
                <div class="row">
                    <div class="wrapper">
                        <?php if (isset($_SESSION['Username'])): ?>
<div id="payment-form">
    <form method="post" action="Partial/paymentProccess.php">
        <label>Email:</label><br>
        <input type="text" name="REmail" style="color: #0b0b0b" ><br>
        <p id="information-buy">Ticket would be sent to this email</p>
        <label>Card Number:</label><br>
        <input type="text" name="cardNumber"  style="color: #0b0b0b" ><br>
        <label>Expiration date:</label><br>
        <input type="date" placeholder="MM/YY"  style="color: #0b0b0b"><br>
        <label>CCV2:</label><br>
        <input type="password"  style="color: #0b0b0b" ><br>
<br>
        <h4>Or Continue with iDeal</h4>
        <a href="https://idea.nl"><img src="assets/images/ideal-logo-png-transparent%20(1).png"></a>
        <br>
        <h6>Total to pay: <?php if (isset($_SESSION['TTP'])){ echo $_SESSION['TTP'];} else echo "0";?></h6>
        <input type="submit" class="btn-primary" name="PaymentBtn" value="Checkout" style="margin: 5%;">
        

    </form>

                        </div>

                        <?php else: ?>
                        <div class="alert-info">
                            <label style="color: #0b0b0b">You do NOT have permission to visiting this page <br>
                            Please <a href="login.php">Loging</a> or <a href="signup.php">Sign Up</a>
                            </label>
                        </div>
                        <?php endif; ?>

                    </div>
                </div></div></section>

        <!--Footer-->
<?php include_once 'Partial/footer.php'?>

</html>
