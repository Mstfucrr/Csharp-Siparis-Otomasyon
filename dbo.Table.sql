CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Ad] NVARCHAR(50) NOT NULL, 
    [Soyad] NVARCHAR(50) NOT NULL,
    [Adres] NVARCHAR(MAX) NOT NULL, 
    [Created_date] DATETIME NOT NULL
)
