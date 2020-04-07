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

    }
}
