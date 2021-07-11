CREATE DATABASE COFFEE_MANAGEMENT

use COFFEE_MANAGEMENT

CREATE TABLE MON
(
	MaMon varchar(10) primary key,
	TenMon nvarchar(20),
	MaDVTM varchar(10),
	Gia int,
	MaTinhTrang varchar(15)
)

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

CREATE TABLE NHACUNGCAP
(
	MaNCC varchar(10) primary key,
	TenNCC varchar(30),
	SDT varchar(10)
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
	MaTK varchar(10)
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

CREATE TABLE HOADON
(
	MaHD varchar(10) primary key,
	MaNV_Lap varchar(10),
	MaKH varchar(10),
	NgLap smalldatetime,
	KhMai int,
	TriGia int
)

CREATE TABLE CT_HOADON
(
	MaHD varchar(10), 
	MaMon varchar(10), 
	SoLuong int
	PRIMARY KEY(MaHD, MaMon)
)

CREATE TABLE PHIEUNHAP
(
	MaPN varchar(10) primary key, 
	NgNhap smalldatetime, 
	TriGia int,
	MaNCC varchar(10)
)

CREATE TABLE CT_PHIEUNHAP
(
	MaPN varchar(10) primary key, 
	MaNL varchar(10), 
	DonGia int,
	SoLuong int
)

CREATE TABLE NGUYENLIEU
(
	MaNL varchar(10) primary key, 
	TenNL nvarchar(20), 
	MaDVTNL varchar(10),
)

CREATE TABLE DVT_NGUYENLIEU
(
	MaDVTNL varchar(10) primary key,
	TenDVTNL nvarchar(20)
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
  MaLKH varchar(10)
)

CREATE TABLE LOAIKHACHHANG
(
	MaLKH varchar(10) primary key,
	LoaiKH nvarchar(20),
	PTramHD float,
	PTgiam float,
	DiemLH int
)

insert into TAIKHOAN values ('nv', '1234')
insert into TAIKHOAN values ('ql', '1234')

insert into NHANVIEN values ('1', 'Nhan Vien 1', '2001-01-13 00:00:00', '0918551999', 'Binh Duong', '2021-01-22 00:00:00', 'NV', 'NV')
