/*Q群196997099*/
USE [WMS]
GO
/****** Object:  Table [dbo].[Goods]    Script Date: 2017/5/12 17:28:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods](
	[GID] [nvarchar](50) NOT NULL,
	[GName] [nvarchar](50) NULL,
	[GPrice] [money] NULL,
	[GProvider] [nvarchar](50) NULL,
	[n_bak] [nvarchar](200) NULL,
 CONSTRAINT [PK_Goods] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Records]    Script Date: 2017/5/12 17:28:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Records](
	[RID] [int] IDENTITY(1,1) NOT NULL,
	[RGID] [nvarchar](50) NULL,
	[RWID] [nvarchar](50) NULL,
	[RQuantity] [int] NULL,
	[Rtype] [int] NULL,
	[RHandler] [nvarchar](50) NULL,
	[RTime] [datetime] NULL,
	[RBak] [nvarchar](200) NULL,
 CONSTRAINT [PK_Records] PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Store]    Script Date: 2017/5/12 17:28:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[SGID] [nvarchar](50) NULL,
	[SWID] [nvarchar](50) NULL,
	[STopLine] [int] NULL,
	[SbaseLine] [int] NULL,
	[SQuantity] [int] NULL,
	[n_bak] [nvarchar](200) NULL,
 CONSTRAINT [PK_Store1] PRIMARY KEY CLUSTERED 
(
	[SID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2017/5/12 17:28:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UID] [nvarchar](50) NOT NULL,
	[UPassword] [nvarchar](50) NULL,
	[UPower] [nvarchar](50) NULL,
	[USex] [char](2) NULL,
	[UName] [nvarchar](50) NULL,
	[UAddress] [nvarchar](50) NULL,
	[UTel] [nvarchar](50) NULL,
	[UEmail] [nvarchar](50) NULL,
	[UDep] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Warehouses]    Script Date: 2017/5/12 17:28:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouses](
	[WID] [nvarchar](50) NOT NULL,
	[WName] [nvarchar](50) NULL,
	[WArea] [float] NULL,
	[WAddress] [nvarchar](50) NULL,
	[WDescribe] [nvarchar](500) NULL,
 CONSTRAINT [PK_Warehouses] PRIMARY KEY CLUSTERED 
(
	[WID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_GWS]    Script Date: 2017/5/12 17:28:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_GWS] (SGID,SWID,SQuantity,STopLine,SbaseLine,GID,GName,GPrice,GProvider,WID,WName,SneedQuantity,SEmergency)
AS 
SELECT SGID,SWID,SQuantity,STopLine,SbaseLine,GID,GName,GPrice,GProvider,WID,WName,STopLine-SQuantity AS SneedQuantity,1-SQuantity/STopLine AS SEmergency
FROM Goods,Warehouses,Store
WHERE GID=SGID 
AND WID=SWID




GO
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'01001', N'海尔冰箱', 2400.0000, N'海尔集团', NULL)
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'02001', N'薯片', 2.0000, N'北京小食品制作公司', NULL)
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'03001', N'海飞丝洗发水', 20.0000, N'海飞丝总公司', NULL)
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'04001', N'雕牌洗衣粉', 18.0000, N'上海日化', NULL)
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'05001', N'荞麦饼干', 5.0000, N'上海食品有限公司', NULL)
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'06001', N'可爱小风扇', 30.0000, N'北京电器公司', NULL)
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'07001', N'香蕉', 2.9000, N'海南香蕉园', NULL)
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'08001', N'苹果', 3.0000, N'铺上果园', NULL)
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'UKU-001', N'', 0.0000, N'', N'入库新增SKU')
INSERT [dbo].[Goods] ([GID], [GName], [GPrice], [GProvider], [n_bak]) VALUES (N'UKU-002', N'', 0.0000, N'', N'入库新增SKU')
SET IDENTITY_INSERT [dbo].[Records] ON 

INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (1, N'01001', N'1', 40, 1, N'李四', CAST(0x0000A2E400000000 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (2, N'02001', N'2', 10, 2, N'王五', CAST(0x0000A2C500000000 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (3, N'03001', N'3', 30, 1, N'徐丽', CAST(0x0000A32300000000 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (4, N'04001', N'3', 10, 2, N'徐丽', CAST(0x0000A34300000000 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (5, N'05001', N'2', 8, 2, N'王五', CAST(0x0000A34300000000 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (6, N'04001', N'3', 5, 2, N'df', CAST(0x0000A3460121AE30 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (7, N'06001', N'1', 10, 1, N'力学', CAST(0x0000A34800FC8E62 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (8, N'06001', N'1', 2, 2, N'李雪', CAST(0x0000A34800FCBE1F AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (9, N'04001', N'3', 5, 1, N'fgh', CAST(0x0000A3480155B620 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (10, N'04001', N'3', 5, 2, N'fgh', CAST(0x0000A3480155D261 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (11, N'07001', N'2', 30, 2, N'消防', CAST(0x0000A348016AC481 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (12, N'08001', N'2', 50, 1, N'李峰', CAST(0x0000A348016B00D5 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (13, N'07001', N'2', 40, 1, N'李航', CAST(0x0000A348016B387F AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (14, N'01001', N'1', 10, 1, N'admin', CAST(0x0000A77100AB1DE0 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (15, N'01001', N'1', 20, 1, N'admin', CAST(0x0000A77100AC739D AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (16, N'01001', N'1', 1, 1, N'admin', CAST(0x0000A77100B3F290 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (17, N'UKU-001', N'1', 20, 1, N'cao919', CAST(0x0000A771010E9D8A AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (18, N'UKU-002', N'1', 100, 1, N'UKU-002 入库100', CAST(0x0000A771011E4ED5 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (19, N'UKU-002', N'1', 50, 1, N'UKU-002 入库50', CAST(0x0000A771011E7912 AS DateTime), NULL)
INSERT [dbo].[Records] ([RID], [RGID], [RWID], [RQuantity], [Rtype], [RHandler], [RTime], [RBak]) VALUES (20, N'UKU-002', N'1', 150, 1, N'UKU-002 入库150', CAST(0x0000A771011F38D7 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Records] OFF
SET IDENTITY_INSERT [dbo].[Store] ON 

INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (1, N'01001', N'1', 160, 4, 25, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (2, N'02001', N'2', 100, 14, 10, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (3, N'03001', N'3', 100, 3, 15, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (4, N'04001', N'3', 50, 40, 25, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (5, N'05001', N'2', 100, 5, 40, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (6, N'06001', N'1', 70, 6, 2, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (7, N'07001', N'2', 200, 40, 20, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (8, N'08001', N'2', 150, 20, 20, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (9, N'UKU-001', N'1', 1000, 1, 20, NULL)
INSERT [dbo].[Store] ([SID], [SGID], [SWID], [STopLine], [SbaseLine], [SQuantity], [n_bak]) VALUES (10, N'UKU-002', N'1', 1000, 1, 200, NULL)
SET IDENTITY_INSERT [dbo].[Store] OFF
INSERT [dbo].[Users] ([UID], [UPassword], [UPower], [USex], [UName], [UAddress], [UTel], [UEmail], [UDep]) VALUES (N'0001', N'0001', N'仓库总管', N'男', N'张三', N'平顶山新城区', N'13253656788', N'546576779@qq.com', N'0')
INSERT [dbo].[Users] ([UID], [UPassword], [UPower], [USex], [UName], [UAddress], [UTel], [UEmail], [UDep]) VALUES (N'1001', N'1001', N'分仓库管理员', N'男', N'李四', N'濮阳市光明路', N'18723647678', N'54634785@qq.com', N'1')
INSERT [dbo].[Users] ([UID], [UPassword], [UPower], [USex], [UName], [UAddress], [UTel], [UEmail], [UDep]) VALUES (N'1002', N'10021', N'分仓库管理员', N'男', N'赵六', N'平顶山新华区', N'17545678658', N'565768899@126.com', N'3')
INSERT [dbo].[Users] ([UID], [UPassword], [UPower], [USex], [UName], [UAddress], [UTel], [UEmail], [UDep]) VALUES (N'1003', N'1003', N'分仓库管理员', N'男', N'王玉', N'平顶山市', N'13456677888', N'356888@136.com', N'2')
INSERT [dbo].[Users] ([UID], [UPassword], [UPower], [USex], [UName], [UAddress], [UTel], [UEmail], [UDep]) VALUES (N'2001', N'2001', N'采购员', N'女', N'郑', N'这个吧v', N'13757364767', N'758gbjh@126.com', N'1')
INSERT [dbo].[Users] ([UID], [UPassword], [UPower], [USex], [UName], [UAddress], [UTel], [UEmail], [UDep]) VALUES (N'admin', N'admin', N'仓库总管', N'男', N'admin', N'北京交流群196997099', N'13333333333', N'333333@126.com', N'0')
INSERT [dbo].[Warehouses] ([WID], [WName], [WArea], [WAddress], [WDescribe]) VALUES (N'1', N'音娱第一仓库', 400, N'广州天河区', N'该仓库以存放成品为主')
INSERT [dbo].[Warehouses] ([WID], [WName], [WArea], [WAddress], [WDescribe]) VALUES (N'2', N'音娱第二仓库', 500, N'北京西门', N'该仓库以存放食品为主')
INSERT [dbo].[Warehouses] ([WID], [WName], [WArea], [WAddress], [WDescribe]) VALUES (N'3', N'音娱第三仓库', 500, N'武汉风情街', N'该仓库以存放生活用品为主')
ALTER TABLE [dbo].[Records] ADD  CONSTRAINT [DF_Records_RTime]  DEFAULT (getdate()) FOR [RTime]
GO
