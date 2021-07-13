<?php

	$hostname = $_GET['hostname'];
	$myip = $_GET['myip'];	
	$user = $_GET['user'];
	$pass = $_GET['pass'];

$url = "http://$user:$pass@dynupdate.no-ip.com/nic/update?hostname=$hostname&myip=$myip";

echo $result = file_get_contents($url);

?>

