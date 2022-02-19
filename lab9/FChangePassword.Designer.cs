namespace lab9
{
    partial class FChangePassword
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
            this.lblTen = new System.Windows.Forms.Label();
            this.btnXN = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtNLMKM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(494, -2);
            this.lblTen.MinimumSize = new System.Drawing.Size(200, 36);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(200, 36);
            this.lblTen.TabIndex = 0;
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnXN
            // 
            this.btnXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXN.Location = new System.Drawing.Point(83, 211);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(168, 38);
            this.btnXN.TabIndex = 1;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.UseVisualStyleBackColor = false;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // btnLL
            // 
            this.btnLL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLL.Location = new System.Drawing.Point(407, 211);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(162, 38);
            this.btnLL.TabIndex = 2;
            this.btnLL.Text = "Làm lại";
            this.btnLL.UseVisualStyleBackColor = false;
            // 
            // txtMKC
            // 
            this.txtMKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKC.Location = new System.Drawing.Point(267, 59);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.PasswordChar = '*';
            this.txtMKC.Size = new System.Drawing.Size(289, 30);
            this.txtMKC.TabIndex = 3;
            // 
            // txtMKM
            // 
            this.txtMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKM.Location = new System.Drawing.Point(267, 108);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(289, 30);
            this.txtMKM.TabIndex = 4;
            // 
            // txtNLMKM
            // 
            this.txtNLMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNLMKM.Location = new System.Drawing.Point(267, 156);
            this.txtNLMKM.Name = "txtNLMKM";
            this.txtNLMKM.PasswordChar = '*';
            this.txtNLMKM.Size = new System.Drawing.Size(289, 30);
            this.txtNLMKM.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // FChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNLMKM);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnXN);
            this.Controls.Add(this.lblTen);
            this.Name = "FChangePassword";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnXN;
        private System.Windows.Forms.Button btnLL;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.TextBox txtNLMKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}