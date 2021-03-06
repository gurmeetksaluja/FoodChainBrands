ALTER TABLE [dbo].[FoodChainFranchises] DROP CONSTRAINT [fk_FoodChainFranchises_FoodChainBrands]
GO
ALTER TABLE [dbo].[FoodChainFranchises] DROP CONSTRAINT [DF__FoodChain__IsDel__33D4B598]
GO
ALTER TABLE [dbo].[FoodChainFranchises] DROP CONSTRAINT [DF__FoodChain__IsAct__32E0915F]
GO
ALTER TABLE [dbo].[FoodChainFranchises] DROP CONSTRAINT [DF__FoodChain__Modif__31EC6D26]
GO
ALTER TABLE [dbo].[FoodChainFranchises] DROP CONSTRAINT [DF__FoodChain__Creat__30F848ED]
GO
ALTER TABLE [dbo].[FoodChainBrands] DROP CONSTRAINT [DF__FoodChain__IsDel__276EDEB3]
GO
ALTER TABLE [dbo].[FoodChainBrands] DROP CONSTRAINT [DF__FoodChain__IsAct__267ABA7A]
GO
ALTER TABLE [dbo].[FoodChainBrands] DROP CONSTRAINT [DF__FoodChain__Modif__25869641]
GO
ALTER TABLE [dbo].[FoodChainBrands] DROP CONSTRAINT [DF__FoodChain__Creat__24927208]
GO
/****** Object:  Table [dbo].[FoodChainFranchises]    Script Date: 18-12-2020 18:31:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FoodChainFranchises]') AND type in (N'U'))
DROP TABLE [dbo].[FoodChainFranchises]
GO
/****** Object:  Table [dbo].[FoodChainBrands]    Script Date: 18-12-2020 18:31:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FoodChainBrands]') AND type in (N'U'))
DROP TABLE [dbo].[FoodChainBrands]
GO
/****** Object:  Table [dbo].[FoodChainBrands]    Script Date: 18-12-2020 18:31:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodChainBrands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FoodChainName] [nvarchar](200) NOT NULL,
	[FoodChainLogoURL] [nvarchar](200) NULL,
	[Description] [nvarchar](1000) NULL,
	[CreatedDate] [date] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [date] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodChainFranchises]    Script Date: 18-12-2020 18:31:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodChainFranchises](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FoodChainId] [int] NULL,
	[Address] [nvarchar](500) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](100) NULL,
	[Country] [nvarchar](100) NULL,
	[PinCode] [nvarchar](20) NULL,
	[CreatedDate] [date] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [date] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FoodChainBrands] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[FoodChainBrands] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[FoodChainBrands] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[FoodChainBrands] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[FoodChainFranchises] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[FoodChainFranchises] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[FoodChainFranchises] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[FoodChainFranchises] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[FoodChainFranchises]  WITH CHECK ADD  CONSTRAINT [fk_FoodChainFranchises_FoodChainBrands] FOREIGN KEY([FoodChainId])
REFERENCES [dbo].[FoodChainBrands] ([ID])
GO
ALTER TABLE [dbo].[FoodChainFranchises] CHECK CONSTRAINT [fk_FoodChainFranchises_FoodChainBrands]
GO
