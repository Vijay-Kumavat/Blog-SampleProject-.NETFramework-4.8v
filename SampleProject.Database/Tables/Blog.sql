CREATE TABLE [dbo].[Blog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ThumbnailUrl] [varchar](150) NOT NULL,
	[Title] [varchar](500) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[ViewCount] [int] NOT NULL,
	[PersonId] [int] NULL, 
    CONSTRAINT [PK_Blog] PRIMARY KEY ([Id])
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Blog] ADD  CONSTRAINT [DF_Blog_ViewCount]  DEFAULT ((1)) FOR [ViewCount]
GO

ALTER TABLE [dbo].[Blog]  WITH CHECK ADD  CONSTRAINT [FK_Person_Blog] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO

ALTER TABLE [dbo].[Blog] CHECK CONSTRAINT [FK_Person_Blog]
GO