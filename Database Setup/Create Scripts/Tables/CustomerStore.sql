IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'CustomerStore')
	BEGIN
		DROP  Table CustomerStore
	END
GO

CREATE TABLE CustomerStore
(
   CustomerID T_CustomerID not null foreign key references Customer (CID),
   StoreID T_CustomerID not null foreign key references Store (StoreID),
   StoreOrder smallint not null,
   primary key (CustomerID, StoreID)
)
GO
