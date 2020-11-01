USE [master]
GO
/****** Object:  Database [NeedPro]    Script Date: 01/11/2020 15:34:20 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'NeedPro')
BEGIN
	Drop DATABASE [NeedPro]
	CREATE DATABASE [NeedPro]
END
ELSE 
BEGIN
	CREATE DATABASE [NeedPro]
END
GO

