DROP TABLE IF EXISTS [dbo].[Occupation];

CREATE TABLE [dbo].[Occupation] (
    [Id]         INT           NOT NULL IDENTITY,
    [Occupation] NVARCHAR (25) NOT NULL,
    [RatingId]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([RatingId]) REFERENCES [dbo].[Rating] ([Id])
);