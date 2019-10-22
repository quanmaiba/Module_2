CREATE TABLE NhanVien
(
	NhanVienID INT IDENTITY (100,1),
	HoNV NVARCHAR(50) NOT NULL,
	TenNV NVARCHAR(30) NOT NULL,
	NgaySinh DATE,
	GioiTinh NVARCHAR(4),
	Luong INT NOT NULL,
	NguoiPhuTrachID INT DEFAULT NULL ,
	ChiNhanhID INT,
	PRIMARY KEY(NhanVienID)
);
ALTER TABLE dbo.NhanVien ADD FOREIGN KEY(NguoiPhuTrachID) REFERENCES dbo.NhanVien(NhanVienID);
--ALTER TABLE dbo.NhanVien ADD FOREIGN KEY (ChiNhanhID) REFERENCES 
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong,ChiNhanhID)
VALUES('Phan Dinh','Tung','19950523',N'Nam',30000000,1);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong,NguoiPhuTrachID,ChiNhanhID)
VALUES('Le Van','Lang','19900212',N'Nữ',12000000,100,1);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong, NguoiPhuTrachID,ChiNhanhID)
VALUES('Dinh Van','Hoang','19850124',N'Nam',10000000,100,2);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong, NguoiPhuTrachID,ChiNhanhID)
VALUES(N'Hoàng Thị',N'Bưởi','19910821',N'Nữ',11000000,102,2);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong, NguoiPhuTrachID,ChiNhanhID)
VALUES(N'Đào Đình',N'Phong','19920812',N'Nam',8000000,102,2);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong, NguoiPhuTrachID,ChiNhanhID)
VALUES(N'Mai Văn',N'Ăn','19860101',N'Nam',6500000,102,2);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong, NguoiPhuTrachID,ChiNhanhID)
VALUES(N'Nguyễn Văn',N'Sung','19990202',N'Nữ',5000000,100,3);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong, NguoiPhuTrachID,ChiNhanhID)
VALUES(N'Cao Bá',N'Thông','19930303',N'Nam',3000000,106,3);
INSERT NhanVien (HoNV,TenNV,NgaySinh,GioiTinh,Luong, NguoiPhuTrachID,ChiNhanhID)
VALUES(N'Nguyễn Văn',N'Balo','19860101',N'Nam',8500000,106,3);

TRUNCATE TABLE dbo.NhanVien;
SELECT * FROM dbo.NhanVien;

SELECT * INTO NewTable1 FROM dbo.NhanVien;
SELECT * FROM dbo.NhanVien;
