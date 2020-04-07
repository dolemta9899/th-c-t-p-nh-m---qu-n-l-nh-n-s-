using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.ComponentForm
{
    public class DomainUse : Panel
    {
        private FormWindowState frmState = FormWindowState.Minimized;
        public DomainUse() : base()
        {
            this.Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            this.Resize += DomainUse_Resize;
            this.LocationChanged += DomainUse_LocationChanged;
        }

        // Đặt lại Location khi bị thay đổi
        private void DomainUse_LocationChanged(object sender, System.EventArgs e)
        {
            this.Location = new Point(1, 1);
        }

        // Đặt lại size cua panel cho khít form
        private void DomainUse_Resize(object sender, System.EventArgs e)
        {
            if (frmState == FormWindowState.Normal)
            {
                this.Location = new Point(1, 1);
                if ((Form)(this.Parent as Form) != null)
                    this.Size = new Size(((Form)(this.Parent as Form)).Width - 2, ((Form)(this.Parent as Form)).Height - 2);
            }
            if (frmState == FormWindowState.Maximized)
            {
                this.Location = new Point(0, 0);
                if ((Form)(this.Parent as Form) != null)
                    this.Size = new Size(((Form)(this.Parent as Form)).Width, ((Form)(this.Parent as Form)).Height);
            }
            Invalidate();
        }

        // Get/set SateForm và đặt lại size panel 
        public FormWindowState FormState
        {
            get
            {
                return frmState;
            }

            set
            {
                frmState = value;
                if (frmState == FormWindowState.Normal)
                {
                    this.Location = new Point(1, 1);
                    if ((Form)(this.Parent as Form) != null)
                        this.Size = new Size(((Form)(this.Parent as Form)).Width - 2, ((Form)(this.Parent as Form)).Height - 2);
                }
                if(frmState == FormWindowState.Maximized)
                {
                    this.Location = new Point(0, 0);
                    if ((Form)(this.Parent as Form) != null)
                        this.Size = new Size(((Form)(this.Parent as Form)).Width, ((Form)(this.Parent as Form)).Height);
                }
                Invalidate();
            }
        }

        // Lấy Parent Form của panel và vẽ Border trên Form 
        protected override void OnPaint(PaintEventArgs e)
        {
            if ((Form)(this.Parent as Form) != null)
            {
                if (((Form)(this.Parent as Form)).WindowState != frmState)
                {
                    FormState = ((Form)(this.Parent as Form)).WindowState;
                    return;
                }
                //else
                //if (FormState == FormWindowState.Normal)
                    //((Form)(this.Parent as Form)).CreateGraphics().DrawRectangle(new Pen(Color.Green, 1), this.Location.X - 1, this.Location.Y - 1, this.Width + 1, this.Height + 1);
            }
            base.OnPaint(e);
        }
    }
}
