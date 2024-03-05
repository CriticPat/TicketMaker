CREATE TABLE [dbo].[UserTable]
(
	[User_ID] INT NOT NULL PRIMARY KEY, 
    [User_FirstName] NCHAR(10) NOT NULL, 
    [User_SecondName] NCHAR(10) NOT NULL, 
    [User_Email] NCHAR(10) NOT NULL, 
    [User_Phone] INT NULL, 
    [User_Activity] NCHAR(10) NULL, 
    [User_Level] NCHAR(10) NOT NULL
)
