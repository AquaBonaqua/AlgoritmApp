USE [Game]
GO
/****** Object:  Table [dbo].[Gamer]    Script Date: 05.04.2019 12:46:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gamer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[TryId] [int] NULL,
	[Score] [int] NULL,
 CONSTRAINT [PK_Gamer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Try]    Script Date: 05.04.2019 12:46:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Try](
	[Id] [int] NOT NULL,
	[TryCount] [int] NULL,
 CONSTRAINT [PK_Try] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gamer] ON 

INSERT [dbo].[Gamer] ([Id], [Login], [TryId], [Score]) VALUES (7, N'Шитов', 1, 5)
INSERT [dbo].[Gamer] ([Id], [Login], [TryId], [Score]) VALUES (8, N'Михалевич', 1, 0)
SET IDENTITY_INSERT [dbo].[Gamer] OFF
INSERT [dbo].[Try] ([Id], [TryCount]) VALUES (1, 5)
ALTER TABLE [dbo].[Gamer]  WITH CHECK ADD  CONSTRAINT [FK_Gamer_Try] FOREIGN KEY([TryId])
REFERENCES [dbo].[Try] ([Id])
GO
ALTER TABLE [dbo].[Gamer] CHECK CONSTRAINT [FK_Gamer_Try]
GO
