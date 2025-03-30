CREATE TABLE [dbo].[Reservation] (
    [Reservation_ID] INT          IDENTITY (1, 1) NOT NULL,
    [Hall_ID]        INT          NOT NULL,
    [User_ID]        INT          NULL,
    [R_Req_ID]       INT          NOT NULL,
    [Status]         VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Reservation_ID] ASC),
    CONSTRAINT [FK_R_H] FOREIGN KEY ([Hall_ID]) REFERENCES [dbo].[Hall] ([Hall_ID]),
    CONSTRAINT [FK_R_U] FOREIGN KEY ([User_ID]) REFERENCES [dbo].[User] ([User_ID]),
    CONSTRAINT [FK_R_R_Req] FOREIGN KEY ([R_Req_ID]) REFERENCES [dbo].[R_Request] ([R_Req_ID])
);

