create database demo
go
use demo
go
create table NHANVIEN
(
	MANV varchar(10) PRIMARY KEY,
	TENNV nvarchar(50),
	NGAYSINH datetime,
	DIACHI nvarchar(50),
	SDT varchar(12),
	TENDANGNHAP varchar(20)
)
go
create table SANPHAM
(
	MASP varchar(10) PRIMARY KEY,
	TENSP nvarchar(50),
	DONVITINH nvarchar(20),
	LOAI nvarchar(20),
	XUATXU nvarchar(20),
	NGAYSANXUAT datetime,
	HANSUDUNG datetime,
	DONGIA int
)
go
create table HOADON
(
	SOHD varchar(10) PRIMARY KEY,
	NGAYLAP datetime,
	THANHTIEN int
)
go
create table TAIKHOAN
(
	TENDANGNHAP varchar(20) PRIMARY KEY,
	MATKHAU varchar(20)
)
go
create table CTHD
(
	MACTHD varchar(10),
	MASP varchar(10) foreign key references SANPHAM,
	SOHD varchar(10) foreign key references HOADON,
	MANV varchar(10) foreign key references NHANVIEN,
	SOLUONG int,
	DONGIA int,
	THANHTIEN int,
	constraint pk_CTHD primary key (MACTHD, MASP, SOHD, MANV)
)


