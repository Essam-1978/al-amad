CREATE TABLE [dbo].[employees]
(
	[Emp_Id] INT NOT NULL PRIMARY KEY, 
    [Ftrst_Name] NCHAR(10) NOT NULL, 
    [Mid_Name] NCHAR(10) NOT NULL, 
    [Last_Name] NCHAR(10) NOT NULL, 
	[Birth_Date] Date NOT NULL,
    [Photo] BINARY(50) NOT NULL, 
    [Badge_Id] BINARY(50) NULL, 
    [Dep_Id] INT NOT NULL, 
    [Address] NCHAR(10) NULL, 
    [Mobile] NCHAR(10) NULL, 
    [Hire_Date] DATE NOT NULL
)
