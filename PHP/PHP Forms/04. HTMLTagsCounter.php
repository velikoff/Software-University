<?php
session_start();
?>
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML Tags Counter</title>
</head>
<body>
<label for="text">Enter HTML tags:</label><br><br>

<form method="get">
    <input type="text" id="text" name="text" autofocus/>
    <input type="submit"/><br/><br/>
</form>
<?php
$htmlTags = file('html-tags.txt', FILE_IGNORE_NEW_LINES);
if (isset($_GET['text'])) {
    $tag = $_GET['text'];

    if (!isset($_SESSION['count'])) {
        $_SESSION['count'] = 0;
    }

    if (array_search($tag, $htmlTags) !== false) {
        echo 'Valid HTML tag!<br>';
        $_SESSION['count']++;
    } else {
        echo 'Invalid HTML tag!<br>';
    }

    echo 'Score: ' . $_SESSION['count'];
}
?>
</body>
</html>