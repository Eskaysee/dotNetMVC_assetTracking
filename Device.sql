CREATE TABLE [dbo].[Device]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(255),
	[TypeId] INT,
	[GroupId] INT,
	[FirmwareId] INT,
	FOREIGN KEY (TypeId) REFERENCES DeviceType(Id),
	FOREIGN KEY (GroupId) REFERENCES DeviceGroup(Id),
	FOREIGN KEY (FirmwareId) REFERENCES Firmware(Id)
)
