CREATE PROCEDURE [dbo].[AddChannel]
    @Title nvarchar(50)

AS
	
	Insert into [Channel] values (@Title)
