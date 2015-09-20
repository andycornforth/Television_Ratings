CREATE PROCEDURE [dbo].[AddPerson]
    @FirstName nvarchar(50),
	@LastName nvarchar(50),
    @Email nvarchar(100),
	@Password nvarchar(50)

AS
	
	Insert into [Person] values (@FirstName, @LastName, @Email, @Password)
