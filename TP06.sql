USE [master]
GO
/****** Object:  Database [Tp06]    Script Date: 17/7/2025 13:45:25 ******/
CREATE DATABASE [Tp06]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tp06', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Tp06.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tp06_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Tp06_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Tp06] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tp06].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tp06] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tp06] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tp06] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tp06] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tp06] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tp06] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tp06] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tp06] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tp06] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tp06] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tp06] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tp06] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tp06] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tp06] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tp06] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tp06] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tp06] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tp06] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tp06] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tp06] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tp06] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tp06] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tp06] SET RECOVERY FULL 
GO
ALTER DATABASE [Tp06] SET  MULTI_USER 
GO
ALTER DATABASE [Tp06] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tp06] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tp06] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tp06] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tp06] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Tp06', N'ON'
GO
ALTER DATABASE [Tp06] SET QUERY_STORE = OFF
GO
USE [Tp06]
GO
/****** Object:  User [alumno]    Script Date: 17/7/2025 13:45:25 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[DatoFamiliar]    Script Date: 17/7/2025 13:45:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatoFamiliar](
	[ID] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Parentesco] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DatoFamiliar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatoInteres]    Script Date: 17/7/2025 13:45:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatoInteres](
	[ID] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[TipoInteres] [int] NOT NULL,
	[Interes] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DatoInteres] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatoPersonal]    Script Date: 17/7/2025 13:45:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatoPersonal](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Foto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DatoPersonal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DatoFamiliar] ([ID], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripcion]) VALUES (1, 1, N'Karina', N'Savitzky', N'madre', N'rubia')
INSERT [dbo].[DatoFamiliar] ([ID], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripcion]) VALUES (2, 2, N'Carlos', N'Carus', N'padre', N'Alto')
GO
INSERT [dbo].[DatoInteres] ([ID], [IdUsuario], [TipoInteres], [Interes]) VALUES (1, 1, 1, N'Futbol')
INSERT [dbo].[DatoInteres] ([ID], [IdUsuario], [TipoInteres], [Interes]) VALUES (2, 2, 1, N'Futbol')
INSERT [dbo].[DatoInteres] ([ID], [IdUsuario], [TipoInteres], [Interes]) VALUES (3, 3, 1, N'Compu')
GO
INSERT [dbo].[DatoPersonal] ([ID], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (1, N'Lucas', N'Chechik', N'lucaschechik@gmail.com', N'Checho', CAST(N'2009-02-25' AS Date), N'img/checho.png')
INSERT [dbo].[DatoPersonal] ([ID], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (2, N'Juan', N'Carus', N'juansecarus@gmail.co,', N'Boca2007', CAST(N'2008-08-28' AS Date), N'foto')
INSERT [dbo].[DatoPersonal] ([ID], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (3, N'Felipe', N'Andraca', N'felipeandraca@gmail.com', N'cajaf', CAST(N'2008-07-16' AS Date), N'img/cajaf.png')
GO
ALTER TABLE [dbo].[DatoFamiliar]  WITH CHECK ADD  CONSTRAINT [FK_DatoFamiliar_DatoPersonal] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[DatoPersonal] ([ID])
GO
ALTER TABLE [dbo].[DatoFamiliar] CHECK CONSTRAINT [FK_DatoFamiliar_DatoPersonal]
GO
ALTER TABLE [dbo].[DatoInteres]  WITH CHECK ADD  CONSTRAINT [FK_DatoInteres_DatoPersonal] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[DatoPersonal] ([ID])
GO
ALTER TABLE [dbo].[DatoInteres] CHECK CONSTRAINT [FK_DatoInteres_DatoPersonal]
GO
USE [master]
GO
ALTER DATABASE [Tp06] SET  READ_WRITE 
GO
