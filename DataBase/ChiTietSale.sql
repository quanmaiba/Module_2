CREATE TABLE ChiTetSale
(
	NhanVienID INT ,
	KhanhHangID INT ,
	TongTien INT NOT NULL,
	PRIMARY KEY(NhanVienID,KhanhHangID)	
);
ALTER TABLE dbo.ChiTetSale ADD FOREIGN KEY(NhanVienID) REFERENCES dbo.NhanVien(NhanVienID);

