<?php
$page_title="Eventive";
include_once 'Partial/header.php';
?>
<!DOCTYPE <!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Your Account</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://fonts.googleapis.com/css?family=Courgette|Lobster|Ranga" rel="stylesheet">
    <link rel="stylesheet" type="text/css" media="screen" href="css/profile1.css" />
    <script src="js/profileeventive.js"></script>
</head>
<body style="padding:20px;">

<div class="tab">
        <button class="tablinks" onclick="openCity(event, 'London')">Personal information</button>
        <button class="tablinks" onclick="openCity(event, 'Paris')">Account</button>
        <button class="tablinks" onclick="openCity(event, 'Tokyo')">Camping</button>
        <button class="tablinks" onclick="openCity(event, 'Tehran')">Activities</button>
      </div>
      
      <div id="London" class="tabcontent">
          <h2>Please contact us in case of inputing wrong information</h2>
       <table>
           <tr>
               <td>
                   Name
               </td>
               <td>
                    Amin
                </td>
           </tr>
           <tr>
                <td>
                    LastName
                </td>
                <td>
                     Jahromi
                 </td>
            </tr>
            <td>
                    Username
                </td>
                <td>
                     a.masoumzadeganjahromi@student.fontys.nl
                 </td>
            </tr>
            <tr>
                 <td>
                        Email
                 </td>
                 <td>
                        a.masoumzadeganjahromi@student.fontys.nl
                  </td>
             </tr>
             <tr>
                    <td>
                        Phone
                    </td>
                    <td>
                         06 26819248
                     </td>
                </tr>
                <tr>
                     <td>
                         Address
                     </td>
                     <td>
                          Rachelmodnstraat R1 146
                      </td>
                 </tr>
                 <td>
                         PostalCode
                     </td>
                     <td>
                          4432 BG
                      </td>
                 </tr>
                 <tr>
                      <td>
                             Country
                      </td>
                      <td>
                             The Netherlands
                       </td>
                  </tr>
       </table>
       <a href="#">Contact Us</a>
       
      </div>
      
      <div id="Paris" class="tabcontent">
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
      
      <div id="Tokyo" class="tabcontent">
        <h3>Book your camping spot here </h3>
        <img src="img/SiteMap_Brochure2011.jpg">
        <button>Add Guest</button>
        <h3><a href="payment.html">Confirm</a></h3>
      </div>
      <div id="Tehran" class="tabcontent">

          </div>
</body>
</html>