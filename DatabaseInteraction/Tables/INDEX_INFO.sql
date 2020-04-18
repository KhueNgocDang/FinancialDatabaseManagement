create table INDEX_INFO(
	[Exchange_Ticker][varchar](5) Foreign key references EXCHANGE_INFO(Exchange_Ticker),
	[Day][date] ,
	[Closed Adjusted INDEX] real,
	Primary key([Day],[Exchange_Ticker]),
);