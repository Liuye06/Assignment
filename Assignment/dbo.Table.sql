CREATE TABLE [dbo].[Order]
(
	[Order_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Quantity] INT NOT NULL, 
    [Time] TIME NOT NULL, 
    [Date] DATE NOT NULL, 
    [Status] VARCHAR(50) NOT NULL, 
    [Request] VARCHAR(MAX) NULL, 
    [Item_ID] INT NOT NULL, 
    [User_ID] INT NOT NULL, 
    CONSTRAINT [FK_O_M] FOREIGN KEY ([Item_ID]) REFERENCES [Menu]([Item_ID]), 
    CONSTRAINT [FK_O_U] FOREIGN KEY ([User_ID]) REFERENCES [User]([User_ID]), 

)
