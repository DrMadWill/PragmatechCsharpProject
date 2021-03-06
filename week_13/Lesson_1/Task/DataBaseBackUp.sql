USE [master]
GO
/****** Object:  Database [Register]    Script Date: 1/15/2022 12:59:57 AM ******/
CREATE DATABASE [Register]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Register', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Register.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Register_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Register_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Register] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Register].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Register] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Register] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Register] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Register] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Register] SET ARITHABORT OFF 
GO
ALTER DATABASE [Register] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Register] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Register] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Register] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Register] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Register] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Register] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Register] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Register] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Register] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Register] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Register] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Register] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Register] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Register] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Register] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Register] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Register] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Register] SET  MULTI_USER 
GO
ALTER DATABASE [Register] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Register] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Register] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Register] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Register] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Register] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Register] SET QUERY_STORE = OFF
GO
USE [Register]
GO
/****** Object:  UserDefinedFunction [dbo].[FUNC_MyConcat]    Script Date: 1/15/2022 12:59:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[FUNC_MyConcat](@UserName nvarchar(60),@Name nvarchar(60))
Returns nvarchar(100)
As
Begin
Declare @Resault nvarchar(100)
Set @Resault = @UserName+' '+ LEFT(@Name,39) 
return @Resault
End
GO
/****** Object:  Table [dbo].[User]    Script Date: 1/15/2022 12:59:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](60) NOT NULL,
	[UserName] [nvarchar](60) NOT NULL,
	[Tel] [int] NULL,
	[Region] [nvarchar](100) NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 1/15/2022 12:59:58 AM ******/
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
/****** Object:  View [dbo].[FullInfoUser]    Script Date: 1/15/2022 12:59:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[FullInfoUser]
as
select [User].Id,[User].Name,[User].UserName,[User].Region,[User].Tel,Job.Name 'Job'
from [User]
Join Job on [User].JobId=Job.Id
GO
/****** Object:  Table [dbo].[CoyUser]    Script Date: 1/15/2022 12:59:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoyUser](
	[UserId] [int] NOT NULL,
	[Name] [nvarchar](60) NOT NULL,
	[UserName] [nvarchar](60) NOT NULL,
	[Tel] [int] NULL,
	[Region] [nvarchar](100) NULL,
	[JobId] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CoyUser] ([UserId], [Name], [UserName], [Tel], [Region], [JobId]) VALUES (12, N'Aladin', N'MagicLamp', 5454656, N'Suadan', 3)
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

INSERT [dbo].[User] ([Id], [Name], [UserName], [Tel], [Region], [JobId]) VALUES (12, N'Aladin', N'MagicLamp', 5454656, N'Suadan', 3)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__User__C9F28456F1FECC7E]    Script Date: 1/15/2022 12:59:58 AM ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [UQ__User__C9F28456F1FECC7E] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
/****** Object:  StoredProcedure [dbo].[usp_SearchJobId]    Script Date: 1/15/2022 12:59:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_SearchJobId] 
@Name nvarchar(60),
@UserName nvarchar(40),
@Tel int,
@Region nvarchar(70),
@Job nvarchar(40)
as
Insert into Register.dbo.[User](Name,UserName,Tel,Region,JobId) 
values(@Name,@UserName,@Tel,@Region,(select y.Id from dbo.Job y where y.Name=@Job))
GO
USE [master]
GO
ALTER DATABASE [Register] SET  READ_WRITE 
GO
