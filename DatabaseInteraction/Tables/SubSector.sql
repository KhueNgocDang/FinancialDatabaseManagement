create table SubSector(
	[SubSector_CODE][varchar](4) Primary key,
	[SubSector][varchar](50),
	[Ind_CODE][varchar](4) Foreign key references Industry(Ind_CODE),
	[SuperSector_CODE][varchar](4) Foreign key references SuperSector(SuperSector_CODE),
	[Sector_CODE][varchar](4) Foreign key references Sector(Sector_CODE),
);