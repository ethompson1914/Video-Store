IF EXISTS (SELECT * FROM sysobjects WHERE type = 'TR' AND name = 'UpdateRentalReturnDate')
	BEGIN
		DROP  Trigger UpdateRentalReturnDate
	END
GO

CREATE Trigger UpdateRentalReturnDate ON Rental
FOR UPDATE AS 

	if update(ReturnDate)
	begin
	  insert into Rental (CustomerID, VideoID)
	  select top 1 Reservation.CustomerID, inserted.VideoID
	  from inserted
	  inner join Video on inserted.VideoID = Video.VideoID
	  inner join Reservation on Video.MovieID = Reservation.MovieID	  
	  where ReservationDate = (
	    select min(ReservationDate)
	    from Reservation R2	    
	    where Reservation.MovieID = R2.MovieID
	  )
	  
	  delete Reservation
	  from inserted, Rental, Video, Movies
	  where Rental.VideoID = inserted.VideoID
	    and Video.VideoID = inserted.VideoID
	    and Movies.MovieID = Video.MovieID
	    and Reservation.MovieID = Video.MovieID
	    and Reservation.CustomerID = Rental.CustomerID
	    and Rental.ReturnDate is null
	    	  	  
	end

GO

