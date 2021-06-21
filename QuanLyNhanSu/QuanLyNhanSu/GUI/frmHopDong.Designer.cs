namespace QuanLyNhanSu.GUI
{
    partial class frmHopDong
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.dtgHopDong = new System.Windows.Forms.DataGridView();
            this.txtTHHD = new System.Windows.Forms.TextBox();
            this.txtLoaiHD = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiHanHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgHopDong);
            this.panel1.Controls.Add(this.txtTHHD);
            this.panel1.Controls.Add(this.txtLoaiHD);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(81, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 679);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSuaHD);
            this.panel2.Controls.Add(this.btnThemHD);
            this.panel2.Controls.Add(this.btnLuuHD);
            this.panel2.Controls.Add(this.btnXoaHD);
            this.panel2.Location = new System.Drawing.Point(163, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 99);
            this.panel2.TabIndex = 5;
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
            // dtgHopDong
            // 
            this.dtgHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHopDong,
            this.LoaiHopDong,
            this.ThoiHanHopDong});
            this.dtgHopDong.Location = new System.Drawing.Point(74, 384);
            this.dtgHopDong.MultiSelect = false;
            this.dtgHopDong.Name = "dtgHopDong";
            this.dtgHopDong.RowTemplate.Height = 24;
            this.dtgHopDong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHopDong.Size = new System.Drawing.Size(885, 277);
            this.dtgHopDong.TabIndex = 4;
            this.dtgHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHopDong_CellClick);
            // 
            // txtTHHD
            // 
            this.txtTHHD.Location = new System.Drawing.Point(688, 87);
            this.txtTHHD.Name = "txtTHHD";
            this.txtTHHD.Size = new System.Drawing.Size(265, 22);
            this.txtTHHD.TabIndex = 1;
            // 
            // txtLoaiHD
            // 
            this.txtLoaiHD.Location = new System.Drawing.Point(197, 148);
            this.txtLoaiHD.Name = "txtLoaiHD";
            this.txtLoaiHD.Size = new System.Drawing.Size(265, 22);
            this.txtLoaiHD.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(197, 85);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(265, 22);
            this.txtMaHD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời Hạn Hợp Đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Hợp Đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // MaHopDong
            // 
            this.MaHopDong.DataPropertyName = "MaHopDong";
            this.MaHopDong.HeaderText = "Mã Hợp Đồng";
            this.MaHopDong.Name = "MaHopDong";
            // 
            // LoaiHopDong
            // 
            this.LoaiHopDong.DataPropertyName = "LoaiHopDong";
            this.LoaiHopDong.HeaderText = "Loại Hợp Đồng";
            this.LoaiHopDong.Name = "LoaiHopDong";
            // 
            // ThoiHanHopDong
            // 
            this.ThoiHanHopDong.DataPropertyName = "ThoiHanHopDong";
            this.ThoiHanHopDong.HeaderText = "Thời Hạn Hợp Đồng";
            this.ThoiHanHopDong.Name = "ThoiHanHopDong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Danh sách hợp đồng";
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 765);
            this.Controls.Add(this.panel1);
            this.Name = "frmHopDong";
            this.Text = "frmHopDong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.DataGridView dtgHopDong;
        private System.Windows.Forms.TextBox txtTHHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiHanHopDong;
        private System.Windows.Forms.Label label5;
    }
}