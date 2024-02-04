
CREATE TABLE [dbo].[Departments]
(
	[Dep_Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Dep_Name] NCHAR(10) NOT NULL, 
    [Create_Date] DATE NULL, 
    [Edit_Date] DATE NULL
)
