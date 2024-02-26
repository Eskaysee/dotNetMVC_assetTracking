CREATE TABLE [dbo].[Firmware]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(255) NOT NULL,
	[Version] VARCHAR(50) NOT NULL,
    [ReleaseDate] DATE NOT NULL
)
