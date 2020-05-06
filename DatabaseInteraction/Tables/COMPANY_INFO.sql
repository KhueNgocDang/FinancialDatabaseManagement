CREATE TABLE [dbo].[COMPANY_INFO] (
    [Company_Ticker]   VARCHAR (10) NOT NULL,
    [Company]          VARCHAR (60) NULL,
    [Exchange_ticker]  VARCHAR (5)  NULL,
    [Ind_CODE]         VARCHAR (4)  NULL,
    [SuperSector_CODE] VARCHAR (4)  NULL,
    [Sector_CODE]      VARCHAR (4)  NULL,
    [SubSector_CODE]   VARCHAR (4)  NULL,
    PRIMARY KEY CLUSTERED ([Company_Ticker] ASC),
    FOREIGN KEY ([Exchange_ticker]) REFERENCES [dbo].[EXCHANGE_INFO] ([Exchange_Ticker]),
    FOREIGN KEY ([Ind_CODE]) REFERENCES [dbo].[Industry] ([Ind_CODE]),
    FOREIGN KEY ([SuperSector_CODE]) REFERENCES [dbo].[SuperSector] ([SuperSector_CODE]),
    FOREIGN KEY ([Sector_CODE]) REFERENCES [dbo].[SuperSector] ([SuperSector_CODE]),
    FOREIGN KEY ([SubSector_CODE]) REFERENCES [dbo].[SubSector] ([SubSector_CODE])
);