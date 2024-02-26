CREATE TABLE [dbo].[Device]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(255) NOT NULL,
	[GroupId] INT NOT NULL,
	[FirmwareId] INT NOT NULL,
	FOREIGN KEY (GroupId) REFERENCES DeviceGroup(Id),
	FOREIGN KEY (FirmwareId) REFERENCES Firmware(Id)
)
