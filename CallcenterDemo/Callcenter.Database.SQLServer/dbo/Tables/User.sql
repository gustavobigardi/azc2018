CREATE TABLE [dbo].[User] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [FirstName]   VARCHAR (40)     NOT NULL,
    [LastName]    VARCHAR (40)     NOT NULL,
    [Document]    CHAR (11)        NOT NULL,
    [Email]       VARCHAR (160)    NOT NULL,
    [Password]    VARCHAR (MAX)    NOT NULL,
    [Picture]     VARCHAR (MAX)    NULL,
    [PictureFile] VARCHAR (255)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

