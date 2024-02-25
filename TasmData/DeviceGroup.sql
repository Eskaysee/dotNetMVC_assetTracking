CREATE TABLE [dbo].[DeviceGroup]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(255) NOT NULL,
    [ParentGroupId] INT,
    FOREIGN KEY (ParentGroupId) REFERENCES DeviceGroup(Id)
)
