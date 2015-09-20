CREATE TABLE [dbo].[Season]
(
	[SeasonId] INT NOT NULL PRIMARY KEY, 
    [ProgrammeId] INT NOT NULL, 
    [SeasonNumber] INT NOT NULL, 
	[EpisodeCount] INT NOT NULL, 
    [FinishYear] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_Season_Programme] FOREIGN KEY ([ProgrammeId]) REFERENCES [Programme]([ProgrammeId])
)
