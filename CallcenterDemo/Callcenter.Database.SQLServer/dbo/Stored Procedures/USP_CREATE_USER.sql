CREATE PROCEDURE USP_CREATE_USER
    @Id UNIQUEIDENTIFIER,
    @FirstName VARCHAR(40),
    @LastName VARCHAR(40),
    @Document CHAR(11),
    @Email VARCHAR(160),
    @Password VARCHAR(MAX),
	@Picture VARCHAR(MAX),
	@PictureFile VARCHAR(255)
AS
    INSERT INTO [User] (
        [Id], 
        [FirstName], 
        [LastName], 
        [Document], 
        [Email], 
        [Password],
		[Picture],
		[PictureFile]
    ) VALUES (
        @Id,
        @FirstName,
        @LastName,
        @Document,
        @Email,
        @Password,
		@Picture,
		@PictureFile
    )