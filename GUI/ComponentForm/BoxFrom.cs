using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.ComponentForm
{
    public partial class BoxFrom : UserControl
    {
        #region Properties
        private FormWindowState fwState;
        private Point locationFrm;
        private Size frmSize;
        private Form frm;
        #endregion

        #region Get/Set
        public Form FormMain
        {
            get
            {
                return frm;
            }

            set
            {
                frm = value;
                if(frm!=null)
                {
                    locationFrm = frm.Location;
                    fwState = frm.WindowState;
                    frmSize = frm.Size;
                    frm.SizeChanged += Frm_SizeChanged;
                }
            }
        }
    
        private void Frm_SizeChanged(object sender, EventArgs e)
        {
            if (fwState == FormWindowState.Normal)
                frmSize = frm.Size;
        }
        #endregion

        #region Create
        public BoxFrom()
        {
            InitializeComponent();
            this.boxExit.Click += BoxExit_Click;
            this.boxMini.Click += BoxMini_Click;
            this.boxMax.Click += BoxMax_Click;
        }
        #endregion

        #region Event Click
        private void BoxMax_Click(object sender, EventArgs e)
        {
            if(fwState== FormWindowState.Normal)
            {
                fwState = FormWindowState.Maximized;
                locationFrm = frm.Location;
                frm.Location = Screen.PrimaryScreen.WorkingArea.Location;
                frm.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }
            else if (fwState==FormWindowState.Maximized)
            {
                frm.Location = locationFrm;
                frm.Size = frmSize;
                fwState = FormWindowState.Normal;
            }
        }

        private void BoxMini_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
        }

        private void BoxExit_Click(object sender, EventArgs e)
        {
            frm.Close();
        }
        #endregion

        #region Properties
        public enum BxStyle { Row, Column }
        private BxStyle bxSty = BxStyle.Row;
        private PictureBox boxExit;
        private PictureBox boxMini;
        private PictureBox boxMax;
        #endregion

        #region Get/Set
        public BxStyle BoxStyle
        {
            get
            {
                return bxSty;
            }

            set
            {
                if (value != bxSty)
                {
                    bxSty = value;
                    setProperties();
                }
            }
        }
        #endregion

        #region Function
        private void setProperties()
        {
            if (bxSty == BxStyle.Row)
            {
                this.MinimumSize = new Size(55, 15);
                this.MaximumSize = new Size(55, 15);
                this.Size = new Size(55, 15);
                this.boxExit.Location = new Point(0, 0);
                this.boxMini.Location = new Point(20, 0);
                this.boxMax.Location = new Point(40, 0);
            }
            else
            {
                this.MinimumSize = new Size(15, 55);
                this.MaximumSize = new Size(15, 55);
                this.Size = new Size(15, 55);
                this.boxExit.Location = new Point(0, 0);
                this.boxMini.Location = new Point(0, 20);
                this.boxMax.Location = new Point(0, 40);
            }
        }
        #endregion

        #region Event Mouse
        private bool moveMax = true;
        private void boxMax_MouseDown(object sender, MouseEventArgs e)
        {
            moveMax = true;
            this.boxMax.Image = GUI.Properties.Resources.icon_maxsize_mac_clk_1;
        }

        private void boxMax_MouseLeave(object sender, EventArgs e)
        {
            moveMax = true;
            this.boxMax.Image = GUI.Properties.Resources.icon_maxsize_mac_nor_1;
        }

        private void boxMax_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveMax)
            {
                moveMax = false;
                this.boxMax.Image = GUI.Properties.Resources.icon_maxsize_mac_hor_1;
            }
        }

        private void boxMax_MouseUp(object sender, MouseEventArgs e)
        {
            moveMax = true;
            this.boxMax.Image = GUI.Properties.Resources.icon_maxsize_mac_nor_1;
        }

        private bool moveMin = true;

        private void boxMini_MouseDown(object sender, MouseEventArgs e)
        {
            moveMin = true;
            this.boxMini.Image = GUI.Properties.Resources.icon_mini_mac_clk_1;
        }

        private void boxMini_MouseUp(object sender, MouseEventArgs e)
        {
            moveMin = true;
            this.boxMini.Image = GUI.Properties.Resources.icon_mini_mac_nor_1;
        }

        private void boxMini_MouseLeave(object sender, EventArgs e)
        {
            moveMin = true;
            this.boxMini.Image = GUI.Properties.Resources.icon_mini_mac_nor_1;
        }

        private void boxMini_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveMin)
            {
                moveMin = false;
                this.boxMini.Image = GUI.Properties.Resources.icon_mini_mac_hor_1;
            }
        }

        private bool moveExt = true;

        private void boxExit_MouseDown(object sender, MouseEventArgs e)
        {
            moveExt = true;
            this.boxExit.Image = GUI.Properties.Resources.ico_exit_mac_clk_1;
        }

        private void boxExit_MouseUp(object sender, MouseEventArgs e)
        {
            moveExt = true;
            this.boxExit.Image = GUI.Properties.Resources.ico_exit_mac_nor_1;
        }

        private void boxExit_MouseLeave(object sender, EventArgs e)
        {
            moveExt = true;
            this.boxExit.Image = GUI.Properties.Resources.ico_exit_mac_nor_1;
        }

        private void boxExit_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveExt)
            {
                moveExt = false;
                this.boxExit.Image = GUI.Properties.Resources.ico_exit_mac_hor_1;

            }
        }

        private void BoxFrom_Resize(object sender, EventArgs e)
        {
            setProperties();
        }
        #endregion
    }
}
