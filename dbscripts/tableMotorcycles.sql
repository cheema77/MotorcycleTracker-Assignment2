
/****** Object:  Table [dbo].[Motorcycles]    Script Date: 2019-07-31 7:21:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Motorcycles](
	[MotorId] [int] IDENTITY(1,1) NOT NULL,
	[MotorName] NVARCHAR(50) NOT NULL,
	[MakeYear] [int] NOT NULL,
	[Company] NVARCHAR(50) NOT NULL,
 CONSTRAINT [PK_Motorcycle] PRIMARY KEY CLUSTERED 
(
	[MotorId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


