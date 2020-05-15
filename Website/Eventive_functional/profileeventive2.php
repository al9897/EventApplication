<?php
 $page_title="Profile";
include_once 'Partial/header.php';
include_once 'Partial/parseProfile.php';


?>

    <?php if (!isset($_SESSION['Username'])): ?>
    <br>
    <br>
        <p class="bg-warning" style="padding-left: 2%;">You do not have permission to access this page.<br>
            <a href="login.php">Login here</a> Not a member yet? <a href="signup.php">Sign Up now!</a></p>


    <?php else:

        ?>
        <br>
        <br>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>




        <div id="London" class="tabcontent" style="margin-top: 1.5%;">
            <table>
                <tr>
                    <th>
                        Name
                    </th>
                    <td></td>
                    <td>
                        <?php if (isset($FirstName)) echo $FirstName; ?>
                    </td>
                </tr>
                <tr>
                    <th>
                        LastName
                    </th>
                    <td></td>

                    <td>
                        <?php if (isset($LastName)) echo $LastName; ?>
                    </td>
                </tr>
                <tr>
                    <th>
                        Username
                    </th>
                    <td></td>

                    <td>
                        <?php if (isset($username)) echo $username; ?>
                    </td>
                </tr>
                <tr>
                    <th>
                        Date of Birth
                    </th>
                    <td></td>
                    <td>
                        <?php if (isset($dob)) echo $dob; ?>
                    </td>
                </tr>
                <tr>
                <tr>
                    <th>
                        Email
                    </th>
                    <td></td>
                    <td>
                        <?php if (isset($email)) echo $email; ?>
                    </td>
                </tr>
                <tr>
                    <th>
                        Phone
                    </th>
                    <td></td>

                    <td>
                        <?php if (isset($PhoneNumber))echo $PhoneNumber; ?>
                    </td>
                </tr>
                <tr>
                    <th>
                        Address
                    </th>
                    <td></td>

                    <td>
                        <?php if (isset($address)) echo $address; ?>
                    </td>
                </tr>
                <tr>
                    <th>
                        Country
                    </th>
                    <td></td>

                    <td>
                        <?php if (isset($country))echo $country; ?>
                    </td>
                </tr>
            </table>

            <a href="edit_profile.php?user_identity=<?php if (isset($encodeID)) echo $encodeID; ?>"><span class="glyphicon glyphicon-edit"></span>Edit</a>

            <hr>
        </div>

        <div id="Paris" class="tabcontent" style="margin-top: 1.5%;">
            <h3>Current Ballance:</h3>
            <h2><?php if (isset($currentBalance))echo $currentBalance; ?></h2>
            <p>To add more credits please follow the structure bellow:<br></p>
            <form method="post" action="Partial/balanceprocces.php">
                <h3>Transfer through IDeal:</h3>

                <input type="number" name="amount" >
                    <button class="btn btn-success" name="IdealBtn" >IDeal</button>
                    <button class="btn btn-success" name="PaypalBtn" >Paypal</button>


                <h3>Transfer through ATM:</h3>
                <p><a href="FAQ.html">How can I add credits on ATMs?</a></p></li>
            </form>
            <hr>
        </div>

        <div id="Tokyo" class="tabcontent" style="margin-top: 1.5%;">
            <?php

            $id=$_SESSION['id'];
            $sqlQuery="select * from EVENTACCOUNT where VisitorNo= :VisitorNo ";
            $statement=$db->prepare($sqlQuery);
            $statement->execute(array(':VisitorNo'=>$_SESSION['id']));
            while ($row=$statement->fetch()){
                $campingSpotNumber=$row['CampingSpotNo'];
            }

            if (!isset($campingSpotNumber)):
            ?>
            <p>You need to have tickets for camping spot<a href="ticketNoTent.php">camping spot</a></p>
            <?php else: ?>
            <h5>You can add your friends into your tent</h5>
            <h6>Please note:<br>for accessing to camping spots you need to have FEM ticket</h6>
            <div class="form-group">
                <form name="add_name" id="add_name" style="width: 50%;" method="POST" action="addguesthandler1.php">
                    <div class="table-responsive">
                        <output style="color: green;"  name="numberOfGuest1" id="numberOfGuest1">you can add 5 people in your tent</output>

                        <table class="table table-dashed" id="dynamic_field">
                            <tr>
                                <td><input  type="text" name="name[]" placeholder="Enter email address" class="form-control name_list" /></td>
                                <td><button type="button" name="add" id="add" class="btn btn-success">Add More</button></td>
                            </tr>
                        </table>

                        <input type="button" name="submit"  id="submit" class="btn btn-info" value="Submit"  />


                        <h6>number of guests:</h6>
                        <label name="numberOfGuest" id="numberOfguest">1</label><br>
                        <p id="infoG" on style="display: none; color: green;font-size: small;">price for adding one person is 20 euros. </p>
                        <h6 >Total to pay:</h6>
                        <label  name="numberOfGuest2" id="ttp" onmouseenter="info()" >20</label>
                        <hr>
                        <h6 >NewBalance:</h6>

                        <label  name="numberOfGuest3" onmouseenter="infoB()" id="balance"><?php echo ($currentBalance-20) ; ?></label>

                        <p id="infoB"  style="display: none; color: red;font-size: small;">not enough balance!Add in your account! </p>

                        <hr>
                        <script>
                            function infoB() {

                                let newBalance=document.getElementById('balance').innerHTML;
                                if (newBalance<0) {
                                    document.getElementById('infoB').style.display = "block";
                                    //setInterval(document.getElementById('infoB').style.display = "none",500);
                                }
                                else {document.getElementById('infoB').style.display = "none";}
                            }
                            function infoOut() {
                                document.getElementById('infoG').style.display="none";


                            }
                            function info() {
                                document.getElementById('infoG').style.display="block";
                                setInterval(infoOut,2000);

                            }



                        </script>



                        <script>
                            
                            let i=1;
                            let ttp=document.getElementById('ttp');

                            let balance=document.getElementById('balance').innerText ;
                            $(document).ready(function(){

                                $('#add').click(function(){if (i<5){
                                    i++;
                                    ttp+=(i*20);
                                    $('#dynamic_field').append('<tr id="row'+i+'"><td><input  type="text"  name="name[]" class="form-control name_list" /></td>' +
                                        '<td><button type="button" name="remove" id="'+i+'" class="btn btn-danger btn_remove">X</button></td></tr>');


                                    numberOfGuest1.style.color="green";
                                    numberOfGuest1.innerHTML= "you can still add "+ (5-i)+"more people";



                                        document.getElementById('ttp').innerText = 20 * i;
                                        document.getElementById('balance').innerText = balance - (20*(i-1) );
                                    document.getElementById('numberOfguest').innerHTML=(i);




                                }else {
                                    numberOfGuest1.style.color="red";
                                    numberOfGuest1.innerHTML= "you can add a maximum number of 5 guests";
                                    document.getElementById('numberOfguest').innerHTML=(i);


                                }
                                });

                                $(document).on('click', '.btn_remove', function(){if (i>5)
                                {
                                    numberOfGuest1.style.color="red";
                                    numberOfGuest1.innerHTML= "you can add a maximum number of 5 guests";
                                    document.getElementById('numberOfguest').innerHTML=(i);

                                } else {


                                    i--;
                                    ttp-=(i*20);

                                    var button_id = $(this).attr("id");
                                    $('#row' + button_id + '').remove();

                                    numberOfGuest1.style.color="green";

                                    numberOfGuest1.innerHTML= "you can still add "+ (5-i)+"more people";
    document.getElementById('ttp').innerText -= 20 ;
    document.getElementById('balance').innerText =balance-(i*20) +20 ;
    document.getElementById('numberOfguest').innerHTML=(i);


                                }

                                });


                                $('#submit').click(function(){



                                    $.ajax({
                                        url:"addguesthandler.php",
                                        method:"POST",
                                        data:$('#add_name').serialize(),
                                        success:function(data)
                                        {
                                            swal(data);
                                            $('#add_name')[0].reset();

                                        }
                                    });
                                });

                            });






                        </script>



                    </div>
                </form>
                <fieldset hidden>
                    <legend>guests email address</legend>
                    <div id=lsEmails></div>
                </fieldset>
            </div>



        </div>

    <?php endif; ?>

    <?php endif; ?>

</div>

        <?php include_once 'Partial/footer.php'?>


    </body>
</html>