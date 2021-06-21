namespace QuanLyNhanSu.GUI
{
    partial class frmPhongBan
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaPB = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.btnLuuPb = new System.Windows.Forms.Button();
            this.btnXoaPb = new System.Windows.Forms.Button();
            this.dtgPhongBan = new System.Windows.Forms.DataGridView();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgPhongBan);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.txtTenPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(92, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 679);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSuaPB);
            this.panel2.Controls.Add(this.btnThemPB);
            this.panel2.Controls.Add(this.btnLuuPb);
            this.panel2.Controls.Add(this.btnXoaPb);
            this.panel2.Location = new System.Drawing.Point(163, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 99);
            this.panel2.TabIndex = 5;
            // 
            // btnSuaPB
            // 
            this.btnSuaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPB.Location = new System.Drawing.Point(392, 26);
            this.btnSuaPB.Name = "btnSuaPB";
            this.btnSuaPB.Size = new System.Drawing.Size(103, 46);
            this.btnSuaPB.TabIndex = 3;
            this.btnSuaPB.Text = "Sửa";
            this.btnSuaPB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaPB.UseVisualStyleBackColor = true;
            this.btnSuaPB.Click += new System.EventHandler(this.btnSuaPB_Click);
            // 
            // btnThemPB
            // 
            this.btnThemPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPB.Location = new System.Drawing.Point(66, 26);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(103, 46);
            this.btnThemPB.TabIndex = 3;
            this.btnThemPB.Text = "Thêm";
            this.btnThemPB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemPB.UseVisualStyleBackColor = true;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // btnLuuPb
            // 
            this.btnLuuPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPb.Location = new System.Drawing.Point(228, 26);
            this.btnLuuPb.Name = "btnLuuPb";
            this.btnLuuPb.Size = new System.Drawing.Size(103, 46);
            this.btnLuuPb.TabIndex = 3;
            this.btnLuuPb.Text = "Lưu";
            this.btnLuuPb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuPb.UseVisualStyleBackColor = true;
            this.btnLuuPb.Click += new System.EventHandler(this.btnLuuPb_Click);
            // 
            // btnXoaPb
            // 
            this.btnXoaPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPb.Location = new System.Drawing.Point(562, 26);
            this.btnXoaPb.Name = "btnXoaPb";
            this.btnXoaPb.Size = new System.Drawing.Size(103, 46);
            this.btnXoaPb.TabIndex = 3;
            this.btnXoaPb.Text = "Xóa";
            this.btnXoaPb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaPb.UseVisualStyleBackColor = true;
            this.btnXoaPb.Click += new System.EventHandler(this.btnXoaPb_Click);
            // 
            // dtgPhongBan
            // 
            this.dtgPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.GhiChu});
            this.dtgPhongBan.Location = new System.Drawing.Point(74, 397);
            this.dtgPhongBan.MultiSelect = false;
            this.dtgPhongBan.Name = "dtgPhongBan";
            this.dtgPhongBan.ReadOnly = true;
            this.dtgPhongBan.RowTemplate.Height = 24;
            this.dtgPhongBan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPhongBan.Size = new System.Drawing.Size(885, 264);
            this.dtgPhongBan.TabIndex = 4;
            this.dtgPhongBan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgPhongBan_CellMouseClick);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(681, 89);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(265, 98);
            this.txtGhiChu.TabIndex = 1;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi Chú";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(199, 89);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(265, 22);
            this.txtMaPhong.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(199, 152);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(265, 22);
            this.txtTenPhong.TabIndex = 1;
            this.txtTenPhong.TextChanged += new System.EventHandler(this.txtTenPhong_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Danh sách phòng ban";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 812);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhongBan";
            this.Text = "frmPhongBan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuaPB;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.Button btnLuuPb;
        private System.Windows.Forms.Button btnXoaPb;
        private System.Windows.Forms.DataGridView dtgPhongBan;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}