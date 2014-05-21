drop type T_EmployeeID
go
create type T_EmployeeID 
from numeric (5,0)
go

drop type T_CustomerID
go
create type T_CustomerID
from numeric (6,0)
go

drop type T_AreaID
go
create type T_AreaID
from numeric (3, 0)
go

drop type T_VideoID
go
create type T_VideoID
from numeric(5, 0)
go

drop type T_Address
go
create type T_Address 
from varchar(50)
go

drop type T_FirstName
go
create type T_FirstName
from varchar(35)
go

drop type T_LastName
go
create type T_LastName
from varchar(50)
go

drop type T_EmailAddress
go
create type T_EmailAddress
from varchar(50) 
go

drop type T_ZipCode
go
create type T_ZipCode
from char(9)
go

drop type T_City
go
create type T_City
from varchar(30)
go

drop type T_State
go
create type T_State
from char(2)
go

drop type T_PhoneNumber
go
create type T_PhoneNumber
from char(10)
go

drop type T_CommunicationMethod
go
create type T_CommunicationMethod
from varchar(25)
go

drop type T_StoreID
go
create type T_StoreID
from numeric (5, 0)
go

drop type T_StoreName
go
create type T_StoreName
from varchar(35)
go

