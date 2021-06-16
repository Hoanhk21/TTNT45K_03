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


go
use QLGD_Suachuathietbi
go
insert into KHACH_HANG (MaKH, TenKH, DiaChi, THANTHIET)
values ('037 4191 656', N'V� S?n Ph??ng', N'S?n Tr�','1'),
		('035 4139 267', N' L� Qu?nh Trang', N'H?i Ch�u','0'),
		('097 7474 811', N'Nguy?n Qu?nh Nh?', N'Li�n Chi?u' ,'0'),
		('097 3002 948', N'Nguy?n Minh Ch�n', N'C?m L?' ,'1'),
		('033 4072 043', N'V� T?n B?o', N'Ng? H�nh S?n' ,'0'),
		('097 9562 702', N'L� V?n ??t',N'H�a Vang','1'),
		('090 5112 345', N'??ng Th? Nh�n', N'Thanh Kh�','1'),
		('086 8396 077', N'Nguy?n Thanh H?i','S?n Tr�','1'),
		('039 2901 892', N'L� Tuy?t', N'Ng? H�nh S?n','0'),
		('090 5413 710',N'Tr?n Quang Tr??ng',N'Ng? H�nh S?n','1')
go
 insert into NHAN_VIEN (MaNV, TenNV, SoDT)
 values  ( '101',N'Nguy?n V? Lu�n','032 851 6352'),
		 ( '102',N'Nguy?n Kim Hoa','034 5151 073'),
		 ( '103',N'Nguy?n V?n Ph�','086 7835 267'),
		 ( '104',N'?inh V? ??t','098 8095 487'),
		 ( '105',N'L� T?n B�nh','035 6063 613'),
		 ('106', N'Tr?n V?n H�ng', '096 6407 132')
go
insert into SUA_CHUA (MaKH, MaNV, NgayNhan, GioNhan, NgayTra, GioTra, NoiDung, TrangThai, Gia)
Values  ('037 4191 656','101','20210605','15:00:00 ','20210608','08:00:00',N'thay m�n h�nh',N'Xong','800000'),
		('035 4139 267','103','20210605','16:00:00', '20210607', '09:00:00', N'thay b�n ph�m', N'Xong', '200000'),
		('097 7474 811','104','20210607', '07:00:00',' 20210609', '09:00:00', N'thay pin v� s?c', N'Xong','700000'),
		('097 3002 948','102','20210607', '17:00:00', '20210610', '12:00:00', N' n�ng c?p ? ssd' ,N'Xong', '650000'),
		('033 4072 043','103','20210608', '09:00:00', '20210610', '08:00:00', N'thay main', N'xong', '750000'),
		('097 9562 702', '105', '20210609', '10:00:00','20210610', '16:00:00', N'thay b?n l?', N'Xong','150000'),
		('090 5112 345','105', '20210609', '17:00:00','20210611','10:00:00', N'v? sinh m�y', N'Xong', '150000'),
		('086 8396 077','104', '20210608', '08:00:00', '20210609', '10:00:00', N'thay b�n ph�m v� loa', N'Xong' , '400000'),
		('039 2901 892','106', '20210610', '12:00:00', '20210611' , '07:00:00', N'thay m�n h�nh', N'Xong', '1000000'),
		('090 5413 710','106', '20210611' , '15:00:00', '20210612', '14:00:00', N'n�ng c�p s? hdd', N'Xong', '600000')
	go
	Select * from KHACH_HANG
	Select * from NHAN_VIEN
	Select *from SUA_CHUA