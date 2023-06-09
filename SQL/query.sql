USE [master]
GO
/****** Object:  Database [HumanResourceManagement]    Script Date: 05/05/2023 19:02:35 ******/
CREATE DATABASE [HumanResourceManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HumanResourceManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HumanResourceManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HumanResourceManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HumanResourceManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HumanResourceManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HumanResourceManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HumanResourceManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [HumanResourceManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HumanResourceManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HumanResourceManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HumanResourceManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HumanResourceManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HumanResourceManagement] SET  MULTI_USER 
GO
ALTER DATABASE [HumanResourceManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HumanResourceManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HumanResourceManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HumanResourceManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HumanResourceManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HumanResourceManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HumanResourceManagement] SET QUERY_STORE = OFF
GO
USE [HumanResourceManagement]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] 
( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000)
AS
BEGIN
	IF @strInput IS NULL RETURN @strInput
	IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136)
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208)
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int
	SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput))
		BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
			BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
				BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)
	ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
	BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[Department]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[idDepartment] [varchar](15) NOT NULL,
	[nameDepartment] [nvarchar](30) NULL,
	[quantityEmployee] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDepartment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[idEmployee] [varchar](15) NOT NULL,
	[nameEmployee] [nvarchar](50) NULL,
	[date] [date] NULL,
	[sex] [bit] NULL,
	[folk] [nvarchar](50) NULL,
	[phoneNumber] [varchar](15) NULL,
	[address] [ntext] NULL,
	[idDepartment] [varchar](15) NULL,
	[idPosition] [varchar](15) NULL,
	[levelSalary] [int] NULL,
	[leave] [bit] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[idEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LevelSalary]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LevelSalary](
	[levelSalary] [int] NOT NULL,
	[basicSalary] [float] NOT NULL,
	[coefficientsSalary] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[levelSalary] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogIn]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogIn](
	[userName] [varchar](15) NOT NULL,
	[password] [varchar](30) NOT NULL,
	[role] [int] NULL,
	[descAccount] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayRoll]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayRoll](
	[idPayRoll] [varchar](15) NOT NULL,
	[month] [int] NULL,
	[year] [int] NULL,
	[date] [date] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_PayRoll] PRIMARY KEY CLUSTERED 
(
	[idPayRoll] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayRollDetail]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayRollDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPayRoll] [varchar](15) NULL,
	[idTimeSheet] [varchar](15) NULL,
	[salary] [float] NULL,
	[idEmployee] [varchar](15) NULL,
	[nameEmployee] [nvarchar](50) NULL,
	[total] [int] NULL,
 CONSTRAINT [PK_PayRollDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[idPosition] [varchar](15) NOT NULL,
	[namePosition] [nvarchar](30) NULL,
	[descriptionPosition] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPosition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reward_Discipline]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reward_Discipline](
	[id] [varchar](15) NOT NULL,
	[idEmployee] [varchar](15) NULL,
	[nameEmployee] [nvarchar](50) NULL,
	[reason] [nvarchar](200) NULL,
	[description] [nvarchar](200) NULL,
	[dateStart] [date] NULL,
	[dateEnd] [date] NULL,
	[type] [bit] NULL,
 CONSTRAINT [PK_Reward_Discipline] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staticstical]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staticstical](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[month] [int] NULL,
	[year] [int] NULL,
	[type] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeSheet]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSheet](
	[idTimeSheet] [varchar](15) NOT NULL,
	[month] [int] NULL,
	[year] [int] NULL,
	[date] [date] NULL,
	[dayOfMonth] [int] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_TimeSheet] PRIMARY KEY CLUSTERED 
(
	[idTimeSheet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeSheetDetail]    Script Date: 05/05/2023 19:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSheetDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTimeSheet] [varchar](15) NULL,
	[idEmployee] [varchar](15) NULL,
	[nameEmployee] [nvarchar](50) NULL,
	[workDay] [int] NULL,
	[excused] [int] NULL,
	[unExcused] [int] NULL,
	[total] [int] NULL,
 CONSTRAINT [PK_TimeSheetDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Department] ([idDepartment], [nameDepartment], [quantityEmployee]) VALUES (N'DE1', N'Hành chính', 8)
INSERT [dbo].[Department] ([idDepartment], [nameDepartment], [quantityEmployee]) VALUES (N'DE2', N'Nhân sự', 4)
GO
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000001', N'Trần Quang Long', CAST(N'2002-12-03' AS Date), 1, N'Kinh', N'0312123123', N'Nam Sách, Hải Dương', N'DE1', N'PO1', 6, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000002', N'Ngô Thị Mỹ Hạnh', CAST(N'1994-11-23' AS Date), 0, N'Kinh', N'0312123123', N'Quận 1, TP.Hồ Chí Minh', N'DE1', N'PO2', 5, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000003', N'Trần Thị Bích Hường', CAST(N'1999-04-18' AS Date), 0, N'Kinh', N'0312123123', N'Hải Phòng', N'DE1', N'PO1', 6, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000004', N'Lê Minh Hồng', CAST(N'1990-05-23' AS Date), 1, N'Kinh', N'0312123123', N'Biên Hoà, Đồng Nai', N'DE1', N'PO2', 5, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000005', N'Dương Văn Dưỡng', CAST(N'2002-05-03' AS Date), 1, N'Kinh', N'0312123123', N'Phủ Lý, Hà Nam', N'DE2', N'PO2', 3, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000006', N'Nguyễn Ngọc Thảo', CAST(N'2002-12-03' AS Date), 0, N'Kinh', N'0312123123', N'Nam Sách, Hải Dương', N'DE2', N'PO1', 6, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000007', N'Bùi Anh Tuấn', CAST(N'2002-12-03' AS Date), 1, N'Kinh', N'0312123123', N'Phan Rang, Ninh Thuận', N'DE2', N'PO1', 6, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000008', N'Dương Gia Bảo', CAST(N'2002-12-03' AS Date), 1, N'Kinh', N'0312123123', N'Hoàn Kiếm, Hà Nội', N'DE1', N'PO2', 4, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000009', N'Nguyễn Thị Gấm', CAST(N'2002-12-03' AS Date), 1, N'Kinh', N'0312123123', N'Kiến Thuỵ, Hải Phòng', N'DE2', N'PO2', 2, 0)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000010', N'Lại là test', CAST(N'1999-12-24' AS Date), 0, N'Mường', N'09287624', N'Trần Hưng Đạo, Nam Định', N'DE1', N'PO2', 4, 1)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000011', N'Test Staticstical', CAST(N'2000-04-15' AS Date), 0, N'Mường', N'123', N'Test thôi', N'DE1', N'PO4', 2, 1)
INSERT [dbo].[Employee] ([idEmployee], [nameEmployee], [date], [sex], [folk], [phoneNumber], [address], [idDepartment], [idPosition], [levelSalary], [leave]) VALUES (N'NV000012', N'Test', CAST(N'2001-04-15' AS Date), 1, N'Thái', N'12314', N'Test', N'DE1', N'PO4', 1, 1)
GO
INSERT [dbo].[LevelSalary] ([levelSalary], [basicSalary], [coefficientsSalary]) VALUES (1, 1490000, 4.4)
INSERT [dbo].[LevelSalary] ([levelSalary], [basicSalary], [coefficientsSalary]) VALUES (2, 1490000, 4.74)
INSERT [dbo].[LevelSalary] ([levelSalary], [basicSalary], [coefficientsSalary]) VALUES (3, 1490000, 5.08)
INSERT [dbo].[LevelSalary] ([levelSalary], [basicSalary], [coefficientsSalary]) VALUES (4, 1490000, 5.42)
INSERT [dbo].[LevelSalary] ([levelSalary], [basicSalary], [coefficientsSalary]) VALUES (5, 1490000, 5.76)
INSERT [dbo].[LevelSalary] ([levelSalary], [basicSalary], [coefficientsSalary]) VALUES (6, 1490000, 6.1)
INSERT [dbo].[LevelSalary] ([levelSalary], [basicSalary], [coefficientsSalary]) VALUES (7, 1490000, 6.44)
INSERT [dbo].[LevelSalary] ([levelSalary], [basicSalary], [coefficientsSalary]) VALUES (8, 1490000, 6.78)
GO
INSERT [dbo].[LogIn] ([userName], [password], [role], [descAccount]) VALUES (N'admin', N'admin', 0, N'')
INSERT [dbo].[LogIn] ([userName], [password], [role], [descAccount]) VALUES (N'nLog0312', N'12345', 1, N'Tài khoản tổ trưởng phòng quản lý nhân sự')
GO
INSERT [dbo].[PayRoll] ([idPayRoll], [month], [year], [date], [status]) VALUES (N'PR012023', 1, 2023, CAST(N'2023-04-12' AS Date), 1)
INSERT [dbo].[PayRoll] ([idPayRoll], [month], [year], [date], [status]) VALUES (N'PR022023', 2, 2023, CAST(N'2023-04-12' AS Date), 1)
INSERT [dbo].[PayRoll] ([idPayRoll], [month], [year], [date], [status]) VALUES (N'PR042023', 4, 2023, CAST(N'2023-04-28' AS Date), 0)
INSERT [dbo].[PayRoll] ([idPayRoll], [month], [year], [date], [status]) VALUES (N'PR052023', 5, 2023, CAST(N'2023-05-05' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[PayRollDetail] ON 

INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (120, N'PR012023', N'TS012023', 9089000, N'NV000001', N'Trần Quang Long', 26)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (121, N'PR012023', N'TS012023', 4951385, N'NV000002', N'Ngô Thị Mỹ Hạnh', 15)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (122, N'PR012023', N'TS012023', 9089000, N'NV000003', N'Trần Thị Bích Hường', 26)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (123, N'PR012023', N'TS012023', 8582400, N'NV000004', N'Lê Minh Hồng', 26)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (124, N'PR012023', N'TS012023', 7569200, N'NV000005', N'Dương Văn Dưỡng', 26)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (125, N'PR012023', N'TS012023', 9089000, N'NV000006', N'Nguyễn Ngọc Thảo', 26)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (126, N'PR012023', N'TS012023', 9089000, N'NV000007', N'Bùi Anh Tuấn', 26)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (127, N'PR012023', N'TS012023', 8075800, N'NV000008', N'Dương Gia Bảo', 26)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (128, N'PR012023', N'TS012023', 7062600, N'NV000009', N'Nguyễn Thị Gấm', 26)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (129, N'PR022023', N'TS022023', 9089000, N'NV000001', N'Trần Quang Long', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (130, N'PR022023', N'TS022023', 8582400, N'NV000002', N'Ngô Thị Mỹ Hạnh', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (131, N'PR022023', N'TS022023', 9089000, N'NV000003', N'Trần Thị Bích Hường', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (132, N'PR022023', N'TS022023', 8582400, N'NV000004', N'Lê Minh Hồng', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (133, N'PR022023', N'TS022023', 7569200, N'NV000005', N'Dương Văn Dưỡng', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (134, N'PR022023', N'TS022023', 9089000, N'NV000006', N'Nguyễn Ngọc Thảo', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (135, N'PR022023', N'TS022023', 9089000, N'NV000007', N'Bùi Anh Tuấn', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (136, N'PR022023', N'TS022023', 8075800, N'NV000008', N'Dương Gia Bảo', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (137, N'PR022023', N'TS022023', 7062600, N'NV000009', N'Nguyễn Thị Gấm', 24)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (138, N'PR042023', N'TS042023', 9089000, N'NV000001', N'Trần Quang Long', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (139, N'PR042023', N'TS042023', 8582400, N'NV000002', N'Ngô Thị Mỹ Hạnh', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (140, N'PR042023', N'TS042023', 9089000, N'NV000003', N'Trần Thị Bích Hường', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (141, N'PR042023', N'TS042023', 8582400, N'NV000004', N'Lê Minh Hồng', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (142, N'PR042023', N'TS042023', 7569200, N'NV000005', N'Dương Văn Dưỡng', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (143, N'PR042023', N'TS042023', 9089000, N'NV000006', N'Nguyễn Ngọc Thảo', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (144, N'PR042023', N'TS042023', 9089000, N'NV000007', N'Bùi Anh Tuấn', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (145, N'PR042023', N'TS042023', 8075800, N'NV000008', N'Dương Gia Bảo', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (146, N'PR042023', N'TS042023', 7062600, N'NV000009', N'Nguyễn Thị Gấm', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (147, N'PR042023', N'TS042023', 6556000, N'NV000012', N'Test', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (148, N'PR052023', N'TS052023', 8415741, N'NV000001', N'Trần Quang Long', 25)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (149, N'PR052023', N'TS052023', 8582401, N'NV000002', N'Ngô Thị Mỹ Hạnh', 27)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (150, N'PR052023', N'TS052023', 9089000, N'NV000003', N'Trần Thị Bích Hường', 27)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (151, N'PR052023', N'TS052023', 8582401, N'NV000004', N'Lê Minh Hồng', 27)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (152, N'PR052023', N'TS052023', 7569200, N'NV000005', N'Dương Văn Dưỡng', 27)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (153, N'PR052023', N'TS052023', 9089000, N'NV000006', N'Nguyễn Ngọc Thảo', 27)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (154, N'PR052023', N'TS052023', 9089000, N'NV000007', N'Bùi Anh Tuấn', 27)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (155, N'PR052023', N'TS052023', 8075801, N'NV000008', N'Dương Gia Bảo', 27)
INSERT [dbo].[PayRollDetail] ([id], [idPayRoll], [idTimeSheet], [salary], [idEmployee], [nameEmployee], [total]) VALUES (156, N'PR052023', N'TS052023', 7062600, N'NV000009', N'Nguyễn Thị Gấm', 27)
SET IDENTITY_INSERT [dbo].[PayRollDetail] OFF
GO
INSERT [dbo].[Position] ([idPosition], [namePosition], [descriptionPosition]) VALUES (N'PO1', N'Quản lý', N'Quản lý của một công xưởng')
INSERT [dbo].[Position] ([idPosition], [namePosition], [descriptionPosition]) VALUES (N'PO2', N'Tổ trưởng', N'Tổ trưởng của một tổ')
INSERT [dbo].[Position] ([idPosition], [namePosition], [descriptionPosition]) VALUES (N'PO3', N'Trưởng phòng', N'Trưởng phòng nhân sự')
INSERT [dbo].[Position] ([idPosition], [namePosition], [descriptionPosition]) VALUES (N'PO4', N'Nhân viên', N'Nhân viên')
GO
INSERT [dbo].[Reward_Discipline] ([id], [idEmployee], [nameEmployee], [reason], [description], [dateStart], [dateEnd], [type]) VALUES (N'QÐ/050520231327', N'NV000003', N'Trần Thị Bích Hường', N'làm việc chăm chỉ', N'', CAST(N'1900-01-01' AS Date), CAST(N'1900-01-01' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[Staticstical] ON 

INSERT [dbo].[Staticstical] ([id], [month], [year], [type]) VALUES (1, 4, 2023, 0)
INSERT [dbo].[Staticstical] ([id], [month], [year], [type]) VALUES (2, 4, 2023, 1)
INSERT [dbo].[Staticstical] ([id], [month], [year], [type]) VALUES (3, 5, 2023, 0)
SET IDENTITY_INSERT [dbo].[Staticstical] OFF
GO
INSERT [dbo].[TimeSheet] ([idTimeSheet], [month], [year], [date], [dayOfMonth], [status]) VALUES (N'TS012023', 1, 2023, CAST(N'2023-04-12' AS Date), 26, 1)
INSERT [dbo].[TimeSheet] ([idTimeSheet], [month], [year], [date], [dayOfMonth], [status]) VALUES (N'TS022023', 2, 2023, CAST(N'2023-04-12' AS Date), 24, 1)
INSERT [dbo].[TimeSheet] ([idTimeSheet], [month], [year], [date], [dayOfMonth], [status]) VALUES (N'TS042023', 4, 2023, CAST(N'2023-04-28' AS Date), 25, 1)
INSERT [dbo].[TimeSheet] ([idTimeSheet], [month], [year], [date], [dayOfMonth], [status]) VALUES (N'TS052023', 5, 2023, CAST(N'2023-05-05' AS Date), 27, 1)
GO
SET IDENTITY_INSERT [dbo].[TimeSheetDetail] ON 

INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (109, N'TS012023', N'NV000001', N'Trần Quang Long', 26, 0, 0, 26)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (110, N'TS012023', N'NV000002', N'Ngô Thị Mỹ Hạnh', 26, 6, 5, 15)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (111, N'TS012023', N'NV000003', N'Trần Thị Bích Hường', 26, 0, 0, 26)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (112, N'TS012023', N'NV000004', N'Lê Minh Hồng', 26, 0, 0, 26)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (113, N'TS012023', N'NV000005', N'Dương Văn Dưỡng', 26, 0, 0, 26)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (114, N'TS012023', N'NV000006', N'Nguyễn Ngọc Thảo', 26, 0, 0, 26)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (115, N'TS012023', N'NV000007', N'Bùi Anh Tuấn', 26, 0, 0, 26)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (116, N'TS012023', N'NV000008', N'Dương Gia Bảo', 26, 0, 0, 26)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (117, N'TS012023', N'NV000009', N'Nguyễn Thị Gấm', 26, 0, 0, 26)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (118, N'TS022023', N'NV000001', N'Trần Quang Long', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (119, N'TS022023', N'NV000002', N'Ngô Thị Mỹ Hạnh', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (120, N'TS022023', N'NV000003', N'Trần Thị Bích Hường', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (121, N'TS022023', N'NV000004', N'Lê Minh Hồng', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (122, N'TS022023', N'NV000005', N'Dương Văn Dưỡng', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (123, N'TS022023', N'NV000006', N'Nguyễn Ngọc Thảo', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (124, N'TS022023', N'NV000007', N'Bùi Anh Tuấn', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (125, N'TS022023', N'NV000008', N'Dương Gia Bảo', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (126, N'TS022023', N'NV000009', N'Nguyễn Thị Gấm', 24, 0, 0, 24)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (127, N'TS042023', N'NV000001', N'Trần Quang Long', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (128, N'TS042023', N'NV000002', N'Ngô Thị Mỹ Hạnh', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (129, N'TS042023', N'NV000003', N'Trần Thị Bích Hường', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (130, N'TS042023', N'NV000004', N'Lê Minh Hồng', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (131, N'TS042023', N'NV000005', N'Dương Văn Dưỡng', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (132, N'TS042023', N'NV000006', N'Nguyễn Ngọc Thảo', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (133, N'TS042023', N'NV000007', N'Bùi Anh Tuấn', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (134, N'TS042023', N'NV000008', N'Dương Gia Bảo', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (135, N'TS042023', N'NV000009', N'Nguyễn Thị Gấm', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (136, N'TS042023', N'NV000012', N'Test', 25, 0, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (137, N'TS052023', N'NV000001', N'Trần Quang Long', 27, 2, 0, 25)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (138, N'TS052023', N'NV000002', N'Ngô Thị Mỹ Hạnh', 27, 0, 0, 27)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (139, N'TS052023', N'NV000003', N'Trần Thị Bích Hường', 27, 0, 0, 27)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (140, N'TS052023', N'NV000004', N'Lê Minh Hồng', 27, 0, 0, 27)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (141, N'TS052023', N'NV000005', N'Dương Văn Dưỡng', 27, 0, 0, 27)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (142, N'TS052023', N'NV000006', N'Nguyễn Ngọc Thảo', 27, 0, 0, 27)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (143, N'TS052023', N'NV000007', N'Bùi Anh Tuấn', 27, 0, 0, 27)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (144, N'TS052023', N'NV000008', N'Dương Gia Bảo', 27, 0, 0, 27)
INSERT [dbo].[TimeSheetDetail] ([id], [idTimeSheet], [idEmployee], [nameEmployee], [workDay], [excused], [unExcused], [total]) VALUES (145, N'TS052023', N'NV000009', N'Nguyễn Thị Gấm', 27, 0, 0, 27)
SET IDENTITY_INSERT [dbo].[TimeSheetDetail] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([idDepartment])
REFERENCES [dbo].[Department] ([idDepartment])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_LevelSalary] FOREIGN KEY([levelSalary])
REFERENCES [dbo].[LevelSalary] ([levelSalary])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_LevelSalary]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Position] FOREIGN KEY([idPosition])
REFERENCES [dbo].[Position] ([idPosition])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Position]
GO
ALTER TABLE [dbo].[PayRollDetail]  WITH CHECK ADD  CONSTRAINT [FK_PayRollDetail_Employee] FOREIGN KEY([idEmployee])
REFERENCES [dbo].[Employee] ([idEmployee])
GO
ALTER TABLE [dbo].[PayRollDetail] CHECK CONSTRAINT [FK_PayRollDetail_Employee]
GO
ALTER TABLE [dbo].[PayRollDetail]  WITH CHECK ADD  CONSTRAINT [FK_PayRollDetail_PayRoll] FOREIGN KEY([idPayRoll])
REFERENCES [dbo].[PayRoll] ([idPayRoll])
GO
ALTER TABLE [dbo].[PayRollDetail] CHECK CONSTRAINT [FK_PayRollDetail_PayRoll]
GO
ALTER TABLE [dbo].[PayRollDetail]  WITH CHECK ADD  CONSTRAINT [FK_PayRollDetail_TimeSheet] FOREIGN KEY([idTimeSheet])
REFERENCES [dbo].[TimeSheet] ([idTimeSheet])
GO
ALTER TABLE [dbo].[PayRollDetail] CHECK CONSTRAINT [FK_PayRollDetail_TimeSheet]
GO
ALTER TABLE [dbo].[Reward_Discipline]  WITH CHECK ADD  CONSTRAINT [FK_Reward_Discipline_Employee] FOREIGN KEY([idEmployee])
REFERENCES [dbo].[Employee] ([idEmployee])
GO
ALTER TABLE [dbo].[Reward_Discipline] CHECK CONSTRAINT [FK_Reward_Discipline_Employee]
GO
ALTER TABLE [dbo].[TimeSheetDetail]  WITH CHECK ADD  CONSTRAINT [FK_TimeSheetDetail_Employee] FOREIGN KEY([idEmployee])
REFERENCES [dbo].[Employee] ([idEmployee])
GO
ALTER TABLE [dbo].[TimeSheetDetail] CHECK CONSTRAINT [FK_TimeSheetDetail_Employee]
GO
ALTER TABLE [dbo].[TimeSheetDetail]  WITH CHECK ADD  CONSTRAINT [FK_TimeSheetDetail_TimeSheet] FOREIGN KEY([idTimeSheet])
REFERENCES [dbo].[TimeSheet] ([idTimeSheet])
GO
ALTER TABLE [dbo].[TimeSheetDetail] CHECK CONSTRAINT [FK_TimeSheetDetail_TimeSheet]
GO
/****** Object:  StoredProcedure [dbo].[CountDiscipline]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CountDiscipline]
AS
BEGIN
	SELECT COUNT(*) FROM dbo.Reward_Discipline
	WHERE type = 0
END
GO
/****** Object:  StoredProcedure [dbo].[CountReward]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CountReward]
AS
BEGIN
	SELECT COUNT(*) FROM dbo.Reward_Discipline
	WHERE type = 1
END
GO
/****** Object:  StoredProcedure [dbo].[CountStaticsticalIn]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CountStaticsticalIn]
@Month int,
@Year int
AS
BEGIN
	SELECT COUNT(*) FROM dbo.Staticstical
	WHERE type IN (
		SELECT type FROM dbo.Staticstical WHERE month = @Month AND year = @Year AND type = 1
	)
END
GO
/****** Object:  StoredProcedure [dbo].[CountStaticsticalLeave]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CountStaticsticalLeave]
@Month int,
@Year int
AS
BEGIN
	SELECT COUNT(*) FROM dbo.Staticstical
	WHERE type IN (
		SELECT type FROM dbo.Staticstical WHERE month = @Month AND year = @Year AND type = 0
	)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteReward_Discipline]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteReward_Discipline]
@Id varchar(15)
AS
BEGIN
	DELETE FROM dbo.Reward_Discipline
	WHERE id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetDiscipline]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDiscipline]
AS
BEGIN
	SELECT id, idEmployee, nameEmployee, dateStart, dateEnd, reason, description
	FROM dbo.Reward_Discipline
	WHERE type = 0
END
GO
/****** Object:  StoredProcedure [dbo].[GetReward]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetReward]
AS
BEGIN
	SELECT id, idEmployee, nameEmployee, reason, description
	FROM dbo.Reward_Discipline
	WHERE type = 1
END
GO
/****** Object:  StoredProcedure [dbo].[InsertDiscipline]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDiscipline]
@Id varchar(15),
@IdEmployee varchar(15),
@NameEmployee nvarchar(50),
@Reason nvarchar(200),
@Description nvarchar(200),
@DateStart date,
@DateEnd date
AS
BEGIN
	INSERT INTO dbo.Reward_Discipline
	VALUES (@Id, @IdEmployee, @NameEmployee, @Reason, @Description, @DateStart, @DateEnd, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertReward]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertReward]
@Id varchar(15),
@IdEmployee varchar(15),
@NameEmployee nvarchar(50),
@Reason nvarchar(200),
@Description nvarchar(200)
AS
BEGIN
	INSERT INTO dbo.Reward_Discipline
	VALUES (@Id, @IdEmployee, @NameEmployee, @Reason, @Description, '', '', 1)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertStaticstical]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertStaticstical]
@Month int,
@Year int,
@Type bit
AS
BEGIN
	INSERT INTO dbo.Staticstical
	VALUES (@Month, @Year, @Type)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_AddPayRoll]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_AddPayRoll]
@IdPayRoll varchar(15),
@Month int,
@Year int,
@Date date
AS
BEGIN
	INSERT INTO dbo.PayRoll
	VALUES (@IdPayRoll, @Month, @Year,  @Date, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_AddPosition]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_AddPosition]
@IdPosition varchar(15),
@NamePosition nvarchar(30),
@DesPosition nvarchar(200)
AS
BEGIN
	INSERT INTO dbo.Position
	VALUES (@IdPosition, @NamePosition, @DesPosition)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_CountByDepartment]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_CountByDepartment]
@IdDepartment varchar(15)
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.Employee
	WHERE idDepartment = @IdDepartment
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_CountDepartment]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_CountDepartment]
AS
BEGIN
	SELECT COUNT(*) FROM dbo.Department
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_CountEmployee]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_CountEmployee]
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.Employee
	INNER JOIN dbo.Department ON Employee.idDepartment = Department.idDepartment
	INNER JOIN dbo.Position ON Employee.idPosition = Position.idPosition
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_CountEmployeeFemale]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_CountEmployeeFemale]
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.Employee
	WHERE sex = 0
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_CountEmployeeMale]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_CountEmployeeMale]
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.Employee
	WHERE sex = 1
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_CountLevelSalary]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_CountLevelSalary]
AS
BEGIN
	SELECT Count(*) FROM dbo.LevelSalary
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteAccount]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_DeleteAccount]
@UserName varchar(15)
AS
BEGIN
	DELETE FROM dbo.LogIn
	WHERE userName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteDepartment]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_DeleteDepartment]
@idDepartment varchar(15)
AS
BEGIN
	DELETE FROM dbo.Department WHERE idDepartment = @idDepartment
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_DeleteLevelSalary]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_DeleteLevelSalary]
@levelSalary int
AS
BEGIN
	DELETE FROM dbo.LevelSalary WHERE levelSalary = @levelSalary
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_DeletePosition]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_DeletePosition]
@IdPosition varchar(15)
AS
BEGIN
	DELETE FROM dbo.Position WHERE idPosition = @IdPosition
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetAccount]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetAccount]
@UserName varchar(15),
@Password varchar(30)
AS
BEGIN
	SELECT * FROM dbo.LogIn
	WHERE userName = @UserName AND password = @Password
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetBassicSalaryByID]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetBassicSalaryByID]
@IdEmployee varchar(15)
AS
BEGIN
	SELECT basicSalary FROM dbo.Employee
	INNER JOIN dbo.LevelSalary ON Employee.levelSalary = LevelSalary.levelSalary
	WHERE idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetCoefficientSalarySalaryByID]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetCoefficientSalarySalaryByID]
@IdEmployee varchar(15)
AS
BEGIN
	SELECT coefficientsSalary FROM dbo.Employee
	INNER JOIN dbo.LevelSalary ON Employee.levelSalary = LevelSalary.levelSalary
	WHERE idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetCountPosition]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetCountPosition]
AS
BEGIN
	SELECT COUNT(*) FROM dbo.Position
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetDepartment]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetDepartment]
AS
BEGIN
	SELECT * FROM dbo.Department
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetEmployee]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetEmployee]
AS
BEGIN
	SELECT idEmployee, nameEmployee, date, sex, folk, phoneNumber, address, Department.nameDepartment, Position.namePosition, levelSalary, leave
	FROM dbo.Employee
	INNER JOIN dbo.Department ON Employee.idDepartment = Department.idDepartment
	INNER JOIN dbo.Position ON Employee.idPosition = Position.idPosition
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetEmployeeLikeName]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetEmployeeLikeName]
@NameEmployee nvarchar(50)
AS
BEGIN
	SELECT idEmployee, nameEmployee, date, sex, folk, phoneNumber, address, Department.nameDepartment, Position.namePosition, levelSalary, leave
	FROM dbo.Employee
	INNER JOIN dbo.Department ON Employee.idDepartment = Department.idDepartment
	INNER JOIN dbo.Position ON Employee.idPosition = Position.idPosition
	WHERE dbo.fuConvertToUnsign1(nameEmployee) LIKE '%' + dbo.fuConvertToUnsign1(@NameEmployee) + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetIdTimeSheet]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetIdTimeSheet]
@Month int,
@Year int
AS
BEGIN
	SELECT TimeSheet.idTimeSheet FROM TimeSheet
	WHERE TimeSheet.month = @Month AND TimeSheet.year = @Year
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetLevelSalary]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetLevelSalary]
AS
BEGIN
	SELECT * FROM dbo.LevelSalary
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetNameEmployee]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetNameEmployee]
@IdEmployee varchar(15)
AS
BEGIN
	SELECT nameEmployee
	FROM dbo.Employee
	WHERE idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetPayRoll]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_GetPayRoll]
AS
BEGIN
	SELECT * FROM dbo.PayRoll
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_GetPayRollById]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedure Get PayRoll Detail
CREATE PROCEDURE [dbo].[Proc_GetPayRollById]
@IdPayRoll varchar(15)
AS
BEGIN
	SELECT * FROM dbo.PayRollDetail
	WHERE idPayRoll = @IdPayRoll
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetPayRollLikeName]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedure Get PayRoll By ID & Name
CREATE PROC [dbo].[PROC_GetPayRollLikeName]
@IdPayRoll varchar(15),
@NameEmployee nvarchar(50)
AS
BEGIN
	SELECT * FROM PayRollDetail WHERE idPayRoll = @IdPayRoll AND dbo.fuConvertToUnsign1(nameEmployee) LIKE '%' + dbo.fuConvertToUnsign1(@NameEmployee) + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetPosition]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetPosition]
AS
BEGIN
	SELECT * FROM dbo.Position
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetRole]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetRole]
@UserName varchar(15)
AS
BEGIN
	SELECT role FROM dbo.LogIn
	WHERE userName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetTimeSheet]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetTimeSheet]
AS
BEGIN
	SELECT * FROM TimeSheet	
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetTimeSheetById]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetTimeSheetById]
@IdTimeSheet varchar(15)
AS
BEGIN
	SELECT * FROM TimeSheetDetail WHERE idTimeSheet = @IdTimeSheet
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetTimeSheetLikeName]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetTimeSheetLikeName]
@IdTimeSheet varchar(15),
@NameEmployee nvarchar(50)
AS
BEGIN
	SELECT * FROM TimeSheetDetail WHERE idTimeSheet = @IdTimeSheet AND dbo.fuConvertToUnsign1(nameEmployee) LIKE '%' + dbo.fuConvertToUnsign1(@NameEmployee) + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetToTalTimeSheetById]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetToTalTimeSheetById]
@IdTimeSheet varchar(15),
@IdEmployee varchar(15)
AS
BEGIN
	SELECT total FROM TimeSheetDetail WHERE idTimeSheet = @IdTimeSheet AND idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_GetWorkDayTimeSheetById]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_GetWorkDayTimeSheetById]
@IdTimeSheet varchar(15),
@IdEmployee varchar(15)
AS
BEGIN
	SELECT workDay FROM TimeSheetDetail WHERE idTimeSheet = @IdTimeSheet AND idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertAccount]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_InsertAccount]
@UserName varchar(15),
@Password varchar(30),
@DescAccount nvarchar(200)
AS
BEGIN
	INSERT INTO dbo.LogIn
	VALUES (@UserName, @Password, 1, @DescAccount)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertDepartment]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_InsertDepartment]
@idDepartment varchar(15),
@nameDepartment nvarchar(30)
AS
BEGIN
	INSERT INTO dbo.Department
	VALUES (@idDepartment, @nameDepartment, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertEmployee]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_InsertEmployee]
@IdEmployee varchar(15),
@Name nvarchar(50),
@Date date,
@Sex bit,
@Folk nvarchar(50),
@PhoneNumber varchar(15),
@Address ntext,
@IdDepartment varchar(15),
@IdPosition varchar(15),
@LevelSalary int,
@Leave bit
AS
BEGIN
	INSERT INTO dbo.Employee
	VALUES (
		@IdEmployee,
		@Name,
		@Date,
		@Sex,
		@Folk,
		@PhoneNumber,
		@Address,
		@IdDepartment,
		@IdPosition,
		@LevelSalary,
		@Leave
	)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertLevelSalary]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_InsertLevelSalary]
@levelSalary int,
@basicSalary float,
@coefficientsSalary float
AS
BEGIN
	INSERT INTO dbo.LevelSalary
	VALUES (@levelSalary, @basicSalary, @coefficientsSalary)
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_InsertPayRoll]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Proc_InsertPayRoll]
@IdPayRoll varchar(15),
@IdEmployee varchar(15),
@IdTimeSheet varchar(15),
@Salary float,
@NameEmployee nvarchar(50),
@Total int
AS
BEGIN
	INSERT INTO dbo.PayRollDetail
	VALUES (@IdPayRoll, @IdTimeSheet, @Salary, @IdEmployee, @NameEmployee, @Total)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertTimeSheet]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_InsertTimeSheet]
@IdTimeSheet varchar(15),
@Month int,
@Year int,
@Date date,
@DayOfMonth int,
@Status bit
AS
BEGIN
	INSERT INTO dbo.TimeSheet
	VALUES (@IdTimeSheet, @Month, @Year, @Date, @DayOfMonth, @Status)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_InsertTimeSheetById]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_InsertTimeSheetById]
@IdTimeSheet varchar(15),
@IdEmployee varchar(15),
@NameEmployee nvarchar(50),
@WorkDay int,
@Excused int,
@UnExcused int,
@Total int
AS
BEGIN
	INSERT INTO dbo.TimeSheetDetail(idTimeSheet, idEmployee, nameEmployee, workDay, excused, unExcused, total)
	VALUES (@IdTimeSheet, @IdEmployee, @NameEmployee, @WorkDay, @Excused, @UnExcused, @Total)
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_ShowtAccount]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_ShowtAccount]
AS
BEGIN
	SELECT * FROM dbo.LogIn
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateAccount]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdateAccount]
@UserName varchar(15),
@Password varchar(30),
@DescAccount nvarchar(200)
AS
BEGIN
	UPDATE dbo.LogIn
	SET password = @Password, descAccount = @DescAccount
	WHERE userName = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateDepartment]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdateDepartment]
@idDepartment varchar(15),
@nameDepartment nvarchar(30) 
AS
BEGIN
	UPDATE dbo.Department
	SET nameDepartment = @nameDepartment
	WHERE idDepartment = @idDepartment
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateEmployee]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdateEmployee]
@IdEmployee varchar(15),
@Name nvarchar(50),
@Date date,
@Sex bit,
@Folk nvarchar(50),
@PhoneNumber varchar(15),
@Address ntext,
@IdDepartment varchar(15),
@IdPosition varchar(15),
@LevelSalary int,
@Leave bit
AS
BEGIN
	UPDATE dbo.Employee
	SET nameEmployee = @Name,
		date = @Date,
		sex = @Sex,
		folk = @Folk,
		phoneNumber = @PhoneNumber,
		address = @Address,
		idDepartment = @IdDepartment,
		idPosition = @IdPosition,
		levelSalary = @LevelSalary,
		leave = @Leave
	WHERE idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateLeaveEmployee]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdateLeaveEmployee]
@IdEmployee varchar(15)
AS
BEGIN
	UPDATE dbo.Employee
	SET leave = 1
	WHERE idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateLevelSalary]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdateLevelSalary]
@levelSalary int,
@basicSalary float,
@coefficientsSalary float
AS
BEGIN
	UPDATE dbo.LevelSalary
	SET basicSalary = @basicSalary, coefficientsSalary = @coefficientsSalary
	WHERE levelSalary = @levelSalary
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdatePayRoll]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PROC_UpdatePayRoll]
@IdPayRoll varchar(15)
AS
BEGIN
	UPDATE dbo.PayRoll
	SET status = 1
	WHERE idPayRoll = @IdPayRoll
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_UpdatePayRollDetail]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Proc_UpdatePayRollDetail]
@IdPayRoll varchar(15),
@IdEmployee varchar(15),
@Salary float,
@Total int
AS
BEGIN
	UPDATE dbo.PayRollDetail
	SET total = @Total, salary = @Salary
	WHERE idPayRoll = @IdPayRoll AND idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdatePosition]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdatePosition]
@IdPosition varchar(15),
@NamePosition nvarchar(30),
@DesPosition nvarchar(200)
AS
BEGIN
	UPDATE dbo.Position SET namePosition = @NamePosition, descriptionPosition =  @DesPosition
	WHERE idPosition = @IdPosition
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateQuantityDepartment]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdateQuantityDepartment]
@idDepartment varchar(15),
@Quantity int
AS
BEGIN
	UPDATE dbo.Department
	SET quantityEmployee = @Quantity
	WHERE idDepartment = @idDepartment
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateStatusTimeSheet]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdateStatusTimeSheet]
@IdTimeSheet varchar(15)
AS
BEGIN
	UPDATE dbo.TimeSheet
	SET status = 1
	WHERE idTimeSheet = @IdTimeSheet
END
GO
/****** Object:  StoredProcedure [dbo].[PROC_UpdateTimeSheetById]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PROC_UpdateTimeSheetById]
@IdTimeSheet varchar(15),
@IdEmployee varchar(15),
@Excused int,
@UnExcused int,
@Total int
AS
BEGIN
	UPDATE dbo.TimeSheetDetail
	SET excused = @Excused, unExcused = @UnExcused, total = @Total
	WHERE idTimeSheet = @IdTimeSheet AND idEmployee = @IdEmployee
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateDiscipline]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDiscipline]
@Id varchar(15),
@IdEmployee varchar(15),
@NameEmployee nvarchar(50),
@Reason nvarchar(200),
@Description nvarchar(200),
@DateStart date,
@DateEnd date
AS
BEGIN
	UPDATE dbo.Reward_Discipline
	SET idEmployee = @IdEmployee, nameEmployee = @NameEmployee, reason = @Reason, description = @Description, dateStart = @DateStart, dateEnd = @DateEnd
	WHERE id = @Id AND type = 0
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateReward]    Script Date: 05/05/2023 19:02:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateReward]
@Id varchar(15),
@IdEmployee varchar(15),
@NameEmployee nvarchar(50),
@Reason nvarchar(200),
@Description nvarchar(200)
AS
BEGIN
	UPDATE dbo.Reward_Discipline
	SET idEmployee = @IdEmployee, nameEmployee = @NameEmployee, reason = @Reason, description = @Description
	WHERE id = @Id AND type = 1
END
GO
USE [master]
GO
ALTER DATABASE [HumanResourceManagement] SET  READ_WRITE 
GO
