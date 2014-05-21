IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'ZipCode')
	BEGIN
		DROP  Table ZipCode
	END
GO

CREATE TABLE ZipCode
(
   Code T_ZipCode not null primary key,
   City T_City not null,
   State T_State not null
)
GO

