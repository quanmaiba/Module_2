CREATE DATABASE QuanLy;
USE QuanLy;



CREATE TABLE ChiNhanh
(
	ChiNhanhID INT IDENTITY(1,1),
	TenChiNhanh NVARCHAR(30),
	QuanLyID INT NOT NULL,
	NgayBatDau DATE,
	PRIMARY KEY(ChiNhanhID)
	
);
ALTER TABLE dbo.ChiNhanh ADD FOREIGN KEY(QuanLyID) REFERENCES dbo.NhanVien(NhanVienID);
ALTER TABLE dbo.NhanVien ADD FOREIGN KEY (ChiNhanhID) REFERENCES dbo.ChiNhanh(ChiNhanhID);
CREATE TABLE KhachHang
(
	KhachHangID INT IDENTITY(400,1),
	TenKhachHang NVARCHAR (50) NOT NULL,
	ChiNhanhID INT NOT NULL ,
	PRIMARY KEY(KhachHangID),	
);
ALTER TABLE dbo.KhachHang ADD FOREIGN KEY(ChiNhanhID) REFERENCES dbo.ChiNhanh(ChiNhanhID);

CREATE TABLE ChiTietSale
(
	NhanVienID INT ,
	KhachHangID INT ,
	TongTien INT NOT NULL,
	PRIMARY KEY(NhanVienID,KhachHangID)	
);
ALTER TABLE dbo.ChiTietSale ADD FOREIGN KEY(NhanVienID) REFERENCES dbo.NhanVien(NhanVienID);
ALTER TABLE dbo.ChiTietSale ADD FOREIGN KEY(KhachHangID) REFERENCES dbo.KhachHang(KhachHangID);
 
--DROP TABLE dbo.ChiNhanh;
--DROP TABLE dbo.ChiTetSale;
--DROP TABLE dbo.KhanhHang;
----DROP TABLE dbo.NhaCungCap;
----DROP TABLE dbo.NhanVien;
INSERT ChiNhanh(TenChiNhanh, QuanLyID, NgayBatDau)
VALUES(N'Huế', 100, '20100502');
INSERT ChiNhanh(TenChiNhanh, QuanLyID, NgayBatDau)
VALUES(N'Quảng Bình', 102, '20120502');
INSERT ChiNhanh(TenChiNhanh, QuanLyID, NgayBatDau)
VALUES(N'Quảng Trị', 106, '20110502');

SELECT * FROM dbo.ChiNhanh;

INSERT KhachHang (TenKhachHang,ChiNhanhID)
VALUES (N'Công Ty Sữa Ong Chúa',2);
INSERT KhachHang (TenKhachHang,ChiNhanhID)
VALUES (N'Công Ty Giấy BCC',2);
INSERT KhachHang (TenKhachHang,ChiNhanhID)
VALUES (N'Công Ty Gốm LCD',3);
INSERT KhachHang (TenKhachHang,ChiNhanhID)
VALUES (N'Công Ty Nhựa Silili',3);
INSERT KhachHang (TenKhachHang,ChiNhanhID)
VALUES (N'Công Ty Bánh Kẹo Hai Lúa',2);
INSERT KhachHang (TenKhachHang,ChiNhanhID)
VALUES (N'Công Ty BDS Háu Ăn',3);
INSERT KhachHang (TenKhachHang,ChiNhanhID)
VALUES (N'Công Ty Hải Sản 3X',2);
SELECT * FROM dbo.KhachHang;

INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (105,400,85000);
INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (102,401,320000);
INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (108,402,25500);
INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (107,403,4000);
INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (108,403,11000);
INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (105,404,32000);
INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (107,405,26000);
INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (102,406,12000);
INSERT ChiTietSale(NhanVienID,KhachHangID,TongTien)
VALUES (105,406,250000);

SELECT * FROM dbo.ChiTietSale;

SELECT * FROM dbo.ChiNhanh whet

 
--SELECT * FROM dbo.NhanVien;
--SELECT * FROM dbo.ChiNhanh;

SELECT * FROM NhanVien ORDER BY Luong ASC;

SELECT * FROM NhanVien ORDER BY Luong DESC;

SELECT * FROM dbo.NhanVien ORDER BY GioiTinh DESC,TenNV ASC;

SELECT Top 5 * FROM dbo.NhanVien ;
 
SELECT HoNV,TenNV FROM dbo.NhanVien;

SELECT DISTINCT GioiTinh FROM dbo.NhanVien;

SELECT * FROM dbo.NhanVien WHERE GioiTinh = N'nam';

SELECT YEAR(GETDATE()) - YEAR(NgaySinh) AS Tuoi,* FROM dbo.NhanVien WHERE YEAR(GETDATE()) - YEAR(NgaySinh) > 30;

SELECT * FROM dbo.NhanVien WHERE GioiTinh = N'Nữ' OR Luong > 8000000;

SELECT nv.HoNV+' '+ nv.TenNV AS name,cn.TenChiNhanh FROM dbo.NhanVien nv LEFT JOIN dbo.ChiNhanh cn ON  nv.ChiNhanhID = cn.ChiNhanhID;

SELECT * FROM dbo.ChiNhanh WHERE TenChiNhanh LIKE '%b%';

SELECT COUNT(DISTINCT HoNV) FROM dbo.NhanVien;

SELECT nv.HoNV , nv.TenNV , TenChiNhanh 
FROM dbo.NhanVien nv 
JOIN dbo.ChiNhanh 
ON ChiNhanh.ChiNhanhID = nv.ChiNhanhID;

  
SELECT cn.TenChiNhanh, COUNT(*) 
FROM dbo.ChiNhanh cn 
LEFT JOIN dbo.NhanVien nv
ON nv.ChiNhanhID = cn.ChiNhanhID
GROUP BY cn.TenChiNhanh

SELECT ncc.TenNhaCungCap , cn.TenChiNhanh, nv.HoNV ,nv.TenNV
FROM dbo.NhaCungCap ncc 
JOIN dbo.ChiNhanh cn 
ON ncc.ChiNhanhID = cn.ChiNhanhID 
JOIN dbo.NhanVien nv 
ON nv.NhanVienID = cn.QuanLyID 
GROUP BY ncc.TenNhaCungCap;

