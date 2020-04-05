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

