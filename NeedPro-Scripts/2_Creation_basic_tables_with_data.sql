USE [NeedPro]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 01/11/2020 15:34:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[City]    Script Date: 01/11/2020 15:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Country]    Script Date: 01/11/2020 15:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Skill]    Script Date: 01/11/2020 15:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Skill]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Skill](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CategoryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[User]    Script Date: 01/11/2020 15:34:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Type] [int] NOT NULL,
	[Adress] [nvarchar](80) NOT NULL,
	[Email] [nvarchar](80) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Scientifique')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Informatique')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([Id], [Name]) VALUES (1, N'Ben arous')
INSERT [dbo].[City] ([Id], [Name]) VALUES (2, N'Ariana')
INSERT [dbo].[City] ([Id], [Name]) VALUES (3, N'Manouba')
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [Name]) VALUES (1, N'Tunisie')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (2, N'Algérie')
INSERT [dbo].[Country] ([Id], [Name]) VALUES (3, N'Maroc')
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Skill] ON 

INSERT [dbo].[Skill] ([Id], [Name], [Description], [CategoryId]) VALUES (1, N'C#', N'Language de développement', 2)
INSERT [dbo].[Skill] ([Id], [Name], [Description], [CategoryId]) VALUES (2, N'Java', N'Language de développement', 2)
INSERT [dbo].[Skill] ([Id], [Name], [Description], [CategoryId]) VALUES (3, N'Psychologie', N'Psychologie sociale', 1)
SET IDENTITY_INSERT [dbo].[Skill] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [FirstName], [LastName], [Type], [Adress], [Email], [DateOfBirth]) VALUES (1, N'Soumaya', N'Mejri', 1, N'Morneg, Ben arous', N'soumaya@gmail.com', CAST(N'1994-02-02' AS Date))
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [Type], [Adress], [Email], [DateOfBirth]) VALUES (2, N'Mohamed Skander', N'Haouem', 1, N'Ezzahra, Ben arous', N'skander@gmail.com', CAST(N'1995-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[User] OFF
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__User__DateOfBirt__2D27B809]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[User] ADD  DEFAULT (getdate()) FOR [DateOfBirth]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Skill_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Skill]'))
ALTER TABLE [dbo].[Skill]  WITH CHECK ADD  CONSTRAINT [FK_Skill_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Skill_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Skill]'))
ALTER TABLE [dbo].[Skill] CHECK CONSTRAINT [FK_Skill_Category]
GO
USE [master]
GO
ALTER DATABASE [NeedPro] SET  READ_WRITE 
GO
