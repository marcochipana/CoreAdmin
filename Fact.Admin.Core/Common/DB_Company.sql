USE [#Facturacion_CompanyName#]
GO
/****** Object:  Table [dbo].[ComponentAttributeType]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComponentAttributeType](
	[ComponentAtributeTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[SqlServerType] [int] NULL,
	[Quoted] [bit] NULL,
	[XmlType] [nvarchar](50) NULL,
	[IntroducedVersion] [nvarchar](50) NULL,
 CONSTRAINT [PK_ComponentAtributeType] PRIMARY KEY CLUSTERED 
(
	[ComponentAtributeTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ComponentAttributeType] ON
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (1, N'bigint', 127, 0, N'integer', N'5.0.9400.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (2, N'binary', 173, 0, N'base64Binary', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (3, N'bit', 104, 0, N'Boolean', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (4, N'char', 175, 1, N'string', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (5, N'datetime', 61, 1, N'dateTime.tz', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (6, N'decimal', 106, 0, N'float', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (7, N'float', 62, 0, N'float', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (8, N'image', 34, 0, N'base64Binary', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (9, N'int', 56, 0, N'integer', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (10, N'money', 60, 0, N'float', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (11, N'nchar', 239, 1, N'string', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (12, N'ntext', 99, 1, N'string', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (13, N'numeric', 108, 0, N'float', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (14, N'nvarchar', 231, 1, N'string', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (15, N'real', 59, 0, N'float', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (16, N'smalldatetime', 58, 1, N'dateTime', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (17, N'smallint', 52, 0, N'integer', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (18, N'smallmoney', 122, 0, N'float', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (19, N'sql_variant', 98, 0, N'string', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (20, N'text', 35, 1, N'string', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (21, N'timestamp', 189, 0, N'string', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (22, N'tinyint', 48, 0, N'integer', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (23, N'uniqueidentifier', 36, 1, N'uuid', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (24, N'varbinary', 165, 0, N'base64Binary', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (25, N'varchar', 167, 1, N'string', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (26, N'picklist', NULL, 0, N'picklist', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (27, N'lookup', NULL, 1, N'lookup', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (28, N'primarykey', NULL, 1, N'primarykey', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (29, N'virtual', NULL, 0, N'virtual', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (30, N'customer', NULL, 1, N'customer', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (31, N'owner', NULL, 1, N'owner', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (32, N'state', NULL, 1, N'state', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (33, N'status', NULL, 1, N'status', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (34, N'partylist', NULL, 0, N'partylist', N'4.0.7333.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (35, N'HierarchyId', 240, 0, N'string', N'5.0.9211.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (36, N'managedproperty', 104, 0, N'Boolean', N'5.0.9430.0')
INSERT [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId], [Description], [SqlServerType], [Quoted], [XmlType], [IntroducedVersion]) VALUES (37, N'xml', 241, 0, NULL, N'4.0.7333.0')
SET IDENTITY_INSERT [dbo].[ComponentAttributeType] OFF
/****** Object:  Table [dbo].[ComponentGroup]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ComponentGroup](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[NameGroup] [varchar](50) NULL,
	[type] [varchar](50) NULL,
	[Url] [varchar](50) NULL,
 CONSTRAINT [PK_ComponentGroup] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ComponentGroup] ON
INSERT [dbo].[ComponentGroup] ([GroupId], [NameGroup], [type], [Url]) VALUES (1, N'Entities', N'Entities', N'Admin/IndexEntities.aspx')
SET IDENTITY_INSERT [dbo].[ComponentGroup] OFF
/****** Object:  Table [dbo].[State]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[State](
	[StateId] [int] IDENTITY(1,1) NOT NULL,
	[NameState] [varchar](50) NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[State] ON
INSERT [dbo].[State] ([StateId], [NameState]) VALUES (1, N'Active')
SET IDENTITY_INSERT [dbo].[State] OFF
/****** Object:  Table [dbo].[ComponentsData]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ComponentsData](
	[ComponentDataId] [int] IDENTITY(1,1) NOT NULL,
	[Fk_GroupId] [int] NULL,
	[DisplayName] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](150) NULL,
	[Customizable] [varchar](50) NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_ComponentEntities] PRIMARY KEY CLUSTERED 
(
	[ComponentDataId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ComponentsData] ON
INSERT [dbo].[ComponentsData] ([ComponentDataId], [Fk_GroupId], [DisplayName], [Name], [Description], [Customizable], [CreatedOn]) VALUES (32, 1, N'auto', N'auto', N'entidad auto', N'Customizable', CAST(0x0000A446009DF743 AS DateTime))
SET IDENTITY_INSERT [dbo].[ComponentsData] OFF
/****** Object:  Table [dbo].[Components]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Components](
	[ComponentId] [int] IDENTITY(1,1) NOT NULL,
	[Fk_GroupId] [int] NULL,
	[Fk_StateId] [int] NULL,
	[DisplayName] [nvarchar](50) NULL,
	[ComponentName] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[Url] [nvarchar](50) NULL,
 CONSTRAINT [PK_COMPONENTES] PRIMARY KEY CLUSTERED 
(
	[ComponentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Components] ON
INSERT [dbo].[Components] ([ComponentId], [Fk_GroupId], [Fk_StateId], [DisplayName], [ComponentName], [Description], [Url]) VALUES (23, 1, 1, N'auto', N'auto', N'entidad auto', N'EForms/frmFormList.aspx')
SET IDENTITY_INSERT [dbo].[Components] OFF
/****** Object:  Table [dbo].[ComponentProperty]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ComponentProperty](
	[PropertyId] [int] IDENTITY(1,1) NOT NULL,
	[FK_ComponentId] [int] NULL,
	[NameProperty] [varchar](50) NULL,
	[UrlProperty] [varchar](50) NULL,
 CONSTRAINT [PK_ComponentProperty] PRIMARY KEY CLUSTERED 
(
	[PropertyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ComponentProperty] ON
INSERT [dbo].[ComponentProperty] ([PropertyId], [FK_ComponentId], [NameProperty], [UrlProperty]) VALUES (77, 23, N'Forms', N'EForms/frmFormList.aspx')
INSERT [dbo].[ComponentProperty] ([PropertyId], [FK_ComponentId], [NameProperty], [UrlProperty]) VALUES (78, 23, N'Views', N'EViews/frmViewList.aspx')
INSERT [dbo].[ComponentProperty] ([PropertyId], [FK_ComponentId], [NameProperty], [UrlProperty]) VALUES (79, 23, N'Fields', N'EFields/frmFieldList.aspx')
INSERT [dbo].[ComponentProperty] ([PropertyId], [FK_ComponentId], [NameProperty], [UrlProperty]) VALUES (80, 23, N'Relations', N'ERelations/frmRelationList.aspx')
SET IDENTITY_INSERT [dbo].[ComponentProperty] OFF
/****** Object:  Table [dbo].[ComponentForms]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComponentForms](
	[ComponentFormId] [int] IDENTITY(1,1) NOT NULL,
	[Fk_ComponentId] [int] NULL,
	[Fk_StateId] [int] NULL,
	[FormName] [nvarchar](50) NULL,
	[FormType] [nvarchar](50) NULL,
	[CreateOn] [date] NULL,
	[Customizable] [nvarchar](50) NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_ComponentForms] PRIMARY KEY CLUSTERED 
(
	[ComponentFormId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ComponentForms] ON
INSERT [dbo].[ComponentForms] ([ComponentFormId], [Fk_ComponentId], [Fk_StateId], [FormName], [FormType], [CreateOn], [Customizable], [Description]) VALUES (27, 23, 1, N'Formulario Auto', N'Main', CAST(0xA1390B00 AS Date), N'Custom', N'Auto formulario description')
SET IDENTITY_INSERT [dbo].[ComponentForms] OFF
/****** Object:  Table [dbo].[ComponentAttribute]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComponentAttribute](
	[ComponentAttributeId] [int] IDENTITY(1,1) NOT NULL,
	[Fk_ComponentAttributeTypeId] [int] NULL,
	[Fk_ComponentId] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[PhysicalName] [nvarchar](100) NULL,
	[AttributeType] [nvarchar](50) NULL,
	[AttributeLogicalType] [nvarchar](100) NULL,
	[AttributeRequired] [bit] NULL,
	[Length] [int] NULL,
	[IsNullable] [bit] NULL,
	[IsIdentity] [bit] NULL,
	[IsHidden] [bit] NULL,
 CONSTRAINT [PK_ComponentAtribute] PRIMARY KEY CLUSTERED 
(
	[ComponentAttributeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ComponentAttribute] ON
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (43, 14, 23, N'codigoauto', N'codigoauto', N'Single Line of Text', N'Text', 1, 100, 0, 0, 1)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (44, 14, 23, N'marca', N'marca', N'Single Line of Text', N'Text', 1, 100, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (45, 6, 23, N'kilometraje', N'kilometraje', N'Decimal Number', N'', 0, 0, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (46, 14, 23, N'color', N'color', N'Option Set', N'', 0, 0, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (47, 14, 23, N'Tipo', N'Tipo', N'Option Set', N'', 0, 0, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (48, 7, 23, N'precio', N'precio', N'Floating Point Number', N'', 0, 0, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (49, 12, 23, N'Descripcion', N'descripcion', N'Multiple Line Of Text', N'', 0, 2000, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (50, 5, 23, N'fecha compra', N'FECHA_COMPRA', N'Date and Time', N'', 0, 2000, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (51, 5, 23, N'fecha', N'fecha_test', N'Date and Time', N'', 0, 2000, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (52, 14, 23, N'revisado', N'revisado', N'Two Options', N'', 0, 0, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (53, 9, 23, N'whole number', N'WHOLE_NUMBER', N'Whole Number', N'', 0, 0, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (54, 7, 23, N'floating number', N'floating_number', N'Floating Point Number', N'', 0, 0, 1, 0, 0)
INSERT [dbo].[ComponentAttribute] ([ComponentAttributeId], [Fk_ComponentAttributeTypeId], [Fk_ComponentId], [Name], [PhysicalName], [AttributeType], [AttributeLogicalType], [AttributeRequired], [Length], [IsNullable], [IsIdentity], [IsHidden]) VALUES (55, 5, 23, N'date time', N'date_time', N'Date and Time', N'0', 0, 2000, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[ComponentAttribute] OFF
/****** Object:  Table [dbo].[ComponentAttributeData]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComponentAttributeData](
	[AttributeDataId] [int] IDENTITY(1,1) NOT NULL,
	[Fk_ComponentAttributeId] [int] NULL,
	[FK_ComponentId] [int] NULL,
	[KeyValue] [nvarchar](50) NULL,
	[Value] [nvarchar](2000) NULL,
 CONSTRAINT [PK_ComponentAttributeData] PRIMARY KEY CLUSTERED 
(
	[AttributeDataId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ComponentAttributeData] ON
INSERT [dbo].[ComponentAttributeData] ([AttributeDataId], [Fk_ComponentAttributeId], [FK_ComponentId], [KeyValue], [Value]) VALUES (17, 45, 23, N'Whole Number', N'{"selectedValue":0,"minimum":0.0,"maximum":1000000000.0}')
INSERT [dbo].[ComponentAttributeData] ([AttributeDataId], [Fk_ComponentAttributeId], [FK_ComponentId], [KeyValue], [Value]) VALUES (18, 46, 23, N'Option Set', N'[{"values":1,"label":"blanco","description":"","$$hashKey":"015"},{"values":2,"label":"Negro","description":"","$$hashKey":"017"},{"values":3,"label":"Azul","description":"","$$hashKey":"019"},{"values":4,"label":"verde","description":"color verde","$$hashKey":"01B"},{"values":5,"label":"amarillo","description":"","$$hashKey":"01E"}]')
INSERT [dbo].[ComponentAttributeData] ([AttributeDataId], [Fk_ComponentAttributeId], [FK_ComponentId], [KeyValue], [Value]) VALUES (19, 47, 23, N'Option Set', N'[{"values":1,"label":"Auto","description":"","$$hashKey":"01Q"},{"values":2,"label":"vagoneta","description":"","$$hashKey":"01S"},{"values":3,"label":"camion","description":"","$$hashKey":"01U"}]')
INSERT [dbo].[ComponentAttributeData] ([AttributeDataId], [Fk_ComponentAttributeId], [FK_ComponentId], [KeyValue], [Value]) VALUES (20, 48, 23, N'Whole Number', N'{"selectedValue":0,"minimum":0.0,"maximum":1000000000.0}')
INSERT [dbo].[ComponentAttributeData] ([AttributeDataId], [Fk_ComponentAttributeId], [FK_ComponentId], [KeyValue], [Value]) VALUES (21, 52, 23, N'Two Options', N'[{"values":0,"label":"No","defaultValue":true,"$$hashKey":"019"},{"values":1,"label":"Si","defaultValue":false,"$$hashKey":"01A"}]')
INSERT [dbo].[ComponentAttributeData] ([AttributeDataId], [Fk_ComponentAttributeId], [FK_ComponentId], [KeyValue], [Value]) VALUES (22, 53, 23, N'Whole Number', N'{"selectedValue":0,"minimum":-2147483648.0,"maximum":2147483647.0}')
INSERT [dbo].[ComponentAttributeData] ([AttributeDataId], [Fk_ComponentAttributeId], [FK_ComponentId], [KeyValue], [Value]) VALUES (23, 54, 23, N'Floating Point Number', N'{"selectedValue":0,"minimum":20.0,"maximum":1000000000.0}')
SET IDENTITY_INSERT [dbo].[ComponentAttributeData] OFF
/****** Object:  Table [dbo].[AttributeLocation]    Script Date: 04/01/2015 16:42:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeLocation](
	[AttributeLocationId] [int] IDENTITY(1,1) NOT NULL,
	[Fk_ComponentFormId] [int] NULL,
	[Fk_ComponentAttributeId] [int] NULL,
	[Location] [nvarchar](50) NULL,
	[Position] [int] NULL,
 CONSTRAINT [PK_AttributeLocation] PRIMARY KEY CLUSTERED 
(
	[AttributeLocationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AttributeLocation] ON
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (108, 27, 44, N'Header', 1)
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (109, 27, 47, N'Header', 2)
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (110, 27, 44, N'Body', 1)
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (111, 27, 45, N'Body', 2)
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (112, 27, 46, N'Body', 3)
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (113, 27, 48, N'Body', 4)
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (114, 27, 49, N'Body', 5)
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (115, 27, 50, N'Body', 6)
INSERT [dbo].[AttributeLocation] ([AttributeLocationId], [Fk_ComponentFormId], [Fk_ComponentAttributeId], [Location], [Position]) VALUES (116, 27, 47, N'Body', 7)
SET IDENTITY_INSERT [dbo].[AttributeLocation] OFF
/****** Object:  ForeignKey [FK_AttributeLocation_ComponentAttribute]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[AttributeLocation]  WITH CHECK ADD  CONSTRAINT [FK_AttributeLocation_ComponentAttribute] FOREIGN KEY([Fk_ComponentAttributeId])
REFERENCES [dbo].[ComponentAttribute] ([ComponentAttributeId])
GO
ALTER TABLE [dbo].[AttributeLocation] CHECK CONSTRAINT [FK_AttributeLocation_ComponentAttribute]
GO
/****** Object:  ForeignKey [FK_AttributeLocation_ComponentForms]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[AttributeLocation]  WITH CHECK ADD  CONSTRAINT [FK_AttributeLocation_ComponentForms] FOREIGN KEY([Fk_ComponentFormId])
REFERENCES [dbo].[ComponentForms] ([ComponentFormId])
GO
ALTER TABLE [dbo].[AttributeLocation] CHECK CONSTRAINT [FK_AttributeLocation_ComponentForms]
GO
/****** Object:  ForeignKey [FK_ComponentAtribute_ComponentAtributeType]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[ComponentAttribute]  WITH CHECK ADD  CONSTRAINT [FK_ComponentAtribute_ComponentAtributeType] FOREIGN KEY([Fk_ComponentAttributeTypeId])
REFERENCES [dbo].[ComponentAttributeType] ([ComponentAtributeTypeId])
GO
ALTER TABLE [dbo].[ComponentAttribute] CHECK CONSTRAINT [FK_ComponentAtribute_ComponentAtributeType]
GO
/****** Object:  ForeignKey [FK_ComponentAttribute_Components]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[ComponentAttribute]  WITH CHECK ADD  CONSTRAINT [FK_ComponentAttribute_Components] FOREIGN KEY([Fk_ComponentId])
REFERENCES [dbo].[Components] ([ComponentId])
GO
ALTER TABLE [dbo].[ComponentAttribute] CHECK CONSTRAINT [FK_ComponentAttribute_Components]
GO
/****** Object:  ForeignKey [FK_ComponentAttributeData_ComponentAttribute]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[ComponentAttributeData]  WITH CHECK ADD  CONSTRAINT [FK_ComponentAttributeData_ComponentAttribute] FOREIGN KEY([Fk_ComponentAttributeId])
REFERENCES [dbo].[ComponentAttribute] ([ComponentAttributeId])
GO
ALTER TABLE [dbo].[ComponentAttributeData] CHECK CONSTRAINT [FK_ComponentAttributeData_ComponentAttribute]
GO
/****** Object:  ForeignKey [FK_ComponentForms_Components]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[ComponentForms]  WITH CHECK ADD  CONSTRAINT [FK_ComponentForms_Components] FOREIGN KEY([Fk_ComponentId])
REFERENCES [dbo].[Components] ([ComponentId])
GO
ALTER TABLE [dbo].[ComponentForms] CHECK CONSTRAINT [FK_ComponentForms_Components]
GO
/****** Object:  ForeignKey [FK_ComponentProperty_Components]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[ComponentProperty]  WITH CHECK ADD  CONSTRAINT [FK_ComponentProperty_Components] FOREIGN KEY([FK_ComponentId])
REFERENCES [dbo].[Components] ([ComponentId])
GO
ALTER TABLE [dbo].[ComponentProperty] CHECK CONSTRAINT [FK_ComponentProperty_Components]
GO
/****** Object:  ForeignKey [FK_Components_ComponentGroup]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[Components]  WITH CHECK ADD  CONSTRAINT [FK_Components_ComponentGroup] FOREIGN KEY([Fk_GroupId])
REFERENCES [dbo].[ComponentGroup] ([GroupId])
GO
ALTER TABLE [dbo].[Components] CHECK CONSTRAINT [FK_Components_ComponentGroup]
GO
/****** Object:  ForeignKey [FK_Components_State]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[Components]  WITH CHECK ADD  CONSTRAINT [FK_Components_State] FOREIGN KEY([Fk_StateId])
REFERENCES [dbo].[State] ([StateId])
GO
ALTER TABLE [dbo].[Components] CHECK CONSTRAINT [FK_Components_State]
GO
/****** Object:  ForeignKey [FK_ComponentsData_ComponentGroup]    Script Date: 04/01/2015 16:42:50 ******/
ALTER TABLE [dbo].[ComponentsData]  WITH CHECK ADD  CONSTRAINT [FK_ComponentsData_ComponentGroup] FOREIGN KEY([Fk_GroupId])
REFERENCES [dbo].[ComponentGroup] ([GroupId])
GO
ALTER TABLE [dbo].[ComponentsData] CHECK CONSTRAINT [FK_ComponentsData_ComponentGroup]
GO
