CREATE TABLE [dbo].[Employee]
(
	[empno] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NULL, 
    [designation] NVARCHAR(50) NULL, 
    [joindate] DATE NULL, 
    [salary] NUMERIC NULL
)
