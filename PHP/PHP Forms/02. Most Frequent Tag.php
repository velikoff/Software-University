<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Problem 2 - The Most Frequent Tag</title>
</head>
<body>
<section>
    <p>Enter Tags:</p>
    <form method="post" action="">
        <input type="text" name="tags" id="tags">
        <input type="submit" name="submitter" id="submitter" value="Submit">
    </form>
    <br />
</section>
</body>
</html>
<?php
if (isset($_POST['tags']) && strlen($_POST['tags']) > 0) { 
    $inputStr = htmlentities($_POST['tags']); 
    $inputArr = explode(',', $inputStr); 
    $inputArr = array_map('trim', $inputArr); 

    $count = array_count_values($inputArr); 
    arsort($count); 
    $keys = array_keys($count); 
    foreach ($count as $tag => $value) { 
        echo $tag . ' : ' . $value . ' times' . '<br>'; 
    }

    echo '<br>' . 'Most Frequent Tag is: ' . $keys[0];

} elseif (strlen($_POST['tags']) == 0 && isset($_POST['submitter'])) { 
    echo 'You have to submit something first!';                       
} else {
    die;
}
?>