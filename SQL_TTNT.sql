create database QLGD_Suachuathietbi
use QLGD_Suachuathietbi
go
create table KHACH_HANG
(
MaKH Varchar(15) primary key,
TenKH NVARCHAR(100),
DiaChi Nvarchar(100),
THANTHIET int
)
go 
create table NHAN_VIEN
(
MaNV INT Primary key,
TenNV Nvarchar(100),
SoDT NVARCHAR(100)
)
go
create table SUA_CHUA
(
MaKH Varchar(15) primary key,
MaNV INT, 
NgayNhan date,
GioNhan time,
NgayTra date,
GioTra time,
NoiDung Nvarchar(500),
TrangThai varchar(50),
Gia Numeric(15)
)
go
alter table SUA_CHUA
Add Constraint fk_SUA_CHUA foreign key (MaKH) references KHACH_HANG (MaKH),
constraint FK_NHAN_VIEN foreign key (MaNV)  references NHAN_VIEN (MaNV)


