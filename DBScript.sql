USE [master]
GO
/****** Object:  Database [Щемелёв_Демо]    Script Date: 23.10.2025 12:19:33 ******/
CREATE DATABASE [Щемелёв_Демо]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Щемелёв_Демо', FILENAME = N'D:\MSSQL14.SQLSERVER\MSSQL\DATA\Щемелёв_Демо.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Щемелёв_Демо_log', FILENAME = N'D:\MSSQL14.SQLSERVER\MSSQL\DATA\Щемелёв_Демо_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Щемелёв_Демо] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Щемелёв_Демо].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Щемелёв_Демо] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET ARITHABORT OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Щемелёв_Демо] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Щемелёв_Демо] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Щемелёв_Демо] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Щемелёв_Демо] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Щемелёв_Демо] SET  MULTI_USER 
GO
ALTER DATABASE [Щемелёв_Демо] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Щемелёв_Демо] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Щемелёв_Демо] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Щемелёв_Демо] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Щемелёв_Демо] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Щемелёв_Демо] SET QUERY_STORE = OFF
GO
USE [Щемелёв_Демо]
GO
/****** Object:  Table [dbo].[C_Service]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[C_Service](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[s_type] [nvarchar](50) NULL,
	[s_name] [nvarchar](50) NULL,
	[code] [nvarchar](50) NULL,
	[mincost] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material_type]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material_type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[m_type] [nvarchar](50) NULL,
	[consume] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[partner_history]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[partner_history](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[service_id] [int] NULL,
	[partner_id] [int] NULL,
	[amount] [int] NULL,
	[h_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partners]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partners](
	[ID] [int] NOT NULL,
	[p_type] [nvarchar](50) NULL,
	[partner_name] [nvarchar](50) NULL,
	[director] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[legal_address] [nvarchar](50) NULL,
	[INN] [int] NULL,
	[rating] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[partner_id] [int] NULL,
	[manager_id] [int] NULL,
	[r_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request_details]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request_details](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[request_id] [int] NULL,
	[service_id] [int] NULL,
	[price] [int] NULL,
	[done_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service_Materials]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service_Materials](
	[ID] [int] NOT NULL,
	[service_id] [int] NULL,
	[material_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service_Type]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service_Type](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[s_type] [nvarchar](50) NULL,
	[coef] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 23.10.2025 12:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DOB] [date] NULL,
	[passport] [nvarchar](50) NULL,
	[bank] [nvarchar](50) NULL,
	[work] [nvarchar](50) NULL,
	[health] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[C_Service] ON 
GO
INSERT [dbo].[C_Service] ([ID], [s_type], [s_name], [code], [mincost]) VALUES (1, N'Стирка', N'Стирка постельного белья (до 10 кг)', N'SRV-001', 500)
GO
INSERT [dbo].[C_Service] ([ID], [s_type], [s_name], [code], [mincost]) VALUES (2, N'Стирка', N'Стирка верхней одежды (куртки, пальто)', N'SRV-002', 800)
GO
INSERT [dbo].[C_Service] ([ID], [s_type], [s_name], [code], [mincost]) VALUES (3, N'Химчистка', N'Химчистка костюма', N'SRV-003', 1200)
GO
INSERT [dbo].[C_Service] ([ID], [s_type], [s_name], [code], [mincost]) VALUES (4, N'Химчистка', N'Химчистка ковра (за кв.м)', N'SRV-004', 300)
GO
INSERT [dbo].[C_Service] ([ID], [s_type], [s_name], [code], [mincost]) VALUES (5, N'Ремонт', N'Ремонт молнии на брюках', N'SRV-005', 250)
GO
INSERT [dbo].[C_Service] ([ID], [s_type], [s_name], [code], [mincost]) VALUES (6, N'Аквачистка', N'Аквачистка пуховика', N'SRV-006', 1500)
GO
INSERT [dbo].[C_Service] ([ID], [s_type], [s_name], [code], [mincost]) VALUES (7, N'Сушка', N'Сушка в барабанной сушилке (цикл)', N'SRV-007', 200)
GO
SET IDENTITY_INSERT [dbo].[C_Service] OFF
GO
SET IDENTITY_INSERT [dbo].[Material_type] ON 
GO
INSERT [dbo].[Material_type] ([ID], [m_type], [consume]) VALUES (1, N'Порошок', N'0.05	')
GO
INSERT [dbo].[Material_type] ([ID], [m_type], [consume]) VALUES (2, N'Растворитель', N'0.08	')
GO
INSERT [dbo].[Material_type] ([ID], [m_type], [consume]) VALUES (3, N'Отбеливатель', N'0.1	')
GO
INSERT [dbo].[Material_type] ([ID], [m_type], [consume]) VALUES (4, N'Кондиционер', N'0.03	')
GO
INSERT [dbo].[Material_type] ([ID], [m_type], [consume]) VALUES (5, N'Пятновыводитель', N'0.07	')
GO
INSERT [dbo].[Material_type] ([ID], [m_type], [consume]) VALUES (6, N'Упаковка', N'0.02	')
GO
SET IDENTITY_INSERT [dbo].[Material_type] OFF
GO
SET IDENTITY_INSERT [dbo].[partner_history] ON 
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (89, 1, 1, 150, CAST(N'2023-03-23' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (90, 2, 1, 85, CAST(N'2023-12-18' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (91, 3, 1, 120, CAST(N'2024-06-07' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (92, 4, 2, 350, CAST(N'2022-12-02' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (93, 5, 2, 45, CAST(N'2023-05-17' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (94, 1, 2, 200, CAST(N'2024-06-07' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (95, 2, 2, 30, CAST(N'2024-07-01' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (96, 3, 3, 300, CAST(N'2023-01-22' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (97, 4, 3, 60, CAST(N'2024-07-05' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (98, 5, 4, 180, CAST(N'2023-03-20' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (99, 1, 4, 250, CAST(N'2024-03-12' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (100, 2, 4, 25, CAST(N'2024-05-14' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (101, 3, 5, 500, CAST(N'2023-09-19' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (102, 4, 5, 320, CAST(N'2023-11-10' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (103, 5, 5, 150, CAST(N'2024-04-15' AS Date))
GO
INSERT [dbo].[partner_history] ([ID], [service_id], [partner_id], [amount], [h_date]) VALUES (104, 1, 5, 420, CAST(N'2024-06-12' AS Date))
GO
SET IDENTITY_INSERT [dbo].[partner_history] OFF
GO
INSERT [dbo].[Partners] ([ID], [p_type], [partner_name], [director], [email], [phone], [legal_address], [INN], [rating]) VALUES (1, N'ИП
', N'Чистый Мир
', N'Смирнова Ольга Викторовна
', N'olga.smirnova@cm.ru
', N'495 111 22 33
', N'123456, г. Москва, ул. Чистая, д. 10
', 1234567890, CAST(9.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Partners] ([ID], [p_type], [partner_name], [director], [email], [phone], [legal_address], [INN], [rating]) VALUES (2, N'ООО', N'Блеск и Глянец
', N'Комаров Денис Игоревич
', N'denis.komarov@bg.ru
', N'812 444 55 66
', N'190000, г. Санкт-Петербург, Невский пр-т, д. 50
', 1345678902, CAST(8.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Partners] ([ID], [p_type], [partner_name], [director], [email], [phone], [legal_address], [INN], [rating]) VALUES (3, N'ИП', N'Свежесть Плюс
', N'Николаева Анна Сергеевна
', N'anna.nikolaeva@sp.ru
', N'383 777 88 99
', N'630000, г. Новосибирск, ул. Лазурная, д. 25
', 1456789023, CAST(7.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Partners] ([ID], [p_type], [partner_name], [director], [email], [phone], [legal_address], [INN], [rating]) VALUES (4, N'ЗАО', N'Уютный Дом
', N'Фролов Артем Васильевич
', N'artem.frolov@ud.ru
', N'843 222 33 44
', N'420000, г. Казань, ул. Уютная, д. 15
', 1567890234, CAST(6.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Partners] ([ID], [p_type], [partner_name], [director], [email], [phone], [legal_address], [INN], [rating]) VALUES (5, N'ООО', N'ЭкоТекстиль
', N'Васнецова Ирина Петровна
', N'irina.vasnecova@et.ru
', N'351 555 66 77
', N'454000, г. Челябинск, пр-т Победы, д. 100
', 1678902345, CAST(10.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Service_Type] ON 
GO
INSERT [dbo].[Service_Type] ([ID], [s_type], [coef]) VALUES (1, N'1', CAST(1.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Service_Type] ([ID], [s_type], [coef]) VALUES (2, N'2', CAST(2.50 AS Decimal(10, 2)))
GO
INSERT [dbo].[Service_Type] ([ID], [s_type], [coef]) VALUES (3, N'3', CAST(3.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Service_Type] ([ID], [s_type], [coef]) VALUES (4, N'4', CAST(1.80 AS Decimal(10, 2)))
GO
INSERT [dbo].[Service_Type] ([ID], [s_type], [coef]) VALUES (5, N'5', CAST(0.50 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Service_Type] OFF
GO
ALTER TABLE [dbo].[partner_history]  WITH CHECK ADD FOREIGN KEY([partner_id])
REFERENCES [dbo].[Partners] ([ID])
GO
ALTER TABLE [dbo].[partner_history]  WITH CHECK ADD FOREIGN KEY([service_id])
REFERENCES [dbo].[C_Service] ([ID])
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD FOREIGN KEY([partner_id])
REFERENCES [dbo].[Partners] ([ID])
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD FOREIGN KEY([manager_id])
REFERENCES [dbo].[Workers] ([ID])
GO
ALTER TABLE [dbo].[Request_details]  WITH CHECK ADD FOREIGN KEY([request_id])
REFERENCES [dbo].[Request] ([ID])
GO
ALTER TABLE [dbo].[Request_details]  WITH CHECK ADD FOREIGN KEY([service_id])
REFERENCES [dbo].[C_Service] ([ID])
GO
ALTER TABLE [dbo].[Service_Materials]  WITH CHECK ADD FOREIGN KEY([service_id])
REFERENCES [dbo].[C_Service] ([ID])
GO
ALTER TABLE [dbo].[Service_Materials]  WITH CHECK ADD FOREIGN KEY([material_id])
REFERENCES [dbo].[Material_type] ([ID])
GO
USE [master]
GO
ALTER DATABASE [Щемелёв_Демо] SET  READ_WRITE 
GO
