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
    public partial class frmDoiMatKhau : Form
    {
        DB_BUS db = new DB_BUS();

        public frmDoiMatKhau()
        {
            InitializeComponent();
            txtTaiKhoan.Enabled = false;
            txtTaiKhoan.Text = QuanLyNhanSu.GUI.frmDangNhap.LuuThongTin.taikhoan;
        }
        private bool kiemTraDuLieu()
        {
            if (txtMKC.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ !");
                return false;
            }
            if (txtMKM.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới !");
                return false;
            }

            if (txtNLMK.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới lần 2 !");
                return false;
            }
            if (!txtNLMK.Text.Equals(txtMKM.Text))
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau");
                return false;
            }
            return true;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            if(!txtMKC.Text.Equals(QuanLyNhanSu.GUI.frmDangNhap.LuuThongTin.matkhau))
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }
            db.doiMatKhau(txtTaiKhoan.Text, txtMKM.Text);
            MessageBox.Show("Đổi mật khẩu thành công");
            QuanLyNhanSu.GUI.frmDangNhap.LuuThongTin.matkhau = txtMKM.Text;
            txtMKC.Text = txtMKM.Text = txtNLMK.Text = "";
        }
    }
}
