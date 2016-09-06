SELECT `output`.`Output`, `testing`.`timelog` FROM `output`,`testing` WHERE `testing`.`idOutput`=`output`.`idOutput` ORDER BY `testing`.`timelog`;

SELECT `testing`.`F1`,`testing`.`F2`,`testing`.`F3`,`testing`.`F4`,`testing`.`F5`,`testing`.`F6`, `output`.`Output` AS 'Ekpresi',
	DATE(`testing`.`timelog`) AS 'Tanggal',TIME(`testing`.`timelog`) AS 'Waktu'
FROM output, testing
WHERE output.`idOutput`=testing.`idOutput` AND `testing`.`idUser`='purwanto@outlook.com'
GROUP BY testing.`timelog` , `output`.`Output`;


SELECT `output`.`Output` AS 'Ekpresi',  COUNT(output.`Output`) AS 'jumlah',DATE(`testing`.`timelog`) AS 'Tanggal',TIME(`testing`.`timelog`) AS 'Waktu'
FROM output, testing
WHERE output.`idOutput`=testing.`idOutput` AND DATE(`testing`.`timelog`)=CURDATE()
GROUP BY testing.`timelog` , `output`.`Output`;