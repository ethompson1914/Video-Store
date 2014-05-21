IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Area')
	BEGIN
		DROP  Table Area
	END
GO

CREATE TABLE Area
(
   AreaID numeric(3, 0) not null identity primary key,
   Name varchar(50) not null unique
)
GO
