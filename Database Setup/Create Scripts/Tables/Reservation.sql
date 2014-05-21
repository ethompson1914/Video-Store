IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Reservation')
	BEGIN
		DROP  Table Reservation
	END
GO

CREATE TABLE Reservation
(
   CustomerID T_CustomerID not null primary key foreign key references Customer(CID),
   MovieID int not null foreign key references Movies (MovieID),
   ReservationDate datetime not null default getdate ()
)
GO
