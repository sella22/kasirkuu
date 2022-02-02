CREATE TABLE [dbo].[admin] (
    [Id_admin] INT         IDENTITY (1, 1) NOT NULL,
    [email]    NCHAR (255) NULL,
    [password] NCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Id_admin] ASC)
);

