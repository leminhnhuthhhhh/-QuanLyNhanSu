CREATE DATABASE DB_QUANLYNHANSU_2
GO
USE DB_QUANLYNHANSU_2
GO
----- TABLE
CREATE TABLE tblPHONGBAN
(
	MaPhong INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenPhong NVARCHAR(50),
	GhiChu NVARCHAR(MAX)
)
GO
CREATE TABLE tblCHUCVU
(
	MaChucVu INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenChucVu NVARCHAR(50),
)
GO
CREATE TABLE tblHOPDONG
(
	MaHopDong INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	LoaiHopDong NVARCHAR(50),
	ThoiHanHopDong INT,
)
GO
CREATE TABLE tblNHANVIEN
(
	MaNhanVien INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenNhanVien	NVARCHAR(50),
	NgaySinh DATE,
	DiaChi NVARCHAR(MAX),
	GioiTinh NVARCHAR(15),
	SDT VARCHAR(13),
	Email VARCHAR(50),
	CMND VARCHAR(13),
	DanToc NVARCHAR(30),
	TrinhDoHocVan NVARCHAR(30),
	TrinhTrangHonNhan NVARCHAR(30),
	NgayVaoLam DATE,
	HeSoLuong FLOAT,
	Anh VARCHAR(MAX),
	MaHopDong INT,
	MaPhong INT,
	CONSTRAINT FK_tblNHANVIEN_tblHOPDONG FOREIGN KEY(MaHopDong) REFERENCES tblHOPDONG(MaHopDong),
	CONSTRAINT FK_tblNHANVIEN_tblPHONGBAN FOREIGN KEY(MaPhong) REFERENCES tblPHONGBAN(MaPhong)
)
GO
CREATE TABLE tblCHITIETCHUCVU
(
	MaNhanVien INT NOT NULL,
	MaChucVu INT NOT NULL,
	LuongCoBan MONEY,
	PhuCapChucVu FLOAT,
	NgayBatDau DATE, -- NGAY VAO LAM
	NgayKetThuc DATE, -- NGAY VAO LAM + HOP DONG
	CONSTRAINT PK_tblCHITIETCHUCVU PRIMARY KEY(MaChucVu, MaNhanVien),
	CONSTRAINT FK_tblCHITIETCHUCVU_tblCHUCVU FOREIGN KEY(MaChucVu) REFERENCES tblCHUCVU(MaChucVu),
	CONSTRAINT FK_tblCHITIETCHUCVU_tblNHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES tblNHANVIEN(MaNhanVien)
)
GO
CREATE TABLE tblBAOHIEM
(
	MaNhanVien INT NOT NULL,
	LoaiBaoHiem NVARCHAR(50) NOT NULL,
	SoThe VARCHAR(20),
	NgayCap DATE,
	NgayHetHan DATE,
	NoiCap NVARCHAR(50),
	CONSTRAINT PK_tblBAOHIEM PRIMARY KEY(MaNhanVien, LoaiBaoHiem),
	CONSTRAINT FK_tblBAOHIEM_tblNHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES tblNHANVIEN(MaNhanVien)
)
GO
CREATE TABLE tblTAIKHOAN
(
	TaiKhoan VARCHAR(20) PRIMARY KEY NOT NULL,
	MatKhau VARCHAR(20),
	Quyen NVARCHAR(20),
	MaNhanVien INT NOT NULL,
	CONSTRAINT FK_tblTAIKHOAN_tblNHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES tblNHANVIEN(MaNhanVien)
)
GO
CREATE TABLE tblKHENTHUONGKYLUAT
(
	MaKTKL INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaNhanVien INT NOT NULL,
	NgayLap DATE,
	Loai NVARCHAR(30),
	GhiChu NVARCHAR(MAX),
	Tien MONEY,
	TrinhTrang NVARCHAR(30),
	CONSTRAINT FK_tblKHENTHUONGKYLUAT_tblNHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES tblNHANVIEN(MaNhanVien)
)
GO
CREATE TABLE tblCHAMCONG
(
	MaNhanVien INT NOT NULL,
	NgayCham DATE NOT NULL,
	TrinhTrang NVARCHAR(30),
	CONSTRAINT PK_tblCHAMCONG PRIMARY KEY(MaNhanVien, NgayCham),
	CONSTRAINT FK_tblCHAMCONG_tblNHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES tblNHANVIEN(MaNhanVien)
)
GO
CREATE TABLE tblLUONG
(
	MaLuong INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaNhanVien INT NOT NULL,
	TienLuong MONEY,
	NgayLap DATE,
	MaNhanVienLap INT,
	CONSTRAINT FK_tblLUONG_tblNHANVIEN FOREIGN KEY(MaNhanVien) REFERENCES tblNHANVIEN(MaNhanVien)
)

-----------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------- DATA---------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------
 GO

INSERT INTO tblPHONGBAN
VALUES 
(N'Phòng Giám Đốc', N'Tầng 3'),
(N'Phòng Phó Giám Đốc', N'Tầng 3'),
(N'Phòng Kế Toán', N'Tầng 2'),
(N'Phòng Hành Chính', N'Tầng 1'),
(N'Phòng Nhân Sự', N'Tầng 2'),
(N'Phòng Chăm Sóc Khách Hàng', N'Tầng 1'),
(N'Phòng Maketing', N'Tầng 2');

INSERT INTO tblCHUCVU
VALUES 
(N'Giám Đốc'),
(N'Phó Giám Đốc'),
(N'Thư Ký'),
(N'Trưởng Phòng'),
(N'Phó Phòng'),
(N'Trưởng Nhóm'),
(N'Nhân Viên');
GO
-- thoi han la thang
INSERT INTO tblHOPDONG
VALUES
(N'Hợp Đồng Chính Thức', null),  -- cho giám đốc
(N'Hợp Đồng  Chính Thức - 5 Năm', 60),
(N'Hợp Đồng  Chính Thức - 4 Năm', 48),
(N'Hợp Đồng  Chính Thức - 3 Năm', 36),
(N'Hợp Đồng  Chính Thức - 2 Năm', 24),
(N'Hợp Đồng  Tạm Thời - 1 Năm', 12),
(N'Hợp Đồng  Tạm Thời - 4 Tháng', 4),
(N'Hợp Đồng  Tạm Thời - 3 Tháng', 3)
GO

SET DATEFORMAT dmy;

GO

INSERT INTO tblNHANVIEN
VALUES 
(N'Nguyễn Văn An', '01-10-1985', N'Bến Tre', N'Nam', '012346789', 'annguyenan@gmail.com', '3541245890', N'Kinh', N'Đại Học', N'Độc Thân', '01-01-2019', 2.34, 'img1.jfif', 1, 1),
(N'Lê Văn Sang', '01-10-1988', N'Bến Tre', N'Nam', '084524565', 'sanglevan@gmail.com', '324568547', N'Kinh', N'Đại Học', N'Đã Kết Hôn', '01-01-2019', 2.34, 'img2.png', 2, 2),
(N'Nguyễn Thị Xinh', '01-10-1999', N'Trà Vinh', N'Nữ', '0915245755', 'xinhnguyenthi@gmail.com', '214563574', N'Kinh', N'Đại Học', N'Độc Thân', '01-01-2019', 2.34, 'img7.jpg', 3, 1),
(N'Nguyễn Thị Đẹp', '01-10-2000', N'An Giang', N'Nữ', '0245785565', 'depnguyenthi@gmail.com', '352145684', N'Kinh', N'Đại Học', N'Độc Thân', '01-01-2019', 2.34, 'img4.jfif', 3, 2),
(N'Nguyễn Hòa Trung Hiếu', '22-10-1999', N'Đăk-Lăk', N'Nam', '082485544', 'hieunguyenhoatrung@gmail.com', '352145682', N'Kinh', N'Đại Học', N'Độc Thân', '21-01-2020', 2.34, 'img5.jfif', 4, 5),
(N'Lê Minh Nhựt', '01-10-2000', N'Bến Tre', N'Nam', '0961042098', 'nhutleminh@gmail.com', '352145625', N'Kinh', N'Cao Đẳng', N'Độc Thân', '21-10-2019', 2.10, 'img6.jfif', 4, 5);


--GO
INSERT INTO tblCHITIETCHUCVU
VALUES
(1, 1, 10000000, 0.5, '1-10-2019', '1-10-2111'),
(2, 2, 9000000, 0.4, '1-10-2019', '1-10-2024'),
(3, 3, 8000000, 0.20, '1-10-2019', '1-10-2023'),
(4, 3, 7500000, 0.25, '1-10-2019', '1-10-2023'),
(5, 4, 6000000, 0.20, '1-10-2019', '1-10-2022'),
(6, 7, 6000000, 0.15, '1-10-2019', '1-10-2022');

GO

INSERT INTO tblBAOHIEM
VALUES 
(1, N'Bảo Hiểm Y Tế', '24578', '1-1-2019', '1-1-2020', N'Bến Tre'),
(1, N'Bảo Hiểm Tai Nạn', '14253', '1-1-2019', '1-1-2020', N'Bến Tre'),
(2, N'Bảo Hiểm Y Tế', '24586', '1-1-2019', '1-1-2020', N'Bến Tre');
GO

INSERT INTO tblTAIKHOAN
VALUES 
('admin', 'admin', 'admin', 1),
('nhut', '123', 'user', 6);

GO

INSERT INTO tblKHENTHUONGKYLUAT
VALUES 
(3, '5-1-2021', N'Khen Thưởng', N'Hoàn thành công việc', 500000, N'Chưa Thanh Toán'),
(3, '6-1-2021', N'Kỉ Luật', N'Đi trễ', 20000, N'Chưa Thanh Toán'),
(4, '5-1-2019', N'Khen Thưởng', N'Hoàn thành công việc', 500000, N'Chưa Thanh Toán');

GO


