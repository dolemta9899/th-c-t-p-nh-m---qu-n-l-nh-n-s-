namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paluse = new System.Windows.Forms.Panel();
            this.panmenu = new System.Windows.Forms.Panel();
            this.fl_help = new GUI.ComponentForm.Flat_Button();
            this.flat_thoat = new GUI.ComponentForm.Flat_Button();
            this.flat_sach = new GUI.ComponentForm.Flat_Button();
            this.flat_thongke = new GUI.ComponentForm.Flat_Button();
            this.flat_timkiem = new GUI.ComponentForm.Flat_Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.panmenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paluse
            // 
            this.paluse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paluse.Location = new System.Drawing.Point(207, 1);
            this.paluse.Name = "paluse";
            this.paluse.Size = new System.Drawing.Size(817, 467);
            this.paluse.TabIndex = 1;
            // 
            // panmenu
            // 
            this.panmenu.BackgroundImage = global::GUI.Properties.Resources.menu1;
            this.panmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panmenu.Controls.Add(this.fl_help);
            this.panmenu.Controls.Add(this.flat_thoat);
            this.panmenu.Controls.Add(this.flat_sach);
            this.panmenu.Controls.Add(this.flat_thongke);
            this.panmenu.Controls.Add(this.flat_timkiem);
            this.panmenu.Controls.Add(this.menuStrip1);
            this.panmenu.Location = new System.Drawing.Point(1, 1);
            this.panmenu.Name = "panmenu";
            this.panmenu.Size = new System.Drawing.Size(207, 481);
            this.panmenu.TabIndex = 0;
            this.panmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panmenu_Paint);
            this.panmenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panmenu_PreviewKeyDown);
            // 
            // fl_help
            // 
            this.fl_help.Active = false;
            this.fl_help.BackColor = System.Drawing.Color.Transparent;
            this.fl_help.BackgroundColorClick = System.Drawing.Color.Yellow;
            this.fl_help.BackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fl_help.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.fl_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fl_help.IconAlignment = 3;
            this.fl_help.IconClick = null;
            this.fl_help.IconHover = null;
            this.fl_help.IconNormal = null;
            this.fl_help.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.fl_help.IconSize = new System.Drawing.Size(0, 0);
            this.fl_help.LineColorClick = System.Drawing.Color.Empty;
            this.fl_help.LineColorHover = System.Drawing.Color.Empty;
            this.fl_help.LineColorNormal = System.Drawing.Color.Green;
            this.fl_help.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.fl_help.LineSize = 0;
            this.fl_help.Location = new System.Drawing.Point(9, 325);
            this.fl_help.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fl_help.MinimumSize = new System.Drawing.Size(23, 23);
            this.fl_help.Name = "fl_help";
            this.fl_help.Size = new System.Drawing.Size(189, 36);
            this.fl_help.TabIndex = 7;
            this.fl_help.Text = "HELP";
            this.fl_help.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.fl_help.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.fl_help.TextColorClick = System.Drawing.Color.Empty;
            this.fl_help.TextColorHover = System.Drawing.Color.Empty;
            this.fl_help.TextColorNormal = System.Drawing.Color.White;
            this.fl_help.UseActive = true;
            this.fl_help.UseBackgroundHoverClick = true;
            this.fl_help.UseIconHoverClick = false;
            this.fl_help.UseLineHoverClick = false;
            this.fl_help.UseTextHoverClick = false;
            this.fl_help.Click += new System.EventHandler(this.fl_help_Click);
            // 
            // flat_thoat
            // 
            this.flat_thoat.Active = false;
            this.flat_thoat.BackColor = System.Drawing.Color.Transparent;
            this.flat_thoat.BackgroundColorClick = System.Drawing.Color.Yellow;
            this.flat_thoat.BackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flat_thoat.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.flat_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flat_thoat.IconAlignment = 3;
            this.flat_thoat.IconClick = null;
            this.flat_thoat.IconHover = null;
            this.flat_thoat.IconNormal = null;
            this.flat_thoat.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.flat_thoat.IconSize = new System.Drawing.Size(0, 0);
            this.flat_thoat.LineColorClick = System.Drawing.Color.Empty;
            this.flat_thoat.LineColorHover = System.Drawing.Color.Empty;
            this.flat_thoat.LineColorNormal = System.Drawing.Color.Green;
            this.flat_thoat.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.flat_thoat.LineSize = 0;
            this.flat_thoat.Location = new System.Drawing.Point(9, 388);
            this.flat_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flat_thoat.MinimumSize = new System.Drawing.Size(23, 23);
            this.flat_thoat.Name = "flat_thoat";
            this.flat_thoat.Size = new System.Drawing.Size(189, 36);
            this.flat_thoat.TabIndex = 6;
            this.flat_thoat.Text = "ĐĂNG XUÁT";
            this.flat_thoat.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.flat_thoat.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.flat_thoat.TextColorClick = System.Drawing.Color.Empty;
            this.flat_thoat.TextColorHover = System.Drawing.Color.Empty;
            this.flat_thoat.TextColorNormal = System.Drawing.Color.White;
            this.flat_thoat.UseActive = false;
            this.flat_thoat.UseBackgroundHoverClick = true;
            this.flat_thoat.UseIconHoverClick = false;
            this.flat_thoat.UseLineHoverClick = false;
            this.flat_thoat.UseTextHoverClick = false;
            this.flat_thoat.Click += new System.EventHandler(this.flat_thoat_Click);
            // 
            // flat_sach
            // 
            this.flat_sach.Active = false;
            this.flat_sach.BackColor = System.Drawing.Color.Transparent;
            this.flat_sach.BackgroundColorClick = System.Drawing.Color.Yellow;
            this.flat_sach.BackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flat_sach.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.flat_sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flat_sach.IconAlignment = 3;
            this.flat_sach.IconClick = null;
            this.flat_sach.IconHover = null;
            this.flat_sach.IconNormal = null;
            this.flat_sach.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.flat_sach.IconSize = new System.Drawing.Size(0, 0);
            this.flat_sach.LineColorClick = System.Drawing.Color.Empty;
            this.flat_sach.LineColorHover = System.Drawing.Color.Empty;
            this.flat_sach.LineColorNormal = System.Drawing.Color.Green;
            this.flat_sach.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.flat_sach.LineSize = 0;
            this.flat_sach.Location = new System.Drawing.Point(10, 275);
            this.flat_sach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flat_sach.MinimumSize = new System.Drawing.Size(23, 23);
            this.flat_sach.Name = "flat_sach";
            this.flat_sach.Size = new System.Drawing.Size(189, 36);
            this.flat_sach.TabIndex = 2;
            this.flat_sach.Text = "NHÂN VIÊN";
            this.flat_sach.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.flat_sach.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.flat_sach.TextColorClick = System.Drawing.Color.Empty;
            this.flat_sach.TextColorHover = System.Drawing.Color.Empty;
            this.flat_sach.TextColorNormal = System.Drawing.Color.White;
            this.flat_sach.UseActive = true;
            this.flat_sach.UseBackgroundHoverClick = true;
            this.flat_sach.UseIconHoverClick = false;
            this.flat_sach.UseLineHoverClick = false;
            this.flat_sach.UseTextHoverClick = false;
            this.flat_sach.Click += new System.EventHandler(this.flat_sach_Click);
            // 
            // flat_thongke
            // 
            this.flat_thongke.Active = false;
            this.flat_thongke.BackColor = System.Drawing.Color.Transparent;
            this.flat_thongke.BackgroundColorClick = System.Drawing.Color.Yellow;
            this.flat_thongke.BackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flat_thongke.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.flat_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flat_thongke.IconAlignment = 3;
            this.flat_thongke.IconClick = null;
            this.flat_thongke.IconHover = null;
            this.flat_thongke.IconNormal = null;
            this.flat_thongke.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.flat_thongke.IconSize = new System.Drawing.Size(0, 0);
            this.flat_thongke.LineColorClick = System.Drawing.Color.Empty;
            this.flat_thongke.LineColorHover = System.Drawing.Color.Empty;
            this.flat_thongke.LineColorNormal = System.Drawing.Color.Green;
            this.flat_thongke.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.flat_thongke.LineSize = 0;
            this.flat_thongke.Location = new System.Drawing.Point(10, 223);
            this.flat_thongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flat_thongke.MinimumSize = new System.Drawing.Size(23, 23);
            this.flat_thongke.Name = "flat_thongke";
            this.flat_thongke.Size = new System.Drawing.Size(189, 36);
            this.flat_thongke.TabIndex = 1;
            this.flat_thongke.Text = "PHÒNG BAN";
            this.flat_thongke.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.flat_thongke.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.flat_thongke.TextColorClick = System.Drawing.Color.Empty;
            this.flat_thongke.TextColorHover = System.Drawing.Color.Empty;
            this.flat_thongke.TextColorNormal = System.Drawing.Color.White;
            this.flat_thongke.UseActive = true;
            this.flat_thongke.UseBackgroundHoverClick = true;
            this.flat_thongke.UseIconHoverClick = false;
            this.flat_thongke.UseLineHoverClick = false;
            this.flat_thongke.UseTextHoverClick = false;
            this.flat_thongke.Click += new System.EventHandler(this.flat_thongke_Click);
            // 
            // flat_timkiem
            // 
            this.flat_timkiem.Active = false;
            this.flat_timkiem.BackColor = System.Drawing.Color.Transparent;
            this.flat_timkiem.BackgroundColorClick = System.Drawing.Color.Yellow;
            this.flat_timkiem.BackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flat_timkiem.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.flat_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flat_timkiem.IconAlignment = 3;
            this.flat_timkiem.IconClick = null;
            this.flat_timkiem.IconHover = null;
            this.flat_timkiem.IconNormal = null;
            this.flat_timkiem.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.flat_timkiem.IconSize = new System.Drawing.Size(0, 0);
            this.flat_timkiem.LineColorClick = System.Drawing.Color.Empty;
            this.flat_timkiem.LineColorHover = System.Drawing.Color.Empty;
            this.flat_timkiem.LineColorNormal = System.Drawing.Color.Green;
            this.flat_timkiem.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.flat_timkiem.LineSize = 0;
            this.flat_timkiem.Location = new System.Drawing.Point(9, 171);
            this.flat_timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flat_timkiem.MinimumSize = new System.Drawing.Size(23, 23);
            this.flat_timkiem.Name = "flat_timkiem";
            this.flat_timkiem.Size = new System.Drawing.Size(189, 36);
            this.flat_timkiem.TabIndex = 0;
            this.flat_timkiem.Text = "TÌM KIẾM";
            this.flat_timkiem.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.flat_timkiem.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.flat_timkiem.TextColorClick = System.Drawing.Color.Empty;
            this.flat_timkiem.TextColorHover = System.Drawing.Color.Empty;
            this.flat_timkiem.TextColorNormal = System.Drawing.Color.White;
            this.flat_timkiem.UseActive = true;
            this.flat_timkiem.UseBackgroundHoverClick = true;
            this.flat_timkiem.UseIconHoverClick = false;
            this.flat_timkiem.UseLineHoverClick = false;
            this.flat_timkiem.UseTextHoverClick = false;
            this.flat_timkiem.Click += new System.EventHandler(this.flat_timkiem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.help.Size = new System.Drawing.Size(44, 20);
            this.help.Text = "Help";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.paluse);
            this.Controls.Add(this.panmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panmenu.ResumeLayout(false);
            this.panmenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panmenu;
        private System.Windows.Forms.Panel paluse;
        private ComponentForm.Flat_Button flat_sach;
        private ComponentForm.Flat_Button flat_thongke;
        private ComponentForm.Flat_Button flat_timkiem;
        private ComponentForm.Flat_Button flat_thoat;
        private ComponentForm.Flat_Button fl_help;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem help;
    }
}