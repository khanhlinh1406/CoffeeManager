CREATE DATABASE COFFEE_MANAGEMENT
use COFFEE_MANAGEMENT
CREATE TABLE MON
(
	MaMon varchar(10) primary key,
	TenMon nvarchar(20),
	MaDVT varchar(10),
	Gia int
)

CREATE TABLE DONVITINH
(
	MaDVT varchar(10) primary key,
	TenDVT nvarchar(20)
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
alter table NHanvien drop column Diachi

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
	NgLap smalldatetime,
	TriGia int,
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
	TriGia int
)

CREATE TABLE CT_PHIEUNHAP
(
	MaPN varchar(10), 
	MaNL varchar(10), 
	DonGia int,
	SoLuong int
)

CREATE TABLE NGUYENLIEU
(
	MaNL varchar(10) primary key, 
	TenNL nvarchar(20), 
	MaDVT varchar(10),
)


create table KHACHHANG
(
  MaKH varchar(10),
  TenKH nvarchar(30),
  NgSinh smalldatetime,
  SoDT varchar(10),
  DiaChi nvarchar(100),
  NgDK smalldatetime,
  Diem int
)

SELECT A.MaNV, A.TenNV, A.NgSinh, A.SDT, A.NgVaoLam, C.TenCV, A.MaTK, B.MatKhau 
FROM TAIKHOAN B join NHANVIEN A on B.MaTK = A.MaTK join CHUCVU C on A.MaCV = C.MaCV