<!DOCTYPE html>
<html>
<title>Admin Panel</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="X-UA-Compatible" content="IE=edge" >
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="/css/style.css">
<script type="text/javascript" src="/js/main.js"></script>

<body>
<div class="bgimg w3-display-container w3-animate-opacity w3-text-white">
  <div class="w3-display-middle">

    <iframe name="hiddenFrame" width="0" height="0" border="0" style="display: none;"></iframe>

    <form action="<?php $_SERVER['PHP_SELF'];?>" method="POST">
      <label for="Username"><b>Administrator Username</b></label>
      <input type="text" id="UsernameBox" placeholder="Enter Username" name="Username" required>

      <label for="Password"><b>Password</b></label>
      <input type="Password" id="PasswordBox" placeholder="Enter Password" name="Password" required>
<break></break>
      <label for="Username"><b>Username</b></label>
      <input type="text" id="UsernameBox1" placeholder="Enter Username" name="Username1" required>

      <label for="Expires">Expires</label>
      <select id="TimeBox" name="Expires">
        <option value=1>1 Day(s)</option>
        <option value=7>7 Day(s)</option>
        <option value=30>30 Day(s)</option>
        <option value=25000000>Lifetime</option>
      </select>

      <label for="Admin">Administrator</label>
      <select id="AdminBox" name="Admin">
        <option value=0>False</option>
        <option value=1>True</option>
      </select>

      <button id="SubmitButton" onclick="" value="Submit">Submit</button>

      <div id="id01" class="modal">

        <div class="w3-modal-content">
          <header class="w3-container w3-display-topcenter purple_neat">
            <span onclick="document.getElementById('id01').style.display='none'"
              class="w3-button w3-display-topright">&times;</span>
              <h2>Messagebox</h2>
            </header>
            <div class="w3-container">

              <span style="color:black;">
<?php

# Get variables from post method

$Username = $_POST['Username'];
$Password = $_POST['Password'];
$Username1 = $_POST['Username1'];
$Expires = $_POST['Expires'];
$Administrator = $_POST['Administrator'];

# Static variables

$Inifile = $_SERVER['DOCUMENT_ROOT'];
$Inifile .= "/php/Settings.ini";
$Settings = parse_ini_file($Inifile, true);

$Serverhostname = $Settings['Database']['Hostname'];
$Databaseuser   = $Settings['Database']['Username'];
$Databasepass   = $Settings['Database']['Password'];
$Databasename   = $Settings['Database']['Database'];

$Adminuser = $Settings['Admin']['Username'];
$Adminpass = $Settings['Admin']['Password'];

$Usertable = $Settings['Tables']['Usertable'];
$Codetable = $Settings['Tables']['Codetable'];

# Connect to Server

$conn = new mysqli($Serverhostname, $Databaseuser, $Databasepass);

# Check if Database exists if not create it

$conn->query("CREATE DATABASE IF NOT EXISTS ${Databasename}");

# Check if Table exists if not create it

$conn = new mysqli($Serverhostname, $Databaseuser, $Databasepass, $Databasename);

$sql = "CREATE TABLE IF NOT EXISTS ${Usertable} (
id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Username VARCHAR(255) NOT NULL,
Password VARCHAR(255) NOT NULL,
Administrator VARCHAR(1) NOT NULL,
Expires VARCHAR(255),
Updated TIMESTAMP
)";

$conn->query($sql);

# Calculate results

$sql = "SELECT * FROM ${Usertable} WHERE Username = '${Username}' and Password = '${Password}'";

if ($conn->query($sql)->num_rows === 1) {

    $Administrator = $conn->query($sql)->fetch_object()->Administrator;

    if ($conn->query("SELECT * FROM ${Usertable} WHERE Username = '${Username}' and Password = '${Password}'")->num_rows === 1) {
        $Timeleft = $conn->query($sql)->fetch_object()->Expires;
        $Administrator = $conn->query($sql)->fetch_object()->Administrator;

        if ($Timeleft > 0) {
          if ($Timeleft >= 25000000) {
              echo "{'Username':'${Username}','Expires':'Never','Authenticated':'true','Administrator':'${Administrator}','Description':'Welcome ${Username} you have successfully logged in.'}";
          }
          else {
              echo "{'Username':'${Username}','Expires':'${Timeleft}','Authenticated':'true','Administrator':'${Administrator}','Description':'Welcome ${Username} you have successfully logged in.'}";
          }
        }
        else {
          echo "{'Username':'${Username}','Expires':'${Timeleft}','Authenticated':'false','Description':'Sorry ${Username} your subscription has expired.'}";
        }

        die();
    }
}

if ($conn->query($sql)->num_rows >= 1) {
  echo "{'Username':'${Username}','Expires':'0','Authenticated':'false','Description':'Sorry ${Username} an unknown error has occured.'}";
}
else {
  echo "{'Username':'${Username}','Expires':'0','Authenticated':'false','Description':'Sorry ${Username} an account with these details does not exist.'}";
}

# Close our connection

$conn->close();

?>

              </span>
            </div>
          </div>
        </div>

      <?php

      if(isset($_POST['Username'])) {
        if(isset($_POST['Password'])) {
          if(isset($_POST['Amount'])) {
            if(isset($_POST['Expires'])) {
              if(isset($_POST['Admin'])) {

                echo "<script> document.getElementById('id01').style.display='block' </script>";
              }
            }
          }
        }
      }

      ?>

      </form>
    </div>

    <div class="w3-display-bottommiddle w3-padding-large">
    Copyright © 2019 RedTool made by TinyCorp
    </div>
</body>
</html>
