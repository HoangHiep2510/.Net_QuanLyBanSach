namespace lab9
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnTrịHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mTTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mDMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mDX = new System.Windows.Forms.ToolStripMenuItem();
            this.mQLNS = new System.Windows.Forms.ToolStripMenuItem();
            this.mQLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mQLS = new System.Windows.Forms.ToolStripMenuItem();
            this.mTKBC = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.quảnLýChiTiếtĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnTrịHệThốngToolStripMenuItem,
            this.mQLNS,
            this.mTKBC});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnTrịHệThốngToolStripMenuItem
            // 
            this.quảnTrịHệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mTTK,
            this.mDN,
            this.mDMK,
            this.mDX});
            this.quảnTrịHệThốngToolStripMenuItem.Name = "quảnTrịHệThốngToolStripMenuItem";
            this.quảnTrịHệThốngToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.quảnTrịHệThốngToolStripMenuItem.Text = "Quản trị hệ thống";
            // 
            // mTTK
            // 
            this.mTTK.Name = "mTTK";
            this.mTTK.Size = new System.Drawing.Size(207, 32);
            this.mTTK.Text = "Đăng ký";
            this.mTTK.Click += new System.EventHandler(this.mTTK_Click);
            // 
            // mDN
            // 
            this.mDN.Name = "mDN";
            this.mDN.Size = new System.Drawing.Size(207, 32);
            this.mDN.Text = "Đăng nhập";
            this.mDN.Click += new System.EventHandler(this.mDN_Click);
            // 
            // mDMK
            // 
            this.mDMK.Name = "mDMK";
            this.mDMK.Size = new System.Drawing.Size(207, 32);
            this.mDMK.Text = "Đổi mật khẩu";
            this.mDMK.Click += new System.EventHandler(this.mDMK_Click);
            // 
            // mDX
            // 
            this.mDX.Name = "mDX";
            this.mDX.Size = new System.Drawing.Size(207, 32);
            this.mDX.Text = "Đăng xuất";
            this.mDX.Click += new System.EventHandler(this.mDX_Click);
            // 
            // mQLNS
            // 
            this.mQLNS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mQLKH,
            this.mQLNV,
            this.mQLHD,
            this.mQLS,
            this.quảnLýChiTiếtĐơnHàngToolStripMenuItem});
            this.mQLNS.Name = "mQLNS";
            this.mQLNS.Size = new System.Drawing.Size(171, 32);
            this.mQLNS.Text = "Quản lý nhà sách";
            // 
            // mQLKH
            // 
            this.mQLKH.Name = "mQLKH";
            this.mQLKH.Size = new System.Drawing.Size(310, 32);
            this.mQLKH.Text = "Quản lý khách hàng";
            this.mQLKH.Click += new System.EventHandler(this.mQLKH_Click);
            // 
            // mQLNV
            // 
            this.mQLNV.Name = "mQLNV";
            this.mQLNV.Size = new System.Drawing.Size(310, 32);
            this.mQLNV.Text = "Quản lý nhân viên";
            this.mQLNV.Click += new System.EventHandler(this.mQLNV_Click);
            // 
            // mQLHD
            // 
            this.mQLHD.Name = "mQLHD";
            this.mQLHD.Size = new System.Drawing.Size(310, 32);
            this.mQLHD.Text = "Quản lý hoá đơn";
            this.mQLHD.Click += new System.EventHandler(this.mQLHD_Click);
            // 
            // mQLS
            // 
            this.mQLS.Name = "mQLS";
            this.mQLS.Size = new System.Drawing.Size(310, 32);
            this.mQLS.Text = "Quản lý sách";
            this.mQLS.Click += new System.EventHandler(this.mQLS_Click);
            // 
            // mTKBC
            // 
            this.mTKBC.Name = "mTKBC";
            this.mTKBC.Size = new System.Drawing.Size(180, 32);
            this.mTKBC.Text = "Thống kê báo cáo";
            this.mTKBC.Click += new System.EventHandler(this.thốngKêBáoCaoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(399, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nguyễn Hoàng Hiệp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(224, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sinh viên thực hiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(477, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "1811545171";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(499, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "18DTH2B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(485, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "2018 - 2020";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(600, 0);
            this.lblTen.MinimumSize = new System.Drawing.Size(243, 36);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(243, 36);
            this.lblTen.TabIndex = 7;
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // quảnLýChiTiếtĐơnHàngToolStripMenuItem
            // 
            this.quảnLýChiTiếtĐơnHàngToolStripMenuItem.Name = "quảnLýChiTiếtĐơnHàngToolStripMenuItem";
            this.quảnLýChiTiếtĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.quảnLýChiTiếtĐơnHàngToolStripMenuItem.Text = "Quản lý chi tiết hoá đơn";
            this.quảnLýChiTiếtĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýChiTiếtĐơnHàngToolStripMenuItem_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(855, 469);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.Text = "Phần mềm quản lý nhà sách";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mTTK;
        private System.Windows.Forms.ToolStripMenuItem mDN;
        private System.Windows.Forms.ToolStripMenuItem mDX;
        private System.Windows.Forms.ToolStripMenuItem mQLNS;
        private System.Windows.Forms.ToolStripMenuItem mQLKH;
        private System.Windows.Forms.ToolStripMenuItem mQLNV;
        private System.Windows.Forms.ToolStripMenuItem mQLHD;
        private System.Windows.Forms.ToolStripMenuItem mQLS;
        private System.Windows.Forms.ToolStripMenuItem mTKBC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.ToolStripMenuItem mDMK;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChiTiếtĐơnHàngToolStripMenuItem;
    }
}