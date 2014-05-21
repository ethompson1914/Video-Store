IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'AreaZipCode')
	BEGIN
		DROP  Table AreaZipCode
	END
GO

CREATE TABLE AreaZipCode
(
	AreaID T_AreaID not null foreign key references Area (AreaID),
	ZipCode T_ZipCode not null foreign key references ZipCode (Code),
	primary key (AreaID, ZipCode)
)
GO
