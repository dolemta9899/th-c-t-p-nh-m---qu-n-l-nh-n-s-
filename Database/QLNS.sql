create database HumanResourceManagement
go
use HumanResourceManagement
go


create table TaiKhoan(
acc char(15) not null primary key,
pass char(15) not null
)
go
create table PhongBan(
	[maPB] [char](10) NOT NULL,
	[tenPB] [nvarchar](30) NOT NULL,
	[SDT] [char](10) NULL,
	[Email] [char](30) NULL,
	
);
go

create table NhanVien(
	[maNV] [char](10) NOT NULL,
	[tenNV] [nvarchar](30) NOT NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nchar](5) NULL,
	[diaChi] [nvarchar](50) NULL,
	[SDT] [char](13) NULL,
	[maPB] [char](10) NOT NULL,
	[Luong] [money] NULL,
);
go
alter table NhanVien add primary key(maNV)
alter table PhongBan add primary key(maPB)
alter table NhanVien
add constraint M foreign key(maPB) references PhongBan(maPB)


------------------------DU Lieu
insert into PhongBan values('00001',N'Kế Hoạch',null,null)
insert into PhongBan values('00002',N'Đầu Tư',null,null)
insert into NhanVien values('00001',N'Nguyễn Đức Mạnh','1996-04-19',N'Nam',N'Bắc Ninh','0123456789','00001','20000')


insert into NhanVien values('00002',N'Nguyễn Đức Cảnh','1996-02-19',N'Nam',N'Bắc Giang','0123436789','00002','30000')

insert into NhanVien values('00003',N'Nguyễn Thị Lan','1996-03-29',N'Nữ',N'Vĩnh Phúc','0123456589','00001','40000')

insert into NhanVien values('00004',N'Nguyễn Kim Yến','1996-12-19',N'Nữ',N'hải Phòng','0123456989','00002','50000')

insert into TaiKhoan values('admin','1')


