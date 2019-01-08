USE [XPTO]
GO

/****** Object:  Table [dbo].[Pessoa]    Script Date: 07/01/2019 21:46:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pessoa](
	[id] [int] NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[sobreNome] [varchar](50) NOT NULL,
	[nascimento] [date] NOT NULL,
	[sexo] [varchar](15) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Pessoa_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


