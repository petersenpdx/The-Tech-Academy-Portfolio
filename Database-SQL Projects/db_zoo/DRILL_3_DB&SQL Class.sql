USE [db_zoo]
GO  

SELECT nutrition_type
FROM [dbo].[tbl_nutrition]
WHERE nutrition_cost<=600;
