namespace GUI.ComponentForm
{
    partial class BoxFrom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxExit = new System.Windows.Forms.PictureBox();
            this.boxMini = new System.Windows.Forms.PictureBox();
            this.boxMax = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMax)).BeginInit();
            this.SuspendLayout();
            // 
            // boxExit
            // 
            this.boxExit.Image = global::GUI.Properties.Resources.ico_exit_mac_nor_1;
            this.boxExit.Location = new System.Drawing.Point(0, 0);
            this.boxExit.Name = "boxExit";
            this.boxExit.Size = new System.Drawing.Size(15, 15);
            this.boxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxExit.TabIndex = 0;
            this.boxExit.TabStop = false;
            this.boxExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxExit_MouseDown);
            this.boxExit.MouseLeave += new System.EventHandler(this.boxExit_MouseLeave);
            this.boxExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boxExit_MouseMove);
            this.boxExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxExit_MouseUp);
            // 
            // boxMini
            // 
            this.boxMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxMini.Image = global::GUI.Properties.Resources.icon_mini_mac_nor_1;
            this.boxMini.Location = new System.Drawing.Point(20, 0);
            this.boxMini.Name = "boxMini";
            this.boxMini.Size = new System.Drawing.Size(15, 15);
            this.boxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxMini.TabIndex = 1;
            this.boxMini.TabStop = false;
            this.boxMini.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxMini_MouseDown);
            this.boxMini.MouseLeave += new System.EventHandler(this.boxMini_MouseLeave);
            this.boxMini.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boxMini_MouseMove);
            this.boxMini.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxMini_MouseUp);
            // 
            // boxMax
            // 
            this.boxMax.Image = global::GUI.Properties.Resources.icon_maxsize_mac_nor_1;
            this.boxMax.Location = new System.Drawing.Point(40, 0);
            this.boxMax.Name = "boxMax";
            this.boxMax.Size = new System.Drawing.Size(15, 15);
            this.boxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxMax.TabIndex = 2;
            this.boxMax.TabStop = false;
            this.boxMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxMax_MouseDown);
            this.boxMax.MouseLeave += new System.EventHandler(this.boxMax_MouseLeave);
            this.boxMax.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boxMax_MouseMove);
            this.boxMax.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxMax_MouseUp);
            // 
            // BoxFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxExit);
            this.Controls.Add(this.boxMini);
            this.Controls.Add(this.boxMax);
            this.Name = "BoxFrom";
            this.Size = new System.Drawing.Size(55, 15);
            this.Resize += new System.EventHandler(this.BoxFrom_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.boxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
