using GUI.ComponentForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panmenu_Paint(object sender, PaintEventArgs e)
        {
            //menuStrip1.Hide();
        }

        private void flat_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void flat_sach_Click(object sender, EventArgs e)
        {
            UC.NhanVien a = new UC.NhanVien();
            a.Dock = DockStyle.Fill;
            paluse.Controls.Add(a);
            foreach (Control ctrl in paluse.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }
        }

       

     

       

        private void flat_timkiem_Click(object sender, EventArgs e)
        {
            UC.TimKiem a = new UC.TimKiem();
            a.Dock = DockStyle.Fill;
            paluse.Controls.Add(a);
            foreach (Control ctrl in paluse.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }

        }

        private void flat_thongke_Click(object sender, EventArgs e)
        {
            UC.PhongBan a = new UC.PhongBan();
            a.Dock = DockStyle.Fill;
            paluse.Controls.Add(a);
            foreach (Control ctrl in paluse.Controls)
            {
                if (ctrl != a)
                    ctrl.Dispose();
            }


        }

        private void fl_help_Click(object sender, EventArgs e)
        {
            Process.Start("http://quanlyns.comeze.com/");
        }

        private void help_Click(object sender, EventArgs e)
        {
            Process.Start("http://quanlyns.comeze.com/");
        }

        private void panmenu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode==Keys.H)
                Process.Start("http://quanlyns.comeze.com/");
        }
    }
}
