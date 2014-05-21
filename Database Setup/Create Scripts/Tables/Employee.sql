IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Employee')
	BEGIN
		DROP  Table Employee
	END
GO

CREATE TABLE Employee
(
  EmployeeID T_EmployeeID not null identity primary key,
  FirstName T_FirstName not null,
  LastName T_LastName not null,
  DateOfHire datetime not null default getdate (),
  DateOfBirth datetime not null,
  SupervisorID T_EmployeeID not null
    foreign key references Employee (EmployeeID)
)
GO
