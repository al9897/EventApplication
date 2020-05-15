<?php
$page_title="Profile";
include_once 'Partial/header.php';
include_once 'Partial/parseProfile.php';

?>


<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Profile</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" media="screen" href="css/profile.css" />
    <script src="main.js"></script>
</head>
<body>
<div id="London" class="tabcontent">
    <h2>Please contact us in case of inputing wrong information</h2>
    <table>
        <tr>
            <td>
                Name
            </td>
            <td></td>
            <td>
                Amin
            </td>
        </tr>
        <tr>
            <td>
                LastName
            </td>
            <td></td>

            <td>
                Jahromi
            </td>
        </tr>
        <tr>
            <td>
                Username
            </td>
            <td></td>

            <td>
                a.masoumzadeganjahromi@student.fontys.nl
            </td>
        </tr>
        <tr>
            <td>
                Email
            </td>
            <td></td>
            <td>
                a.masoumzadeganjahromi@student.fontys.nl
            </td>
        </tr>
        <tr>
            <td>
                Phone
            </td>
            <td></td>

            <td>
                06 26819248
            </td>
        </tr>
        <tr>
            <td>
                Address
            </td>
            <td></td>

            <td>
                Rachelmodnstraat R1 146
            </td>
        </tr>
        <tr>
            <td>
                PostalCode
            </td>
            <td></td>

            <td>
                4432 BG
            </td>
        </tr>
        <tr>
            <td>
                Country
            </td>
            <td></td>

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
<div id="Tehran" class="tabcontent">

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

</body>
</html>