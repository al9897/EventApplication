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

    <?php else: ?>
        <!--[if lt IE 8]>
            <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->


		<br>

      <div id="London" class="tabcontent" style="margin-top: 1.5%;">

       <table>
           <h4>Personal Information</h4>
           <tr>
               <th>
                   Name
               </th>
               <td></td>
               <td>
                    <?php if (isset($FisrtName)) echo $FisrtName; ?>
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
                         <?php if (isset($contry))echo $contry; ?>
                       </td>
                  </tr>
       </table>

          <a href="edit_profile.php?user_identity=<?php if (isset($encodeID)) echo $encodeID; ?>"><span class="glyphicon glyphicon-edit"></span>Edit</a>
       
      </div>
      
      <div id="Paris" class="tabcontent" style="margin-top: 1.5%;">
        <h4>Current Balance:</h4>
          <form method="post" action="Partial/balanceprocces.php" class="form-control-static">

          <h3><?php if (!empty($currentBalance)) echo $currentBalance; else echo '0';?> Euros.</h3>
        <p>To add more credits please follow the structure bellow:<br></p>
        <ul>
            <li><h5>Transfer directly:</h5>

            <input type="text" style="margin-bottom: 0.5%;" class="info" name="amount" placeholder="Amount"><br>
            <button href="" type="submit" name="IdealBtn" class="btn-lg">Pay with IDeal</button>

            <button href="" type="submit" name="PaypalBtn" class="btn-lg">Pay with Paypal</button> <br>
                </form>
            </li>
            <li><br></li>
            <li><h5>Transfer through ATM:</h5>
                <p><a href="FAQ.html">How can I add credits on ATMs?</a></p></li>
        </ul>
      </div>
      
      <div id="Tokyo" class="tabcontent" style="margin-top: 1.5%;">
    <div class="form-group">

        <h4>Camping with friends</h4>
        <h6>maxmimum number of people per tent is 4,5 and 6</h6>


        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>        <div class="form-group">
            <form name="add_name" id="add_name" style="width: 50%;">
                <div class="table-responsive">
                    <table class="table table-condensed" id="dynamic_field">
                        <tr>
                            <td><input type="text" name="name[]" placeholder="Enter Emial" class="form-control name_list" /></td>
                            <td><button type="button" name="add" id="add" class="btn btn-success">Add More</button></td>
                        </tr>
                    </table>
                    <input type="button" name="submit" id="submit" class="btn btn-info" value="Submit" />
                </div>
            </form>
        </div>

            <script>
                $(document).ready(function(){
                    var i=1;
                    $('#add').click(function(){
                        i++;
                        $('#dynamic_field').append('<tr id="row'+i+'"><td><input type="text" name="name[]" placeholder="Enter your Name" class="form-control name_list" /></td><td><button type="button" name="remove" id="'+i+'" class="btn btn-danger btn_remove">X</button></td></tr>');
                    });

                    $(document).on('click', '.btn_remove', function(){
                        var button_id = $(this).attr("id");
                        $('#row'+button_id+'').remove();
                    });

                    $('#submit').click(function(){
                        $.ajax({
                            url:"addguesthandler.php",
                            method:"POST",
                            data:$('#add_name').serialize(),
                            success:function(data)
                            {
                                alert(data);
                                $('#add_name')[0].reset();
                            }
                        });
                    });

                });
            </script>

        <output type="text"><?php if (!empty($form_errors)) {echo $form_errors; }
        else echo "No Error to show";
        ?></output>

            </form>
    </div>
        
      </div>
      <div id="Tehran" class="tabcontent" style="margin-top: 1.5%;">

          <h4>Activities</h4>
          <?php


          $sqlQuery="select * from EVENTACCOUNT where VisitorNo= :VisitorNo ";
          $statement=$db->prepare($sqlQuery);
          $statement->execute(array(':VisitorNo'=>$_SESSION['id']));
          while ($row=$statement->fetch()){
              $accountNo=$row['AccountNo'];
              $campingSpotNumber=$row['CampingSpotNo'];
              $_SESSION['CampingSpotNr']=$campingSpotNumber;
          }

          ?>
          <table>
            <tr>
            <td>Tent</td><td><?php if (isset($campingSpotNumber)){echo "Tent Number:".$campingSpotNumber; }else{echo "No Camping Spot<td>You can buy a camping spot <a href='tickets.php'>here</a>";} ?></td>
            </tr>
            <tr>
            <td>Logs</td>
            </tr>
            <tr>
            <td>Purchases</td>
            </tr>
            <tr>
            <td>Materials</td>
            </tr>  
          </table>
          </div>

<?php endif; ?>
<a class="pull-right" style="margin: 2%;" href="index.php">Home</a>

<a class="pull-right" style="margin: 2%;" href="logout.php">Log out</a>


        <?php include_once 'Partial/footer.php'?>


    </body>
</html>