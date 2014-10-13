<?php 
$input = $_GET['text'];
$text= htmlspecialchars($input);
//$result = preg_replace("/[^a-zA-Z0-9]+/", "", $input);

$words = preg_split("/[\s,]*\\\"([^\\\"]+)\\\"[\s,]*|" . "[\s,]*'([^']+)'[\s,]*|" . "[\s,]+/", $input, 0, PREG_SPLIT_NO_EMPTY | PREG_SPLIT_DELIM_CAPTURE);
//var_dump($words);

//echo count($words);
$test = "";
$test2 = "";
$testing = "";


for ($i=0; $i < 20; $i++) {
	$testing = $words[$i];
	//echo "$testing<br>";
	 if (!ctype_upper($testing)) {
		 $test = strrev("$words[$i]");
		//echo $test;
		//echo $words[$i];
		$test2 = $words[$i];
		$reverse = str_replace("$words[$i]", "$test", $text);
		$test = "";
		$test2 = "";
	 }
	 else {
		continue;
	 }
	 
}
$ala = "ala bala nica HP";
$misho = str_replace("HP","PH", $ala);
var_dump($reverse);

?>