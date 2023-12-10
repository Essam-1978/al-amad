CREATE TABLE [dbo].[agreements]
(
	[Agr_Id] INT NOT NULL PRIMARY KEY, 
    [First_Party] NVARCHAR(50) NOT NULL, 
    [Second_Party] NVARCHAR(50) NOT NULL, 
    [date] DATE NOT NULL
)
