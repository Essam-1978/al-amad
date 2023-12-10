CREATE TABLE [dbo].[Payroll]
(
	[Payroll_Id] INT NOT NULL PRIMARY KEY, 
    [Payroll_Date] DATE NOT NULL, 
    [Emp_Id] INT NOT NULL, 
    [Salary] MONEY NOT NULL, 
    [Bonus] MONEY NULL, 
    [Note] TEXT NULL
)
