USE [dbfreebabyshop]
GO

/****** Object:  Table [dbo].[CategoryEntity]    Script Date: 05/10/2017 16:20:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CategoryEntity](
	[idCategory] [int] IDENTITY(1,1) NOT NULL,
	[categoryName] [nchar](25) NULL,
 CONSTRAINT [PK_CategoryEntity] PRIMARY KEY CLUSTERED 
(
	[idCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


INSERT INTO [dbo].[CategoryEntity]
           ([categoryName])
     VALUES
           (<categoryName, nchar(25),>)
GO


