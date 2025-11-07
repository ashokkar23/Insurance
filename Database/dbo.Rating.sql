CREATE TABLE [dbo].[Rating]
(
	[Id] INT NOT NULL PRIMARY KEY,     
    [Rating] NVARCHAR(15) NOT NULL,
    [Factor] DECIMAL(5,2) NOT NULL
)