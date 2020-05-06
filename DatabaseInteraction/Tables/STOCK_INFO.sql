CREATE TABLE [dbo].[STOCK_INFO] (
    [Company_Ticker]        VARCHAR (10) NOT NULL,
    [Day]                   DATE         NOT NULL,
    [Closed Adjusted Price] DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([Day] ASC, [Company_Ticker] ASC),
    FOREIGN KEY ([Company_Ticker]) REFERENCES [dbo].[COMPANY_INFO] ([Company_Ticker])
);