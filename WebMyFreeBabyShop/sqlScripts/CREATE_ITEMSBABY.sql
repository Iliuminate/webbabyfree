USE [dbfreebabyshop]
GO

/****** Object:  Table [dbo].[ItemBabyEntity]    Script Date: 05/10/2017 16:22:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ItemBabyEntity](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[itemName] [nchar](100) NOT NULL,
	[itemDescription] [nchar](500) NULL,
	[itemSerial] [nchar](25) NULL,
	[dateAdd] [datetime] NOT NULL,
	[qualify] [int] NULL,
	[itemImage] [nchar](100) NULL,
	[category] [int] NULL,
	[subcategory] [int] NULL,
 CONSTRAINT [PK_ItemBabyEntity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ItemBabyEntity]  WITH CHECK ADD FOREIGN KEY([category])
REFERENCES [dbo].[CategoryEntity] ([idCategory])
GO

ALTER TABLE [dbo].[ItemBabyEntity]  WITH CHECK ADD FOREIGN KEY([subcategory])
REFERENCES [dbo].[Subcategory] ([idSubcategory])
GO


INSERT INTO [dbo].[ItemBabyEntity]
           ([itemName]
           ,[itemDescription]
           ,[itemSerial]
           ,[dateAdd]
           ,[qualify]
           ,[itemImage]
           ,[category]
           ,[subcategory])
     VALUES
           (<itemName, nchar(100),>
           ,<itemDescription, nchar(500),>
           ,<itemSerial, nchar(25),>
           ,<dateAdd, datetime,>
           ,<qualify, int,>
           ,<itemImage, nchar(100),>
           ,<category, int,>
           ,<subcategory, int,>)
GO

