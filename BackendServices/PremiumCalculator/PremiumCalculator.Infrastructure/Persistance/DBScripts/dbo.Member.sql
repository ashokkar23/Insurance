DROP TABLE IF EXISTS [dbo].[Member];
CREATE TABLE [dbo].[Member]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [DateOfBirth] DATE NOT NULL, 
    [AgeNextBirthDay] TINYINT NOT NULL, 
    [OccupationId] INT NOT NULL FOREIGN KEY REFERENCES Occupation, 
    [SumInsured] MONEY NOT NULL
)