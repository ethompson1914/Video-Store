IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Rental')
	BEGIN
		DROP  Table Rental
	END
GO

CREATE TABLE Rental
(
   CustomerID T_CustomerID not null foreign key references Customer(CID),
   VideoID T_VideoID not null foreign key references Video (VideoID),
   RentalDate datetime not null default getdate (),
   DueDate datetime not null default dateadd(day, 7, getdate()),
   ReturnDate datetime null 
   primary key (CustomerID, VideoID)
)
GO

alter table Rental
add constraint CheckReturnDate CHECK (ReturnDate >= RentalDate)
go