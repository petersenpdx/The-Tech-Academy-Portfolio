USE db_seaweed
GO


CREATE PROCEDURE dbo.JoinSeaweedTbls2P2I  @seaweed nvarchar(30), @location nvarchar(30)
AS
SELECT tbl_seaweed.seaweed_name , tbl_location.location_name , tbl_methode.methode_cost
FROM tbl_location 
INNER JOIN tbl_seaweed ON tbl_seaweed.seaweed_id=tbl_location.seaweed_ID
INNER JOIN tbl_methode ON tbl_methode.methode_id=tbl_location.methode_ID
WHERE seaweed_name = @seaweed AND location_name = @location
GO

EXEC dbo.JoinSeaweedTbls2P2I @seaweed='Sea Palm', @location = 'Ireland';

