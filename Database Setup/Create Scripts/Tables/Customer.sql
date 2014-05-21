IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Customer')
	BEGIN
		DROP  Table Customer
	END
GO

CREATE TABLE Customer
(
   CID T_CustomerID not null identity primary key,
   Title varchar(10) not null,
   FirstName T_FirstName,
   LastName T_LastName not null,
   StreetAddress T_Address not null,
   ZipCode T_ZipCode foreign key references ZipCode (Code),
   EmailAddress T_EmailAddress null,
   Password varchar(50) not null
)
GO

