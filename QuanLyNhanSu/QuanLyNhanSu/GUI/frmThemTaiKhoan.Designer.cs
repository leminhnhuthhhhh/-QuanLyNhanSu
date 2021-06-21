namespace QuanLyNhanSu.GUI
{
    partial class frmThemTaiKhoan
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
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgNhanVienTK = new System.Windows.Forms.DataGridView();
            this.dtgTaiKhoan = new System.Windows.Forms.DataGridView();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVienTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(214, 103);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(222, 22);
            this.txtMaNhanVien.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mã Nhân Viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(214, 222);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(222, 22);
            this.txtMatKhau.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Quyền";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(214, 161);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(222, 22);
            this.txtTaiKhoan.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mật Khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "THÊM TÀI KHOẢN NHÂN VIÊN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tài Khoản";
            // 
            // dtgNhanVienTK
            // 
            this.dtgNhanVienTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNhanVienTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVienTK.Location = new System.Drawing.Point(497, 142);
            this.dtgNhanVienTK.MultiSelect = false;
            this.dtgNhanVienTK.Name = "dtgNhanVienTK";
            this.dtgNhanVienTK.RowTemplate.Height = 24;
            this.dtgNhanVienTK.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgNhanVienTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNhanVienTK.Size = new System.Drawing.Size(590, 184);
            this.dtgNhanVienTK.TabIndex = 22;
            this.dtgNhanVienTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhanVienTK_CellClick);
            // 
            // dtgTaiKhoan
            // 
            this.dtgTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTaiKhoan.Location = new System.Drawing.Point(45, 440);
            this.dtgTaiKhoan.MultiSelect = false;
            this.dtgTaiKhoan.Name = "dtgTaiKhoan";
            this.dtgTaiKhoan.RowTemplate.Height = 24;
            this.dtgTaiKhoan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTaiKhoan.Size = new System.Drawing.Size(1042, 177);
            this.dtgTaiKhoan.TabIndex = 23;
            this.dtgTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTaiKhoan_CellClick);
            // 
            // cbQuyen
            // 
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Location = new System.Drawing.Point(214, 280);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(222, 24);
            this.cbQuyen.TabIndex = 24;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(198, 333);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(98, 35);
            this.btnThemTK.TabIndex = 25;
            this.btnThemTK.Text = "Thêm";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Location = new System.Drawing.Point(363, 333);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(98, 35);
            this.btnXoaTK.TabIndex = 25;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(736, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "(*) Vui lòng chọn nhân viên trước khi thêm tài khoản";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(502, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(302, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "Danh sách nhân viên chưa có tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Danh sách tài khoản";
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.cbQuyen);
            this.Controls.Add(this.dtgTaiKhoan);
            this.Controls.Add(this.dtgNhanVienTK);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemTaiKhoan";
            this.Text = "frmThemTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVienTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgNhanVienTK;
        private System.Windows.Forms.DataGridView dtgTaiKhoan;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
    }
}