USE [master]
GO
/****** Object:  Database [ModuloSeguridad]    Script Date: 15/12/2020 02:55:26 ******/
CREATE DATABASE [ModuloSeguridad]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ModuloSeguridad', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ModuloSeguridad.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ModuloSeguridad_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ModuloSeguridad_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ModuloSeguridad] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ModuloSeguridad].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ModuloSeguridad] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET ARITHABORT OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ModuloSeguridad] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ModuloSeguridad] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ModuloSeguridad] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ModuloSeguridad] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ModuloSeguridad] SET  MULTI_USER 
GO
ALTER DATABASE [ModuloSeguridad] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ModuloSeguridad] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ModuloSeguridad] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ModuloSeguridad] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ModuloSeguridad] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ModuloSeguridad] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ModuloSeguridad] SET QUERY_STORE = OFF
GO
USE [ModuloSeguridad]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15/12/2020 02:55:26 ******/
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
/****** Object:  Table [dbo].[Acciones]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acciones](
	[AccionId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[FechaActualizacion] [datetime2](7) NULL,
	[CreadoPor] [nvarchar](max) NULL,
	[ActualizadoPor] [nvarchar](max) NULL,
 CONSTRAINT [PK_Acciones] PRIMARY KEY CLUSTERED 
(
	[AccionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccionModulos]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccionModulos](
	[AccionModuloId] [int] IDENTITY(1,1) NOT NULL,
	[AccionId] [int] NOT NULL,
	[ModuloId] [int] NOT NULL,
 CONSTRAINT [PK_AccionModulos] PRIMARY KEY CLUSTERED 
(
	[AccionModuloId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoGrupos]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoGrupos](
	[EstadoGrupoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[FechaActualizacion] [datetime2](7) NULL,
	[CreadoPor] [nvarchar](max) NULL,
	[ActualizadoPor] [nvarchar](max) NULL,
 CONSTRAINT [PK_EstadoGrupos] PRIMARY KEY CLUSTERED 
(
	[EstadoGrupoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoUsuarios]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoUsuarios](
	[EstadoUsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[FechaActualizacion] [datetime2](7) NULL,
	[CreadoPor] [nvarchar](max) NULL,
	[ActualizadoPor] [nvarchar](max) NULL,
 CONSTRAINT [PK_EstadoUsuarios] PRIMARY KEY CLUSTERED 
(
	[EstadoUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoAccionModulos]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoAccionModulos](
	[GrupoId] [int] NOT NULL,
	[AccionModuloId] [int] NOT NULL,
 CONSTRAINT [PK_GrupoAccionModulos] PRIMARY KEY CLUSTERED 
(
	[GrupoId] ASC,
	[AccionModuloId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupos]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupos](
	[GrupoId] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) NOT NULL,
	[EstadoGrupoId] [int] NOT NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[FechaActualizacion] [datetime2](7) NULL,
	[CreadoPor] [nvarchar](max) NULL,
	[ActualizadoPor] [nvarchar](max) NULL,
	[Descripcion] [nvarchar](100) NULL,
 CONSTRAINT [PK_Grupos] PRIMARY KEY CLUSTERED 
(
	[GrupoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulos](
	[ModuloId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[FechaActualizacion] [datetime2](7) NULL,
	[CreadoPor] [nvarchar](max) NULL,
	[ActualizadoPor] [nvarchar](max) NULL,
 CONSTRAINT [PK_Modulos] PRIMARY KEY CLUSTERED 
(
	[ModuloId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioGrupos]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioGrupos](
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[GrupoId] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioGrupos] PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC,
	[GrupoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 15/12/2020 02:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Clave] [nvarchar](max) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[EstadoUsuarioId] [int] NOT NULL,
	[FechaCreacion] [datetime2](7) NULL,
	[FechaActualizacion] [datetime2](7) NULL,
	[CreadoPor] [nvarchar](max) NULL,
	[ActualizadoPor] [nvarchar](max) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201124001535_InitialCreate', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201125231330_Modulo', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201126001747_BaseEntity', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201126114652_Constraint', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201126223821_Required', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201127232631_SacarModulo', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201130233953_GrupoAccionModulo', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201201231055_ClaveNoMaxLenght', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201201232249_GrupoNoDescripcion', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201203224253_Accion', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201203230307_AccionDescripcionMinLength', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201207130621_RemoveEliminado', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201209224703_FakeData', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201213021708_DescripcionGrupo', N'5.0.0')
GO
SET IDENTITY_INSERT [dbo].[Acciones] ON 

INSERT [dbo].[Acciones] ([AccionId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (2, N'Agregar', CAST(N'2020-11-30T21:47:15.6466667' AS DateTime2), NULL, N'SYSTEM', NULL)
INSERT [dbo].[Acciones] ([AccionId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (4, N'Modificar', CAST(N'2020-11-30T21:47:15.6500000' AS DateTime2), NULL, N'SYSTEM', NULL)
INSERT [dbo].[Acciones] ([AccionId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (5, N'Eliminar', CAST(N'2020-11-30T21:47:15.6500000' AS DateTime2), NULL, N'SYSTEM', NULL)
INSERT [dbo].[Acciones] ([AccionId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (1002, N'ResetearClave', CAST(N'2020-12-03T20:28:34.3333333' AS DateTime2), NULL, N'SYSTEM', NULL)
INSERT [dbo].[Acciones] ([AccionId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (1007, N'Leer', CAST(N'2020-12-06T17:43:48.0033333' AS DateTime2), NULL, N'SYSTEM', NULL)
SET IDENTITY_INSERT [dbo].[Acciones] OFF
GO
SET IDENTITY_INSERT [dbo].[AccionModulos] ON 

INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (1003, 1007, 2002)
INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (2002, 2, 2002)
INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (2003, 4, 2002)
INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (2004, 5, 2002)
INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (2005, 1002, 2002)
INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (2006, 2, 2003)
INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (2007, 4, 2003)
INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (2008, 5, 2003)
INSERT [dbo].[AccionModulos] ([AccionModuloId], [AccionId], [ModuloId]) VALUES (2009, 1007, 2003)
SET IDENTITY_INSERT [dbo].[AccionModulos] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoGrupos] ON 

INSERT [dbo].[EstadoGrupos] ([EstadoGrupoId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (1, N'Activo', CAST(N'2020-12-01T20:19:50.2200000' AS DateTime2), NULL, N'SYSTEM', NULL)
INSERT [dbo].[EstadoGrupos] ([EstadoGrupoId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (2, N'Inactivo', CAST(N'2020-12-14T16:06:25.7533333' AS DateTime2), NULL, N'SYSTEM', NULL)
SET IDENTITY_INSERT [dbo].[EstadoGrupos] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoUsuarios] ON 

INSERT [dbo].[EstadoUsuarios] ([EstadoUsuarioId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (1, N'Activo', CAST(N'2020-12-01T20:03:46.5400000' AS DateTime2), NULL, N'SYSTEM', NULL)
INSERT [dbo].[EstadoUsuarios] ([EstadoUsuarioId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (2, N'Inactivo', CAST(N'2020-12-12T15:14:36.1500000' AS DateTime2), NULL, N'SYSTEM', NULL)
SET IDENTITY_INSERT [dbo].[EstadoUsuarios] OFF
GO
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 1003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 1003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (6, 1003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (7, 1003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 2002)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 2002)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (6, 2002)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (7, 2002)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (8, 2002)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 2003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 2003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (6, 2003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (7, 2003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (9, 2003)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 2004)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 2004)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (6, 2004)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (7, 2004)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 2005)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 2005)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (6, 2005)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (7, 2005)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 2006)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 2006)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 2007)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 2007)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (7, 2007)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (8, 2007)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (9, 2007)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 2008)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 2008)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (7, 2008)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (1, 2009)
INSERT [dbo].[GrupoAccionModulos] ([GrupoId], [AccionModuloId]) VALUES (5, 2009)
GO
SET IDENTITY_INSERT [dbo].[Grupos] ON 

INSERT [dbo].[Grupos] ([GrupoId], [Codigo], [EstadoGrupoId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor], [Descripcion]) VALUES (1, N'Administradores', 1, CAST(N'2020-12-01T20:23:15.2733333' AS DateTime2), NULL, N'SYSTEM', NULL, N'Pueden realizar todo')
INSERT [dbo].[Grupos] ([GrupoId], [Codigo], [EstadoGrupoId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor], [Descripcion]) VALUES (2, N'Usuarios comunes', 1, CAST(N'2020-12-09T00:49:57.5900000' AS DateTime2), NULL, N'SYSTEM', NULL, N'Otros usuarios')
INSERT [dbo].[Grupos] ([GrupoId], [Codigo], [EstadoGrupoId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor], [Descripcion]) VALUES (5, N'nuevo grupo2', 1, CAST(N'2020-12-14T21:00:26.4455786' AS DateTime2), CAST(N'2020-12-14T22:37:31.6196581' AS DateTime2), N'g.rodriguez', N'g.rodriguez', N'nuevo grupo')
INSERT [dbo].[Grupos] ([GrupoId], [Codigo], [EstadoGrupoId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor], [Descripcion]) VALUES (6, N'nuevo grupo3', 1, CAST(N'2020-12-14T21:04:21.1430047' AS DateTime2), NULL, N'g.rodriguez', NULL, N'nuevo grupo')
INSERT [dbo].[Grupos] ([GrupoId], [Codigo], [EstadoGrupoId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor], [Descripcion]) VALUES (7, N'nuevo grupo', 1, CAST(N'2020-12-14T22:38:09.9469704' AS DateTime2), CAST(N'2020-12-14T22:49:18.8657852' AS DateTime2), N'g.rodriguez', N'g.rodriguez', N'nuevo grupo')
INSERT [dbo].[Grupos] ([GrupoId], [Codigo], [EstadoGrupoId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor], [Descripcion]) VALUES (8, N'nuevo grupo4', 1, CAST(N'2020-12-14T22:46:17.9980873' AS DateTime2), NULL, N'g.rodriguez', NULL, N'nuevo grupo')
INSERT [dbo].[Grupos] ([GrupoId], [Codigo], [EstadoGrupoId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor], [Descripcion]) VALUES (9, N'nuevo grupo5', 1, CAST(N'2020-12-14T22:49:34.7513508' AS DateTime2), NULL, N'g.rodriguez', NULL, N'nuevo grupo')
SET IDENTITY_INSERT [dbo].[Grupos] OFF
GO
SET IDENTITY_INSERT [dbo].[Modulos] ON 

INSERT [dbo].[Modulos] ([ModuloId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (2002, N'Usuarios', CAST(N'2020-11-30T21:46:02.2066667' AS DateTime2), NULL, N'SYSTEM', NULL)
INSERT [dbo].[Modulos] ([ModuloId], [Nombre], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (2003, N'Grupos', CAST(N'2020-11-30T21:46:02.2833333' AS DateTime2), NULL, N'SYSTEM', NULL)
SET IDENTITY_INSERT [dbo].[Modulos] OFF
GO
INSERT [dbo].[UsuarioGrupos] ([NombreUsuario], [GrupoId]) VALUES (N'g.rodriguez', 1)
INSERT [dbo].[UsuarioGrupos] ([NombreUsuario], [GrupoId]) VALUES (N'g.rodriguezC', 1)
INSERT [dbo].[UsuarioGrupos] ([NombreUsuario], [GrupoId]) VALUES (N'g.rodriguez', 2)
INSERT [dbo].[UsuarioGrupos] ([NombreUsuario], [GrupoId]) VALUES (N'g.rodriguezC', 2)
INSERT [dbo].[UsuarioGrupos] ([NombreUsuario], [GrupoId]) VALUES (N'g.rodriguez', 5)
INSERT [dbo].[UsuarioGrupos] ([NombreUsuario], [GrupoId]) VALUES (N'g.rodriguez', 6)
GO
INSERT [dbo].[Usuarios] ([NombreUsuario], [Nombre], [Apellido], [Clave], [Mail], [EstadoUsuarioId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (N'Aaron.Acuna162001', N'Aaron', N'Acuna', N'C76DB12C821B79A91D361A4C705CE6B4', N'gabriel_pro@hotmail.es', 1, CAST(N'2020-12-14T05:51:33.3901823' AS DateTime2), CAST(N'2020-12-14T05:51:55.5872999' AS DateTime2), N'Aaron.Acuna162001', N'Aaron.Acuna162001')
INSERT [dbo].[Usuarios] ([NombreUsuario], [Nombre], [Apellido], [Clave], [Mail], [EstadoUsuarioId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (N'Aaron.Acuna162002', N'Aaron', N'Acuna', N'C8B783B9D0A80C01B3A1271630F5EA5B', N'gabriel_pro@hotmail.es', 1, CAST(N'2020-12-14T05:53:38.0806249' AS DateTime2), CAST(N'2020-12-14T05:53:45.6111200' AS DateTime2), N'Aaron.Acuna162002', N'Aaron.Acuna162002')
INSERT [dbo].[Usuarios] ([NombreUsuario], [Nombre], [Apellido], [Clave], [Mail], [EstadoUsuarioId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (N'Aaron.Alejandro5160', N'Aarón', N'Alejandro', N'FB2697869F56484404C8CEEE2985B01D', N'Aaron_Alejandro@corpfolder.com', 1, NULL, CAST(N'2020-12-14T12:46:08.4766670' AS DateTime2), NULL, N'Aaron.Alejandro5160')
INSERT [dbo].[Usuarios] ([NombreUsuario], [Nombre], [Apellido], [Clave], [Mail], [EstadoUsuarioId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (N'g.rodriguez', N'Gabriel', N'Rodríguez Castellini', N'D033743D7A7769D6078DEE26DC5158AA', N'gabriel.rod.cas.10@gmail.com', 1, CAST(N'2020-12-01T20:11:37.4100000' AS DateTime2), CAST(N'2020-12-14T10:31:01.8158139' AS DateTime2), N'SYSTEM', N'g.rodriguez')
INSERT [dbo].[Usuarios] ([NombreUsuario], [Nombre], [Apellido], [Clave], [Mail], [EstadoUsuarioId], [FechaCreacion], [FechaActualizacion], [CreadoPor], [ActualizadoPor]) VALUES (N'g.rodriguezC', N'Gabriel', N'Rodríguez Castellini', N'FA3060EDB66E6FF4507886F9912E1AB9', N'gabriel_pro@hotmail.es', 1, NULL, CAST(N'2020-12-14T06:20:34.0349246' AS DateTime2), NULL, N'g.rodriguezC')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Acciones_Nombre]    Script Date: 15/12/2020 02:55:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Acciones_Nombre] ON [dbo].[Acciones]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AccionModulos_AccionId]    Script Date: 15/12/2020 02:55:27 ******/
CREATE NONCLUSTERED INDEX [IX_AccionModulos_AccionId] ON [dbo].[AccionModulos]
(
	[AccionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AccionModulos_ModuloId]    Script Date: 15/12/2020 02:55:27 ******/
CREATE NONCLUSTERED INDEX [IX_AccionModulos_ModuloId] ON [dbo].[AccionModulos]
(
	[ModuloId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_EstadoGrupos_Nombre]    Script Date: 15/12/2020 02:55:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_EstadoGrupos_Nombre] ON [dbo].[EstadoGrupos]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_EstadoUsuarios_Nombre]    Script Date: 15/12/2020 02:55:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_EstadoUsuarios_Nombre] ON [dbo].[EstadoUsuarios]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_GrupoAccionModulos_AccionModuloId]    Script Date: 15/12/2020 02:55:27 ******/
CREATE NONCLUSTERED INDEX [IX_GrupoAccionModulos_AccionModuloId] ON [dbo].[GrupoAccionModulos]
(
	[AccionModuloId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Grupos_Codigo]    Script Date: 15/12/2020 02:55:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Grupos_Codigo] ON [dbo].[Grupos]
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Grupos_EstadoGrupoId]    Script Date: 15/12/2020 02:55:27 ******/
CREATE NONCLUSTERED INDEX [IX_Grupos_EstadoGrupoId] ON [dbo].[Grupos]
(
	[EstadoGrupoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Modulos_Nombre]    Script Date: 15/12/2020 02:55:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Modulos_Nombre] ON [dbo].[Modulos]
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UsuarioGrupos_GrupoId]    Script Date: 15/12/2020 02:55:27 ******/
CREATE NONCLUSTERED INDEX [IX_UsuarioGrupos_GrupoId] ON [dbo].[UsuarioGrupos]
(
	[GrupoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Usuarios_EstadoUsuarioId]    Script Date: 15/12/2020 02:55:27 ******/
CREATE NONCLUSTERED INDEX [IX_Usuarios_EstadoUsuarioId] ON [dbo].[Usuarios]
(
	[EstadoUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Acciones] ADD  DEFAULT (N'') FOR [Nombre]
GO
ALTER TABLE [dbo].[AccionModulos]  WITH CHECK ADD  CONSTRAINT [FK_AccionModulos_Acciones_AccionId] FOREIGN KEY([AccionId])
REFERENCES [dbo].[Acciones] ([AccionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AccionModulos] CHECK CONSTRAINT [FK_AccionModulos_Acciones_AccionId]
GO
ALTER TABLE [dbo].[AccionModulos]  WITH CHECK ADD  CONSTRAINT [FK_AccionModulos_Modulos_ModuloId] FOREIGN KEY([ModuloId])
REFERENCES [dbo].[Modulos] ([ModuloId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AccionModulos] CHECK CONSTRAINT [FK_AccionModulos_Modulos_ModuloId]
GO
ALTER TABLE [dbo].[GrupoAccionModulos]  WITH CHECK ADD  CONSTRAINT [FK_GrupoAccionModulos_AccionModulos_AccionModuloId] FOREIGN KEY([AccionModuloId])
REFERENCES [dbo].[AccionModulos] ([AccionModuloId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GrupoAccionModulos] CHECK CONSTRAINT [FK_GrupoAccionModulos_AccionModulos_AccionModuloId]
GO
ALTER TABLE [dbo].[GrupoAccionModulos]  WITH CHECK ADD  CONSTRAINT [FK_GrupoAccionModulos_Grupos_GrupoId] FOREIGN KEY([GrupoId])
REFERENCES [dbo].[Grupos] ([GrupoId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GrupoAccionModulos] CHECK CONSTRAINT [FK_GrupoAccionModulos_Grupos_GrupoId]
GO
ALTER TABLE [dbo].[Grupos]  WITH CHECK ADD  CONSTRAINT [FK_Grupos_EstadoGrupos_EstadoGrupoId] FOREIGN KEY([EstadoGrupoId])
REFERENCES [dbo].[EstadoGrupos] ([EstadoGrupoId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Grupos] CHECK CONSTRAINT [FK_Grupos_EstadoGrupos_EstadoGrupoId]
GO
ALTER TABLE [dbo].[UsuarioGrupos]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioGrupos_Grupos_GrupoId] FOREIGN KEY([GrupoId])
REFERENCES [dbo].[Grupos] ([GrupoId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsuarioGrupos] CHECK CONSTRAINT [FK_UsuarioGrupos_Grupos_GrupoId]
GO
ALTER TABLE [dbo].[UsuarioGrupos]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioGrupos_Usuarios_NombreUsuario] FOREIGN KEY([NombreUsuario])
REFERENCES [dbo].[Usuarios] ([NombreUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsuarioGrupos] CHECK CONSTRAINT [FK_UsuarioGrupos_Usuarios_NombreUsuario]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_EstadoUsuarios_EstadoUsuarioId] FOREIGN KEY([EstadoUsuarioId])
REFERENCES [dbo].[EstadoUsuarios] ([EstadoUsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_EstadoUsuarios_EstadoUsuarioId]
GO
USE [master]
GO
ALTER DATABASE [ModuloSeguridad] SET  READ_WRITE 
GO
