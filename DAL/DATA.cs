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

        public static DataTable xuat_PB()
        {
            return DataProvider.GetData("xuat_PB");
        }

        //phong ban
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
        //nhan vien
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
        public static DataTable xuat_NV()
        {
            return DataProvider.GetData("xuat_NV");
        }
    }
}
