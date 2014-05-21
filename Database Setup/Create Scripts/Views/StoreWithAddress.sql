IF EXISTS (SELECT * FROM sysobjects WHERE type = 'V' AND name = 'StoreWithAddress')
	BEGIN
		DROP  View StoreWithAddress
	END
GO

CREATE View StoreWithAddress AS
	select Store.*, City, State
  from Store 
  inner join ZipCode on Store.ZipCode = ZipCode.Code
GO
