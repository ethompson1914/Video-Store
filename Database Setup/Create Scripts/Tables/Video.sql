IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Video')
	BEGIN
		DROP  Table Video
	END
GO

CREATE TABLE Video
(
   VideoID T_VideoID not null identity primary key,
   MovieID int not null foreign key references Movies (MovieID),
   StoreID T_StoreID not null foreign key references Store(StoreID),
   NewArrival bit not null default 1,
   DatePurchased datetime not null default getdate ()
)
GO

