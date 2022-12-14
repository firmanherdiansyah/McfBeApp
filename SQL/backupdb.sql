USE [master]
GO
/****** Object:  Database [MCF]    Script Date: 10/24/2022 16:00:30 ******/
CREATE DATABASE [MCF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MCF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MCF.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MCF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MCF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MCF] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MCF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MCF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MCF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MCF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MCF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MCF] SET ARITHABORT OFF 
GO
ALTER DATABASE [MCF] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MCF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MCF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MCF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MCF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MCF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MCF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MCF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MCF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MCF] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MCF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MCF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MCF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MCF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MCF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MCF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MCF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MCF] SET RECOVERY FULL 
GO
ALTER DATABASE [MCF] SET  MULTI_USER 
GO
ALTER DATABASE [MCF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MCF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MCF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MCF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MCF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MCF] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MCF', N'ON'
GO
ALTER DATABASE [MCF] SET QUERY_STORE = OFF
GO
USE [MCF]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/24/2022 16:00:31 ******/
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
/****** Object:  Table [dbo].[ms_storage_location]    Script Date: 10/24/2022 16:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ms_storage_location](
	[location_id] [varchar](10) NOT NULL,
	[location_name] [varchar](100) NULL,
 CONSTRAINT [PK_ms_storage_location] PRIMARY KEY CLUSTERED 
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tr_bpkb]    Script Date: 10/24/2022 16:00:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tr_bpkb](
	[agreement_number] [varchar](100) NOT NULL,
	[bpkb_number] [varchar](100) NULL,
	[branch_id] [varchar](10) NULL,
	[bpkp_date] [datetime2](7) NOT NULL,
	[faktur_no] [varchar](100) NULL,
	[faktur_date] [datetime2](7) NOT NULL,
	[location_id] [varchar](10) NULL,
	[police_no] [varchar](20) NULL,
	[bpkp_date_in] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tr_bpkb] PRIMARY KEY CLUSTERED 
(
	[agreement_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tr_bpkb_location_id]    Script Date: 10/24/2022 16:00:31 ******/
CREATE NONCLUSTERED INDEX [IX_tr_bpkb_location_id] ON [dbo].[tr_bpkb]
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tr_bpkb]  WITH CHECK ADD  CONSTRAINT [FK_tr_bpkb_ms_storage_location_location_id] FOREIGN KEY([location_id])
REFERENCES [dbo].[ms_storage_location] ([location_id])
GO
ALTER TABLE [dbo].[tr_bpkb] CHECK CONSTRAINT [FK_tr_bpkb_ms_storage_location_location_id]
GO
USE [master]
GO
ALTER DATABASE [MCF] SET  READ_WRITE 
GO
