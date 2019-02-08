USE [master]
GO
/****** Object:  StoredProcedure [dbo].[Build_db_zoo]    Script Date: 3/27/2017 9:27:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Build_db_zoo]
AS
BEGIN

	/******************************************************
	 * The following prevents any errors from occuring
	 * if the database or tables already exist.
	 * This code will close all active connections to the 
	 * database and then drop it
	 ******************************************************/

	WHILE EXISTS(select * from sys.databases where name='db_zoo')
	BEGIN
		DECLARE @SQL varchar(max)
		SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
		FROM MASTER.sys.sysprocesses
		WHERE DBId = DB_ID(N'db_zoo') AND SPId <> @@SPId
		EXEC(@SQL)
		DROP DATABASE [db_zoo]
	END
	/******************************************************
	 * The following demonstrates a stored proceedure to 
	 * build the database, tables and then populate the 
	 * tables with data.
	 ******************************************************/

	CREATE DATABASE db_zoo

END

GO
