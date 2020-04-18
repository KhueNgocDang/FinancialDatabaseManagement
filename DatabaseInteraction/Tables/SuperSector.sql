create table SuperSector(
	[SuperSector_CODE][varchar](4) Primary key,
	[SuperSector][varchar](50),
	[Ind_CODE][varchar](4) Foreign key references Industry(Ind_CODE),
);