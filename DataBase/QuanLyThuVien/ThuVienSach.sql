﻿CREATE DATABASE QuanLyThuVien;

--USE QuanLyThuVien;

CREATE TABLE SinhVien
(
	MaSv INT NOT NULL IDENTITY,
	Lop VARCHAR(10),
	HoTen NVARCHAR(50),
	PRIMARY KEY(MaSv)
)

CREATE TABLE SVMuonSach
(
	MaSach NVARCHAR(30),
	MaSv INT ,
	NgayTra DATE ,
	NgayMuon DATE,
	HinhThucMuon NVARCHAR(50),
	SoNgayMuon INT NOT NULL,
	PRIMARY KEY(MaSach,MaSv)
)

CREATE TABLE Kho
(
	MaKho INT NOT NULL IDENTITY(10,1),
	TenKho NVARCHAR(40),
	PRIMARY KEY(MaKho)
)

CREATE TABLE NgonNgu
(
	MaNgonNgu INT NOT NULL IDENTITY(20,1),
	TenNgonNgu NVARCHAR(40),
	PRIMARY KEY(MaNgonNgu)
)

CREATE TABLE LoaiSach
(
	MaLoaiSach INT NOT NULL IDENTITY(30,1),
	TenLoai NVARCHAR(40),
	PRIMARY KEY(MaLoaiSach)
)

CREATE TABLE NhaXuatBan
(
	MaNXB INT NOT NULL IDENTITY(40,1),
	TenNXB NVARCHAR(40),
	DiaChi NVARCHAR(100),
	PRIMARY KEY(MaNXB)
)

CREATE TABLE TacGia
(
	MaTacGia INT NOT NULL IDENTITY(50,1),
	TenTacGia NVARCHAR(40),
	DiaChi NVARCHAR(100),
	PRIMARY KEY(MaTacGia)
)

CREATE TABLE ViTri
(
	MaViTri INT NOT NULL IDENTITY(60,1),
	Khu INT NOT NULL,
	Ke INT NOT NULL,
	Ngan INT NOT NULL,
	PRIMARY KEY(MaViTri)	
)

CREATE TABLE Sach
(
	MaSach NVARCHAR(30),
	TenSach NVARCHAR(100),
	MaKho INT,
	MaNgonNgu INT ,
	MaLoaiSach INT,
	MaNXB INT,
	MaTacGia INT,
	MaViTri INT,
	NamXuatBan DATE,
	SoLuong INT NOT NULL,
	PRIMARY KEY(MaSach) 
)
ALTER TABLE dbo.SVMuonSach ADD FOREIGN KEY(MaSv) REFERENCES dbo.SinhVien(MaSv);
ALTER TABLE dbo.SVMuonSach ADD FOREIGN KEY(MaSach) REFERENCES dbo.Sach(MaSach);
ALTER TABLE dbo.Sach ADD FOREIGN KEY (MaKho) REFERENCES dbo.Kho(MaKho);
ALTER TABLE dbo.Sach ADD FOREIGN KEY (MaNgonNgu) REFERENCES dbo.NgonNgu(MaNgonNgu);
ALTER TABLE dbo.Sach ADD FOREIGN KEY (MaLoaiSach) REFERENCES dbo.LoaiSach(MaLoaiSach);
ALTER TABLE dbo.Sach ADD FOREIGN KEY (MaNXB) REFERENCES dbo.NhaXuatBan(MaNXB);
ALTER TABLE dbo.Sach ADD FOREIGN KEY (MaTacGia) REFERENCES dbo.TacGia(MaTacGia);
ALTER TABLE dbo.Sach ADD FOREIGN KEY (MaViTri) REFERENCES dbo.ViTri(MaViTri) ON DELETE CASCADE ;

EXEC sp_rename 'SVMuonsach','SinhVien_MuonSach';

DECLARE @I INT = 0 ;
DECLARE @J INT = 100000 ;

WHILE (@I<@J)
BEGIN
	INSERT Kho(TenKho)
	VALUES ( CONCAT(N'KhoSo ' , @i))
	SET @I += 1
END 

SELECT * FROM dbo.Kho;


PRINT N'Nhị uyên bị điên';