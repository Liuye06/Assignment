CREATE TABLE [dbo].[Hall] (
    [Hall_ID]         INT             IDENTITY (1, 1) NOT NULL,
    [Hall_Name]       VARCHAR (50)    NOT NULL,
    [Capacity]        INT             NOT NULL,
    [Price_P_Day(RM)] MONEY NOT NULL,
    [Availability]    VARCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Hall_ID] ASC)
);

