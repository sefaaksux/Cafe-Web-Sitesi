USE [master]
GO
/****** Object:  Database [sherlock]    Script Date: 8.04.2024 14:37:12 ******/
CREATE DATABASE [sherlock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sherlock', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\sherlock.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sherlock_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\sherlock_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [sherlock] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sherlock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sherlock] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sherlock] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sherlock] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sherlock] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sherlock] SET ARITHABORT OFF 
GO
ALTER DATABASE [sherlock] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [sherlock] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sherlock] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sherlock] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sherlock] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sherlock] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sherlock] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sherlock] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sherlock] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sherlock] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sherlock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sherlock] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sherlock] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sherlock] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sherlock] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sherlock] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [sherlock] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sherlock] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sherlock] SET  MULTI_USER 
GO
ALTER DATABASE [sherlock] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sherlock] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sherlock] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sherlock] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sherlock] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sherlock] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [sherlock] SET QUERY_STORE = OFF
GO
USE [sherlock]
GO
/****** Object:  UserDefinedDataType [dbo].[barkod_str]    Script Date: 8.04.2024 14:37:13 ******/
CREATE TYPE [dbo].[barkod_str] FROM [nvarchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[belgeno_str]    Script Date: 8.04.2024 14:37:13 ******/
CREATE TYPE [dbo].[belgeno_str] FROM [nvarchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[cihazseri_str]    Script Date: 8.04.2024 14:37:13 ******/
CREATE TYPE [dbo].[cihazseri_str] FROM [nvarchar](50) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[evrakseri_str]    Script Date: 8.04.2024 14:37:13 ******/
CREATE TYPE [dbo].[evrakseri_str] FROM [nvarchar](20) NULL
GO
/****** Object:  UserDefinedDataType [dbo].[nvarchar_maxhesapisimno]    Script Date: 8.04.2024 14:37:13 ******/
CREATE TYPE [dbo].[nvarchar_maxhesapisimno] FROM [nvarchar](90) NULL
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8.04.2024 14:37:13 ******/
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
/****** Object:  Table [dbo].[kategoriler]    Script Date: 8.04.2024 14:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategoriler](
	[kategoriId] [int] IDENTITY(1,1) NOT NULL,
	[kategoriName] [nvarchar](max) NULL,
 CONSTRAINT [PK_kategoriler] PRIMARY KEY CLUSTERED 
(
	[kategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tablolar]    Script Date: 8.04.2024 14:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablolar](
	[tabloId] [int] IDENTITY(1,1) NOT NULL,
	[tabloName] [nvarchar](max) NULL,
 CONSTRAINT [PK_tablolar] PRIMARY KEY CLUSTERED 
(
	[tabloId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urunler]    Script Date: 8.04.2024 14:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[tabloId] [int] NOT NULL,
	[kategoriId] [int] NOT NULL,
 CONSTRAINT [PK_urunler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 8.04.2024 14:37:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240327142957_FirstCommit', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240327143553_updateTables', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240329132342_createdNewTableSchema', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240407233445_InıtialCreateIdentity', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240408112048_addedUsersTable', N'7.0.0')
GO
SET IDENTITY_INSERT [dbo].[kategoriler] ON 

INSERT [dbo].[kategoriler] ([kategoriId], [kategoriName]) VALUES (1, N'yemekler')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriName]) VALUES (2, N'alkoller')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriName]) VALUES (3, N'icecekler')
INSERT [dbo].[kategoriler] ([kategoriId], [kategoriName]) VALUES (4, N'extralar')
SET IDENTITY_INSERT [dbo].[kategoriler] OFF
GO
SET IDENTITY_INSERT [dbo].[tablolar] ON 

INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (1, N'aperatifler')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (2, N'tavukYemekleri')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (3, N'etYemekleri')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (4, N'pizzalar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (5, N'makarnalar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (6, N'sandviçler')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (7, N'corbalar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (8, N'salatalar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (9, N'ficiBiralar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (10, N'siseBiralar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (11, N'saraplar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (12, N'likörler')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (13, N'vodkalar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (14, N'vermutlar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (15, N'viskiler')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (16, N'cinler')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (17, N'kokteylShotlar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (18, N'sicakIcecekler')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (19, N'sogukIcecekler')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (20, N'cerezler')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (21, N'tatlilar')
INSERT [dbo].[tablolar] ([tabloId], [tabloName]) VALUES (22, N'krepler')
SET IDENTITY_INSERT [dbo].[tablolar] OFF
GO
SET IDENTITY_INSERT [dbo].[urunler] ON 

INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (2, N'Parmak Cips', N'350gr parmak dilim patates kızartması', CAST(115.00 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (3, N'Tavuk Çökertme', N'Jülyen tavuk, kibrit patates ve süzme yoğurt', CAST(235.00 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (4, N'Efes Fıçı 33 CI', N'Deneme eklendi', CAST(80.00 AS Decimal(10, 2)), 9, 2)
INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (5, N'Americano', NULL, CAST(65.00 AS Decimal(10, 2)), 18, 3)
INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (7, N'sasa', NULL, CAST(0.00 AS Decimal(10, 2)), 4, 1)
INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (9, N'sasa', NULL, CAST(5545.00 AS Decimal(10, 2)), 4, 1)
INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (21, N'Antep çerez', N'aciklamacacia ', CAST(77.00 AS Decimal(10, 2)), 20, 4)
INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (22, N'Baklava', N'maraş baklavaa', CAST(155.00 AS Decimal(10, 2)), 21, 4)
INSERT [dbo].[urunler] ([Id], [Name], [Description], [Amount], [tabloId], [kategoriId]) VALUES (24, N'Deneme Sefa Aksu', N'sdafasdfasdfasfd', CAST(999.00 AS Decimal(10, 2)), 1, 1)
SET IDENTITY_INSERT [dbo].[urunler] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([UserId], [userName], [password]) VALUES (1, N'admin', N'sherlockhouse01!')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
/****** Object:  Index [IX_urunler_kategoriId]    Script Date: 8.04.2024 14:37:13 ******/
CREATE NONCLUSTERED INDEX [IX_urunler_kategoriId] ON [dbo].[urunler]
(
	[kategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_urunler_tabloId]    Script Date: 8.04.2024 14:37:13 ******/
CREATE NONCLUSTERED INDEX [IX_urunler_tabloId] ON [dbo].[urunler]
(
	[tabloId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[urunler]  WITH CHECK ADD  CONSTRAINT [FK_urunler_kategoriler_kategoriId] FOREIGN KEY([kategoriId])
REFERENCES [dbo].[kategoriler] ([kategoriId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[urunler] CHECK CONSTRAINT [FK_urunler_kategoriler_kategoriId]
GO
ALTER TABLE [dbo].[urunler]  WITH CHECK ADD  CONSTRAINT [FK_urunler_tablolar_tabloId] FOREIGN KEY([tabloId])
REFERENCES [dbo].[tablolar] ([tabloId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[urunler] CHECK CONSTRAINT [FK_urunler_tablolar_tabloId]
GO
USE [master]
GO
ALTER DATABASE [sherlock] SET  READ_WRITE 
GO
