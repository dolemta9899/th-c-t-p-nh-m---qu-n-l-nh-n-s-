using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLNS.ValueObject;

namespace QLNS.DataAccessLayer
{
    public class DAO
    {

      

        public static int them_TK(TaiKhoan a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@acc", a.Acc),
                new SqlParameter("@pass", a.Pass),
               
            };
            return DataProvider.ExecuteNonQuery("them_TK", para);

        }
        //phong ban
        public static DataTable xuat_PB()
        {
            return DataProvider.GetData("xuat_PB");
        }
        public static int them_PB(PhongBan a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapb", a.MaPB),
                new SqlParameter("@tenpb", a.TenPB),
                new SqlParameter("@sdt", a.SDT1),
                new SqlParameter("@email", a.Email1),

            };
            return DataProvider.ExecuteNonQuery("them_PB", para);
        }
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
        public static int xoa_PB(PhongBan a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapb", a.MaPB),
             

            };
            return DataProvider.ExecuteNonQuery("xoa_PB", para);
        }

        //Nhan Vien
        public static DataTable xuat_NV()
        {
            return DataProvider.GetData("xuat_NV");
        }
        public static int them_NV(NhanVien a)
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
            return DataProvider.ExecuteNonQuery("them_NV", para);
        }
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
        public static int xoa_NV(NhanVien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv", a.MaNV),
               

            };
            return DataProvider.ExecuteNonQuery("xoa_NV", para);
        }


    }
}
