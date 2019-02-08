/* From the specialist table, retrieve the first and last name and contact 
number of those that provide care for the penguins from the species table. */

USE [db_zoo]
GO  

SELECT * FROM [dbo].[tbl_species]
SELECT * FROM [dbo].[tbl_specialist]



SELECT tbl_species.species_name, tbl_specialist.specialist_fname, tbl_specialist.specialist_lname, tbl_specialist.specialist_contact
FROM tbl_specialist
INNER JOIN tbl_species ON tbl_species.species_ID=tbl_specialist.specialist_ID
WHERE species_name='penguin';