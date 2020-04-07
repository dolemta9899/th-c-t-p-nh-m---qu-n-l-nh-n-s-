using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GUI.ComponentForm
{
    [DefaultEvent("Click")]
    public partial class Thin_Button : UserControl
    {
        #region Create
        public Thin_Button()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }
        #endregion

        #region Properties
        //Active
        private bool active = false;
        private bool usgAct = false;

        //Border
        private int sizeBdr = 1;
        private Color clrBdr = Color.Green;
        private Color clrBdrNor = Color.Green;
        private Color clrBdrHor;
        private Color clrBdrClk;
        private Color clrBdrDisable;
        private bool usgBdrHorClk = false;

        //Inner
        private Color clrInr = Color.Transparent;
        private Color clrInrNor = Color.Transparent;
        private Color clrInrHor;
        private Color clrInrClk;
        private Color clrInrDisable;
        private bool usgInrHorClk = false;

        //Text
        private string text = "Thin_Buttom";
        private Color txtClr = Color.Black;
        private Color txtClrNor = Color.Black;
        private Color txtClrHor;
        private Color txtClrClk;
        private Color txtClrDisable;
        private StringAlignment txtAlignmentHorizontal = StringAlignment.Center;
        private StringAlignment txtAlignmentVertical = StringAlignment.Center;
        private bool usgTxtHorClick = false;
        #endregion

        #region Get/Set
        #region Active
        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                if (value)
                    foreach (Control ctrl in this.Parent.Controls)
                    {
                        Thin_Button tbtn = (Thin_Button)(ctrl as Thin_Button);
                        if (tbtn != null && tbtn.active)
                        {
                            tbtn.Active = false;
                            tbtn.clrBdr = tbtn.clrBdrNor;
                            tbtn.clrInr = tbtn.clrInrNor;
                            tbtn.txtClr = tbtn.txtClrNor;
                            tbtn.Invalidate();
                        }
                    }
                active = value;
            }
        }

        public bool UseActive
        {
            get
            {
                return usgAct;
            }

            set
            {
                usgAct = value;
            }
        }
        #endregion

        #region Border
        public int SizeBorder
        {
            get
            {
                return sizeBdr;
            }

            set
            {
                sizeBdr = value;
                Invalidate();
            }
        }

        public Color BorderColorNomal
        {
            get
            {
                return clrBdrNor;
            }

            set
            {
                clrBdrNor = value;
                clrBdr = clrBdrNor;
                Invalidate();
            }
        }

        public Color BorderColorHover
        {
            get
            {
                return clrBdrHor;
            }

            set
            {
                clrBdrHor = value;
            }
        }

        public Color BorderColorClick
        {
            get
            {
                return clrBdrClk;
            }

            set
            {
                clrBdrClk = value;
            }
        }

        public Color BoderColorDisable
        {
            get
            {
                return clrBdrDisable;
            }

            set
            {
                clrBdrDisable = value;
            }
        }
        public bool UseBorderColorHoverClick
        {
            get
            {
                return usgBdrHorClk;
            }

            set
            {
                usgBdrHorClk = value;
            }
        }
        #endregion

        #region Inner
        public Color InnerColorNomal
        {
            get
            {
                return clrInrNor;
            }

            set
            {
                clrInrNor = value;
                clrInr = clrInrNor;
                Invalidate();
            }
        }

        public Color InnerColorHover
        {
            get
            {
                return clrInrHor;
            }

            set
            {
                clrInrHor = value;
            }
        }

        public Color InnerColorClick
        {
            get
            {
                return clrInrClk;
            }

            set
            {
                clrInrClk = value;
            }
        }

        public Color InnerColorDisable
        {
            get
            {
                return clrInrDisable;
            }

            set
            {
                clrInrDisable = value;
            }
        }

        public bool UseInnerColorHoverClick
        {
            get
            {
                return usgInrHorClk;
            }

            set
            {
                usgInrHorClk = value;
            }
        }
        #endregion

        #region Text
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
                Invalidate();
            }
        }

        public Color TextColorNomal
        {
            get
            {
                return txtClrNor;
            }

            set
            {
                txtClrNor = value;
                txtClr = txtClrNor;
                Invalidate();
            }
        }

        public Color TextColorHover
        {
            get
            {
                return txtClrHor;
            }

            set
            {
                txtClrHor = value;
            }
        }

        public Color TextColorClick
        {
            get
            {
                return txtClrClk;
            }

            set
            {
                txtClrClk = value;
            }
        }

        public Color TextColorDisable
        {
            get
            {
                return txtClrDisable;
            }

            set
            {
                txtClrDisable = value;
            }
        }

        public StringAlignment TextAlignmentHorizontal
        {
            get
            {
                return txtAlignmentHorizontal;
            }

            set
            {
                txtAlignmentHorizontal = value;
                Invalidate();
            }
        }

        public StringAlignment TextAlignmentVertical
        {
            get
            {
                return txtAlignmentVertical;
            }

            set
            {
                txtAlignmentVertical = value;
                Invalidate();
            }
        }

        public bool UseTextColorHoverClick
        {
            get
            {
                return usgTxtHorClick;
            }

            set
            {
                usgTxtHorClick = value;
            }
        }
        #endregion
        #endregion

        #region Function
        private GraphicsPath GetGraphicsPath(RectangleF rect)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            if (rect.Width < Height)
                gp.AddRectangle(new Rectangle(sizeBdr / 2, sizeBdr / 2, this.Width - sizeBdr, this.Height - sizeBdr));
            else
            {
                gp.AddArc(sizeBdr / 2, sizeBdr / 2, rect.Height - sizeBdr, rect.Height - sizeBdr - 1, 90, 180);
                gp.AddArc(rect.Right - rect.Height - sizeBdr / 2, sizeBdr / 2, rect.Height - sizeBdr, rect.Height - sizeBdr - 1, 270, 180);
            }
            gp.CloseFigure();
            return gp;
        }
        #endregion

        #region Event
        private void Thin_Button_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //MessageBox.Show("Test");
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath gp = GetGraphicsPath(new Rectangle(0, 0, this.Width, this.Height));
                e.Graphics.FillPath(new SolidBrush(clrInr), gp);
                e.Graphics.DrawPath(new Pen(clrBdr, sizeBdr), gp);
                StringFormat strFM = new StringFormat();
                strFM.Alignment = txtAlignmentHorizontal;
                strFM.LineAlignment = txtAlignmentVertical;
                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new Rectangle(0, 0, this.Width, this.Height), strFM);

                gp.Dispose();
                strFM.Dispose();
            }
            catch
            {

            }
        }

        protected override void OnResize(EventArgs e) { }

        protected override void OnBackColorChanged(EventArgs e) { }

        private bool move = true;
        private void Thin_Button_MouseDown(object sender, MouseEventArgs e)
        {
            move = false;
            if (usgAct) Active = true;
            if (usgInrHorClk) clrInr = clrInrClk;
            if (usgBdrHorClk) clrBdr = clrBdrClk;
            if (usgTxtHorClick) txtClr = txtClrClk;
            Invalidate();
        }

        private void Thin_Button_MouseUp(object sender, MouseEventArgs e)
        {
            move = true;
            if (!usgAct || !active)
            {
                clrInr = clrInrNor;
                clrBdr = clrBdrNor;
                txtClr = txtClrNor;
                Invalidate();
            }
        }

        private void Thin_Button_MouseLeave(object sender, EventArgs e)
        {
            if (!usgAct || !active)
            {
                move = true;
                clrInr = clrInrNor;
                clrBdr = clrBdrNor;
                txtClr = txtClrNor;
                Invalidate();
            }
        }

        private void Thin_Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (!usgAct || !active)
                if (move)
                {
                    move = false;
                    if (usgInrHorClk) clrInr = clrInrHor;
                    if (usgBdrHorClk) clrBdr = clrBdrHor;
                    if (usgTxtHorClick) txtClr = txtClrHor;
                    Invalidate();
                }
        }
        #endregion

        #region Hide Properties
        [Browsable(false)]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }

        [Browsable(false)]
        public override RightToLeft RightToLeft
        {
            get
            {
                return base.RightToLeft;
            }
            set
            {
                base.RightToLeft = value;
            }
        }

        //[Browsable(false)]
        //public override Color BackColor
        //{
        //    get
        //    {
        //        return base.BackColor;
        //    }
        //    set
        //    {
        //        base.BackColor = value;
        //    }
        //}

        [Browsable(false)]
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }

        [Browsable(false)]
        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return base.BackgroundImageLayout;
            }
            set
            {
                base.BackgroundImageLayout = value;
            }
        }
        #endregion

        private void Thin_Button_EnabledChanged(object sender, EventArgs e)
        {
            if(!this.Enabled)
            {
                clrBdr = clrBdrDisable;
                clrInr = clrInrDisable;
                txtClr = txtClrDisable;
                Invalidate();
            }
            else
            {
                clrBdr = clrBdrNor;
                clrInr = clrInrNor;
                txtClr = txtClrNor;
                Invalidate();
            }
        }
    }
}
