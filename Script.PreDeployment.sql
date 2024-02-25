﻿/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
-- Inserting data into DeviceType table
INSERT INTO DeviceGroup (Id, Name, ParentGroupId)
VALUES
    (1, 'SensorDevice', NULL),
    (2, 'TrackerDevice', NULL),
    (3, 'Indoor', 1),
    (4, 'Outdoor', 2),
    (5, 'Battery', 2),
    (6, 'Wired', 3);

-- Inserting data into Firmware table
INSERT INTO Firmware (Id, Name, Version, ReleaseDate)
VALUES
    (1, 'MonitorMyAsset', 'v1.0', '2000-01-01'),
    (2, 'LocateMyAsset', 'v1.0', '2000-01-01'),
    (3, 'MonitorMyAsset', 'v1.1', '2000-03-15'),
    (4, 'LocateMyAsset', 'v2.0', '2001-02-03');

INSERT INTO Device (Id, Name, GroupId, FirmwareId)
VALUES
    (1,'Finder',4,2),
    (2,'Watcher',6,1),
    (3,'Locator',2,4);