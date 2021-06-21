namespace QuanLyNhanSu.GUI
{
    partial class frmBaoHiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiBaoHiem = new System.Windows.Forms.ComboBox();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemBH = new System.Windows.Forms.Button();
            this.btnLuuBH = new System.Windows.Forms.Button();
            this.btnXoaBH = new System.Windows.Forms.Button();
            this.dtgBaoHiem = new System.Windows.Forms.DataGridView();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoHiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.dtpNgayHetHan);
            this.panel1.Controls.Add(this.dtpNgayCap);
            this.panel1.Controls.Add(this.cbLoaiBaoHiem);
            this.panel1.Controls.Add(this.dtgNhanVien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgBaoHiem);
            this.panel1.Controls.Add(this.txtNoiCap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSoThe);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 741);
            this.panel1.TabIndex = 1;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(175, 269);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(204, 22);
            this.dtpNgayHetHan.TabIndex = 8;
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCap.Location = new System.Drawing.Point(175, 208);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(204, 22);
            this.dtpNgayCap.TabIndex = 8;
            // 
            // cbLoaiBaoHiem
            // 
            this.cbLoaiBaoHiem.FormattingEnabled = true;
            this.cbLoaiBaoHiem.Location = new System.Drawing.Point(175, 85);
            this.cbLoaiBaoHiem.Name = "cbLoaiBaoHiem";
            this.cbLoaiBaoHiem.Size = new System.Drawing.Size(204, 24);
            this.cbLoaiBaoHiem.TabIndex = 7;
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Location = new System.Drawing.Point(466, 51);
            this.dtgNhanVien.MultiSelect = false;
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowTemplate.Height = 24;
            this.dtgNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNhanVien.Size = new System.Drawing.Size(672, 467);
            this.dtgNhanVien.TabIndex = 6;
            this.dtgNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhanVien_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemBH);
            this.panel2.Controls.Add(this.btnLuuBH);
            this.panel2.Controls.Add(this.btnXoaBH);
            this.panel2.Location = new System.Drawing.Point(53, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 137);
            this.panel2.TabIndex = 5;
            // 
            // btnThemBH
            // 
            this.btnThemBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBH.Location = new System.Drawing.Point(17, 12);
            this.btnThemBH.Name = "btnThemBH";
            this.btnThemBH.Size = new System.Drawing.Size(103, 46);
            this.btnThemBH.TabIndex = 3;
            this.btnThemBH.Text = "Thêm";
            this.btnThemBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemBH.UseVisualStyleBackColor = true;
            this.btnThemBH.Click += new System.EventHandler(this.btnThemBH_Click);
            // 
            // btnLuuBH
            // 
            this.btnLuuBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuBH.Location = new System.Drawing.Point(192, 12);
            this.btnLuuBH.Name = "btnLuuBH";
            this.btnLuuBH.Size = new System.Drawing.Size(103, 46);
            this.btnLuuBH.TabIndex = 3;
            this.btnLuuBH.Text = "Lưu";
            this.btnLuuBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuBH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuBH.UseVisualStyleBackColor = true;
            this.btnLuuBH.Click += new System.EventHandler(this.btnLuuBH_Click);
            // 
            // btnXoaBH
            // 
            this.btnXoaBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBH.Location = new System.Drawing.Point(96, 75);
            this.btnXoaBH.Name = "btnXoaBH";
            this.btnXoaBH.Size = new System.Drawing.Size(103, 46);
            this.btnXoaBH.TabIndex = 3;
            this.btnXoaBH.Text = "Xóa";
            this.btnXoaBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaBH.UseVisualStyleBackColor = true;
            this.btnXoaBH.Click += new System.EventHandler(this.btnXoaBH_Click);
            // 
            // dtgBaoHiem
            // 
            this.dtgBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaoHiem.Location = new System.Drawing.Point(136, 563);
            this.dtgBaoHiem.MultiSelect = false;
            this.dtgBaoHiem.Name = "dtgBaoHiem";
            this.dtgBaoHiem.RowTemplate.Height = 24;
            this.dtgBaoHiem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBaoHiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBaoHiem.Size = new System.Drawing.Size(956, 175);
            this.dtgBaoHiem.TabIndex = 4;
            this.dtgBaoHiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBaoHiem_CellClick);
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(175, 330);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(204, 22);
            this.txtNoiCap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nơi Cấp";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(175, 145);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(204, 22);
            this.txtSoThe.TabIndex = 1;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(175, 22);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(204, 22);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Hết Hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Thẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Bảo Hiểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(132, 530);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(239, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Danh sách bảo hiểm nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Danh sách nhân viên";
            // 
            // frmBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 765);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoHiem";
            this.Text = "frmBaoHiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoHiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemBH;
        private System.Windows.Forms.Button btnLuuBH;
        private System.Windows.Forms.Button btnXoaBH;
        private System.Windows.Forms.DataGridView dtgBaoHiem;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiBaoHiem;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
    }
}