using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;
using QuanLyNhanSu.DAL;
namespace QuanLyNhanSu.GUI
{
    public partial class frmChucVu : Form
    {
        DB_BUS db = new DB_BUS();
        public frmChucVu()
        {
            InitializeComponent();
            txtMaCV.Enabled = false;
            load_dtgChucVu();
            btnLuuCV.Enabled = false;
            btnThemCV.Image = Image.FromFile("./../../Icons/Them.PNG");
            btnLuuCV.Image = Image.FromFile("./../../Icons/Luu.PNG");
            btnXoaCV.Image = Image.FromFile("./../../Icons/Xoa.PNG");
            btnSuaCV.Image = Image.FromFile("./../../Icons/Sua.PNG");
        }
        private void load_dtgChucVu()
        {
            List<tblCHUCVU> dsCV = db.layDSChucVu();
            dtgChucVu.DataSource = dsCV;
            //if (dsCV.Count() > 0)
            //{
            //    dtgChucVu.Rows[0].Selected = true;
            //    txtMaCV.Text = dtgChucVu.Rows[0].Cells[0].Value.ToString();
            //    txtTenCV.Text = dtgChucVu.Rows[0].Cells[1].Value.ToString();
            //}
        }
        private bool kiemTraDuLieu()
        {
            if (txtTenCV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên chức vụ !");
                txtTenCV.Focus();
                return false;
            }
            return true;
        }
        private void btnThemCV_Click(object sender, EventArgs e)
        {
            if (btnThemCV.Text.ToString().Trim().Equals("Thêm"))
            {
                btnLuuCV.Enabled = true;
                btnXoaCV.Enabled = false;
                btnSuaCV.Enabled = false;
                txtMaCV.Text = "AUTO";
                txtTenCV.Text = "";
                btnThemCV.Text = "Đóng";
                btnThemCV.Image = Image.FromFile("./../../Icons/Dong.PNG");
            }
            else
            {
                btnThemCV.Image = Image.FromFile("./../../Icons/Them.PNG");
                btnLuuCV.Enabled = false;
                btnXoaCV.Enabled = true;
                btnSuaCV.Enabled = true;
                btnThemCV.Text = "Thêm";
                // chọn 1 dòng
                dtgChucVu.Rows[0].Selected = true;
                txtMaCV.Text = dtgChucVu.Rows[0].Cells[0].Value.ToString();
                txtTenCV.Text = dtgChucVu.Rows[0].Cells[1].Value.ToString();
            }
        }

        private void btnLuuCV_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            db.themChucVu(txtTenCV.Text);
            MessageBox.Show("Thêm chức vụ thành công");
            load_dtgChucVu();
        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            db.capnhatChucVu(int.Parse(txtMaCV.Text), txtTenCV.Text);
            MessageBox.Show("Cập nhật chức vụ thành công");
            load_dtgChucVu();
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần xóa !");
                return;
            }
            int ma = int.Parse(dtgChucVu.CurrentRow.Cells[0].Value.ToString());
            //if (db.ktKhoaNgoai_CTChucVu(ma) == false || db.ktKhoaNgoai_HopDong(ma) == false)
            //{
            //    MessageBox.Show("Không thể xóa chức vụ này");
            //} 
            if (db.ktKhoaNgoai_CTChucVu(ma) == false)
            {
                MessageBox.Show("Không thể xóa chức vụ này");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    db.xoaChucVu(ma);
                    MessageBox.Show("Xóa chức vụ thành công");
                    load_dtgChucVu();
                }
               
            }
        }
        private void DataBinding()
        {
            txtMaCV.Text = dtgChucVu.CurrentRow.Cells[0].Value.ToString();
            txtTenCV.Text = dtgChucVu.CurrentRow.Cells[1].Value.ToString();
        }
        private void dtgChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!btnThemCV.Text.Equals("Đóng"))
            {
                DataBinding();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
