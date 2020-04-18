create table ITEM_FACT(
	[Item_ID][varchar](4) Foreign key references ITEM_SETTING([Item_ID]),
	[TICKER][varchar](10) Foreign key references COMPANY_INFO(Company_Ticker),
	[YEAR][int],
	[Value][bigint],
	Primary key([YEAR],[Item_ID],[TICKER]),
);