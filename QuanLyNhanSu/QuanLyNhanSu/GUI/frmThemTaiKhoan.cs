using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAL;
using QuanLyNhanSu.BUS;
namespace QuanLyNhanSu.GUI
{
    public partial class frmThemTaiKhoan : Form
    {
        DB_BUS db = new DB_BUS();
        public frmThemTaiKhoan()
        {
            InitializeComponent();
            load_dtgTaiKhoan();
            load_dtgNhanVienChuaCoTaiKhoan();
            load_cbQuyen();
            txtMaNhanVien.Enabled = false;
        }
        private void load_dtgTaiKhoan()
        {
            var ds = db.layDSTaiKhoan_NV();
            dtgTaiKhoan.DataSource = ds;
        }
        private void load_dtgNhanVienChuaCoTaiKhoan()
        {
            var ds = db.layDSNV_ChuaCoTaiKhoan();
            dtgNhanVienTK.DataSource = ds;
        }
        private void load_cbQuyen()
        {
            List<String> lst = new List<string>() {"Admin" , "User" };
            cbQuyen.DataSource = lst;
        }
        private bool kiemTraDuLieu()
        {
            if (txtTaiKhoan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tài khoản !");
                txtTaiKhoan.Focus();
                return false;
            }
            if (txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !");
                txtMatKhau.Focus();
                return false;
            }
            if (cbQuyen.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn quyền !");
                return false;
            }
            if (txtMaNhanVien.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn nhân viên !");
                return false;
            }
            return true;
        }

        private void dtgNhanVienTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaiKhoan.Text = txtMatKhau.Text = "";
            cbQuyen.Text = "";
            txtMaNhanVien.Text = dtgNhanVienTK.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            if (db.ktKhoaChinh_TaiKhoan(txtTaiKhoan.Text))
            {
                db.themTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, cbQuyen.Text, int.Parse(txtMaNhanVien.Text));
                MessageBox.Show("Thêm tài khoản thành công");
                load_dtgNhanVienChuaCoTaiKhoan();
                load_dtgTaiKhoan();
            }
            else
                MessageBox.Show("Tên tài khoản đã tồn tại! ");
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa !");
                txtTaiKhoan.Focus();
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa không?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                String taikhoan = txtTaiKhoan.Text;
                db.xoaTaiKhoan(taikhoan);
                MessageBox.Show("Xóa tài khoản thành công");
                load_dtgNhanVienChuaCoTaiKhoan();
                load_dtgTaiKhoan();
            }
           
        }
        private void DataBinding()
        {
            txtMaNhanVien.Text = dtgTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtTaiKhoan.Text = dtgTaiKhoan.CurrentRow.Cells[2].Value.ToString();
            txtMatKhau.Text = dtgTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            cbQuyen.Text = dtgTaiKhoan.CurrentRow.Cells[4].Value.ToString();
        }
        private void dtgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBinding();
        }
        
    }
}
