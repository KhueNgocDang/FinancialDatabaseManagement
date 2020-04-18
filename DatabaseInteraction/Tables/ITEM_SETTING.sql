create table ITEM_SETTING(
	[ENTRY_ID][varchar](13) Foreign key references STATEMENT_ENTRIES([ENTRIES_ID]),
	[Item_ID][varchar](4) Primary key,
	[Item_Order][int],
	[Item_Description][varchar](max),
	[Item_Properties][varchar](max),
	[Item_Title][varchar](255),
);