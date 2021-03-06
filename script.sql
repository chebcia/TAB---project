USE [master]
GO
/****** Object:  Database [ClinicDB]    Script Date: 17.05.2021 11:36:04 ******/
CREATE DATABASE [ClinicDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClinicDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ClinicDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClinicDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ClinicDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ClinicDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClinicDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClinicDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClinicDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClinicDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClinicDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ClinicDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClinicDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClinicDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClinicDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClinicDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClinicDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClinicDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClinicDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClinicDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ClinicDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClinicDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClinicDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClinicDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClinicDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClinicDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClinicDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClinicDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ClinicDB] SET  MULTI_USER 
GO
ALTER DATABASE [ClinicDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClinicDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClinicDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClinicDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ClinicDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ClinicDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ClinicDB', N'ON'
GO
ALTER DATABASE [ClinicDB] SET QUERY_STORE = OFF
GO
USE [ClinicDB]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id_user] [int] NOT NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exam_type]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam_type](
	[code] [varchar](5) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[type] [char](1) NOT NULL,
 CONSTRAINT [PK_exam_type] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_exam]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_exam](
	[id_lab_exam] [int] IDENTITY(1,1) NOT NULL,
	[doctors_notes] [nvarchar](255) NULL,
	[id_visit] [int] NOT NULL,
	[id_worker] [int] NULL,
	[id_manager] [int] NULL,
	[code] [varchar](5) NOT NULL,
	[dt_request] [datetime] NOT NULL,
	[result] [nvarchar](255) NULL,
	[dt_finalized_cancelled] [datetime] NULL,
	[managers_notes] [nvarchar](255) NULL,
	[dt_approved_cancelled] [datetime] NULL,
	[status] [char](2) NOT NULL,
 CONSTRAINT [PK_lab_exam] PRIMARY KEY CLUSTERED 
(
	[id_lab_exam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_manager]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_manager](
	[id_user] [int] NOT NULL,
 CONSTRAINT [PK_lab_manager] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_worker]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_worker](
	[id_user] [int] NOT NULL,
 CONSTRAINT [PK_lab_worker] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id_patient] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
	[PESEL] [char](11) NOT NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[id_patient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Physical_exam]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Physical_exam](
	[id_physical_exam] [int] IDENTITY(1,1) NOT NULL,
	[result] [nvarchar](255) NULL,
	[id_visit] [int] NOT NULL,
	[code] [varchar](5) NOT NULL,
 CONSTRAINT [PK_physical_exam] PRIMARY KEY CLUSTERED 
(
	[id_physical_exam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registrar]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registrar](
	[id_user] [int] NOT NULL,
 CONSTRAINT [PK_registar] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](50) NOT NULL,
	[password] [varchar](256) NOT NULL,
	[role] [varchar](5) NULL,
	[active] [char](1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit]    Script Date: 20.05.2021 17:22:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[id_visit] [int] IDENTITY(1,1) NOT NULL,
	[id_doctor] [int] NOT NULL,
	[id_patient] [int] NOT NULL,
	[id_registrar] [int] NOT NULL,
	[status] [char](1) NOT NULL,
	[diagnosis] [nvarchar](255) NULL,
	[dt_registered] [datetime] NOT NULL,
	[dt_finalized_cancelled] [datetime] NULL,
	[description] [nvarchar](255) NULL,
 CONSTRAINT [PK_visit] PRIMARY KEY CLUSTERED 
(
	[id_visit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lab_exam] ADD  CONSTRAINT [DF_Lab_exam_status]  DEFAULT ('re') FOR [status]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__active__440B1D61]  DEFAULT ('A') FOR [active]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_18] FOREIGN KEY([id_user])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_18]
GO
ALTER TABLE [dbo].[Lab_exam]  WITH CHECK ADD  CONSTRAINT [FK_29] FOREIGN KEY([id_visit])
REFERENCES [dbo].[Visit] ([id_visit])
GO
ALTER TABLE [dbo].[Lab_exam] CHECK CONSTRAINT [FK_29]
GO
ALTER TABLE [dbo].[Lab_exam]  WITH CHECK ADD  CONSTRAINT [FK_32] FOREIGN KEY([id_worker])
REFERENCES [dbo].[Lab_worker] ([id_user])
GO
ALTER TABLE [dbo].[Lab_exam] CHECK CONSTRAINT [FK_32]
GO
ALTER TABLE [dbo].[Lab_exam]  WITH CHECK ADD  CONSTRAINT [FK_35] FOREIGN KEY([id_manager])
REFERENCES [dbo].[Lab_manager] ([id_user])
GO
ALTER TABLE [dbo].[Lab_exam] CHECK CONSTRAINT [FK_35]
GO
ALTER TABLE [dbo].[Lab_exam]  WITH CHECK ADD  CONSTRAINT [FK_43] FOREIGN KEY([code])
REFERENCES [dbo].[Exam_type] ([code])
GO
ALTER TABLE [dbo].[Lab_exam] CHECK CONSTRAINT [FK_43]
GO
ALTER TABLE [dbo].[Lab_manager]  WITH CHECK ADD  CONSTRAINT [FK_68] FOREIGN KEY([id_user])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Lab_manager] CHECK CONSTRAINT [FK_68]
GO
ALTER TABLE [dbo].[Lab_worker]  WITH CHECK ADD  CONSTRAINT [FK_63] FOREIGN KEY([id_user])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Lab_worker] CHECK CONSTRAINT [FK_63]
GO
ALTER TABLE [dbo].[Physical_exam]  WITH CHECK ADD  CONSTRAINT [FK_26] FOREIGN KEY([id_visit])
REFERENCES [dbo].[Visit] ([id_visit])
GO
ALTER TABLE [dbo].[Physical_exam] CHECK CONSTRAINT [FK_26]
GO
ALTER TABLE [dbo].[Physical_exam]  WITH CHECK ADD  CONSTRAINT [FK_46] FOREIGN KEY([code])
REFERENCES [dbo].[Exam_type] ([code])
GO
ALTER TABLE [dbo].[Physical_exam] CHECK CONSTRAINT [FK_46]
GO
ALTER TABLE [dbo].[Registrar]  WITH CHECK ADD  CONSTRAINT [FK_10] FOREIGN KEY([id_user])
REFERENCES [dbo].[User] ([id_user])
GO
ALTER TABLE [dbo].[Registrar] CHECK CONSTRAINT [FK_10]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_48] FOREIGN KEY([id_registrar])
REFERENCES [dbo].[Registrar] ([id_user])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_48]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_61] FOREIGN KEY([id_doctor])
REFERENCES [dbo].[Doctor] ([id_user])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_61]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_70] FOREIGN KEY([id_patient])
REFERENCES [dbo].[Patient] ([id_patient])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_70]
GO
ALTER TABLE [dbo].[Exam_type]  WITH CHECK ADD  CONSTRAINT [CK_Exam_type] CHECK  (([type]='p' OR [type]='l'))
GO
ALTER TABLE [dbo].[Exam_type] CHECK CONSTRAINT [CK_Exam_type]
GO
ALTER TABLE [dbo].[Lab_exam]  WITH CHECK ADD  CONSTRAINT [CK_Lab_exam] CHECK  (([status]='cm' OR [status]='cw' OR [status]='fm' OR [status]='fw' OR [status]='re'))
GO
ALTER TABLE [dbo].[Lab_exam] CHECK CONSTRAINT [CK_Lab_exam]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [CK_User] CHECK  (([role]='lab_m' OR [role]='lab_w' OR [role]='doc' OR [role]='reg'))
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [CK_User]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [CK_Visit] CHECK  (([status]='c' OR [status]='f' OR [status]='r'))
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [CK_Visit]
GO
