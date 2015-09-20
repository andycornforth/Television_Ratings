CREATE PROCEDURE [dbo].[AddSeason]
    @ProgrammeId int,
	@SeasonNumber int,
    @EpisodeCount int,
	@FinsihYear datetime2

AS
	
	Insert into [Season] values (@ProgrammeId, @SeasonNumber, @EpisodeCount, @FinsihYear)
