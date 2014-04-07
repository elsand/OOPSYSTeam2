<?php

ini_set('display_errors', 'on');
error_reporting(E_ALL);

// Tar for lang tid, dump lokalt og last opp
//$dbh = new PDO("mysql:host=mysql.stud.aitel.hist.no;dbname=***REMOVED***", "***REMOVED***", "***REMOVED***");
$url   = 'http://www.erikbolstad.no/postnummer-koordinatar/txt/postnummer.txt';
/*
 Array
 (
     [0] => 0001                                        // Postnummer
     [1] => Oslo                                        // Poststed
     [2] => 0001 OSLO                                   // Postnr/sted
     [3] => Postboksar                                  // Type
     [4] =>                                             // Folketall
     [5] => Sentrum                                     // Bydel
     [6] => 301                                         // Kommunenr
     [7] => Oslo                                        // Kommune
     [8] => Oslo                                        // Fylke
     [9] => 59.9116                                     // Latitude
     [10] => 10.7545                                    // Longitude
     [11] => 2                                          // Datakvalitet
     [12] => Koordinatane er retta av Erik Bolstad      // Forklaring
     [13] => 2012-09-28 19:49:37                        // Sist oppdatert
 )
*/

///////////////////////////////////////////////////////////////////

$f = fopen($url, 'r');
if (!$f) {
	die("Kan ikke åpne $url!\n");
}
$ziplist = array();
while ($line = fgetcsv($f, null, "\t")) {

	if (count($line) < 5 || $line[0] == "POSTNR") {
		continue;
	}

	if (stripos($line[1], 'ikkje i bruk'))
		continue;

	//$line = array_map('utf8_decode', $line);

	$ziplist[$line[0]] = $line[1];
}
$count = count($ziplist);
//echo "Hentet $count postnumre fra $url\n";

 $done = 0;
echo "SET FOREIGN_KEY_CHECKS = 0;\n";
foreach ($ziplist as $zip => $city) {
	$done++;
	if ($done % 10 == 0) {
	//	echo "\r". round(($done / $count) * 100, 1) . "%";
	}
	echo "REPLACE INTO zip (zip, city) VALUES ('$zip', '$city');\n";
	//$dbh->query("REPLACE INTO zip (zip, city) VALUES ('$zip', '$city')");

}
echo "SET FOREIGN_KEY_CHECKS = 1;\n";
//echo "\r100%\n\n";
//echo "Database oppdatert \n";