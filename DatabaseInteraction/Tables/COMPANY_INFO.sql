create table COMPANY_INFO(
	[Company_Ticker][varchar](10) Primary key,
	[Company][varchar](60),
	[Exchange_ticker][varchar](5) Foreign key references EXCHANGE_INFO(Exchange_Ticker),
	[Ind_CODE][varchar](4) Foreign key references Industry(Ind_CODE),
	[SuperSector_CODE][varchar](4) Foreign key references SuperSector(SuperSector_CODE),
	[Sector_CODE][varchar](4) Foreign key references SuperSector(SuperSector_CODE),
	[SubSector_CODE][varchar](4) Foreign key references SubSector(SubSector_CODE),
);