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
            <p>You need to have tickets for camping spot</p>
            <?php else: ?>
            <h4>You can add your friends into your tent</h4>
            <h6>Please note:for accessing to camping spots you need to have FEM ticket</h6>
            <div class="form-group">
                <form name="add_name" id="add_name" style="width: 50%;" method="POST" action="addguesthandler1.php">
                    <div class="table-responsive">
                        <output  name="numberOfGuest1" id="numberOfGuest1"></output>

                        <table class="table table-dashed" id="dynamic_field">
                            <tr>
                                <td><input  type="text" name="name[]" value="test" placeholder="Enter email address" class="form-control name_list" /></td>
                                <td><button type="button" name="add" id="add" class="btn btn-success">Add More</button></td>
                            </tr>
                        </table>
                        <input type="button" name="submit" onclick="proccess()" id="submit" class="btn btn-info" value="Submit"  />
                        <p  hidden>number of guests:</p>
                        <label hidden name="numberOfGuest" id="numberOfGuest">0</label>
                        <h6 >Total to pay:</h6>
                        <label  name="numberOfGuest2" id="numberOfGuest2">0</label>
                        <h6 >Balance:</h6>
                        <label  name="numberOfGuest3" id="numberOfGuest3">0</label>

                        <hr>

                        <script>



                            let i=0;
                            let ttp=0;
                            $(document).ready(function(){

                                $('#add').click(function(){if (i<5){
                                    i++;

                                    ttp=i*20;
                                    $('#dynamic_field').append('<tr id="row'+i+'"><td><input  type="text"  name="name[]" placeholder="Enter email address" class="form-control name_list" /></td><td><button type="button" name="remove" id="'+i+'" class="btn btn-danger btn_remove">X</button></td></tr>');

                                    numberOfGuest.innerHTML=i;
                                    numberOfGuest2.innerHTML=ttp;


                                    numberOfGuest1.innerHTML= "";

                                }else {
                                    numberOfGuest1.innerHTML= "<p style='color: red;'>you can add a maximum number of 5 guests</p> ";

                                }
                                });

                                $(document).on('click', '.btn_remove', function(){if (i>5){ numberOfGuest1.innerHTML= "<p style='color: red;'>you can add a maximum number of 5 guests</p> ";
                                } else {


                                    i--;
                                    ttp=i*20;
                                    var button_id = $(this).attr("id");
                                    $('#row' + button_id + '').remove();

                                    numberOfGuest.innerHTML = i;
                                    numberOfGuest2.innerHTML=ttp;

                                    numberOfGuest1.innerHTML= "";

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





                            function proccess(){
                                const numberOfGuest3 =document.getElementById("numberOfGuest3");
                                let balance=200;
                                balance= <?php echo $currentBalance; ?>;


                                let newBalance = balance-ttp;
                                localStorage.clear();
                                localStorage.setItem("newBalance",newBalance);
                                numberOfGuest3.innerHTML=newBalance;

                                window.location='addguesthandler1.php'




                            }
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