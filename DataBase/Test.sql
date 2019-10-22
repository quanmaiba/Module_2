SELECT serverproperty('ComputerNamePhysicalNetBIOS');
SELECT @@VERSION;
SELECT @@SERVERNAME;
SELECT @@SERVICENAME;
SELECT * FROM fn_virtualservernodes();
SELECT * INTO newTable FROM dbo.ChiNhanh;
SELECT * FROM dbo.sysdiagrams;
UPDATE  dbo.sysdiagrams SET name = 'B' OUTPUT INSERTED.* WHERE principal_id = 1;
SELECT TOP 10 NgayBatDau FROM dbo.ChiNhanh;
SELECT CAST('ABC' AS CHAR(10));
DECLARE @GUID UNIQUEIDENTIFIER = NEWID();
ALTER TABLE dbo.sysdiagrams ADD ten INT ;
SELECT * FROM dbo.sysdiagrams ORDER BY UnitPrice DESC OFFSET 5 ROWS FETCH FIRST 10 ROWS ONLY
