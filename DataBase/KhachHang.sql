CREATE TABLE KhachHang
(
	KhachHangID INT IDENTITY(400,1),
	TenKhachHang NVARCHAR (50) NOT NULL,
	ChiNhanhID INT NOT NULL ,
	PRIMARY KEY(KhachHangID),	
);
ALTER TABLE dbo.KhanhHang ADD FOREIGN KEY(ChiNhanhID) REFERENCES dbo.ChiNhanh(ChiNhanhID);




SELECT * FROM dbo.KhachHang;
--DROP TABLE dbo.KhachHang;
