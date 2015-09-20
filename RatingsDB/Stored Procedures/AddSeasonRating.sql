CREATE PROCEDURE [dbo].[AddSeasonRating]
    @PersonId int,
	@SeasonId int,
    @Rating float,
	@YearViewed datetime2

AS
	
	Insert into [SeasonRating] values (@PersonId, @SeasonId, @Rating, @YearViewed)
