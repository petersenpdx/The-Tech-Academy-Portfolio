/* Retrieve all names within the species_name column using the alias "Species Name:" from 
the species table and their corresponding nutrition_type under the alias "Nutrition Type:" from 
the nutrition table. */

USE [db_zoo]
GO  

SELECT * FROM [dbo].[tbl_species]
SELECT * FROM [dbo].[tbl_nutrition]



SELECT tbl_species.species_name AS "Species Name:", tbl_nutrition.nutrition_type AS "Nutrition Type:"
FROM tbl_nutrition
INNER JOIN tbl_species ON tbl_species.species_nutrition=tbl_nutrition.nutrition_ID;

