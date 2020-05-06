CREATE TABLE [dbo].[SuperSector] (
    [SuperSector_CODE] VARCHAR (4)  NOT NULL,
    [SuperSector]      VARCHAR (50) NULL,
    [Ind_CODE]         VARCHAR (4)  NULL,
    PRIMARY KEY CLUSTERED ([SuperSector_CODE] ASC),
    FOREIGN KEY ([Ind_CODE]) REFERENCES [dbo].[Industry] ([Ind_CODE])
);