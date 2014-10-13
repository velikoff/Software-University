<?php
$n = 1234;
$arr = array();

if ($n < 102) {
	echo "No";
} else {
	for ($i=102; $i < 1000; $i++) {
		$counter = $i; 
		while ($counter !== 0) {
			$var = (int)($counter % 10);
			$counter = (int)($counter / 10);
			$arr[] = $var;
			$var = 0;		
		}
		if ($arr[0] !== $arr[1] && $arr[0] !== $arr[2] && $arr[1] !== $arr[2]) {
				$array2 = array_reverse($arr);
				echo implode($array2);
				echo ", ";
				
		}else{
			unset($arr);
			unset($array2);
		}
		unset($arr);
		unset($array2);
	}
}

?>