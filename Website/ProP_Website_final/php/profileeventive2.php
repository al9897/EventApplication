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
        <h3>Current Ballance:</h3>
        <h2>100 Euros.</h2> 
        <p>To add more credits please follow the structure bellow:<br></p>
        <ul>
            <li><h3>Transfer through IDeal:</h3>
            <p><a href="#">IDeal</a></p>
            </li>
            <li><h3>Transfer through ATM:</h3>
                <p><a href="FAQ.html">How can I add credits on ATMs?</a></p></li>
        </ul>
      </div>
      
      <div id="Tokyo" class="tabcontent" style="margin-top: 1.5%;">
        <img src="assets/images/pablo-heimplatz-243307-unsplash.jpg" style="width: 40%; height: 40%;">
    <div class="tent_cont">
        <h6>maxmimum number of people per tent is 4,5 and 6</h6>
        <select><option>Number of guest</option>
        <option>3</option>
        <option>4</option>
        <option>5</option>
        </select>
        <h5>Add your guests</h5>
        <input type="text" id="Email_Address" value="Email Address">
        <input type="submit" class="btn1" value="Add more">
        <input type="submit" class="btn1" value="submit the list"><br>

        <label>GuestList</label><br>
        <textarea  class="guestlist" value="username">Username</textarea><br>
    </div>
        
      </div>
      <div id="Tehran" class="tabcontent" style="margin-top: 1.5%;">

          <table>
            <tr>
            <td>Tent</td><td>NO</td>
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
<a class="pull-right" style="margin: 2%;" href="logout.php">Log out</a>


        <?php include_once 'Partial/footer.php'?>


    </body>
</html>