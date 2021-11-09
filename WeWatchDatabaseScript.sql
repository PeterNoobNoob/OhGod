USE [master]
GO
/****** Object:  Database [WeWatchDbDemo]    Script Date: 11/10/2021 12:29:41 AM ******/
CREATE DATABASE [WeWatchDbDemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WeWatchDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WeWatchDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WeWatchDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WeWatchDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WeWatchDbDemo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WeWatchDbDemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WeWatchDbDemo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET ARITHABORT OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WeWatchDbDemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WeWatchDbDemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WeWatchDbDemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WeWatchDbDemo] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [WeWatchDbDemo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET RECOVERY FULL 
GO
ALTER DATABASE [WeWatchDbDemo] SET  MULTI_USER 
GO
ALTER DATABASE [WeWatchDbDemo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WeWatchDbDemo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WeWatchDbDemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WeWatchDbDemo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WeWatchDbDemo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WeWatchDbDemo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'WeWatchDbDemo', N'ON'
GO
ALTER DATABASE [WeWatchDbDemo] SET QUERY_STORE = OFF
GO
USE [WeWatchDbDemo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/10/2021 12:29:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evidences]    Script Date: 11/10/2021 12:29:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evidences](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IncidentId] [int] NOT NULL,
	[OwnerId] [int] NOT NULL,
	[DateOfEvent] [datetime2](7) NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
	[Description] [nvarchar](max) NULL,
	[Created] [datetime2](7) NULL,
	[Updated] [datetime2](7) NULL,
 CONSTRAINT [PK_Evidences] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incidents]    Script Date: 11/10/2021 12:29:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incidents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OwnerId] [int] NOT NULL,
	[DateOfEvent] [datetime2](7) NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Type] [nvarchar](max) NULL,
	[IsClosed] [bit] NULL,
	[IsOwnerVictim] [bit] NULL,
	[Created] [datetime2](7) NULL,
	[Updated] [datetime2](7) NULL,
 CONSTRAINT [PK_Incidents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medias]    Script Date: 11/10/2021 12:29:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EvidenceId] [int] NULL,
	[IncidentId] [int] NULL,
	[Name] [nvarchar](max) NULL,
	[BlobFileAddress] [nvarchar](max) NULL,
	[Created] [datetime2](7) NULL,
 CONSTRAINT [PK_Medias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RejectedRequests]    Script Date: 11/10/2021 12:29:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RejectedRequests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OwnerId] [int] NOT NULL,
	[IncidentId] [int] NOT NULL,
	[Created] [datetime2](7) NULL,
 CONSTRAINT [PK_RejectedRequests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 11/10/2021 12:29:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IncidentId] [int] NOT NULL,
	[HttpLink] [nvarchar](max) NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/10/2021 12:29:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[DeviceId] [nvarchar](max) NULL,
	[Token] [uniqueidentifier] NOT NULL,
	[Forename] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Zip] [nvarchar](max) NULL,
	[Created] [datetime2](7) NULL,
	[ProfilePic] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211105160441_InitialWeWatchMigration', N'3.1.18')
GO
SET IDENTITY_INSERT [dbo].[Evidences] ON 

INSERT [dbo].[Evidences] ([Id], [IncidentId], [OwnerId], [DateOfEvent], [Latitude], [Longitude], [Description], [Created], [Updated]) VALUES (1, 1, 1, CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), 20.13847, -76.552734, N'Ukazka tavy', CAST(N'2020-01-02T00:00:00.0000000' AS DateTime2), CAST(N'2020-01-03T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Evidences] ([Id], [IncidentId], [OwnerId], [DateOfEvent], [Latitude], [Longitude], [Description], [Created], [Updated]) VALUES (5, 4, 2, CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), 20.13847, -76.552734, N'Ukazka pirata', CAST(N'2020-02-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-03-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Evidences] OFF
GO
SET IDENTITY_INSERT [dbo].[Incidents] ON 

INSERT [dbo].[Incidents] ([Id], [OwnerId], [DateOfEvent], [Latitude], [Longitude], [Title], [Description], [Type], [IsClosed], [IsOwnerVictim], [Created], [Updated]) VALUES (1, 1, CAST(N'2020-01-02T00:00:00.0000000' AS DateTime2), 28.476745, 8.085938, N'Zrazka s tavou', N'Narazil som autom do tavy', N'Assault', 0, 1, CAST(N'2000-01-05T00:00:00.0000000' AS DateTime2), CAST(N'2000-01-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Incidents] ([Id], [OwnerId], [DateOfEvent], [Latitude], [Longitude], [Title], [Description], [Type], [IsClosed], [IsOwnerVictim], [Created], [Updated]) VALUES (4, 2, CAST(N'2000-01-03T00:00:00.0000000' AS DateTime2), 20.13847, -76.552734, N'Napadnutie piratmi', N'Na plavbe okolo Kuby nas napadli pirati z karibiku', N'Assault', 0, 1, CAST(N'2020-01-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-02-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Incidents] ([Id], [OwnerId], [DateOfEvent], [Latitude], [Longitude], [Title], [Description], [Type], [IsClosed], [IsOwnerVictim], [Created], [Updated]) VALUES (5, 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Incidents] OFF
GO
SET IDENTITY_INSERT [dbo].[Medias] ON 

INSERT [dbo].[Medias] ([Id], [EvidenceId], [IncidentId], [Name], [BlobFileAddress], [Created]) VALUES (2, 1, 1, N'Foto tavy', N'https://as2.ftcdn.net/v2/jpg/02/90/89/05/1000_F_290890587_Z9FahWZh9RMmnAZvI4PU7oaLY099XyYw.jpg', CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Medias] ([Id], [EvidenceId], [IncidentId], [Name], [BlobFileAddress], [Created]) VALUES (4, 5, 4, N'Foto pirata', N'https://m.media-amazon.com/images/M/MV5BNDNiZTY2YmYtYzNiZS00YjE1LTlmY2YtZGZjYzU2NTRjMWNkXkEyXkFqcGdeQXVyNDIwOTkyNjM@._V1_.jpg', CAST(N'2020-01-02T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Medias] OFF
GO
SET IDENTITY_INSERT [dbo].[RejectedRequests] ON 

INSERT [dbo].[RejectedRequests] ([Id], [OwnerId], [IncidentId], [Created]) VALUES (1, 1, 1, CAST(N'2020-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[RejectedRequests] ([Id], [OwnerId], [IncidentId], [Created]) VALUES (2, 2, 4, CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[RejectedRequests] OFF
GO
SET IDENTITY_INSERT [dbo].[Reports] ON 

INSERT [dbo].[Reports] ([Id], [IncidentId], [HttpLink]) VALUES (1, 1, N'https://docplayer.sk/storage/100/146307346/1636136279/uYXUMnlOGSOld1dQzij1ZQ/146307346.pdf')
SET IDENTITY_INSERT [dbo].[Reports] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Email], [Password], [DeviceId], [Token], [Forename], [Surname], [Phone], [City], [Street], [Zip], [Created], [ProfilePic]) VALUES (1, N'Jaadmin@admin.cz', N'Admin', N'AAA666', N'b105fd6b-f52e-489d-982e-7e553d31d6d6', N'Admin', N'Admin', N'777625166', N'Praha', N'Trojska 12', N'16200', CAST(N'2000-01-01T00:00:00.0000000' AS DateTime2), N'https://i.ytimg.com/vi/KEkrWRHCDQU/maxresdefault.jpg')
INSERT [dbo].[Users] ([Id], [Email], [Password], [DeviceId], [Token], [Forename], [Surname], [Phone], [City], [Street], [Zip], [Created], [ProfilePic]) VALUES (2, N'JuliusNovy@yahoo.com', N'Julius123', N'bbb222', N'466e0ea1-a263-4b7a-a398-23b3480ce1fa', N'Julius', N'Novy', N'0910555123', N'Bratislava', N'Slovenska 13', N'07632', CAST(N'2010-01-02T00:00:00.0000000' AS DateTime2), N'https://pbs.twimg.com/profile_images/1445978785589993472/pYbOxQ7m_400x400.jpg')
INSERT [dbo].[Users] ([Id], [Email], [Password], [DeviceId], [Token], [Forename], [Surname], [Phone], [City], [Street], [Zip], [Created], [ProfilePic]) VALUES (3, NULL, N'aaa', NULL, N'89ad71d5-725e-4fdc-863a-553f60400195', N'Random', N'Surname', NULL, N'Berlin', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Evidences]  WITH CHECK ADD  CONSTRAINT [FK_Evidences_Incidents] FOREIGN KEY([IncidentId])
REFERENCES [dbo].[Incidents] ([Id])
GO
ALTER TABLE [dbo].[Evidences] CHECK CONSTRAINT [FK_Evidences_Incidents]
GO
ALTER TABLE [dbo].[Evidences]  WITH CHECK ADD  CONSTRAINT [FK_Evidences_Users] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Evidences] CHECK CONSTRAINT [FK_Evidences_Users]
GO
ALTER TABLE [dbo].[Incidents]  WITH CHECK ADD  CONSTRAINT [FK_Incidents_Users] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Incidents] CHECK CONSTRAINT [FK_Incidents_Users]
GO
ALTER TABLE [dbo].[Medias]  WITH CHECK ADD  CONSTRAINT [FK_Medias_Evidences] FOREIGN KEY([EvidenceId])
REFERENCES [dbo].[Evidences] ([Id])
GO
ALTER TABLE [dbo].[Medias] CHECK CONSTRAINT [FK_Medias_Evidences]
GO
ALTER TABLE [dbo].[Medias]  WITH CHECK ADD  CONSTRAINT [FK_Medias_Incidents] FOREIGN KEY([IncidentId])
REFERENCES [dbo].[Incidents] ([Id])
GO
ALTER TABLE [dbo].[Medias] CHECK CONSTRAINT [FK_Medias_Incidents]
GO
ALTER TABLE [dbo].[RejectedRequests]  WITH CHECK ADD  CONSTRAINT [FK_RejectedRequests_Incidents] FOREIGN KEY([IncidentId])
REFERENCES [dbo].[Incidents] ([Id])
GO
ALTER TABLE [dbo].[RejectedRequests] CHECK CONSTRAINT [FK_RejectedRequests_Incidents]
GO
ALTER TABLE [dbo].[RejectedRequests]  WITH CHECK ADD  CONSTRAINT [FK_RejectedRequests_Users] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[RejectedRequests] CHECK CONSTRAINT [FK_RejectedRequests_Users]
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD  CONSTRAINT [FK_Reports_Incidents] FOREIGN KEY([IncidentId])
REFERENCES [dbo].[Incidents] ([Id])
GO
ALTER TABLE [dbo].[Reports] CHECK CONSTRAINT [FK_Reports_Incidents]
GO
USE [master]
GO
ALTER DATABASE [WeWatchDbDemo] SET  READ_WRITE 
GO
