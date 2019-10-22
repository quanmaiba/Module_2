USE QuanLy;

--l?y l??ng tb c?a công ty
SELECT AVG(Luong) AS LuongTB 
FROM dbo.NhanVien ;

-- l?y ng??i nhân viên co l??ng cao nhât cuat cty
--SELECT * FROM dbo.NhanVien;
--SELECT TOP(1)TenNV,MAX(Luong) 
--FROM  dbo.NhanVien 
--GROUP BY TenNV,Luong
--ORDER BY luong DESC;

SELECT nv.Luong 
FROM dbo.NhanVien nv
WHERE nv.Luong =
(
	SELECT MAX(luong) 
	FROM dbo.NhanVien
)

-- l?y top 3 nguoi  luong cao nh?t c?a cty
SELECT TOP(3)TenNV,MAX(Luong) 
FROM  dbo.NhanVien 
GROUP BY TenNV,Luong
ORDER BY luong DESC;

-- l?y nv là n? mà có ?? tu?i d??i 35
SELECT HoNV,TenNV, YEAR(GETDATE())- YEAR(NgaySinh) AS Tuoi 
FROM dbo.NhanVien 
WHERE YEAR(GETDATE())- YEAR(NgaySinh) < 35 AND GioiTinh = N'N?';

-- t?ng ti?n sale ??i vs t?ng khách hàng.
SELECT kh.TenKhachHang, SUM(cts.TongTien) AS TongTienSale
FROM dbo.ChiTietSale cts  JOIN dbo.KhachHang kh 
ON kh.KhachHangID = cts.KhachHangID
GROUP BY cts.KhachHangID,kh.TenKhachHang;

-- l?y thông tin nv và t?ng ti?n sale c?a nv ?o
SELECT nv.TenNV ,SUM(cts.TongTien) AS TongTienSale 
FROM dbo.NhanVien nv 
LEFT JOIN dbo.ChiTietSale cts 
ON cts.NhanVienID = nv.NhanVienID
GROUP BY cts.NhanVienID,nv.TenNV;

-- l?y thông tin nh?ng nhà cc co tên b?t ??u b?ng 'hu'
SELECT * 
FROM dbo.NhaCungCap 
WHERE TenNhaCungCap LIKE N'Hu%';

-- l?y tên nv snhatj vào thag 1
SELECT CONCAT(HoNV,TenNV) AS TenDayDu, NgaySinh
FROM dbo.NhanVien 
WHERE MONTH(NgaySinh) = 1;

-- l?y all nv mà ti?n sale > 5000000
SELECT nv.TenNV ,SUM(cts.TongTien) AS TongTienSale 
FROM dbo.NhanVien nv 
LEFT JOIN dbo.ChiTietSale cts 
ON cts.NhanVienID = nv.NhanVienID 
GROUP BY cts.NhanVienID,nv.TenNV
HAVING SUM(cts.TongTien) > 300000;

-- l?y thông tin khách hàng mà ng??i qu?n lý co id là 102
SELECT KhachHangID, TenKhachHang,QuanLyID , TenChiNhanh FROM dbo.KhachHang 
JOIN dbo.ChiNhanh 
ON ChiNhanh.ChiNhanhID = KhachHang.ChiNhanhID 
AND QuanLyID = 102;

-- l?y ttin khag nhung ng??i qu?n lý co tên là sung 
SELECT nv.TenNV, kh.TenKhachHang FROM dbo.NhanVien nv 
JOIN dbo.ChiNhanh cn 
ON cn.QuanLyID = nv.NhanVienID 
AND nv.TenNV = N'Sung'
JOIN dbo.KhachHang kh ON kh.ChiNhanhID = cn.ChiNhanhID;
 
-- l?y tt nv ?ã co sale thuoc chi nhánh qu?ng tr?
SELECT DISTINCT(nv.NhanVienID), nv.HoNV + ' '+ nv.TenNV AS TenDayDu
FROM dbo.ChiNhanh cn
JOIN dbo.NhanVien nv
ON nv.ChiNhanhID = cn.ChiNhanhID 
AND cn.TenChiNhanh = N'quảng trị'
JOIN dbo.ChiTietSale cts
ON cts.NhanVienID = nv.NhanVienID

-- tìm all khag co tien sale >200000
SELECT cts.KhachHangID , kh.TenKhachHang, SUM(cts.TongTien) AS TongTien
FROM dbo.KhachHang kh 
JOIN dbo.ChiTietSale cts
ON cts.KhachHangID = kh.KhachHangID
GROUP BY cts.KhachHangID,kh.TenKhachHang
HAVING SUM(cts.TongTien) > 200000;

SELECT TenNV, Luong + (Luong - ISNULL(luong,0)) FROM dbo.NhanVien 

SELECT nv2.TenNV,nv1.TenNV AS nguoiQuanLy , nv1.ChiNhanhID
FROM dbo.NhanVien nv1 
RIGHT JOIN dbo.NhanVien nv2
ON nv2.NguoiPhuTrachID = nv1.NhanVienID

