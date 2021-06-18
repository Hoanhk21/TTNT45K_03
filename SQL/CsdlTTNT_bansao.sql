Create database QLGD_Suachuathietbi
Use QLGD_Suachuathietbi
go
Create table KHACH_HANG
(
MaKH Varchar(15) primary key,
TenKH NVARCHAR(100),
DiaChi Nvarchar(100),
THANTHIET int
)
go 
Create table NHAN_VIEN
(
MaNV INT Primary key,
TenNV Nvarchar(100),
SoDT NVARCHAR(100)
)
go
Create table SUA_CHUA
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
Alter table SUA_CHUA
Add Constraint fk_SUA_CHUA foreign key (MaKH) references KHACH_HANG (MaKH),
constraint FK_NHAN_VIEN foreign key (MaNV)  references NHAN_VIEN (MaNV)


go
Use QLGD_Suachuathietbi
go
Insert into KHACH_HANG (MaKH, TenKH, DiaChi, THANTHIET)
values  ('037 4191 656', N'Vo Son Phuong', N'Son Tra','1'),
		('035 4139 267', N' Le Quynh Trang', N'Hai Chau','0'),
		('097 7474 811', N'Nguyen Quynh Nhu', N'Lien Chieu' ,'0'),
		('097 3002 948', N'Nguyen Minh Chan', N'Cam Le' ,'1'),
		('033 4072 043', N'Vo Tan Bao', N'Ngu Hanh Son' ,'0'),
		('097 9562 702', N'Le Van Dat',N'Hoa Vang','1'),
		('090 5112 345', N'Dang The Nhan', N'Thanh Khe','1'),
		('086 8396 077', N'Nguyen Thanh Hai', N'Son Tra','1'),
		('039 2901 892', N'Le Tuyet', N'Ngu Hanh Son','0'),
		('090 5413 710', N'Tran Quang Truong',N'Ngu Hanh Son','1')
go
 Insert into NHAN_VIEN (MaNV, TenNV, SoDT)
 values  ( '101',N'Nguyen Vu Luan','032 851 6352'),
		 ( '102',N'Nguyen Kim Hoa','034 5151 073'),
		 ( '103',N'Nguyen Van Phu','086 7835 267'),
		 ( '104',N'Dinh Vi Dat','098 8095 487'),
		 ( '105',N'Le Tan Binh','035 6063 613'),
		 ('106', N'Tran Van Hung', '096 6407 132')
go
Insert into SUA_CHUA (MaKH, MaNV, NgayNhan, GioNhan, NgayTra, GioTra, NoiDung, TrangThai, Gia)
Values  ('037 4191 656','101','20210605','15:00:00 ','20210608','08:00:00', N'thay man hinh',N'Xong','800000'),
		('035 4139 267','103','20210605','16:00:00', '20210607', '09:00:00', N'thay ban phim', N'Xong', '200000'),
		('097 7474 811','104','20210607', '07:00:00',' 20210609', '09:00:00', N'thay pin voi sac', N'Xong','700000'),
		('097 3002 948','102','20210607', '17:00:00', '20210610', '12:00:00', N' nang cap o ssd' ,N'Xong', '650000'),
		('033 4072 043','103','20210608', '09:00:00', '20210610', '08:00:00', N'thay main', N'xong', '750000'),
		('097 9562 702', '105', '20210609', '10:00:00','20210610', '16:00:00', N'thay ban le', N'Xong','150000'),
		('090 5112 345','105', '20210609', '17:00:00','20210611','10:00:00', N've sinh may', N'Xong', '150000'),
		('086 8396 077','104', '20210608', '08:00:00', '20210609', '10:00:00', N'thay ban phim va loa', N'Xong' , '400000'),
		('039 2901 892','106', '20210610', '12:00:00', '20210611' , '07:00:00', N'thay man hinh', N'Xong', '1000000'),
		('090 5413 710','106', '20210611' , '15:00:00', '20210612', '14:00:00', N'nang cap o hdd', N'Xong', '600000')
	go
	Select * from KHACH_HANG
	Select * from NHAN_VIEN
	Select *from SUA_CHUA
	