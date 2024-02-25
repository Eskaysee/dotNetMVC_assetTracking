/*
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
    (4, 'Outdoor', 2);

-- Inserting data into Firmware table
INSERT INTO Firmware (FirmwareId, Name, Version, ReleaseDate)
VALUES
    (1, 'Watcher', 'v1.0', '2000-01-01'),
    (2, 'Finder', 'v1.0', '2000-01-01'),
    (3, 'Watcher', 'v1.1', '2000-03-15'),
    (4, 'Finder', 'v2.0', '2001-02-03');
