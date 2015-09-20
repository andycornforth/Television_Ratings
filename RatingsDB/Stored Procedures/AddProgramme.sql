CREATE PROCEDURE [dbo].[AddProgramme]
    @Title nvarchar(50),
	@ChannelId int

AS
	
	Insert into [Person] values (@Title, @ChannelId)
