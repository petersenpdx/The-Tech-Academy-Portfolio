

USE [db_zoo]
GO  

SELECT * FROM [dbo].[tbl_species]
SELECT * FROM [dbo].[tbl_nutrition]

SELECT tbl_species.species_nutrition, tbl_species.species_name, tbl_nutrition.nutrition_ID
FROM tbl_nutrition
INNER JOIN tbl_species ON tbl_species.species_nutrition=tbl_nutrition.nutrition_ID
WHERE nutrition_id BETWEEN 2202 AND 2206;
