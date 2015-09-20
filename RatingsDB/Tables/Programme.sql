CREATE TABLE [dbo].[Programme]
(
	[ProgrammeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(100) NOT NULL, 
    [ChannelId] INT NOT NULL, 
    CONSTRAINT [FK_Programme_Channel] FOREIGN KEY ([ChannelId]) REFERENCES [Channel]([ChannelId])
)
