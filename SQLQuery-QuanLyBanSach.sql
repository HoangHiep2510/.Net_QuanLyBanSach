create database QuanLyBanSach
use QuanLyBanSach 
go
create table NhaXuatBan(
MaNXB char(10) primary key,
TenNXB nvarchar(30) not null 
)
Insert into NhaXuatBan values('NXB01',N'Kim Đồng')
Insert into NhaXuatBan values('NXB02',N'Thanh Niên')
Insert into NhaXuatBan values('NXB03',N'Lao Động')
go
create table Sach(
MaSach char(10) primary key,
TenSach nvarchar(50) not null,
TacGia nvarchar(50) not null,
NamXB int null,
DonGia int not null,
MoTa nvarchar(255) null,
MaNXB char(10) not null,
foreign key(MaNXB) references NhaXuatBan(MaNXB)
)
Insert into Sach values('S0001',N'Doraemon', N'Hoàng Hiệp',2000,20000,N'Chưa bán', 'NXB01')
Insert into Sach values('S0002',N'Conan', N'Hiệp Hoàng',2000,10000,N'Đang hot', 'NXB02')
go
create table KhachHang(
MaKH char(10)  primary key,
HoTenKH nvarchar(50) not null,
GioiTinh bit not null,
NamSinh int not null,
SoDT varchar(15) not null
)
Insert into KhachHang values('KH001',N'Nguyễn Văn Thành', 1, 1980, '0907546876')
Insert into KhachHang values('KH002',N'Hoàng Hương Trang', 0, 1978, '0907546876')
Insert into KhachHang values('KH003',N'Đinh Trường Sơn', 1, 1986, '0907546876')
Insert into KhachHang values('KH004',N'Trịnh Tú Anh', 0, 1983, '0907546876')
Insert into KhachHang values('KH005',N'Đặng Thành Công', 1, 1991, '0907546876')
go
create table NhanVien(
MaNV char(10) primary key,
HoTen nvarchar(50) not null,
NamSinh int not null
)

Insert into NhanVien values('NV001',N'Vũ Đình Hiếu', 2000)
Insert into NhanVien values('NV002',N'Lê Hữu Tâm', 2000)
Insert into NhanVien values('NV003',N'Nguyễn Trần Khánh Duy', 2000)
go
create table HoaDon(
SoHD char(10) primary key,
NgayBan date not null,
MaKH char(10) not null ,
MaNV char(10) not null ,
foreign key(MaKH) references KhachHang(MaKH),
foreign key(MaNV) references NhanVien(MaNV)
)
Insert into HoaDon values('HD001','2000/10/25', 'KH001', 'NV001')
Insert into HoaDon values('HD002','2000/10/26', 'KH002', 'NV002')
Insert into HoaDon values('HD003','2000/10/27', 'KH003', 'NV003')
go
create table CTHoaDon(
SoHD char(10) not null,
MaSach char(10) not null,
NgayGiao date not null,
SoLuong int not null,
Gia int not null
primary key(SoHD,MaSach),
foreign key(SoHD) references HoaDon(SoHD),
foreign key(MaSach) references Sach(MaSach)
)
Insert into CTHoaDon values('HD001','S0002','2000/10/25', 3, 10000)
Insert into CTHoaDon values('HD001','S0001','2000/10/26', 1, 20000)
Insert into CTHoaDon values('HD002','S0001','2000/10/27', 2, 20000)
go
create table UserDN(
Username Char(10) primary key,
Password Char(10) not null
)
Insert into UserDN values('admin','123')
Insert into UserDN values('guess','123')
Insert into UserDN values('user','123')
Insert into UserDN values('hiep','123')
go


select * from CTHoaDon
select * from HoaDon
select * from KhachHang
select * from NhanVien
select * from NhaXuatBan
select * from Sach
select * from UserDN
go

create proc DoanhThu(@ngayban date, @ngaygiao date)
as
begin
	select CTHoaDon.SoHD as N'Số hoá đơn', CTHoaDon.MaSach as N'Mã sách', HoaDon.NgayBan as N'Ngày bán',
	CTHoaDon.SoLuong as'Số lượng', CTHoaDon.Gia as N'Đơn giá',
	CTHoaDon.SoLuong*CTHoaDon.Gia as N'Thành tiền' from HoaDon, CTHoaDon
	where CTHoaDon.SoHD = HoaDon.SoHD and HoaDon.NgayBan >= @ngayban and CTHoaDon.NgayGiao <= @ngaygiao
end
go

select * from CTHoaDon where SoHD like '%00%' or MaSach like '%1%'