CREATE TABLE NhaCungCap
(
	ChiNhanhID INT NOT NULL ,
	TenNhaCungCap NVARCHAR(50),
	LoaiSanPhamCC NVARCHAR(30),
	PRIMARY KEY(ChiNhanhID,TenNhaCungCap)
);
ALTER TABLE dbo.NhaCungCap ADD FOREIGN KEY(ChiNhanhID) REFERENCES dbo.ChiNhanh(ChiNhanhID) ON DELETE SET NULL;

INSERT NhaCungCap(ChiNhanhID,TenNhaCungCap,LoaiSanPhamCC)
VALUES (2,N'Hồng Vân',N'Sữa');
INSERT NhaCungCap(ChiNhanhID,TenNhaCungCap,LoaiSanPhamCC)
VALUES (2,N'Chiến Thắng',N'Giấy');
INSERT NhaCungCap(ChiNhanhID,TenNhaCungCap,LoaiSanPhamCC)
VALUES (3,N'Huda Huế',N'Gốm');
INSERT NhaCungCap(ChiNhanhID,TenNhaCungCap,LoaiSanPhamCC)
VALUES (2,N'CodeGym',N'Bánh Kẹo');
INSERT NhaCungCap(ChiNhanhID,TenNhaCungCap,LoaiSanPhamCC)
VALUES (3,N'CodeGym',N'Bánh Kẹo');
INSERT NhaCungCap(ChiNhanhID,TenNhaCungCap,LoaiSanPhamCC)
VALUES (3,N'Chiến Thắng',N'Giấy');
INSERT NhaCungCap(ChiNhanhID,TenNhaCungCap,LoaiSanPhamCC)
VALUES (3,N'3S',N'Hải Sản');

SELECT * FROM dbo.NhaCungCap;
--DROP TABLE dbo.NhaCungCap;

