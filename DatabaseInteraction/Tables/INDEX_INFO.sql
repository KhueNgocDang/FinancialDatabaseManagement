CREATE TABLE [dbo].[INDEX_INFO] (
    [Exchange_Ticker]       VARCHAR (5) NOT NULL,
    [Day]                   DATE        NOT NULL,
    [Closed Adjusted INDEX] REAL        NULL,
    PRIMARY KEY CLUSTERED ([Day] ASC, [Exchange_Ticker] ASC),
    FOREIGN KEY ([Exchange_Ticker]) REFERENCES [dbo].[EXCHANGE_INFO] ([Exchange_Ticker])
);