CREATE TABLE [dbo].[employees]
(
	[Emp_Id] INT NOT NULL PRIMARY KEY, 
    [Ftrst_Name] NCHAR(50) NOT NULL, 
    [Mid_Name] NCHAR(50) NOT NULL, 
    [Last_Name] NCHAR(50) NOT NULL, 
	[Birth_Date] DATETIME NOT NULL,
    [Photo] BINARY(50) NOT NULL, 
    [Badge_Id] BINARY(50) NULL, 
    [Dep_Id] INT NOT NULL, 
    [Address] NCHAR(50) NULL, 
    [Mobile] NCHAR(20) NULL, 
    [Hire_Date] DATE NOT NULL
)
