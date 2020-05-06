CREATE TABLE [dbo].[Sector] (
    [Sector_CODE]      VARCHAR (4)  NOT NULL,
    [Sector]           VARCHAR (50) NULL,
    [Ind_CODE]         VARCHAR (4)  NULL,
    [SuperSector_CODE] VARCHAR (4)  NULL,
    PRIMARY KEY CLUSTERED ([Sector_CODE] ASC),
    FOREIGN KEY ([Ind_CODE]) REFERENCES [dbo].[Industry] ([Ind_CODE]),
    FOREIGN KEY ([SuperSector_CODE]) REFERENCES [dbo].[SuperSector] ([SuperSector_CODE])
);