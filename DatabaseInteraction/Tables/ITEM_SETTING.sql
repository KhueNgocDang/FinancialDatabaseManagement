CREATE TABLE [dbo].[ITEM_SETTING] (
    [ENTRY_ID]         VARCHAR (13)  NULL,
    [Item_ID]          VARCHAR (4)   NOT NULL,
    [Item_Order]       INT           NULL,
    [Item_Description] VARCHAR (MAX) NULL,
    [Item_Properties]  VARCHAR (MAX) NULL,
    [Item_Tile]        VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Item_ID] ASC),
    FOREIGN KEY ([ENTRY_ID]) REFERENCES [dbo].[STATEMENT_ENTRIES] ([ENTRY_ID])
);