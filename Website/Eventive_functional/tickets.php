<?php
$page_title="Tickets";
include_once 'Partial/header.php';
include_once 'Partial/parseTicket.php';



?>

<script>

    function showCamping() {
if (!document.getElementsByName('stay').checked){
document.getElementById('camping').style.display='block';
}
else {
    document.getElementById('camping').style.display='none';

}
    }
</script>
        <!-- Sections -->
        <section id="tickets" class="ticket sections" style="text-align: center;">
            <div class="container" style="text-align: center;">

                <!-- Example row of columns -->
                <div class="row">
                    <div class="wrapper">
                        <?php if (isset($_SESSION['Username'])): ?>
                        <br>
                        <form method="post" action="Partial/balanceprocces.php">

                            <fieldset>
                                <?php #echo $nr['CampingSpotNo'];?>

                                <label style="color: #fff"><h5>Number of tickets:</h5></label>
                                <input type="number" class="information-form" disabled value="1" name="NrOfTicketshow"><br>
                                <input type="number" hidden value="1" name="NrOfTicket">

                                <input type="checkbox" name="stay"  onclick="showTotal()">
                                <label style="color: #fff"><h7>Willing to stay for weekend?</h7></label>
                            </fieldset>
                            <fieldset id="camping" style="display: none;">




                            </fieldset>
                            <br>
                            <label style="color: #fff;">Total:</label>
                            <output id="totalOutput" style="color: #fff;">55 euros</output>


                            <script>

                                let stay=document.getElementsByName('stay');
                                
                                function showTotal() {

                                    if (stay[0].checked) {

                                        document.getElementById('totalOutput').innerHTML = "85 euros";

                                    }
                                    else {

                                        document.getElementById('totalOutput').innerHTML = "55 euros";
                                    }

                                }

                            </script>


                            <br>
                            <input type="submit" class="btn-primary" value="Confirm" name="ticketBtn">
                            <?php if (isset($_SESSION['bought']))echo $_SESSION['bought']?>
                        </form>

                        <?php else: ?>
                        <div class="alert-info">
                            <label style="color: #0b0b0b">You do NOT have permission to visit this page <br>
                                Please <a href="login.php">Log in </a> or <a href="signup.php">Sign Up</a>
                            </label>
                        </div>
                        <?php endif; ?>
                    </div>
                </div>
            </div>
        </section>

 <?php include_once 'Partial/footer.php'?>
    </body>
</html>
