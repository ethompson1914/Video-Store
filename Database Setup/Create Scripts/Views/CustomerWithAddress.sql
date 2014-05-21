IF EXISTS (SELECT * FROM sysobjects WHERE type = 'V' AND name = 'CustomerWithAddress')
	BEGIN
		DROP  View CustomerWithAddress
	END
GO

CREATE View CustomerWithAddress AS

  select Customer.*, City, State
  from Customer 
  inner join ZipCode on Customer.ZipCode = ZipCode.Code


GO


