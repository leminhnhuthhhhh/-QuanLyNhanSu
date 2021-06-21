namespace QuanLyNhanSu.GUI
{
    partial class frmDoiMatKhau
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
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtNLMK = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(580, 429);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(139, 41);
            this.btnDoiMatKhau.TabIndex = 12;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtNLMK
            // 
            this.txtNLMK.Location = new System.Drawing.Point(529, 347);
            this.txtNLMK.Name = "txtNLMK";
            this.txtNLMK.PasswordChar = '*';
            this.txtNLMK.Size = new System.Drawing.Size(190, 22);
            this.txtNLMK.TabIndex = 8;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(529, 282);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(190, 22);
            this.txtMKM.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nhập Lại Mật Khẩu";
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(529, 224);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.PasswordChar = '*';
            this.txtMKC.Size = new System.Drawing.Size(190, 22);
            this.txtMKC.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(356, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mật Khẩu Mới";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(529, 163);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(190, 22);
            this.txtTaiKhoan.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mật Khẩu Cũ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "ĐỔI MẬT KHẨU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tài Khoản";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 582);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtNLMK);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtNLMK;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}