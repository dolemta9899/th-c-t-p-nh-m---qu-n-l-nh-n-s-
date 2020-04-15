use HumanResourceManagement
go


create proc them_TK(@acc char(15),@pass char(15))
as
begin
if exists(select acc from TaiKhoan where acc=@acc) print('khong them duoc')
else
insert into TaiKhoan values(@acc,@pass)
end
go	

create proc them_PB(@mapb char(10),@tenpb nvarchar(30),@sdt char(10),@email char(30))
as
begin
if exists(select maPB from PhongBan where maPB=@mapb) print('khong them duoc')
else
insert into PhongBan values(@mapb,@tenpb,@sdt,@email)
end
go

create proc sua_PB(@mapb char(10),@tenpb nvarchar(30),@sdt char(10),@email char(30))
as
begin
update PhongBan
set tenPB=@tenpb,
	SDT=@sdt,
	[Email]=@email
where maPB=@mapb
end
go

create proc xoa_PB(@mapb char(10))
as
begin
delete NhanVien
where maPB=@mapb
delete PhongBan
where maPB=@mapb
end
go

create proc xuat_PB
as
begin
select maPB as[Mã Phòng Ban],tenPB as[Tên Phòng Ban],SDT as[Số Điện Thoại],Email
from PhongBan
end
go


create proc xuat_NV
as
begin
select maNV as[Mã Nhân Viên],tenNV as[Tên Nhân Viên],ngaySinh as[Ngày Sinh],gioiTinh as[Giới Tính],diaChi as[Địa Chỉ],NhanVien.SDT as[Số Điện Thoại],tenPB as[Tên Phòng Ban],Luong as[Lương]

from NhanVien,PhongBan
where NhanVien.maPB=PhongBan.maPB
end
go

create proc them_NV(@manv char(10),@tennv nvarchar(30) ,@ngaysinh date,@gioitinh nchar(5),@diachi nvarchar(50),@sdt char(13),@mapb char(10),@luong money)
as
begin
if exists(select maNV from NhanVien where maNV=@manv)
print ('khong them duoc')
else
insert into NhanVien values(@manv,@tennv,@ngaysinh,@gioitinh,@diachi,@sdt,@mapb,@luong)
end
go

create proc sua_NV(@manv char(10),@tennv nvarchar(30) ,@ngaysinh date,@gioitinh nchar(5),@diachi nvarchar(50),@sdt char(13),@mapb char(10),@luong money)
as
begin
update NhanVien
set tenNV=@tennv,
ngaySinh=@ngaysinh,
gioiTinh=@gioitinh,
diaChi=@diachi,
SDT=@sdt,
maPB=@mapb,
Luong=@luong
where maNV=@manv
end
go

create proc xoa_NV(@manv char(10))
as
begin
delete NhanVien
where maNV=@manv
end 
go

