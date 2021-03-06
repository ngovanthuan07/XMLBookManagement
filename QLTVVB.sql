create database QLTVVB
go
use QLTVVB
go
create table QTV(
TenDN char(20) primary key,
Pass char(20),
TenQTV nvarchar(30),
Ngaysinh char(10),
Thongtin nvarchar(100),
Sdt char(10) check(Sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Diachi nvarchar(50))
go
create table TacGia(
MaTacGia char(5) primary key,
TenTacGia nvarchar(30))
go
create table TheLoai(
MaTheLoai char(5) primary key,
TenTheLoai nvarchar(30))
go
create table NhaXuatBan(
MaNXB char(5) primary key,
TenNXB nvarchar(30))
go
create table DocGia(
MaDocGia char(5) primary key,
TenDocGia nvarchar(30),
Ngaysinh char(10),
Gioitinh nchar(3) check(Gioitinh in ('Nam',N'Nữ')),
CMND char(10) check(CMND like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
SDT char(10) check(SDT like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Diachi nvarchar(50))
go
create table NhanVien(
MaNV char(5) primary key,
TenNV nvarchar(30),
Ngaysinh char(10),
Gioitinh nchar(3) check(Gioitinh in ('Nam',N'Nữ')),
NgayVaoLam char(10),
CMND char(10) check(CMND like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
SDT char(10) check(SDT like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
ChucVu nchar(20),
DiaChi nvarchar(50))
go
create table Sach(
MaSach char(5) primary key,
TenSach nvarchar(100),
MaTacGia char(5) foreign key references TacGia(MaTacGia)on delete cascade on update cascade,
MaTheLoai char(5) foreign key references TheLoai(MaTheLoai)on delete cascade on update cascade,
MaNXB char(5) foreign key references NhaXuatBan(MaNXB)on delete cascade on update cascade,
NamSX int)
go
create table MuonSach(
MaID char(5),
MaNV char(5) foreign key references NhanVien(MaNV) on delete cascade on update cascade,
MaDocGia char(5) foreign key references DocGia(MaDocGia) on delete cascade on update cascade,
SoLuongMS int,
Ngaymuon char(10),
Ngaytra char(10),
Trangthai char(5) check (Trangthai in ('true','false')),
primary key(MaID,MaDocGia)
)
go
create table CTMuonSach(
MaCTMS int IDENTITY(1,1) primary key,
MaDocGia char(5) foreign key references DocGia(MaDocGia) on delete cascade on update cascade,
MaSach char(5) foreign key references Sach(MaSach) on delete cascade on update cascade)
go
insert into QTV(TenDN,Pass,TenQTV,Ngaysinh,Thongtin,Sdt,Diachi)
values('admin','admin',N'Chung Hiếu Thuần','06/10/2000',N'SV Năm II - IT','0941780740',N'Đà Nẵng')
go
insert into DocGia(MaDocGia,TenDocGia,Ngaysinh,Gioitinh,CMND,SDT,Diachi)
values('DG01',N'Nguyễn Văn A','06/04/2002',N'Nữ','241760321','0123456789',N'Hải Châu-Đà Nẵng'),
('DG02',N'Nguyễn Văn B','06/04/2002','Nam','241760321','0123456789',N'Hải Châu-Đà Nẵng'),
('DG03',N'Nguyễn Văn C','06/04/2002',N'Nữ','241760321','0123456789',N'Hải Châu-Đà Nẵng'),
('DG04',N'Nguyễn Văn D','06/04/2002',N'Nữ','241760321','0123456789',N'Hải Châu-Đà Nẵng'),
('DG05',N'Nguyễn Thị E','06/04/2002',N'Nữ','241760321','0123456789',N'Hải Châu-Đà Nẵng'),
('DG06',N'Nguyễn Văn F','06/04/2002',N'Nữ','241760321','0123456789',N'Hải Châu-Đà Nẵng'),
('DG07',N'Nguyễn Văn G','06/04/2002',N'Nữ','241760321','0123456789',N'Hải Châu-Đà Nẵng'),
('DG08',N'Nguyễn Thị H','06/04/2002',N'Nữ','241760321','0123456789',N'Hải Châu-Đà Nẵng')
GO
insert into TacGia(MaTacGia,TenTacGia)
values('TG01',N'Hồ Chí Minh'),
('TG02',N'Nguyễn Trãi'),
('TG03',N'Nguyễn Nhật Ánh'),
('TG04',N'Nguyễn Huệ'),
('TG05',N'Tô Hoài')
go
insert into TheLoai(MaTheLoai,TenTheLoai)
values('TL01',N'Tự do'),
('TL02',N'Ngôn Tình'),
('TL03',N'Thơ'),
('TL04',N'Chính Trị'),
('TL05',N'Giáo Trình')
go
insert into NhaXuatBan(MaNXB,TenNXB)
values('NXB01',N'Kim Đồng'),
('NXB02',N'NXB Trẻ'),
('NXB03',N'Đại Học Quốc Gia'),
('NXB04',N'Tự Do'),
('NXB05',N'Thông tin và truyền thông')
go
insert into NhanVien(MaNV,TenNV,Ngaysinh,Gioitinh,NgayVaoLam,CMND,SDT,ChucVu,DiaChi)
values('NV01',N'Nguyễn Văn A','06/10/2000','Nam','23/12/2019','241760361','0123456789',N'Phó thư',N'Hải Châu-Đà Nẵng'),
('NV02',N'Nguyễn Thị B','06/10/2000',N'Nữ','23/12/2019','241760361','0123456789',N'Phó thư',N'Hải Châu-Đà Nẵng'),
('NV03',N'Nguyễn Văn C','06/10/2000','Nam','23/12/2019','241760361','0123456789',N'Phó thư',N'Hải Châu-Đà Nẵng'),
('NV04',N'Nguyễn Thị D','06/10/2000',N'Nữ','23/12/2019','241760361','0123456789',N'Phó thư',N'Hải Châu-Đà Nẵng'),
('NV05',N'Nguyễn Văn E','06/10/2000','Nam','23/12/2019','241760361','0123456789',N'Phó thư',N'Hải Châu-Đà Nẵng')
go
insert into Sach(MaSach,TenSach,MaTacGia,MaTheLoai,MaNXB,NamSX)
values('S01',N'Cho tôi một vé về tuổi thơ','TG03','TL02','NXB02',2000),
('S02',N'Bạn đến chơi nhà','TG04','TL02','NXB02',2000),
('S03',N'Ngắm Trăng','TG01','TL03','NXB02',2000),
('S04',N'Ngày xưa có một chuyện tình','TG03','TL02','NXB02',2000),
('S05',N'Mắt Biếc','TG03','TL02','NXB02',2000),
('S06',N'Bàn có 5 chổ ngồi','TG03','TL02','NXB02',2000),
('S07',N'999 bức thư gửi cho chính mình','TG03','TL02','NXB02',2000),
('S08',N'Lập trình cơ bản với C','TG03','TL02','NXB02',2000),
('S09',N'Bong bóng lên trời','TG03','TL02','NXB02',2000),
('S10',N'Truyện Kiều','TG04','TL03','NXB02',2000)
go
insert into MuonSach(MaID,MaNV,MaDocGia,SoLuongMS,Ngaymuon,Ngaytra,Trangthai)
values('MS01','NV01','DG01',0,'26/10/2019','28/11/2019','true'),
('MS02','NV02','DG02',1,'26/10/2019','28/11/2019','false'),
('MS03','NV03','DG03',0,'26/10/2019','28/11/2019','false'),
('MS04','NV04','DG04',1,'26/10/2019','28/11/2019','false'),
('MS05','NV05','DG05',2,'26/06/2020','28/11/2020','false')
go
insert into CTMuonSach(MaDocGia,MaSach)
values('DG02','S01'),
('DG04','S02'),
('DG05','S03'),
('DG05','S04')