/****** Script for SelectTopNRows command from SSMS  ******/


UPDATE [CS6232-g4].[dbo].[Login]
SET [password] = PWDENCRYPT('password');