
/****** Object:  Table [dbo].[MotorcycleDetails]    Script Date: 2019-07-31 7:21:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MotorcycleDetails](
	[DetailsId] [int] IDENTITY(1,1) NOT NULL,
	[MotorId] [int] NOT NULL,
	[MotorBrand] NVARCHAR(20) NOT NULL,
	[MotorModel] NVARCHAR(20) NOT NULL,
	[Country] NVARCHAR(20) NOT NULL,
 CONSTRAINT [PK_MotorcycleDetails] PRIMARY KEY CLUSTERED 
(
	[DetailsId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[MotorcycleDetails]  WITH CHECK ADD  CONSTRAINT [FK_MotorcycleDetail_Motorcycle] FOREIGN KEY([MotorId])
REFERENCES [dbo].[Motorcycles] ([MotorId])
GO

ALTER TABLE [dbo].[MotorcycleDetails] CHECK CONSTRAINT [FK_MotorcycleDetail_Motorcycle]
GO


