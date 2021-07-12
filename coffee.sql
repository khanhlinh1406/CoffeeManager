CREATE DATABASE COFFEE_MANAGEMENT

use COFFEE_MANAGEMENT

CREATE TABLE TINHTRANGMON
(
	MaTT varchar(10) primary key,
	TenTT nvarchar(20)
)

CREATE TABLE DVT_MON
(
	MaDVTM varchar(10) primary key,
	TenDVTM nvarchar(20)
)

CREATE TABLE MON
(
	MaMon varchar(10) primary key,
	TenMon nvarchar(20),
	MaDVTM varchar(10),
	Gia int,
	MaTT varchar(10),
	CONSTRAINT fk_mon_tt_ttmon FOREIGN KEY (MaTT) REFERENCES TINHTRANGMON (MaTT),
	CONSTRAINT fk_mon_dvt_dvtmon FOREIGN KEY (MaDVTM) REFERENCES DVT_MON (MaDVTM)
)

CREATE TABLE NHACUNGCAP
(
	MaNCC varchar(10) primary key,
	TenNCC varchar(30),
	SDT varchar(10)
)

CREATE TABLE CHUCVU
(
	MaCV varchar(10) primary key,
	TenCV nvarchar(10)
)

CREATE TABLE TAIKHOAN
(
	MaTK varchar(10) primary key,
	MatKhau varchar(10)
)

CREATE TABLE NHANVIEN
(
	MaNV varchar(10) primary key,
	TenNV nvarchar(20),
	NgSinh smalldatetime,
	SDT varchar(10),
	DiaChi nvarchar(50),
	NgVaoLam smalldatetime,
	MaCV varchar(10),
	MaTK varchar(10),
	CONSTRAINT fk_nv_macv_cv FOREIGN KEY (MaCV) REFERENCES CHUCVU (MaCV),
	CONSTRAINT fk_nv_matk_tk FOREIGN KEY (MaTK) REFERENCES TAIKHOAN (MaTK)
)


CREATE TABLE LOAIKHACHHANG
(
	MaLKH varchar(10) primary key,
	LoaiKH nvarchar(20),
	PTramHD float,
	PTgiam float,
	DiemLH int
)

create table KHACHHANG
(
  MaKH varchar(10) primary key,
  TenKH nvarchar(30),
  NgSinh smalldatetime,
  SoDT varchar(10),
  DiaChi nvarchar(100),
  NgDK smalldatetime,
  Diem int,
  MaLKH varchar(10),
  CONSTRAINT fk_kh_malkh_lkh FOREIGN KEY (MaLKH) REFERENCES LOAIKHACHHANG (MaLKH)
)

CREATE TABLE HOADON
(
	MaHD varchar(10) primary key,
	MaNV_Lap varchar(10),
	MaKH varchar(10),
	NgLap smalldatetime,
	KhMai int,
	TriGia int,
	CONSTRAINT fk_hd_manv_nv FOREIGN KEY (MaNV_Lap) REFERENCES NHANVIEN (MaNV),
	CONSTRAINT fk_hd_makh_kh FOREIGN KEY (MaKH) REFERENCES KHACHHANG (MaKH)
)

CREATE TABLE CT_HOADON
(
	MaHD varchar(10), 
	MaMon varchar(10), 
	SoLuong int
	PRIMARY KEY(MaHD, MaMon),
	CONSTRAINT fk_cthd_hd FOREIGN KEY (MaHD) REFERENCES HOADON (MaHD),
	CONSTRAINT fk_cthd_mon FOREIGN KEY (MaMon) REFERENCES MON (MaMon)
)

CREATE TABLE PHIEUNHAP
(
	MaPN varchar(10) primary key, 
	NgNhap smalldatetime, 
	TriGia int,
	MaNCC varchar(10),
	CONSTRAINT fk_pn_mancc_ncc FOREIGN KEY (MaNCC) REFERENCES NHACUNGCAP (MaNCC)
)

CREATE TABLE DVT_NGUYENLIEU
(
	MaDVTNL varchar(10) primary key,
	TenDVTNL nvarchar(20)
)

CREATE TABLE NGUYENLIEU
(
	MaNL varchar(10) primary key, 
	TenNL nvarchar(20), 
	MaDVTNL varchar(10),
	CONSTRAINT fk_nl_madvtnl_dvtnl FOREIGN KEY (MaDVTNL) REFERENCES DVT_NGUYENLIEU (MaDVTNL)
)

CREATE TABLE CT_PHIEUNHAP
(
	MaPN varchar(10), 
	MaNL varchar(10), 
	DonGia int,
	SoLuong int,
	primary key (MaPN, MaNL),

	CONSTRAINT fk_ctpn_mapn_pn FOREIGN KEY (MaPN) REFERENCES PHIEUNHAP (MaPN),
	CONSTRAINT fk_ctpn_manl_nl FOREIGN KEY (MaNL) REFERENCES NGUYENLIEU (MaNL)
)

insert into TAIKHOAN values ('nv', '1234')
insert into TAIKHOAN values ('ql', '1234')
insert into CHUCVU values ('ql', 'Quản lí')
insert into CHUCVU values ('nv', 'Nhân viên')

insert into NHANVIEN values ('1', 'Nhan Vien 1', '2001-01-13 00:00:00', '0918551999', 'Binh Duong', '2021-01-22 00:00:00', 'nv', 'nv')
