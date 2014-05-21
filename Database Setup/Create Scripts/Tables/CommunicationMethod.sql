IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'CommunicationMethod')
	BEGIN
		DROP  Table CommunicationMethod
	END
GO

CREATE TABLE CommunicationMethod
(
	Name T_CommunicationMethod not null primary key,
	Frequency smallint not null   
)
GO

