CREATE TABLE [dbo].[EXCHANGE_INFO] (
    [Name]            VARCHAR (50) NULL,
    [Exchange_Ticker] VARCHAR (5)  NOT NULL,
    [INDEX]           VARCHAR (15) NULL,
    PRIMARY KEY CLUSTERED ([Exchange_Ticker] ASC)
);