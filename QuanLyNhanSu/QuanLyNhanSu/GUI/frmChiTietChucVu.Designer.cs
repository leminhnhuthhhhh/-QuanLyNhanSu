namespace QuanLyNhanSu.GUI
{
    partial class frmChiTietChucVu
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
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.dtgChucVu = new System.Windows.Forms.DataGridView();
            this.dtgChiTietCV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLCB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.dtpngaybd = new System.Windows.Forms.DateTimePicker();
            this.dtpngaykt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietCV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Location = new System.Drawing.Point(464, 50);
            this.dtgNhanVien.MultiSelect = false;
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowTemplate.Height = 24;
            this.dtgNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNhanVien.Size = new System.Drawing.Size(720, 298);
            this.dtgNhanVien.TabIndex = 0;
            this.dtgNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhanVien_CellClick);
            // 
            // dtgChucVu
            // 
            this.dtgChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChucVu.Location = new System.Drawing.Point(42, 475);
            this.dtgChucVu.MultiSelect = false;
            this.dtgChucVu.Name = "dtgChucVu";
            this.dtgChucVu.RowTemplate.Height = 24;
            this.dtgChucVu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChucVu.Size = new System.Drawing.Size(549, 298);
            this.dtgChucVu.TabIndex = 0;
            this.dtgChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChucVu_CellClick);
            // 
            // dtgChiTietCV
            // 
            this.dtgChiTietCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgChiTietCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietCV.Location = new System.Drawing.Point(638, 475);
            this.dtgChiTietCV.MultiSelect = false;
            this.dtgChiTietCV.Name = "dtgChiTietCV";
            this.dtgChiTietCV.RowTemplate.Height = 24;
            this.dtgChiTietCV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChiTietCV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChiTietCV.Size = new System.Drawing.Size(588, 298);
            this.dtgChiTietCV.TabIndex = 0;
            this.dtgChiTietCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChiTietCV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(149, 22);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(203, 22);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chức Vụ";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(149, 77);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(203, 22);
            this.txtMaChucVu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lương Cơ Bản";
            // 
            // txtLCB
            // 
            this.txtLCB.Location = new System.Drawing.Point(149, 130);
            this.txtLCB.Name = "txtLCB";
            this.txtLCB.Size = new System.Drawing.Size(203, 22);
            this.txtLCB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phụ Cấp";
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(149, 196);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(203, 22);
            this.txtPC.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày BD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày KT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSuaHD);
            this.panel2.Controls.Add(this.btnThemHD);
            this.panel2.Controls.Add(this.btnLuuHD);
            this.panel2.Controls.Add(this.btnXoaHD);
            this.panel2.Location = new System.Drawing.Point(203, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 99);
            this.panel2.TabIndex = 6;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHD.Location = new System.Drawing.Point(560, 26);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(103, 46);
            this.btnSuaHD.TabIndex = 3;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.Location = new System.Drawing.Point(50, 26);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(103, 46);
            this.btnThemHD.TabIndex = 3;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.Location = new System.Drawing.Point(220, 26);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(103, 46);
            this.btnLuuHD.TabIndex = 3;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.Location = new System.Drawing.Point(391, 26);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(103, 46);
            this.btnXoaHD.TabIndex = 3;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // dtpngaybd
            // 
            this.dtpngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaybd.Location = new System.Drawing.Point(149, 251);
            this.dtpngaybd.Name = "dtpngaybd";
            this.dtpngaybd.Size = new System.Drawing.Size(200, 22);
            this.dtpngaybd.TabIndex = 7;
            // 
            // dtpngaykt
            // 
            this.dtpngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaykt.Location = new System.Drawing.Point(149, 301);
            this.dtpngaykt.Name = "dtpngaykt";
            this.dtpngaykt.Size = new System.Drawing.Size(200, 22);
            this.dtpngaykt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Danh sách nhân viên chưa ký hợp đồng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Danh sách chức vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(951, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Danh sách nhân viên đã ký hd";
            // 
            // frmChiTietChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 765);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpngaykt);
            this.Controls.Add(this.dtpngaybd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.txtLCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgChucVu);
            this.Controls.Add(this.dtgChiTietCV);
            this.Controls.Add(this.dtgNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChiTietChucVu";
            this.Text = "frmChiTietChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietCV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.DataGridView dtgChucVu;
        private System.Windows.Forms.DataGridView dtgChiTietCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.DateTimePicker dtpngaybd;
        private System.Windows.Forms.DateTimePicker dtpngaykt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}