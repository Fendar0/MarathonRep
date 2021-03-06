USE [master]
GO
/****** Object:  Database [Marathon Skills]    Script Date: 02.02.2022 13:16:54 ******/
CREATE DATABASE [Marathon Skills]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Marathon Skills', FILENAME = N'Z:\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Marathon Skills.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Marathon Skills_log', FILENAME = N'Z:\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Marathon Skills_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Marathon Skills] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Marathon Skills].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Marathon Skills] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Marathon Skills] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Marathon Skills] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Marathon Skills] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Marathon Skills] SET ARITHABORT OFF 
GO
ALTER DATABASE [Marathon Skills] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Marathon Skills] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Marathon Skills] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Marathon Skills] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Marathon Skills] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Marathon Skills] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Marathon Skills] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Marathon Skills] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Marathon Skills] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Marathon Skills] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Marathon Skills] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Marathon Skills] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Marathon Skills] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Marathon Skills] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Marathon Skills] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Marathon Skills] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Marathon Skills] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Marathon Skills] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Marathon Skills] SET  MULTI_USER 
GO
ALTER DATABASE [Marathon Skills] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Marathon Skills] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Marathon Skills] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Marathon Skills] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Marathon Skills] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Marathon Skills] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Marathon Skills] SET QUERY_STORE = OFF
GO
USE [Marathon Skills]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[IDCountry] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[IDCountry] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginHistory]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginHistory](
	[IDHis] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[TimeLogin] [time](7) NOT NULL,
	[ResultLogin] [bit] NOT NULL,
 CONSTRAINT [PK_LoginHistory] PRIMARY KEY CLUSTERED 
(
	[IDHis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersMarathon]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersMarathon](
	[IDOrder] [int] IDENTITY(1,1) NOT NULL,
	[IDRunner] [int] NOT NULL,
	[IDTypeDistance] [int] NOT NULL,
	[IDSet] [int] NOT NULL,
	[IDStatus] [int] NOT NULL,
	[TimeRun] [decimal](18, 2) NOT NULL,
	[Place] [int] NOT NULL,
 CONSTRAINT [PK_OrdersMarathon] PRIMARY KEY CLUSTERED 
(
	[IDOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IDRole] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[IDRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Runners]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Runners](
	[IDRunner] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](10) NOT NULL,
	[Birthday] [date] NOT NULL,
	[IDCountry] [int] NOT NULL,
	[PhoneNumber] [char](15) NOT NULL,
	[Wallet] [decimal](18, 0) NOT NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK_Runners] PRIMARY KEY CLUSTERED 
(
	[IDRunner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RunnerSponsor]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RunnerSponsor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDRunner] [int] NOT NULL,
	[IDSponsor] [int] NOT NULL,
	[SumSponsor] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_RunnerSponsor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sets]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sets](
	[IDSet] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Sets] PRIMARY KEY CLUSTERED 
(
	[IDSet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sponsors]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sponsors](
	[IDSponsor] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[NumberCard] [char](19) NOT NULL,
	[MonthCard] [int] NOT NULL,
	[YearCard] [int] NOT NULL,
	[TotalSum] [decimal](18, 0) NOT NULL,
	[Logo] [image] NULL,
 CONSTRAINT [PK_Sponsors] PRIMARY KEY CLUSTERED 
(
	[IDSponsor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[IDStatus] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[IDStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeDistance]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeDistance](
	[IDType] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_TypeDistance] PRIMARY KEY CLUSTERED 
(
	[IDType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 02.02.2022 13:16:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IDUser] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[IDRole] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrdersMarathon]  WITH CHECK ADD  CONSTRAINT [FK_OrdersMarathon_Runners] FOREIGN KEY([IDRunner])
REFERENCES [dbo].[Runners] ([IDRunner])
GO
ALTER TABLE [dbo].[OrdersMarathon] CHECK CONSTRAINT [FK_OrdersMarathon_Runners]
GO
ALTER TABLE [dbo].[OrdersMarathon]  WITH CHECK ADD  CONSTRAINT [FK_OrdersMarathon_Sets] FOREIGN KEY([IDSet])
REFERENCES [dbo].[Sets] ([IDSet])
GO
ALTER TABLE [dbo].[OrdersMarathon] CHECK CONSTRAINT [FK_OrdersMarathon_Sets]
GO
ALTER TABLE [dbo].[OrdersMarathon]  WITH CHECK ADD  CONSTRAINT [FK_OrdersMarathon_Status] FOREIGN KEY([IDStatus])
REFERENCES [dbo].[Status] ([IDStatus])
GO
ALTER TABLE [dbo].[OrdersMarathon] CHECK CONSTRAINT [FK_OrdersMarathon_Status]
GO
ALTER TABLE [dbo].[OrdersMarathon]  WITH CHECK ADD  CONSTRAINT [FK_OrdersMarathon_TypeDistance] FOREIGN KEY([IDTypeDistance])
REFERENCES [dbo].[TypeDistance] ([IDType])
GO
ALTER TABLE [dbo].[OrdersMarathon] CHECK CONSTRAINT [FK_OrdersMarathon_TypeDistance]
GO
ALTER TABLE [dbo].[Runners]  WITH CHECK ADD  CONSTRAINT [FK_Runners_Countries] FOREIGN KEY([IDCountry])
REFERENCES [dbo].[Countries] ([IDCountry])
GO
ALTER TABLE [dbo].[Runners] CHECK CONSTRAINT [FK_Runners_Countries]
GO
ALTER TABLE [dbo].[Runners]  WITH CHECK ADD  CONSTRAINT [FK_Runners_Users] FOREIGN KEY([IDRunner])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[Runners] CHECK CONSTRAINT [FK_Runners_Users]
GO
ALTER TABLE [dbo].[RunnerSponsor]  WITH CHECK ADD  CONSTRAINT [FK_RunnerSponsor_Runners] FOREIGN KEY([IDRunner])
REFERENCES [dbo].[Runners] ([IDRunner])
GO
ALTER TABLE [dbo].[RunnerSponsor] CHECK CONSTRAINT [FK_RunnerSponsor_Runners]
GO
ALTER TABLE [dbo].[RunnerSponsor]  WITH CHECK ADD  CONSTRAINT [FK_RunnerSponsor_Sponsors] FOREIGN KEY([IDSponsor])
REFERENCES [dbo].[Sponsors] ([IDSponsor])
GO
ALTER TABLE [dbo].[RunnerSponsor] CHECK CONSTRAINT [FK_RunnerSponsor_Sponsors]
GO
ALTER TABLE [dbo].[Sponsors]  WITH CHECK ADD  CONSTRAINT [FK_Sponsors_Users] FOREIGN KEY([IDSponsor])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[Sponsors] CHECK CONSTRAINT [FK_Sponsors_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([IDRole])
REFERENCES [dbo].[Roles] ([IDRole])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [Marathon Skills] SET  READ_WRITE 
GO
