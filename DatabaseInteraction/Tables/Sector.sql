create table Sector(
	[Sector_CODE][varchar](4) Primary key,
	[Sector][varchar](50),
	[Ind_CODE][varchar](4) Foreign key references Industry(Ind_CODE),
	[SuperSector_CODE][varchar](4) Foreign key references SuperSector(SuperSector_CODE),
);