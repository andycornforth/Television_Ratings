CREATE TABLE [dbo].[SeasonRating]
(
	[SeasonRatingId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [SeasonId] INT NOT NULL, 
    [Rating] FLOAT NOT NULL, 
    [YearViewed] DATETIME2 NULL, 
    CONSTRAINT [FK_Rating_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([PersonId]), 
    CONSTRAINT [FK_Rating_Season] FOREIGN KEY ([SeasonId]) REFERENCES [Season]([SeasonId])
)
