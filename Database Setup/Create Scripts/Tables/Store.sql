IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Store')
	BEGIN
		DROP  Table Store
	END
GO

CREATE TABLE Store
(  
   StoreID T_StoreID not null identity primary key,
   StoreName T_StoreName not null,
   StreetAddress T_Address not null,
   PhoneNumber T_PhoneNumber not null,
   ZipCode T_ZipCode foreign key references ZipCode (Code)
)
GO