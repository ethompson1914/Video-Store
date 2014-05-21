IF EXISTS (SELECT * FROM sysobjects WHERE type = 'V' AND name = 'LateRental')
	BEGIN
		DROP  View LateRental
	END
GO

CREATE View LateRental AS

SELECT Customer.FirstName, Customer.LastName, Customer.StreetAddress AS CustomerStreet, Customer.City AS CustomerCity, 
  Customer.State AS CustomerState, Customer.ZipCode AS CustomerZipCode, Rental.RentalDate, Rental.DueDate, Movies.MovieTitle, 
  Store.StreetAddress AS StoreStreet, Store.City AS StoreCity, Store.State AS StoreState, Store.ZipCode AS StoreZipCode
FROM CustomerWithAddress as Customer
INNER JOIN Rental ON Rental.CustomerID = Customer.CID 
INNER JOIN Video ON Rental.VideoID = Video.VideoID 
INNER JOIN Movies ON Video.MovieID = Movies.MovieID 
INNER JOIN StoreWithAddress as Store ON Store.StoreID = Video.StoreID
where getdate() > DueDate
  and ReturnDate is null                           
GO

