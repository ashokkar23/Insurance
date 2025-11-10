# Architecture Pattern:
Have  tried best to implement Clean Architecture Principle for coding.
 ![Clean Architecture Pic](CleanArchitect.jpg)

# Not Implemented :
-	Storing Member Information in Database
-	Authentication method  for API and UI
-	Complete working and clean UI

# Areas for improvements:
-	Occupation Id,  should not come as Input for calculatePremium. Only Occupation should be in the payload. 
-	AppGateway though implemented but not working as expected.
-	JWT Authentication  for end points.
-	Authetication module for the whole application.

# Database Schema

```SQL
CREATE TABLE [dbo].[Member] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (50) NOT NULL,
    [DateOfBirth]     DATE          NOT NULL,
    [AgeNextBirthDay] TINYINT       NOT NULL,
    [OccupationId]    INT           NOT NULL,
    [SumInsured]      MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([OccupationId]) REFERENCES [dbo].[Occupation] ([Id])
);

CREATE TABLE [dbo].[Occupation] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Occupation] NVARCHAR (25) NOT NULL,
    [RatingId]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([RatingId]) REFERENCES [dbo].[Rating] ([Id])
);

CREATE TABLE [dbo].[Rating] (
    [Id]     INT            NOT NULL,
    [Rating] NVARCHAR (15)  NOT NULL,
    [Factor] DECIMAL (5, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

```