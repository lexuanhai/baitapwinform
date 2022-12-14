USE [master]
GO
/****** Object:  Database [MyPham]    Script Date: 12/11/2022 12:05:07 AM ******/
CREATE DATABASE [MyPham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyPham', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\MyPham.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyPham_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\MyPham_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MyPham] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyPham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyPham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyPham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyPham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyPham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyPham] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyPham] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyPham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyPham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyPham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyPham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyPham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyPham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyPham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyPham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyPham] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MyPham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyPham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyPham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyPham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyPham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyPham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyPham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyPham] SET RECOVERY FULL 
GO
ALTER DATABASE [MyPham] SET  MULTI_USER 
GO
ALTER DATABASE [MyPham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyPham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyPham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyPham] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyPham] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyPham', N'ON'
GO
ALTER DATABASE [MyPham] SET QUERY_STORE = OFF
GO
USE [MyPham]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MyPham]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[username] [nvarchar](225) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[address] [nvarchar](255) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[phone2] [nvarchar](50) NULL,
	[address2] [nvarchar](255) NULL,
	[type] [nvarchar](max) NULL,
	[name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[ProductID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderExport]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderExport](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[UserName] [varchar](250) NULL,
	[AgentName] [nvarchar](250) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[Total] [decimal](18, 0) NULL,
	[TypePayment] [nvarchar](250) NULL,
	[Status] [nvarchar](250) NULL,
 CONSTRAINT [PK_OrderExport] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderExportDetail]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderExportDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[OrderExportId] [int] NULL,
	[Quantity] [int] NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[Status] [nvarchar](250) NULL,
	[Note] [nvarchar](250) NULL,
 CONSTRAINT [PK_OrderExportDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderImport]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderImport](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodeOrder] [varchar](250) NULL,
	[MaNV] [varchar](250) NULL,
	[CreateDated] [datetime] NULL,
	[Total] [int] NULL,
	[Note] [nvarchar](250) NULL,
	[ImportLocation] [nvarchar](500) NULL,
 CONSTRAINT [PK_OrderImport] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderImportDetail]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderImportDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderImportId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[CreatedDate] [datetime] NULL,
	[Note] [nvarchar](500) NULL,
 CONSTRAINT [PK_OrderImportDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[Username] [nvarchar](16) NULL,
	[Status] [int] NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nchar](10) NULL,
	[Total] [float] NULL,
	[TypePaymet] [nvarchar](max) NULL,
	[StatusPayment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[img] [nvarchar](100) NULL,
	[description] [nvarchar](500) NULL,
	[price] [float] NULL,
	[count] [int] NULL,
	[pricefordistributors] [float] NULL,
	[priceCustom] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 12/11/2022 12:05:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MaNV] [varchar](250) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Accounts] ([username], [password], [address], [phone], [phone2], [address2], [type], [name]) VALUES (N'hailx', N'123', N'hà nội', N'0345801986', N'0345801986', N'hà nội', N'0', N'Lê xuân hải')
INSERT [dbo].[Accounts] ([username], [password], [address], [phone], [phone2], [address2], [type], [name]) VALUES (N'hungnv', N'123', N'thanh xuân ', N'0345801763', N'0345801763', N'thanh xuân ', N'0', N'Nguyên văn hưng')
INSERT [dbo].[OrderDetails] ([ProductID], [OrderID], [Quantity], [Price]) VALUES (1, 3, 3, CAST(6000 AS Decimal(18, 0)))
INSERT [dbo].[OrderDetails] ([ProductID], [OrderID], [Quantity], [Price]) VALUES (2, 3, 3, CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[OrderDetails] ([ProductID], [OrderID], [Quantity], [Price]) VALUES (4, 9, 1, CAST(3000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[OrderExport] ON 

INSERT [dbo].[OrderExport] ([Id], [Code], [CreatedDate], [UserName], [AgentName], [Phone], [Email], [Address], [Total], [TypePayment], [Status]) VALUES (5, N'phieuxuat001', CAST(N'2022-12-11T00:00:00.000' AS DateTime), N'h001', N'bánh kẹo hải hà', N'034580165', N'test@gmail.com', N'quận 2 thành phố hồ chí minh', CAST(0 AS Decimal(18, 0)), N'Tiền mặt', N'Thành công')
INSERT [dbo].[OrderExport] ([Id], [Code], [CreatedDate], [UserName], [AgentName], [Phone], [Email], [Address], [Total], [TypePayment], [Status]) VALUES (6, N'phieuxuat002', CAST(N'2022-12-10T00:00:00.000' AS DateTime), N'h002', N'bánh kẹo ngọt', N'0345801986', N'test@gmail.com', N'hồ chí minh', NULL, N'Tiền mặt', N'Đang vẩn chuyển')
SET IDENTITY_INSERT [dbo].[OrderExport] OFF
SET IDENTITY_INSERT [dbo].[OrderExportDetail] ON 

INSERT [dbo].[OrderExportDetail] ([Id], [ProductId], [OrderExportId], [Quantity], [TotalPrice], [Status], [Note]) VALUES (4, 3, 5, 5, CAST(20000 AS Decimal(18, 0)), N'Đổi trả', N'')
INSERT [dbo].[OrderExportDetail] ([Id], [ProductId], [OrderExportId], [Quantity], [TotalPrice], [Status], [Note]) VALUES (5, 1, 5, 3, CAST(6000 AS Decimal(18, 0)), N'Đã giao', N'')
SET IDENTITY_INSERT [dbo].[OrderExportDetail] OFF
SET IDENTITY_INSERT [dbo].[OrderImport] ON 

INSERT [dbo].[OrderImport] ([Id], [CodeOrder], [MaNV], [CreateDated], [Total], [Note], [ImportLocation]) VALUES (5, N'phieu001', N'h001', CAST(N'2022-12-05T21:27:41.000' AS DateTime), 0, N'', N'số 30 thanh xuân hà nội')
INSERT [dbo].[OrderImport] ([Id], [CodeOrder], [MaNV], [CreateDated], [Total], [Note], [ImportLocation]) VALUES (6, N'phieu002', N'h001', CAST(N'2022-12-05T21:27:41.000' AS DateTime), 0, N'', N'thanh xuân hà nội')
INSERT [dbo].[OrderImport] ([Id], [CodeOrder], [MaNV], [CreateDated], [Total], [Note], [ImportLocation]) VALUES (7, N'phieu003', N'h001', CAST(N'2022-12-10T21:27:41.000' AS DateTime), 0, N'', N'')
INSERT [dbo].[OrderImport] ([Id], [CodeOrder], [MaNV], [CreateDated], [Total], [Note], [ImportLocation]) VALUES (8, N'phieu004', N'h002', CAST(N'2022-12-10T22:42:34.000' AS DateTime), 0, N'', N'quận 2 thành phố hồ chí minh')
SET IDENTITY_INSERT [dbo].[OrderImport] OFF
SET IDENTITY_INSERT [dbo].[OrderImportDetail] ON 

INSERT [dbo].[OrderImportDetail] ([Id], [OrderImportId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [Note]) VALUES (8, 6, 1, 20, CAST(1000 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), NULL, N'')
INSERT [dbo].[OrderImportDetail] ([Id], [OrderImportId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [Note]) VALUES (9, 5, 2, 300, CAST(2000 AS Decimal(18, 0)), CAST(600000 AS Decimal(18, 0)), NULL, N'')
INSERT [dbo].[OrderImportDetail] ([Id], [OrderImportId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [Note]) VALUES (10, 5, 3, 63, CAST(3000 AS Decimal(18, 0)), CAST(189000 AS Decimal(18, 0)), NULL, N'')
INSERT [dbo].[OrderImportDetail] ([Id], [OrderImportId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [Note]) VALUES (11, 8, 4, 600, CAST(4000 AS Decimal(18, 0)), CAST(2400000 AS Decimal(18, 0)), NULL, N'')
INSERT [dbo].[OrderImportDetail] ([Id], [OrderImportId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [Note]) VALUES (12, 7, 5, 700, CAST(4000 AS Decimal(18, 0)), CAST(2800000 AS Decimal(18, 0)), NULL, N'')
INSERT [dbo].[OrderImportDetail] ([Id], [OrderImportId], [ProductId], [Quantity], [Price], [TotalPrice], [CreatedDate], [Note]) VALUES (13, 8, 6, 500, CAST(2000 AS Decimal(18, 0)), CAST(1000000 AS Decimal(18, 0)), NULL, N'')
SET IDENTITY_INSERT [dbo].[OrderImportDetail] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [Name], [CreateDate], [Username], [Status], [Address], [Phone], [Total], [TypePaymet], [StatusPayment]) VALUES (3, N'Order-20221210095900', CAST(N'2022-12-10T00:00:00.000' AS DateTime), N'hungnv', 1, N'thanh xuân ', N'034580165 ', 1000, N'the', N'Đã thanh toán')
INSERT [dbo].[Orders] ([ID], [Name], [CreateDate], [Username], [Status], [Address], [Phone], [Total], [TypePaymet], [StatusPayment]) VALUES (6, N'order002', CAST(N'2022-11-30T00:00:00.000' AS DateTime), N'Nguyễn văn mạnh', 1, N'hà nội', N'0345801986', 20, N'tructiep', N'Đã thanh toán')
INSERT [dbo].[Orders] ([ID], [Name], [CreateDate], [Username], [Status], [Address], [Phone], [Total], [TypePaymet], [StatusPayment]) VALUES (7, N'order003', CAST(N'2022-12-07T23:27:50.000' AS DateTime), N'lê văn khánh', 0, N'hà nội ', N'035801985 ', 20, N'the', N'Kiểm tra thanh toán')
INSERT [dbo].[Orders] ([ID], [Name], [CreateDate], [Username], [Status], [Address], [Phone], [Total], [TypePaymet], [StatusPayment]) VALUES (9, N'Order-20221210235716', CAST(N'2022-12-10T00:00:00.000' AS DateTime), N'hailx', 1, N'hà nội', N'0345801986', 3000, N'tructiep', N'Đã thanh toán')
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([id], [name], [img], [description], [price], [count], [pricefordistributors], [priceCustom]) VALUES (1, N'sản phẩm 1', NULL, NULL, 2000, 3000, NULL, NULL)
INSERT [dbo].[Products] ([id], [name], [img], [description], [price], [count], [pricefordistributors], [priceCustom]) VALUES (2, N'sản phẩm 2', NULL, NULL, 1000, 4000, NULL, NULL)
INSERT [dbo].[Products] ([id], [name], [img], [description], [price], [count], [pricefordistributors], [priceCustom]) VALUES (3, N'sản phẩm 3', NULL, NULL, 4000, 5000, NULL, NULL)
INSERT [dbo].[Products] ([id], [name], [img], [description], [price], [count], [pricefordistributors], [priceCustom]) VALUES (4, N'sản phẩm 4', NULL, NULL, 3000, 1000, NULL, NULL)
INSERT [dbo].[Products] ([id], [name], [img], [description], [price], [count], [pricefordistributors], [priceCustom]) VALUES (5, N'sản phẩm 5', NULL, NULL, 2000, 6000, NULL, NULL)
INSERT [dbo].[Products] ([id], [name], [img], [description], [price], [count], [pricefordistributors], [priceCustom]) VALUES (6, N'sản phẩm 6', NULL, NULL, 1000, 7000, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([Id], [Name], [MaNV]) VALUES (1, N'Lê Xuân Hải', N'h001')
INSERT [dbo].[Staff] ([Id], [Name], [MaNV]) VALUES (2, N'Nguyễn Văn Hưng', N'h002')
SET IDENTITY_INSERT [dbo].[Staff] OFF
USE [master]
GO
ALTER DATABASE [MyPham] SET  READ_WRITE 
GO
