CREATE TABLE [dbo].[SubSector] (
    [SubSector_CODE]   VARCHAR (4)  NOT NULL,
    [SubSector]        VARCHAR (50) NULL,
    [Ind_CODE]         VARCHAR (4)  NULL,
    [SuperSector_CODE] VARCHAR (4)  NULL,
    [Sector_CODE]      VARCHAR (4)  NULL,
    PRIMARY KEY CLUSTERED ([SubSector_CODE] ASC),
    FOREIGN KEY ([Ind_CODE]) REFERENCES [dbo].[Industry] ([Ind_CODE]),
    FOREIGN KEY ([SuperSector_CODE]) REFERENCES [dbo].[SuperSector] ([SuperSector_CODE]),
    FOREIGN KEY ([Sector_CODE]) REFERENCES [dbo].[Sector] ([Sector_CODE])
);