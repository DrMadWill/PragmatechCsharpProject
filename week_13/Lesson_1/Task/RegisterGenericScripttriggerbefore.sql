USE [Register]
GO
/****** Object:  Table [dbo].[CoyUser]    Script Date: 1/11/2022 12:23:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoyUser](
	[Id] [int] NOT NULL,
	[Name] [nchar](60) NOT NULL,
	[UserName] [nchar](40) NOT NULL,
	[Tel] [int] NULL,
	[Region] [nchar](70) NULL,
	[JobId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 1/11/2022 12:23:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](40) NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 1/11/2022 12:23:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](60) NOT NULL,
	[UserName] [nchar](40) NOT NULL,
	[Tel] [int] NULL,
	[Region] [nchar](70) NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Job] ON 

INSERT [dbo].[Job] ([Id], [Name]) VALUES (1, N'Teacher                                 ')
INSERT [dbo].[Job] ([Id], [Name]) VALUES (2, N'Enginner                                ')
INSERT [dbo].[Job] ([Id], [Name]) VALUES (3, N'Developer                               ')
INSERT [dbo].[Job] ([Id], [Name]) VALUES (4, N'Solder                                  ')
INSERT [dbo].[Job] ([Id], [Name]) VALUES (5, N'Aouthor                                 ')
SET IDENTITY_INSERT [dbo].[Job] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [UserName], [Tel], [Region], [JobId]) VALUES (1, N'Ali                                                         ', N'Ali55                                   ', 5555666, N'Qazak                                                                 ', 1)
INSERT [dbo].[User] ([Id], [Name], [UserName], [Tel], [Region], [JobId]) VALUES (2, N'Jon                                                         ', N'Jhon                                    ', 6656564, N'Amerika                                                               ', 3)
INSERT [dbo].[User] ([Id], [Name], [UserName], [Tel], [Region], [JobId]) VALUES (3, N'Berke                                                       ', N'Berk                                    ', 77784456, N'Turk                                                                  ', 4)
INSERT [dbo].[User] ([Id], [Name], [UserName], [Tel], [Region], [JobId]) VALUES (4, N'Muyki                                                       ', N'Mukii                                   ', 68878514, N'Japon                                                                 ', 5)
INSERT [dbo].[User] ([Id], [Name], [UserName], [Tel], [Region], [JobId]) VALUES (5, N'Will                                                        ', N'MadWill                                 ', 77777777, N'Ideal                                                                 ', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[CoyUser]  WITH CHECK ADD  CONSTRAINT [FK_CoyUser_Job] FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([Id])
GO
ALTER TABLE [dbo].[CoyUser] CHECK CONSTRAINT [FK_CoyUser_Job]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Job] FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Job]
GO
