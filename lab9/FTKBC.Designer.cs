namespace lab9
{
    partial class FTKBC
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDT = new System.Windows.Forms.DataGridView();
            this.dtpNG = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.dtpNB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvS = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDMKH = new System.Windows.Forms.TabPage();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDMKH = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvS)).BeginInit();
            this.tpDMKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.tcDMKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage4.Controls.Add(this.dgvDT);
            this.tabPage4.Controls.Add(this.dtpNG);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btnTK);
            this.tabPage4.Controls.Add(this.dtpNB);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1151, 551);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Doanh thu";
            // 
            // dgvDT
            // 
            this.dgvDT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDT.Location = new System.Drawing.Point(59, 106);
            this.dgvDT.Name = "dgvDT";
            this.dgvDT.RowTemplate.Height = 24;
            this.dgvDT.Size = new System.Drawing.Size(1027, 406);
            this.dgvDT.TabIndex = 5;
            // 
            // dtpNG
            // 
            this.dtpNG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNG.Location = new System.Drawing.Point(548, 38);
            this.dtpNG.Name = "dtpNG";
            this.dtpNG.Size = new System.Drawing.Size(150, 30);
            this.dtpNG.TabIndex = 4;
            this.dtpNG.Value = new System.DateTime(2020, 9, 28, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến ngày:";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTK.Location = new System.Drawing.Point(849, 35);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(112, 33);
            this.btnTK.TabIndex = 2;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // dtpNB
            // 
            this.dtpNB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNB.Location = new System.Drawing.Point(287, 38);
            this.dtpNB.Name = "dtpNB";
            this.dtpNB.Size = new System.Drawing.Size(150, 30);
            this.dtpNB.TabIndex = 1;
            this.dtpNB.Value = new System.DateTime(2020, 9, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dgvS);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1151, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh mục sách";
            // 
            // dgvS
            // 
            this.dgvS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.NamXB,
            this.MoTa,
            this.MaNXB});
            this.dgvS.Location = new System.Drawing.Point(7, 7);
            this.dgvS.Name = "dgvS";
            this.dgvS.RowTemplate.Height = 24;
            this.dgvS.Size = new System.Drawing.Size(1138, 538);
            this.dgvS.TabIndex = 0;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.Name = "TacGia";
            // 
            // NamXB
            // 
            this.NamXB.DataPropertyName = "NamXB";
            this.NamXB.HeaderText = "Năm xuất bản";
            this.NamXB.Name = "NamXB";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã nhà xuất bản";
            this.MaNXB.Name = "MaNXB";
            // 
            // tpDMKH
            // 
            this.tpDMKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tpDMKH.Controls.Add(this.dgvKH);
            this.tpDMKH.Location = new System.Drawing.Point(4, 34);
            this.tpDMKH.Name = "tpDMKH";
            this.tpDMKH.Padding = new System.Windows.Forms.Padding(3);
            this.tpDMKH.Size = new System.Drawing.Size(1151, 551);
            this.tpDMKH.TabIndex = 0;
            this.tpDMKH.Text = "Danh mục khách hàng";
            // 
            // dgvKH
            // 
            this.dgvKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTenKH,
            this.GioiTinh,
            this.NamSinh,
            this.SoDT});
            this.dgvKH.Location = new System.Drawing.Point(7, 7);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(1138, 538);
            this.dgvKH.TabIndex = 0;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Họ tên khách hàng";
            this.HoTenKH.Name = "HoTenKH";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.Name = "NamSinh";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.Name = "SoDT";
            // 
            // tcDMKH
            // 
            this.tcDMKH.Controls.Add(this.tpDMKH);
            this.tcDMKH.Controls.Add(this.tabPage2);
            this.tcDMKH.Controls.Add(this.tabPage4);
            this.tcDMKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDMKH.Location = new System.Drawing.Point(26, 25);
            this.tcDMKH.Name = "tcDMKH";
            this.tcDMKH.SelectedIndex = 0;
            this.tcDMKH.Size = new System.Drawing.Size(1159, 589);
            this.tcDMKH.TabIndex = 0;
            // 
            // FTKBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1212, 634);
            this.Controls.Add(this.tcDMKH);
            this.Name = "FTKBC";
            this.Text = "Thống kê báo cáo";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvS)).EndInit();
            this.tpDMKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.tcDMKH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.TabPage tpDMKH;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.TabControl tcDMKH;
        private System.Windows.Forms.DateTimePicker dtpNB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.DataGridView dgvDT;
        private System.Windows.Forms.DateTimePicker dtpNG;
        private System.Windows.Forms.Label label2;

    }
}