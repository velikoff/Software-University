<?php
	$var = 152;
	
	if (is_numeric($var)) {
		var_dump($var);
	} else {
		echo gettype($var);
	}
	
?>