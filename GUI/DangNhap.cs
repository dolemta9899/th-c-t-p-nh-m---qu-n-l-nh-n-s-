using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
          
            InitializeComponent();
       
        }
        SqlConnection a = new SqlConnection(@"Data Source=DESKTOP-OBFA05G\SQLEXPRESS;Initial Catalog=QLNS4;Integrated Security=True");
   

        private void txttk_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txtmk.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtmk.UseSystemPasswordChar)
            {
                txtmk.UseSystemPasswordChar = false;
            }
            else
            {
                txtmk.UseSystemPasswordChar = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if ((txttk.Text == "") || (txtmk.Text == ""))
            {
                errortk.Icon = Properties.Resources._1481007008_Error;
                errortk.SetError(txttk, "Tài Khoản Lỗi");
                MessageBox.Show("Xin hãy Điền Đủ Thông Tin", "Thông Báo");
                return;
            }
            else
            {

                errortk.Icon = Properties.Resources._1481007037_Tick_Mark;
                errortk.SetError(txttk, "OK");

                SqlDataAdapter f = new SqlDataAdapter("select count(*) from TaiKhoan where acc='" + txttk.Text + "' and pass='" + txtmk.Text + "'", a);
                DataTable dt = new DataTable();
                f.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Main a = new Main();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Kiểm Tra Lại Mật Khẩu Hoặc Tài Khoản");
                }
            }
        }

        private void btntaotk_Click(object sender, EventArgs e)
        {
            taotk a = new taotk();
            a.Show();
        }

        private void txttk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttk.Text))
            {
                errortk.Icon = Properties.Resources._1481007008_Error;
                errortk.SetError(txttk, "Tài Khoản Lỗi");

            }
            else
            {
                errortk.Icon = Properties.Resources._1481007037_Tick_Mark;
                errortk.SetError(txttk, "OK");

            }



        }
    }
}
