<?php
$page_title="Tickets";
include_once 'Partial/header.php';
include_once 'Partial/parseTicket.php'
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
                        <form method="post" action="payment.php">

                            <fieldset>
                                <?php echo $nr['CampingSpotNo'];?>

                                <label style="color: #fff"><h5>Number of tickets:</h5></label>
                                <input type="number" name="NrOfTicket"><br>
                                <input type="checkbox" name="stay"  onclick="showCamping()">
                                <label style="color: #fff"><h7>Willing to stay for weekend?</h7></label>
                            </fieldset>
                            <fieldset id="camping" style="display: none;">

                                <label style="color: #fff;">Select your tent</label>
                                <select style="width: 100px;">
                                </select>

                                <div class="campMap">
                                    <div class="top">
                                        <div class="tent"><b>1</b>

                                        </div>
                                        <div class="tent">2

                                        </div>
                                        <div class="tent">3

                                        </div>
                                        <div class="tent" id="NAtent">4

                                        </div>

                                        <div class="tent">5

                                        </div>
                                        <div class="facility">6
                                            WC
                                        </div>
                                        <div class="tent">7

                                        </div>
                                        <div class="facility">
                                            WC
                                        </div>
                                        <div class="tent">8

                                        </div>
                                        <div class="tent">9

                                        </div>
                                        <div class="tent">10

                                        </div>
                                        <div class="tent" id="NAtent">11
                                        </div>

                                        <div class="tent">12

                                        </div>
                                        <div class="tent" id="NAtent">13
                                        </div>

                                    </div>
                                    <div class="lake">
                                        Lake
                                    </div>
                                    <div class="down">
                                        <div class="tent">14

                                        </div>
                                        <div class="tent">15

                                        </div>
                                        <div class="tent">16

                                        </div>
                                        <div class="tent" id="NAtent">17

                                        </div>

                                        <div class="tent">

                                        </div>
                                        <div class="facility">
                                            WC
                                        </div>
                                        <div class="tent">

                                        </div>
                                        <div class="facility">
                                            WC
                                        </div>
                                        <div class="tent">

                                        </div>
                                        <div class="tent">

                                        </div>
                                        <div class="tent">

                                        </div>
                                        <div class="tent" id="NAtent">

                                        </div>

                                        <div class="tent">

                                        </div>
                                        <div class="tent" id="NAtent">

                                        </div>

                                    </div>
                                    <div class="shops">SHOPS</div>


                                    <div class="entranceG">
                                        Entrance
                                    </div>




                                </div>
                            </fieldset>
                            <br>

                            <?php
                            #echo "<p style='color: #fff;'>Total:  ". $totalToPay."</p>";
                            ?>
                            <br>
                            <input type="submit" value="Confirm" name="ticketBtn">

                        </form>

                        <?php else: ?>
                        <div class="alert-info">
                            <label style="color: #0b0b0b">You do NOT have permission to visiting this page <br>
                                Please <a href="login.php">Loging</a> or <a href="signup.php">Sign Up</a>
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
