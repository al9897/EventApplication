<?php

include 'qrgen.php';
echo '<div style="height: 30%; width: 50%;">';
echo '<p>'.bar128(stripcslashes($_POST['PaymentBtn'])).'</p>';
echo '</div>';