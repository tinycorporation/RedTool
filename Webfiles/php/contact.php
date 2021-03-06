<?php
$Name = $_POST['Name'];
$Email = $_POST['Email'];
$Subject = $_POST['Subject'];
$Message = $_POST['Message'];

# Static variables

$Inifile = $_SERVER['DOCUMENT_ROOT'];
$Inifile .= "/php/Settings.ini";
$Settings = parse_ini_file($Inifile, true);

$Serverhostname = $Settings['Database']['Hostname'];
$Databasename   = $Settings['Database']['Database'];
$Databaseuser   = $Settings['Database']['Username'];
$Databasepass   = $Settings['Database']['Password'];

$Contact = $Settings['Tables']['Contact_table'];

//whether ip is from share internet
if (!empty($_SERVER['HTTP_CLIENT_IP']))  
  {
    $ip_address = $_SERVER['HTTP_CLIENT_IP'];
  }
//whether ip is from proxy
elseif (!empty($_SERVER['HTTP_X_FORWARDED_FOR']))  
  {
    $ip_address = $_SERVER['HTTP_X_FORWARDED_FOR'];
  }
//whether ip is from remote address
else
  {
    $ip_address = $_SERVER['REMOTE_ADDR'];
  }

# Connect to Server

$conn = new mysqli($Serverhostname, $Databaseuser, $Databasepass);

if($conn->connect_error) {
    die("connection failed: " . $conn->connect_error);
}

# Check if Database exists if not create it

$conn->query("CREATE DATABASE IF NOT EXISTS ${Databasename}");

# Check if Table exists if not create it

$conn = new mysqli($Serverhostname, $Databaseuser, $Databasepass, $Databasename);

$sql = "CREATE TABLE IF NOT EXISTS ${Contact} (
id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
Email VARCHAR(100) NOT NULL,
Subject VARCHAR(100) NOT NULL,
Message text,
ipaddress VARCHAR(255) NOT NULL,
Created_on DATETIME DEFAULT CURRENT_TIMESTAMP
)";

$conn->query($sql);

$conn->query("INSERT INTO ${Contact} (Name, Email, Subject, Message, ipaddress) VALUES ('${Name}', '${Email}', '${Subject}', '${Message}', '${ip_address}') ");
    echo "<script>
		alert('Thank you for contacting us, we will get back to you on ${Email} soon!');
		window.history.go(-2);
     </script>";

$conn->close();
?>
