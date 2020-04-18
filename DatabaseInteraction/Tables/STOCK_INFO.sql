create table STOCK_INFO(
	[Company_Ticker][varchar](10) Foreign key references COMPANY_INFO(Company_Ticker),
	[Day][date] ,
	[Closed Adjusted Price]real,
	Primary key([Day],[Company_Ticker]),
);