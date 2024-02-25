CREATE TABLE [dbo].[Device]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(255),
	[GroupId] INT,
	[FirmwareId] INT,
	FOREIGN KEY (GroupId) REFERENCES DeviceGroup(Id),
	FOREIGN KEY (FirmwareId) REFERENCES Firmware(Id)
)
