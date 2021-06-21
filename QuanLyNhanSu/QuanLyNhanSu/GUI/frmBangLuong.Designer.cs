namespace QuanLyNhanSu.GUI
{
    partial class frmBangLuong
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
            this.dtgLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSNL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienThuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCapChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLuong
            // 
            this.dtgLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.LuongCoBan,
            this.HeSoLuong,
            this.PhuCapChucVu,
            this.SoNgayLam,
            this.TienThuong,
            this.TienPhat,
            this.NgayLap,
            this.TongTien});
            this.dtgLuong.Location = new System.Drawing.Point(22, 376);
            this.dtgLuong.MultiSelect = false;
            this.dtgLuong.Name = "dtgLuong";
            this.dtgLuong.RowTemplate.Height = 24;
            this.dtgLuong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLuong.Size = new System.Drawing.Size(1164, 413);
            this.dtgLuong.TabIndex = 0;
            this.dtgLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLuong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(186, 72);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(181, 22);
            this.txtTenNV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ Số Lương";
            // 
            // txtHSL
            // 
            this.txtHSL.Location = new System.Drawing.Point(186, 151);
            this.txtHSL.Name = "txtHSL";
            this.txtHSL.Size = new System.Drawing.Size(181, 22);
            this.txtHSL.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Ngày Làm";
            // 
            // txtSNL
            // 
            this.txtSNL.Location = new System.Drawing.Point(186, 236);
            this.txtSNL.Name = "txtSNL";
            this.txtSNL.Size = new System.Drawing.Size(181, 22);
            this.txtSNL.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tiền Thưởng";
            // 
            // txtTienThuong
            // 
            this.txtTienThuong.Location = new System.Drawing.Point(572, 72);
            this.txtTienThuong.Name = "txtTienThuong";
            this.txtTienThuong.Size = new System.Drawing.Size(181, 22);
            this.txtTienThuong.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tiền Phạt";
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(572, 151);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(181, 22);
            this.txtTienPhat.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lương Cơ Bản";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(572, 236);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(181, 22);
            this.txtLuongCB.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(818, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ngày Lập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(962, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(994, 308);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(192, 42);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Lập Bảng Lương";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(137, 322);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(40, 22);
            this.txtThang.TabIndex = 4;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(201, 322);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(75, 22);
            this.txtNam.TabIndex = 4;
            this.txtNam.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "/";
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(301, 311);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(101, 43);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Chọn Ngày";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.Location = new System.Drawing.Point(797, 308);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(163, 42);
            this.btnTinhLuong.TabIndex = 9;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(818, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(962, 72);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(181, 22);
            this.txtTongTien.TabIndex = 4;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 126;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 121;
            // 
            // LuongCoBan
            // 
            this.LuongCoBan.DataPropertyName = "LuongCoBan";
            this.LuongCoBan.HeaderText = "Lương Cơ Bản";
            this.LuongCoBan.Name = "LuongCoBan";
            this.LuongCoBan.Width = 94;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ Số Lương";
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.Width = 110;
            // 
            // PhuCapChucVu
            // 
            this.PhuCapChucVu.DataPropertyName = "PhuCapChucVu";
            this.PhuCapChucVu.HeaderText = "Phụ Cấp Chức Vụ";
            this.PhuCapChucVu.Name = "PhuCapChucVu";
            this.PhuCapChucVu.Width = 120;
            // 
            // SoNgayLam
            // 
            this.SoNgayLam.DataPropertyName = "SoNgayLam";
            this.SoNgayLam.HeaderText = "Số Ngày Làm";
            this.SoNgayLam.Name = "SoNgayLam";
            this.SoNgayLam.Width = 112;
            // 
            // TienThuong
            // 
            this.TienThuong.DataPropertyName = "TienThuong";
            this.TienThuong.HeaderText = "Tiền Thưởng";
            this.TienThuong.Name = "TienThuong";
            this.TienThuong.Width = 109;
            // 
            // TienPhat
            // 
            this.TienPhat.DataPropertyName = "TienPhat";
            this.TienPhat.HeaderText = "Tiền Phạt";
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.Width = 91;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 91;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TienLuong";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 94;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 812);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtSNL);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHSL);
            this.Controls.Add(this.txtTienThuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBangLuong";
            this.Text = "frmBangLuong";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSNL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienThuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCapChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}