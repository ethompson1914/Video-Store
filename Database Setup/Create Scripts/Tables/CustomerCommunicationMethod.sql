IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'CustomerCommunicationMethod')
	BEGIN
		DROP  Table CustomerCommunicationMethod
	END
GO

CREATE TABLE CustomerCommunicationMethod
(
	CustomerID T_CustomerID not null foreign key references Customer (CID),
	CommunicationMethod T_CommunicationMethod not null
	  foreign key references CommunicationMethod (Name),
	primary key (CustomerID, CommunicationMethod)
)
GO

