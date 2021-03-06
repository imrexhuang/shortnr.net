USE [shortnr]
GO
/****** Object:  Table [dbo].[short_urls]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[short_urls](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[long_url] [varchar](1000) NOT NULL,
	[segment] [varchar](20) NOT NULL,
	[added] [datetime] NOT NULL,
	[ip] [varchar](50) NOT NULL,
	[num_of_clicks] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stats]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stats](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[click_date] [datetime] NOT NULL,
	[ip] [varchar](50) NOT NULL,
	[referer] [varchar](500) NULL,
	[shortUrl_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[short_urls] ON 

INSERT [dbo].[short_urls] ([id], [long_url], [segment], [added], [ip], [num_of_clicks]) VALUES (1, N'https://github.com/dukeofharen/shortnr.net', N'13f6c8', CAST(N'2018-12-05T22:39:45.000' AS DateTime), N'::1', 1)
SET IDENTITY_INSERT [dbo].[short_urls] OFF

/****** Object:  Index [idxstats_shortUrl_id]   ******/
CREATE NONCLUSTERED INDEX [idxstats_shortUrl_id] ON [dbo].[stats]
(
	[shortUrl_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
