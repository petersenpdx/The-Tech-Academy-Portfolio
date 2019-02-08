

CREATE DATABASE db_seaweed;

CREATE TABLE tbl_methode (
		methode_id INT PRIMARY KEY NOT NULL IDENTITY(1000,1),
		methode_name VARCHAR(50) NOT NULL,
		methode_cost MONEY NOT NULL
);

CREATE TABLE tbl_location (
		location_name VARCHAR(50) NOT NULL,
		seaweed_id INT NOT NULL CONSTRAINT fk_seaweed_id FOREIGN KEY REFERENCES tbl_seaweed(seaweed_id), 
		methode_id INT NOT NULL CONSTRAINT fk_methode_id FOREIGN KEY REFERENCES tbl_methode(methode_id), 
);

CREATE TABLE tbl_seaweed (
		seaweed_id INT PRIMARY KEY NOT NULL IDENTITY (1000,1),
		seaweed_name VARCHAR(50) NOT NULL
	);


INSERT INTO tbl_seaweed
		(seaweed_name)
		VALUES 
		('Chlorella'),
		('Arame'),
		('Oarweed'),
		('Sea palm'),
		('Sea whip'),
		('Irish Moss')
	;
	SELECT * FROM tbl_seaweed;

	INSERT INTO tbl_methode
		(methode_name, methode_cost)
		VALUES 
		('Line', 1500),
		('Net', 3000),
		('Cage', 40000),
		('Natural', 0),
		('Bottom Monoline', 4000);

	SELECT * FROM tbl_methode

	INSERT INTO tbl_location
		(location_name, seaweed_ID, methode_ID)
		VALUES 
		('Alaska', 1001, 1003),
		('South Pacific', 1005, 1000),
		('Fiji', 1000, 1003),
		('Austrlia', 1004, 1001),
		('Scottland', 1002, 1002),
		('Ireland', 1003, 1001);

	SELECT * FROM tbl_methode
	SELECT * FROM tbl_seaweed
	SELECT * FROM tbl_location

SELECT tbl_seaweed.seaweed_name, tbl_location.location_name 
FROM tbl_seaweed
INNER JOIN tbl_location ON tbl_seaweed.seaweed_id=tbl_location.seaweed_ID;
