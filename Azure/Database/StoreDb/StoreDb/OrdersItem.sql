CREATE TABLE [dbo].[OrdersItem]
(
	[OrdersItemId] INT NOT NULL IDENTITY PRIMARY KEY,
	[ItemId] int not  null,
	[OrderId] int  not   null
)
