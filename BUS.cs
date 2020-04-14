using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNS.DataAccessLayer;
using QLNS.ValueObject;

namespace QLNS.BUSLayer
{
    public class BUS
    {
      
        public static int them_TK(TaiKhoan a)
        {
            return DAO.them_TK(a);
        }
        //phong ban
        public static DataTable xuat_PB()
        {
            return DAO.xuat_PB();
        }
        public static int them_PB(PhongBan a)
        {
            return DAO.them_PB(a);
        }
        public static int sua_PB(PhongBan a)
        {
            return DAO.sua_PB(a);
        }
             public static int xoa_PB(PhongBan a)
        {
            return DAO.xoa_PB(a);
        }

        //nhan vien
        public static DataTable xuat_NV()
        {
            return DAO.xuat_NV();
        }
        public static int them_NV(NhanVien a)
        {
            return DAO.them_NV(a);
        }
        public static int sua_NV(NhanVien a)
        {
            return DAO.sua_NV(a);
        }
        public static int xoa_NV(NhanVien a)
        {
            return DAO.xoa_NV(a);
        }
    }


    
}

