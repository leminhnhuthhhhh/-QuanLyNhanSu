namespace QuanLyNhanSu.GUI
{
    partial class frmChamCong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgChamCong = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhTrang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtpNgayCham = new System.Windows.Forms.DateTimePicker();
            this.chkTatCa = new System.Windows.Forms.CheckBox();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgThoiGian = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Chấm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình Trạng";
            // 
            // dtgChamCong
            // 
            this.dtgChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.TrinhTrang});
            this.dtgChamCong.Location = new System.Drawing.Point(67, 298);
            this.dtgChamCong.MultiSelect = false;
            this.dtgChamCong.Name = "dtgChamCong";
            this.dtgChamCong.RowTemplate.Height = 24;
            this.dtgChamCong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChamCong.Size = new System.Drawing.Size(1055, 491);
            this.dtgChamCong.TabIndex = 2;
            this.dtgChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChamCong_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // TrinhTrang
            // 
            this.TrinhTrang.DataPropertyName = "TrinhTrang";
            this.TrinhTrang.HeaderText = "Tình Trạng";
            this.TrinhTrang.Items.AddRange(new object[] {
            "Đi Làm",
            "Vắng Mặt",
            "Nghỉ Có Phép"});
            this.TrinhTrang.Name = "TrinhTrang";
            this.TrinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtpNgayCham
            // 
            this.dtpNgayCham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCham.Location = new System.Drawing.Point(218, 138);
            this.dtpNgayCham.Name = "dtpNgayCham";
            this.dtpNgayCham.Size = new System.Drawing.Size(181, 22);
            this.dtpNgayCham.TabIndex = 3;
            // 
            // chkTatCa
            // 
            this.chkTatCa.AutoSize = true;
            this.chkTatCa.Location = new System.Drawing.Point(67, 248);
            this.chkTatCa.Name = "chkTatCa";
            this.chkTatCa.Size = new System.Drawing.Size(140, 21);
            this.chkTatCa.TabIndex = 5;
            this.chkTatCa.Text = "Chấm công tất cả";
            this.chkTatCa.UseVisualStyleBackColor = true;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Location = new System.Drawing.Point(960, 33);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(179, 48);
            this.btnChamCong.TabIndex = 6;
            this.btnChamCong.Text = "Chấm Công";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày chấm công";
            // 
            // dtgThoiGian
            // 
            this.dtgThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtgThoiGian.Location = new System.Drawing.Point(919, 248);
            this.dtgThoiGian.Name = "dtgThoiGian";
            this.dtgThoiGian.Size = new System.Drawing.Size(200, 22);
            this.dtgThoiGian.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(945, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xóa Chấm Công";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(215, 67);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(0, 17);
            this.lblMaNhanVien.TabIndex = 10;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(638, 64);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(0, 17);
            this.lblTenNhanVien.TabIndex = 11;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(638, 141);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(0, 17);
            this.lblTinhTrang.TabIndex = 11;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 812);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgThoiGian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.chkTatCa);
            this.Controls.Add(this.dtpNgayCham);
            this.Controls.Add(this.dtgChamCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgChamCong;
        private System.Windows.Forms.DateTimePicker dtpNgayCham;
        private System.Windows.Forms.CheckBox chkTatCa;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtgThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn TrinhTrang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblTinhTrang;
    }
}