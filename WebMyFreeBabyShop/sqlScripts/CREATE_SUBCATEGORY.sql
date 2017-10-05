USE [dbfreebabyshop]
GO

/****** Object:  Table [dbo].[Subcategory]    Script Date: 05/10/2017 16:21:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Subcategory](
	[idSubcategory] [int] IDENTITY(1,1) NOT NULL,
	[subcategory] [nchar](10) NULL,
 CONSTRAINT [PK_Subcategory] PRIMARY KEY CLUSTERED 
(
	[idSubcategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


INSERT INTO [dbo].[Subcategory]
           ([subcategory])
     VALUES
           (<subcategory, nchar(10),>)
GO
