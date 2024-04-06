CREATE TABLE [dbo].[Person] (
    [Id]				INT           IDENTITY (1, 1) NOT NULL,
    [Name]				VARCHAR (100) NOT NULL,
    [ImageUrl]			VARCHAR (250) NULL,
    [ShortDescription]	NVARCHAR(400) NOT NULL,
    [Description]		NVARCHAR(MAX) NOT NULL,

    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC)
);
