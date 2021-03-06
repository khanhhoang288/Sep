USE [VideoRental]
GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [varchar](20) NULL,
 CONSTRAINT [PK_tbl_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Disk]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Disk](
	[DiskID] [int] IDENTITY(1,1) NOT NULL,
	[TitleID] [int] NULL,
	[DiskStatus] [nvarchar](50) NULL,
	[DiskCode] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Disk] PRIMARY KEY CLUSTERED 
(
	[DiskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_DiskRental]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DiskRental](
	[RentalID] [int] NOT NULL,
	[DiskID] [int] NOT NULL,
 CONSTRAINT [PK_tbl_RentalDetail] PRIMARY KEY CLUSTERED 
(
	[RentalID] ASC,
	[DiskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_LateCharge]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LateCharge](
	[LateChargeID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[DiskID] [int] NULL,
	[LateCharge] [decimal](18, 0) NULL,
 CONSTRAINT [PK_tbl_LateCharge] PRIMARY KEY CLUSTERED 
(
	[LateChargeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Rental]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Rental](
	[RentalID] [int] IDENTITY(1,1) NOT NULL,
	[RentalDate] [date] NULL,
	[CustomerID] [int] NULL,
 CONSTRAINT [PK_tbl_Rental] PRIMARY KEY CLUSTERED 
(
	[RentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Reservation]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Reservation](
	[ReservationID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
 CONSTRAINT [PK_tbl_Reservation] PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ReservationTitle]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ReservationTitle](
	[ReservationID] [int] NOT NULL,
	[TitleID] [int] NOT NULL,
 CONSTRAINT [PK_tbl_ReservationTitle] PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC,
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Return]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Return](
	[CustomerID] [int] NOT NULL,
	[DiskID] [int] NOT NULL,
	[ReturnDate] [date] NULL,
 CONSTRAINT [PK_tbl_Return] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC,
	[DiskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Title]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Title](
	[TitleID] [int] IDENTITY(1,1) NOT NULL,
	[TitleName] [nvarchar](50) NULL,
	[RentalPeriod] [int] NULL,
	[RentalCharge] [decimal](18, 0) NULL,
	[TitleStatus] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_tbl_Title] PRIMARY KEY CLUSTERED 
(
	[TitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 11/9/2017 8:16:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_User](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_Disk]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Disk_tbl_Title] FOREIGN KEY([TitleID])
REFERENCES [dbo].[tbl_Title] ([TitleID])
GO
ALTER TABLE [dbo].[tbl_Disk] CHECK CONSTRAINT [FK_tbl_Disk_tbl_Title]
GO
ALTER TABLE [dbo].[tbl_DiskRental]  WITH CHECK ADD  CONSTRAINT [FK_tbl_RentalDetail_tbl_Disk] FOREIGN KEY([DiskID])
REFERENCES [dbo].[tbl_Disk] ([DiskID])
GO
ALTER TABLE [dbo].[tbl_DiskRental] CHECK CONSTRAINT [FK_tbl_RentalDetail_tbl_Disk]
GO
ALTER TABLE [dbo].[tbl_DiskRental]  WITH CHECK ADD  CONSTRAINT [FK_tbl_RentalDetail_tbl_Rental] FOREIGN KEY([RentalID])
REFERENCES [dbo].[tbl_Rental] ([RentalID])
GO
ALTER TABLE [dbo].[tbl_DiskRental] CHECK CONSTRAINT [FK_tbl_RentalDetail_tbl_Rental]
GO
ALTER TABLE [dbo].[tbl_LateCharge]  WITH CHECK ADD  CONSTRAINT [FK_tbl_LateCharge_tbl_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tbl_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[tbl_LateCharge] CHECK CONSTRAINT [FK_tbl_LateCharge_tbl_Customer]
GO
ALTER TABLE [dbo].[tbl_LateCharge]  WITH CHECK ADD  CONSTRAINT [FK_tbl_LateCharge_tbl_Disk] FOREIGN KEY([DiskID])
REFERENCES [dbo].[tbl_Disk] ([DiskID])
GO
ALTER TABLE [dbo].[tbl_LateCharge] CHECK CONSTRAINT [FK_tbl_LateCharge_tbl_Disk]
GO
ALTER TABLE [dbo].[tbl_Rental]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Rental_tbl_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tbl_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[tbl_Rental] CHECK CONSTRAINT [FK_tbl_Rental_tbl_Customer]
GO
ALTER TABLE [dbo].[tbl_Reservation]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Reservation_tbl_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tbl_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[tbl_Reservation] CHECK CONSTRAINT [FK_tbl_Reservation_tbl_Customer]
GO
ALTER TABLE [dbo].[tbl_ReservationTitle]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ReservationTitle_tbl_Reservation] FOREIGN KEY([ReservationID])
REFERENCES [dbo].[tbl_Reservation] ([ReservationID])
GO
ALTER TABLE [dbo].[tbl_ReservationTitle] CHECK CONSTRAINT [FK_tbl_ReservationTitle_tbl_Reservation]
GO
ALTER TABLE [dbo].[tbl_ReservationTitle]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ReservationTitle_tbl_Title] FOREIGN KEY([TitleID])
REFERENCES [dbo].[tbl_Title] ([TitleID])
GO
ALTER TABLE [dbo].[tbl_ReservationTitle] CHECK CONSTRAINT [FK_tbl_ReservationTitle_tbl_Title]
GO
ALTER TABLE [dbo].[tbl_Return]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Return_tbl_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tbl_Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[tbl_Return] CHECK CONSTRAINT [FK_tbl_Return_tbl_Customer]
GO
ALTER TABLE [dbo].[tbl_Return]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Return_tbl_Disk] FOREIGN KEY([DiskID])
REFERENCES [dbo].[tbl_Disk] ([DiskID])
GO
ALTER TABLE [dbo].[tbl_Return] CHECK CONSTRAINT [FK_tbl_Return_tbl_Disk]
GO
