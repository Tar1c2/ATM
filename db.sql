USE [master]
GO
/****** Object:  Database [Banco_Aerosaurio]    Script Date: 01/12/2024 12:54:28 p. m. ******/
CREATE DATABASE [Banco_Aerosaurio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Banco_Aerosaurio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Banco_Aerosaurio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Banco_Aerosaurio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Banco_Aerosaurio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Banco_Aerosaurio] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Banco_Aerosaurio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Banco_Aerosaurio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Banco_Aerosaurio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Banco_Aerosaurio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Banco_Aerosaurio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Banco_Aerosaurio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET RECOVERY FULL 
GO
ALTER DATABASE [Banco_Aerosaurio] SET  MULTI_USER 
GO
ALTER DATABASE [Banco_Aerosaurio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Banco_Aerosaurio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Banco_Aerosaurio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Banco_Aerosaurio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Banco_Aerosaurio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Banco_Aerosaurio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Banco_Aerosaurio', N'ON'
GO
ALTER DATABASE [Banco_Aerosaurio] SET QUERY_STORE = ON
GO
ALTER DATABASE [Banco_Aerosaurio] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Banco_Aerosaurio]
GO
/****** Object:  User [Zegmar06]    Script Date: 01/12/2024 12:54:28 p. m. ******/
CREATE USER [Zegmar06] FOR LOGIN [remoto] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Zegmar06]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Zegmar06]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Zegmar06]
GO
/****** Object:  Table [dbo].[Acceso_Administrativo]    Script Date: 01/12/2024 12:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acceso_Administrativo](
	[Administrador_ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Nivel_Autoridad] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Info_Cliente]    Script Date: 01/12/2024 12:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Info_Cliente](
	[Cliente_ID] [int] NOT NULL,
	[RFC] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Fecha_Nacimiento] [date] NULL,
 CONSTRAINT [PK_Info_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cliente_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Info_Usuario]    Script Date: 01/12/2024 12:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Info_Usuario](
	[Cliente_ID] [int] NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Saldo] [real] NULL,
	[Numero_cuenta] [int] NOT NULL,
 CONSTRAINT [PK_Info_Usuario] PRIMARY KEY CLUSTERED 
(
	[Numero_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transacciones]    Script Date: 01/12/2024 12:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transacciones](
	[Folio] [int] IDENTITY(1,1) NOT NULL,
	[Nomcuentasalida] [int] NULL,
	[Nomcuentaentrada] [int] NOT NULL,
	[Tipo_transaccion] [varchar](50) NOT NULL,
	[Fecha] [date] NULL,
	[Monto] [real] NULL,
 CONSTRAINT [PK_Transacciones] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Acceso_Administrativo] ON 

INSERT [dbo].[Acceso_Administrativo] ([Administrador_ID], [Nombre], [Apellidos], [Usuario], [Password], [Nivel_Autoridad]) VALUES (1, N'Emiliano', N'Zambrano Gracia', N'Zegmar06', N'Zegmar0', N'Administrador')
INSERT [dbo].[Acceso_Administrativo] ([Administrador_ID], [Nombre], [Apellidos], [Usuario], [Password], [Nivel_Autoridad]) VALUES (2, N'Jorge Alberto', N'Mendez Quiroga', N'Tar1c', N'Ruoska', N'Administrador')
INSERT [dbo].[Acceso_Administrativo] ([Administrador_ID], [Nombre], [Apellidos], [Usuario], [Password], [Nivel_Autoridad]) VALUES (3, N'Emiliio', N'Zambrano Luna', N'Zeluma', N'Zeluma', N'Gerente')
INSERT [dbo].[Acceso_Administrativo] ([Administrador_ID], [Nombre], [Apellidos], [Usuario], [Password], [Nivel_Autoridad]) VALUES (5, N'Patricio', N'Estrella', N'Pat', N'Estrellado', N'Cajero')
SET IDENTITY_INSERT [dbo].[Acceso_Administrativo] OFF
GO
ALTER TABLE [dbo].[Info_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Info_Usuario_Info_Cliente] FOREIGN KEY([Cliente_ID])
REFERENCES [dbo].[Info_Cliente] ([Cliente_ID])
GO
ALTER TABLE [dbo].[Info_Usuario] CHECK CONSTRAINT [FK_Info_Usuario_Info_Cliente]
GO
ALTER TABLE [dbo].[Transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Transacciones_Info_Usuario] FOREIGN KEY([Nomcuentaentrada])
REFERENCES [dbo].[Info_Usuario] ([Numero_cuenta])
GO
ALTER TABLE [dbo].[Transacciones] CHECK CONSTRAINT [FK_Transacciones_Info_Usuario]
GO
USE [master]
GO
ALTER DATABASE [Banco_Aerosaurio] SET  READ_WRITE 
GO
