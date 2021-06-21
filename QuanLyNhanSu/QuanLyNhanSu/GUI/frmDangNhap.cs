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
    public partial class frmDangNhap : Form
    {
        DB_BUS db = new DB_BUS();
        Main f = new Main();
        public frmDangNhap()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("./../../Icons/background.jfif");
                
        }
        public class LuuThongTin
        {
            public static int ma;
            public static String taikhoan;
            public static String matkhau;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblTAIKHOAN taikhoan = db.check_TaiKhoan(txtTK.Text.ToString().Trim(), txtMatKhau.Text.ToString().Trim());
            if(taikhoan == null)
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                LuuThongTin.ma = taikhoan.MaNhanVien;
                LuuThongTin.taikhoan = taikhoan.TaiKhoan;
                LuuThongTin.matkhau = taikhoan.MatKhau;
                this.Hide();
                f = new Main();
                f.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
        }
    }
}
