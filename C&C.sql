CREATE TABLE [dbo].[Contact]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY, 
    [First Name] NVARCHAR(10) NOT NULL, 
    [Last Name] NVARCHAR(10) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(11) NOT NULL, 
    [Address] NVARCHAR(100) NOT NULL, 
    [Comment] NVARCHAR(100) NOT NULL
)

CREATE TABLE [dbo].[Career]
(
	[Id] INT identity(1,1) NOT NULL PRIMARY KEY, 
	[First Name] NVARCHAR(10) NOT NULL, 
    [Last Name] NVARCHAR(10) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(11) NOT NULL, 
	[Desired Position] NVARCHAR(50) NOT NULL, 
   
)
