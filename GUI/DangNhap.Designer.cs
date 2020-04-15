namespace GUI
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errortk = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnthoat = new GUI.ComponentForm.Thin_Button();
            this.btnlogin = new GUI.ComponentForm.Thin_Button();
            this.btntaotk = new GUI.ComponentForm.Thin_Button();
            ((System.ComponentModel.ISupportInitialize)(this.errortk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(311, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài Khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(311, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu :";
            // 
            // txttk
            // 
            this.txttk.BackColor = System.Drawing.SystemColors.Menu;
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttk.Location = new System.Drawing.Point(435, 223);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(200, 22);
            this.txttk.TabIndex = 5;
            this.txttk.Text = "Nhập tài khoản";
            this.txttk.Click += new System.EventHandler(this.txttk_Click);
            this.txttk.Leave += new System.EventHandler(this.txttk_Leave);
            // 
            // txtmk
            // 
            this.txtmk.BackColor = System.Drawing.SystemColors.Menu;
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmk.Location = new System.Drawing.Point(435, 272);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(200, 22);
            this.txtmk.TabIndex = 6;
            this.txtmk.Text = "Nhập password";
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(590, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errortk
            // 
            this.errortk.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errortk.ContainerControl = this;
            this.errortk.Icon = ((System.Drawing.Icon)(resources.GetObject("errortk.Icon")));
            this.errortk.RightToLeft = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Active = false;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnthoat.BorderColorClick = System.Drawing.Color.Empty;
            this.btnthoat.BorderColorHover = System.Drawing.Color.Empty;
            this.btnthoat.BorderColorNomal = System.Drawing.Color.Green;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.InnerColorClick = System.Drawing.Color.Empty;
            this.btnthoat.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnthoat.InnerColorHover = System.Drawing.Color.Empty;
            this.btnthoat.InnerColorNomal = System.Drawing.Color.DarkRed;
            this.btnthoat.Location = new System.Drawing.Point(624, 400);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.SizeBorder = 1;
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnthoat.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnthoat.TextColorClick = System.Drawing.Color.Empty;
            this.btnthoat.TextColorDisable = System.Drawing.Color.Empty;
            this.btnthoat.TextColorHover = System.Drawing.Color.Empty;
            this.btnthoat.TextColorNomal = System.Drawing.Color.WhiteSmoke;
            this.btnthoat.UseActive = false;
            this.btnthoat.UseBorderColorHoverClick = false;
            this.btnthoat.UseInnerColorHoverClick = false;
            this.btnthoat.UseTextColorHoverClick = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Active = false;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnlogin.BorderColorClick = System.Drawing.Color.Empty;
            this.btnlogin.BorderColorHover = System.Drawing.Color.Empty;
            this.btnlogin.BorderColorNomal = System.Drawing.Color.Green;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.InnerColorClick = System.Drawing.Color.Empty;
            this.btnlogin.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnlogin.InnerColorHover = System.Drawing.Color.Empty;
            this.btnlogin.InnerColorNomal = System.Drawing.Color.LimeGreen;
            this.btnlogin.Location = new System.Drawing.Point(422, 321);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(232, 43);
            this.btnlogin.SizeBorder = 1;
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnlogin.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnlogin.TextColorClick = System.Drawing.Color.Empty;
            this.btnlogin.TextColorDisable = System.Drawing.Color.Empty;
            this.btnlogin.TextColorHover = System.Drawing.Color.Empty;
            this.btnlogin.TextColorNomal = System.Drawing.Color.White;
            this.btnlogin.UseActive = false;
            this.btnlogin.UseBorderColorHoverClick = false;
            this.btnlogin.UseInnerColorHoverClick = false;
            this.btnlogin.UseTextColorHoverClick = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btntaotk
            // 
            this.btntaotk.Active = false;
            this.btntaotk.BackColor = System.Drawing.Color.Transparent;
            this.btntaotk.BoderColorDisable = System.Drawing.Color.Empty;
            this.btntaotk.BorderColorClick = System.Drawing.Color.Empty;
            this.btntaotk.BorderColorHover = System.Drawing.Color.Empty;
            this.btntaotk.BorderColorNomal = System.Drawing.Color.Green;
            this.btntaotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaotk.InnerColorClick = System.Drawing.Color.Empty;
            this.btntaotk.InnerColorDisable = System.Drawing.Color.Empty;
            this.btntaotk.InnerColorHover = System.Drawing.Color.Empty;
            this.btntaotk.InnerColorNomal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntaotk.Location = new System.Drawing.Point(446, 370);
            this.btntaotk.Name = "btntaotk";
            this.btntaotk.Size = new System.Drawing.Size(189, 23);
            this.btntaotk.SizeBorder = 1;
            this.btntaotk.TabIndex = 0;
            this.btntaotk.Text = "Tạo tài khoản";
            this.btntaotk.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btntaotk.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btntaotk.TextColorClick = System.Drawing.Color.Empty;
            this.btntaotk.TextColorDisable = System.Drawing.Color.Empty;
            this.btntaotk.TextColorHover = System.Drawing.Color.Empty;
            this.btntaotk.TextColorNomal = System.Drawing.Color.White;
            this.btntaotk.UseActive = false;
            this.btntaotk.UseBorderColorHoverClick = false;
            this.btntaotk.UseInnerColorHoverClick = false;
            this.btntaotk.UseTextColorHoverClick = false;
            this.btntaotk.Click += new System.EventHandler(this.btntaotk_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 545);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btntaotk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.errortk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentForm.Thin_Button btntaotk;
        private ComponentForm.Thin_Button btnlogin;
        private ComponentForm.Thin_Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errortk;
    }
}