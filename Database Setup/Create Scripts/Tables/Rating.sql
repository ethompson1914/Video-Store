IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Rating')
	BEGIN
		DROP  Table Rating
	END
GO

CREATE TABLE Rating
(
   RatingID numeric (6, 0) identity not null primary key,
   CustomerID T_CustomerID not null,
   VideoID T_VideoID not null,
   Score smallint not null check (Score >= 1 and Score <=5),
   Comment varchar(2048),
   foreign key (CustomerID, VideoID) references Rental(CustomerID, VideoID)
)
GO
