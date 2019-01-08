USE [XPTO]
GO

/****** Object:  Table [dbo].[Produto]    Script Date: 08/01/2019 16:22:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produto](
	[id] [int] NOT NULL,
	[pessoa_id] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Pessoa_Produto] FOREIGN KEY([pessoa_id])
REFERENCES [dbo].[Pessoa] ([id])
GO

ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Pessoa_Produto]
GO


