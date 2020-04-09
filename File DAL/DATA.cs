           //Phong Ban             

        public static int sua_PB(PhongBan a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapb", a.MaPB),
                new SqlParameter("@tenpb", a.TenPB),
                new SqlParameter("@sdt", a.SDT1),
                new SqlParameter("@email", a.Email1),

            };
            return DataProvider.ExecuteNonQuery("sua_PB", para);
        }
       
        //Nhan Vien
       
        public static int sua_NV(NhanVien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", a.MaNV),
                new SqlParameter("@tennv", a.TenNV),
                new SqlParameter("@ngaysinh", a.NgaySinh),
                new SqlParameter("@gioitinh", a.GioiTinh),
                new SqlParameter("@diachi", a.DiaChi),
                  new SqlParameter("@sdt", a.SDT1),
                    new SqlParameter("@mapb", a.MaPB),
                      new SqlParameter("@luong", a.Luong1),

            };
            return DataProvider.ExecuteNonQuery("sua_NV", para);
        }
       
