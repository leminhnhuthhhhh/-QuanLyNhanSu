namespace QuanLyNhanSu.GUI
{
    partial class frmChucVu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaCV = new System.Windows.Forms.Button();
            this.btnThemCV = new System.Windows.Forms.Button();
            this.btnLuuCV = new System.Windows.Forms.Button();
            this.btnXoaCV = new System.Windows.Forms.Button();
            this.dtgChucVu = new System.Windows.Forms.DataGridView();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSuaCV);
            this.panel2.Controls.Add(this.btnThemCV);
            this.panel2.Controls.Add(this.btnLuuCV);
            this.panel2.Controls.Add(this.btnXoaCV);
            this.panel2.Location = new System.Drawing.Point(245, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 99);
            this.panel2.TabIndex = 13;
            // 
            // btnSuaCV
            // 
            this.btnSuaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCV.Location = new System.Drawing.Point(392, 26);
            this.btnSuaCV.Name = "btnSuaCV";
            this.btnSuaCV.Size = new System.Drawing.Size(103, 46);
            this.btnSuaCV.TabIndex = 3;
            this.btnSuaCV.Text = "Sửa";
            this.btnSuaCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaCV.UseVisualStyleBackColor = true;
            this.btnSuaCV.Click += new System.EventHandler(this.btnSuaCV_Click);
            // 
            // btnThemCV
            // 
            this.btnThemCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCV.Location = new System.Drawing.Point(50, 26);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(103, 46);
            this.btnThemCV.TabIndex = 3;
            this.btnThemCV.Text = "Thêm";
            this.btnThemCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCV.UseVisualStyleBackColor = true;
            this.btnThemCV.Click += new System.EventHandler(this.btnThemCV_Click);
            // 
            // btnLuuCV
            // 
            this.btnLuuCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCV.Location = new System.Drawing.Point(220, 26);
            this.btnLuuCV.Name = "btnLuuCV";
            this.btnLuuCV.Size = new System.Drawing.Size(103, 46);
            this.btnLuuCV.TabIndex = 3;
            this.btnLuuCV.Text = "Lưu";
            this.btnLuuCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuCV.UseVisualStyleBackColor = true;
            this.btnLuuCV.Click += new System.EventHandler(this.btnLuuCV_Click);
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCV.Location = new System.Drawing.Point(562, 26);
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.Size = new System.Drawing.Size(103, 46);
            this.btnXoaCV.TabIndex = 3;
            this.btnXoaCV.Text = "Xóa";
            this.btnXoaCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaCV.UseVisualStyleBackColor = true;
            this.btnXoaCV.Click += new System.EventHandler(this.btnXoaCV_Click);
            // 
            // dtgChucVu
            // 
            this.dtgChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.TenChucVu});
            this.dtgChucVu.Location = new System.Drawing.Point(245, 471);
            this.dtgChucVu.MultiSelect = false;
            this.dtgChucVu.Name = "dtgChucVu";
            this.dtgChucVu.ReadOnly = true;
            this.dtgChucVu.RowTemplate.Height = 24;
            this.dtgChucVu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChucVu.Size = new System.Drawing.Size(732, 260);
            this.dtgChucVu.TabIndex = 12;
            this.dtgChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChucVu_CellClick);
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(509, 111);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(265, 22);
            this.txtMaCV.TabIndex = 10;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(509, 174);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(265, 22);
            this.txtTenCV.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Danh sách chức vụ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã Chức Vụ";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Tên Chức Vụ";
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.ReadOnly = true;
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 765);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgChucVu);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChucVu";
            this.Text = "frmChucVu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSuaCV;
        private System.Windows.Forms.Button btnThemCV;
        private System.Windows.Forms.Button btnLuuCV;
        private System.Windows.Forms.Button btnXoaCV;
        private System.Windows.Forms.DataGridView dtgChucVu;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
    }
}