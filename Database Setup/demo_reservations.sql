delete from Area
delete from Rental
delete from Video
delete from Store
delete from Reservation
delete from Customer
delete from ZipCode
go

insert into ZipCode values ('49423', 'Holland', 'MI')
insert into ZipCode values ('49464', 'Zeeland', 'MI')

set identity_insert Customer on
insert into Customer (CID, Title, FirstName, LastName, StreetAddress, ZipCode, Password)
values (1, 'Mr.', 'Ryan', 'McFall', '1260 Winterwood Lane', '49464', 'Password')

insert into Customer (CID, Title, FirstName, LastName, StreetAddress, ZipCode, Password)
values (2, 'Mrs.', 'Leanne', 'McFall', '1260 Winterwood Lane', '49464', 'Password2')

insert into Customer (CID, Title, FirstName, LastName, StreetAddress, ZipCode, Password)
values (3, 'Ms.', 'Lauryn', 'McFall', '1260 Winterwood Lane', '49464', 'Password3')

set identity_insert Customer off

set identity_insert Store on
insert into Store (StoreID, StreetAddress, PhoneNumber, ZipCode)
values (1, 'Store1', '395-7000', '49423')
set identity_insert Store off

set identity_insert Video on
insert into Video (VideoID, MovieID, StoreID, NewArrival)
values (1, 100944, @@identity, 1)
set identity_insert Video off

insert into Rental (CustomerID, VideoID)
values (3, 1)

insert into Reservation (CustomerID, MovieID) values (1, 100944)

insert into Reservation (CustomerID, MovieID) values (2, 100944)

select * from Reservation

update Rental
set ReturnDate = getdate()
where CustomerID = 3 and VideoID = 1


select * from Rental

select * from Reservation
