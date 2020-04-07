using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.ComponentModel;

namespace GUI.ComponentForm
{
    public class Panel_Simple : System.Windows.Forms.Panel
    {
        public Panel_Simple() : base() { }

        #region Properties
        private Color topLClr = SystemColors.Control;
        private Color topRClr = SystemColors.Control;
        private Color botLClr = SystemColors.Control;
        private Color botRClr = SystemColors.Control;
        #endregion

        #region Get/Set
        public Color TopLeftColor
        {
            get
            {
                return topLClr;
            }

            set
            {
                topLClr = value;
                OnPaintBackground(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
            }
        }

        public Color BottomLeftColor
        {
            get
            {
                return botLClr;
            }

            set
            {
                botLClr = value;
                OnPaintBackground(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
            }
        }

        public Color TopRightColor
        {
            get
            {
                return topRClr;
            }

            set
            {
                topRClr = value;
                OnPaintBackground(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
            }
        }

        public Color BotRightColor
        {
            get
            {
                return botRClr;
            }

            set
            {
                botRClr = value;
                OnPaintBackground(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
            }
        }
        #endregion

        #region Event
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                GraphicsPath gp = new GraphicsPath();
                gp.AddRectangle(new Rectangle(0, 0, this.Width, this.Height));
                PathGradientBrush pgb = new PathGradientBrush(gp);
                pgb.CenterPoint = new Point(0, 0);
                pgb.CenterColor = topLClr;
                pgb.SurroundColors = new Color[] { topLClr, topRClr, botRClr, botLClr };
                e.Graphics.FillRectangle(pgb, new Rectangle(0, 0, this.Width, this.Height));
                gp.Dispose();
                pgb.Dispose();
            }
            catch
            {

            }
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    try
        //    {
        //        GraphicsPath gp = new GraphicsPath();
        //        gp.AddRectangle(new Rectangle(0, 0, this.Width, this.Height));
        //        PathGradientBrush pgb = new PathGradientBrush(gp);
        //        pgb.CenterPoint = new Point(0, 0);
        //        pgb.CenterColor = topLClr;
        //        pgb.SurroundColors = new Color[] { topLClr, topRClr, botRClr, botLClr };
        //        e.Graphics.FillRectangle(pgb, new Rectangle(0, 0, this.Width, this.Height));
        //        gp.Dispose();
        //        pgb.Dispose();
        //    }
        //    catch
        //    {

        //    }
        //}

        //protected override void OnClientSizeChanged(EventArgs e)
        //{
        //    //base.OnClientSizeChanged(e);
        //    foreach (Control ctrl in this.Controls)
        //    {
        //        ctrl.BackColor = Color.Transparent;
        //    }
        //}

        protected override void OnSizeChanged(EventArgs e)
        {
            //MessageBox.Show(this.Height + " "+this.Width);
            Invalidate();
            //foreach (Control ctrl in this.Controls)
            //{
            //    ctrl.BackColor = Color.Transparent;
            //}
        }

        protected override void OnResize(EventArgs eventargs)
        {
            //this.Refresh();
        }
        #endregion

        #region Hide Properties
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
    }
}
