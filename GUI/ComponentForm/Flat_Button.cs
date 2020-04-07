using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.ComponentForm
{
    [DefaultEvent("Click")]
    public partial class Flat_Button : UserControl
    {
        #region Create
        public Flat_Button()
        {
            this.MinimumSize = new Size(23, 23);
            this.BackColor = bckClrNor;
            InitializeComponent();
        }
        #endregion

        #region Properties
        //Active
        private bool active = false;
        private bool usgAct = false;

        //BackgroundColor
        private Color bckClrNor = Color.Transparent;
        private Color bckClrHor;
        private Color bckClrClk;
        private bool usgBckClrHorClk = false;

        //Line
        public enum LinePosition { Top, Buttom, Left, Right, None }
        private int lnSize = 3;
        private Color lnClr = Color.Green;
        private Color lnClrNor = Color.Green;
        private Color lnClrHor;
        private Color lnClrClk;
        private LinePosition lnLayout = LinePosition.None;
        bool usgLnHorClk = false;

        //Icon
        public enum IconPosition { LeftOfText, RightOfText, OnlyText, OnlyIcon }
        private Image ico;
        private Image icoNor;
        private Image icoHor;
        private Image icoClk;
        private Size icoSize = new Size(20, 20);
        private int iconAln = 3;
        private IconPosition icoPos = IconPosition.OnlyText;
        private bool usgIcoHorClk = false;

        //Text
        string text;
        Color txtClr = Color.Black;
        Color txtClrNor = Color.Black;
        Color txtClrHor;
        Color txtClrClk;
        StringAlignment txtAlnHor = StringAlignment.Center;
        StringAlignment txtAlnVer = StringAlignment.Center;
        bool usgTxtHorClk = false;
        #endregion

        #region Get/Set properties
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
                        Flat_Button flb = (Flat_Button)(ctrl as Flat_Button);
                        if (flb != null && flb.active)
                        {
                            flb.Active = false;
                            flb.ico = flb.icoNor;
                            flb.lnClr = flb.lnClrNor;
                            flb.txtClr = flb.txtClrNor;
                            flb.BackColor = flb.bckClrNor;
                            flb.Invalidate();
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

        #region BackColor
        [Browsable(false)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        public Color BackgroundColorNormal
        {
            get
            {
                return bckClrNor;
            }

            set
            {
                bckClrNor = value;
                this.BackColor = bckClrNor;
                Invalidate();
            }
        }

        public Color BackgroundColorHover
        {
            get
            {
                return bckClrHor;
            }

            set
            {
                bckClrHor = value;
            }
        }

        public Color BackgroundColorClick
        {
            get
            {
                return bckClrClk;
            }

            set
            {
                bckClrClk = value;
            }
        }

        public bool UseBackgroundHoverClick
        {
            get
            {
                return usgBckClrHorClk;
            }
            set
            {
                usgBckClrHorClk = value;
            }
        }
        #endregion

        #region Line
        public int LineSize
        {
            get
            {
                return lnSize;
            }

            set
            {
                setSizeLine(value);
                Invalidate();
            }
        }

        public Color LineColorNormal
        {
            get
            {
                return lnClrNor;
            }

            set
            {
                lnClrNor = value;
                lnClr = lnClrNor;
                Invalidate();
            }
        }

        public Color LineColorHover
        {
            get
            {
                return lnClrHor;
            }

            set
            {
                lnClrHor = value;
            }
        }

        public Color LineColorClick
        {
            get
            {
                return lnClrClk;
            }

            set
            {
                lnClrClk = value;
            }
        }

        public LinePosition LineLayout
        {
            get
            {
                return lnLayout;
            }

            set
            {
                lnLayout = value;
                if (lnLayout == LinePosition.None) lnSize = 0;
                else if (lnSize == 0) setSizeLine(3);
                Invalidate();
            }
        }

        public bool UseLineHoverClick
        {
            get
            {
                return usgLnHorClk;
            }

            set
            {
                usgLnHorClk = value;
            }
        }
        #endregion

        #region Icon
        public Image IconNormal
        {
            get
            {
                return icoNor;
            }

            set
            {
                icoNor = value;
                ico = icoNor;
                Invalidate();
            }
        }

        public Image IconHover
        {
            get
            {
                return icoHor;
            }

            set
            {
                icoHor = value;
            }
        }

        public Image IconClick
        {
            get
            {
                return icoClk;
            }

            set
            {
                icoClk = value;
            }
        }

        public IconPosition IconPositions
        {
            get
            {
                return icoPos;
            }

            set
            {
                icoPos = value;
                if (icoPos == IconPosition.OnlyText) icoSize = new Size(0, 0);
                else if (ico.Size.Width == 0 || IconSize.Height == 0) setSizeIcon(new Size(20, 20));
                Invalidate();
            }
        }

        public Size IconSize
        {
            get
            {
                return icoSize;
            }

            set
            {
                setSizeIcon(value);
                Invalidate();
            }
        }

        public int IconAlignment
        {
            get
            {
                return iconAln;
            }

            set
            {
                setSizeIconAln(value);
                Invalidate();
            }
        }

        public bool UseIconHoverClick
        {
            get
            {
                return usgIcoHorClk;
            }

            set
            {
                usgIcoHorClk = value;
            }
        }
        #endregion

        #region text
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
            }
        }

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
        public Color TextColorNormal
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

        public StringAlignment TextAlignmentHorizontal
        {
            get
            {
                return txtAlnHor;
            }

            set
            {
                txtAlnHor = value;
                Invalidate();
            }
        }

        public StringAlignment TextAlignmentVertical
        {
            get
            {
                return txtAlnVer;
            }

            set
            {
                txtAlnVer = value;
                Invalidate();
            }
        }

        public bool UseTextHoverClick
        {
            get
            {
                return usgTxtHorClk;
            }

            set
            {
                usgTxtHorClk = value;
            }
        }
        #endregion
        #endregion

        #region Function
        private void setSizeLine(int value)
        {
            if (value >= 0 && value != lnSize)
            {
                if (lnLayout == LinePosition.Buttom || lnLayout == LinePosition.Top)
                {
                    if (value + icoSize.Height <= this.Height)
                        lnSize = value;
                }
                else if (lnLayout == LinePosition.Left || lnLayout == LinePosition.Right)
                {
                    if (value + icoSize.Width + iconAln <= this.Height)
                        lnSize = value;
                }
                else lnSize = 0;
                if (lnSize == 0) lnLayout = LinePosition.None;
            }
        }

        private void setSizeIcon(Size value)
        {
            if (icoPos != IconPosition.OnlyText && value != icoSize && value.Width >= 0 && value.Height >= 0)
            {
                if (lnLayout == LinePosition.Buttom || lnLayout == LinePosition.Top)
                {
                    if (value.Height + lnSize <= this.Height && value.Width + iconAln <= this.Width)
                        icoSize = value;
                }
                else if (lnLayout == LinePosition.Left || lnLayout == LinePosition.Right)
                {
                    if (value.Width + lnSize + iconAln <= this.Width && value.Height <= this.Height)
                        icoSize = value;
                }
                else
                {
                    if (value.Width + iconAln <= this.Width && value.Height <= this.Height)
                        icoSize = value;
                }
                if (icoSize.Height == 0 || IconSize.Width == 0) icoPos = IconPosition.OnlyText;
            }
        }

        private void setSizeIconAln(int value)
        {
            if (value >= 0 && value != iconAln)
            {
                if (lnLayout == LinePosition.Left || lnLayout == LinePosition.Right)
                {
                    if (value + lnSize + icoSize.Width <= this.Width)
                        iconAln = value;
                }
                else
                {
                    if (value + IconSize.Width <= this.Width)
                        iconAln = value;
                }
            }
        }
        #endregion

        #region Event
        private void Flat_Button_Paint(object sender, PaintEventArgs e)
        {
            if (ico == null) icoPos = IconPosition.OnlyText;
            switch (lnLayout)
            {
                case LinePosition.Buttom:
                    //vẽ line
                    e.Graphics.FillRectangle(new SolidBrush(lnClr), new Rectangle(0, this.Height - lnSize, this.Width, lnSize));
                    switch (icoPos)
                    {
                        case IconPosition.OnlyIcon:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln, (this.Height - lnSize - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            break;
                        case IconPosition.OnlyText:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(this.ForeColor),
                                    new RectangleF(0, 0, this.Width, this.Height - lnSize), strFM);
                            }
                            break;
                        case IconPosition.LeftOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln, (this.Height - lnSize - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(iconAln + icoSize.Width,
                                    0, this.Width - iconAln - icoSize.Width, this.Height - lnSize), strFM);
                            }
                            break;
                        case IconPosition.RightOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(this.Width - iconAln - icoSize.Width, (this.Height - lnSize - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width - iconAln - icoSize.Width,
                                    this.Height - lnSize), strFM);
                            }
                            break;
                    }
                    break;
                case LinePosition.Top:
                    e.Graphics.FillRectangle(new SolidBrush(lnClr), new Rectangle(0, 0, this.Width, lnSize));
                    switch (icoPos)
                    {
                        case IconPosition.OnlyIcon:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln, (this.Height - lnSize - icoSize.Height) / 2 + lnSize, icoSize.Width, icoSize.Height));
                            break;
                        case IconPosition.OnlyText:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr),
                                    new RectangleF(0, lnSize, this.Width, this.Height - lnSize), strFM);
                            }
                            break;
                        case IconPosition.LeftOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln, (this.Height - lnSize - icoSize.Height) / 2 + lnSize, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(iconAln + icoSize.Width,
                                    lnSize, this.Width - iconAln - icoSize.Width, this.Height - lnSize), strFM);
                            }
                            break;
                        case IconPosition.RightOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(this.Width - iconAln - icoSize.Width, (this.Height - lnSize - icoSize.Height) / 2 + lnSize, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(0, lnSize, this.Width - iconAln - icoSize.Width,
                                    this.Height - lnSize), strFM);
                            }
                            break;
                    }
                    break;
                case LinePosition.Left:
                    e.Graphics.FillRectangle(new SolidBrush(lnClr), new Rectangle(0, 0, lnSize, this.Height));
                    switch (icoPos)
                    {
                        case IconPosition.OnlyIcon:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln + lnSize, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            break;
                        case IconPosition.OnlyText:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr),
                                    new RectangleF(lnSize, 0, this.Width - lnSize, this.Height), strFM);
                            }
                            break;
                        case IconPosition.LeftOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln + lnSize, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(iconAln + icoSize.Width + lnSize,
                                    0, this.Width - iconAln - icoSize.Width - lnSize, this.Height), strFM);
                            }
                            break;
                        case IconPosition.RightOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(this.Width - iconAln - icoSize.Width, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(lnSize, 0, this.Width - iconAln - icoSize.Width - lnSize,
                                    this.Height), strFM);
                            }
                            break;
                    }
                    break;
                case LinePosition.Right:
                    e.Graphics.FillRectangle(new SolidBrush(lnClr), new Rectangle(this.Width - lnSize, 0, lnSize, this.Height));
                    switch (icoPos)
                    {
                        case IconPosition.OnlyIcon:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            break;
                        case IconPosition.OnlyText:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr),
                                    new RectangleF(0, 0, this.Width - lnSize, this.Height), strFM);
                            }
                            break;
                        case IconPosition.LeftOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(iconAln + icoSize.Width,
                                    0, this.Width - iconAln - icoSize.Width - lnSize, this.Height), strFM);
                            }
                            break;
                        case IconPosition.RightOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(this.Width - iconAln - icoSize.Width - lnSize, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width - iconAln - icoSize.Width - lnSize,
                                    this.Height), strFM);
                            }
                            break;
                    }
                    break;
                case LinePosition.None:
                    switch (icoPos)
                    {
                        case IconPosition.OnlyIcon:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            break;
                        case IconPosition.OnlyText:
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr),
                                    new RectangleF(0, 0, this.Width, this.Height), strFM);
                            }
                            break;
                        case IconPosition.LeftOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(iconAln, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(iconAln + icoSize.Width,
                                    0, this.Width - iconAln - icoSize.Width, this.Height), strFM);
                            }
                            break;
                        case IconPosition.RightOfText:
                            e.Graphics.DrawImage(ico, new Rectangle(this.Width - iconAln - icoSize.Width, (this.Height - icoSize.Height) / 2, icoSize.Width, icoSize.Height));
                            using (StringFormat strFM = new StringFormat())
                            {
                                strFM.Alignment = txtAlnHor;
                                strFM.LineAlignment = txtAlnVer;
                                e.Graphics.DrawString(text, this.Font, new SolidBrush(txtClr), new RectangleF(0, 0, this.Width - iconAln - icoSize.Width,
                                    this.Height), strFM);
                            }
                            break;
                    }
                    break;
            }
        }

        private bool move = true;
        private void Flat_Button_MouseDown(object sender, MouseEventArgs e)
        {
            move = false;
            if (usgAct) Active = true;
            if (usgIcoHorClk) ico = icoClk;
            if (usgLnHorClk) lnClr = lnClrClk;
            if (usgTxtHorClk) txtClr = txtClrClk;
            if (usgBckClrHorClk) this.BackColor = bckClrClk;
            Invalidate();
        }

        private void Flat_Button_MouseUp(object sender, MouseEventArgs e)
        {
            move = true;
            if (!usgAct || !active)
            {
                ico = icoNor;
                lnClr = lnClrNor;
                txtClr = txtClrNor;
                this.BackColor = bckClrNor;
                Invalidate();
            }
        }

        private void Flat_Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (!usgAct || !active)
                if (move)
                {
                    move = false;
                    if (usgIcoHorClk) ico = icoHor;
                    if (usgLnHorClk) lnClr = lnClrHor;
                    if (usgTxtHorClk) txtClr = txtClrHor;
                    if (usgBckClrHorClk) this.BackColor = bckClrHor;
                    Invalidate();
                }
        }

        private void Flat_Button_MouseLeave(object sender, System.EventArgs e)
        {
            move = true;
            if(!usgAct||!active)
            {
                ico = icoNor;
                lnClr = lnClrNor;
                txtClr = txtClrNor;
                this.BackColor = bckClrNor;
                Invalidate();
            }
        }
        #endregion
    }
}
