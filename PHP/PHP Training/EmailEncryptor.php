<?php
$recipientText = $_GET['recipient'];
$subjectText = $_GET['subject'];
$bodyText = $_GET['body'];
$keyText = $_GET['key'];
$body ="";
$body = htmlspecialchars($bodyText);
$subject = htmlspecialchars($subjectText);
$recipient = htmlspecialchars($recipientText);

$messageText = "<p class='recipient'>$recipient</p><p class='subject'>$subject</p><p class='message'>$body</p>"; // space after coming.
$message = htmlspecialchars($messageText); // see without htmlspecialchars


$array = [];
$array = str_split($messageText);
$keyArr = [];
$keyArr = str_split($keyText);
$result = [];
$y=0;

$length = count($keyArr);


for ($i=0; $i < count($array); $i++){
	$result[$i] = ord($keyArr[$y]) * ord($array[$i]);
	
	
	echo "|";
	echo dechex($result[$i]);
 	if ($y == $length - 1){
		 $y=-1;
	 }
	$y++;
	
}
echo "|";





?>
