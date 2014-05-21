IF EXISTS (SELECT * FROM sysobjects WHERE type = 'V' AND name = 'CustomerInStoreArea')
	BEGIN
		DROP  View CustomerInStoreArea
	END
GO

CREATE View CustomerInStoreArea AS
  WITH StoreAreas (StoreID, AreaID, AreaName) 
  as
  (
    select StoreID, Area.AreaID, Name
    from Store 
    inner join AreaZipCode on Store.ZipCode = AreaZipCode.ZipCode
    inner join Area on Area.AreaID = AreaZipCode.AreaID
    
  )
  SELECT AreaName, Store.StoreID, Customer.FirstName, Customer.LastName, Customer.StreetAddress AS CustomerStreet, 
    Customer.City AS CustomerCity, Customer.State AS CustomerState, Customer.ZipCode AS CustomerZipCode,
    Store.StreetAddress AS StoreStreet, Store.City AS StoreCity, Store.State AS StoreState, Store.ZipCode AS StoreZipCode
  FROM StoreWithAddress as Store
  inner join StoreAreas on Store.StoreID = StoreAreas.StoreID
  inner join AreaZipCode on AreaZipCode.AreaID = StoreAreas.AreaID
  inner join CustomerWithAddress as Customer on Customer.ZipCode = AreaZipCode.ZipCode
  
  
  

GO


