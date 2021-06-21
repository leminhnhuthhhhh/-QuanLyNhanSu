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
using System.Text.RegularExpressions;
namespace QuanLyNhanSu.GUI
{
    public partial class frmBangLuong : Form
    {
        DB_BUS db = new DB_BUS();
        public frmBangLuong()
        {
            InitializeComponent();
            btnThem.Image = Image.FromFile("./../../Icons/Them.PNG");
            btnXem.Image = Image.FromFile("./../../Icons/Tim.PNG");
            btnTinhLuong.Image = Image.FromFile("./../../Icons/Tinh.PNG");
        }
        private void load_Luong()
        {
            var ds = db.layDSBL();
            dtgLuong.DataSource = ds;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void tinhToan()
        {
            for (int i = 0; i < dtgLuong.RowCount; i++)
            {
                int snl = db.tinhSoNgayLam(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), DateTime.Now.Month, DateTime.Now.Year);
                float tienthuong = db.tinhTienThuong(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), DateTime.Now.Month, DateTime.Now.Year);
                float tienphat = db.tinhTienPhat(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), DateTime.Now.Month, DateTime.Now.Year);
                float lcb = float.Parse(dtgLuong.Rows[i].Cells["LuongCoBan"].Value.ToString());
                float hesoLuong = float.Parse(dtgLuong.Rows[i].Cells["HeSoLuong"].Value.ToString());
                float pc = float.Parse(dtgLuong.Rows[i].Cells["PhuCapChucVu"].Value.ToString());
                dtgLuong.Rows[i].Cells["SoNgayLam"].Value = snl;
                dtgLuong.Rows[i].Cells["TienThuong"].Value = tienthuong;
                dtgLuong.Rows[i].Cells["TienPhat"].Value = tienphat;
                dtgLuong.Rows[i].Cells["TongTien"].Value = db.tongTien(lcb, hesoLuong, pc, snl, tienthuong, tienphat);
                if(dtgLuong.Rows[i].Cells["NgayLap"].Value == null)
                {
                    dtgLuong.Rows[i].Cells["NgayLap"].Value = DateTime.Now;
                } 
            }
        }
        private void frmBangLuong_Load(object sender, EventArgs e)
        {
           
            load_Luong();
            //dtgLuong.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (db.kiemTraLapBangLuong())
            {
                for (int i = 0; i < dtgLuong.RowCount; i++)
                {
                    int snl = db.tinhSoNgayLam(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), DateTime.Now.Month, DateTime.Now.Year);
                    float tienthuong = db.tinhTienThuong(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), DateTime.Now.Month, DateTime.Now.Year);
                    float tienphat = db.tinhTienPhat(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), DateTime.Now.Month, DateTime.Now.Year);
                    float lcb = float.Parse(dtgLuong.Rows[i].Cells["LuongCoBan"].Value.ToString());
                    float hesoLuong = float.Parse(dtgLuong.Rows[i].Cells["HeSoLuong"].Value.ToString());
                    float pc = float.Parse(dtgLuong.Rows[i].Cells["PhuCapChucVu"].Value.ToString());
                    float tongluong = db.tongTien(lcb, hesoLuong, pc, snl, tienthuong, tienphat);

                    tblNHANVIEN nv = db.timNVTheoMa(QuanLyNhanSu.GUI.frmDangNhap.LuuThongTin.ma);

                    db.themLuong(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), tongluong, nv.MaNhanVien);
                }
                MessageBox.Show("Đã Lập Bảng Lương");
            }
            else
            {
                MessageBox.Show("Tháng này đã lập bảng lương");
            }
            
            
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            tinhToan();
        }
       

        private void dtgLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTenNV.Text = dtgLuong.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();
                txtLuongCB.Text = dtgLuong.Rows[e.RowIndex].Cells["LuongCoBan"].Value.ToString();
                txtHSL.Text = dtgLuong.Rows[e.RowIndex].Cells["HeSoLuong"].Value.ToString();
                txtSNL.Text = dtgLuong.Rows[e.RowIndex].Cells["SoNgayLam"].Value.ToString();
                txtTienThuong.Text = dtgLuong.Rows[e.RowIndex].Cells["TienThuong"].Value.ToString();
                txtTienPhat.Text = dtgLuong.Rows[e.RowIndex].Cells["TienPhat"].Value.ToString();
                dateTimePicker1.Text = dtgLuong.Rows[e.RowIndex].Cells["NgayLap"].Value.ToString();
                txtTongTien.Text = dtgLuong.Rows[e.RowIndex].Cells["TongTien"].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
        private void tinhToan_LuaChon(int thang, int nam)
        {
            // tinh luong
            for (int i = 0; i < dtgLuong.RowCount; i++)
            {
                int snl = db.tinhSoNgayLam(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), thang, nam);
                float tienthuong = db.tinhTienThuong(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), thang, nam);
                float tienphat = db.tinhTienPhat(int.Parse(dtgLuong.Rows[i].Cells["MaNhanVien"].Value.ToString()), thang, nam);
                float lcb = float.Parse(dtgLuong.Rows[i].Cells["LuongCoBan"].Value.ToString());
                float hesoLuong = float.Parse(dtgLuong.Rows[i].Cells["HeSoLuong"].Value.ToString());
                float pc = float.Parse(dtgLuong.Rows[i].Cells["PhuCapChucVu"].Value.ToString());
                dtgLuong.Rows[i].Cells["SoNgayLam"].Value = snl;
                dtgLuong.Rows[i].Cells["TienThuong"].Value = tienthuong;
                dtgLuong.Rows[i].Cells["TienPhat"].Value = tienphat;
                dtgLuong.Rows[i].Cells["TongTien"].Value = db.tongTien(lcb, hesoLuong, pc, snl, tienthuong, tienphat);
                if (dtgLuong.Rows[i].Cells["NgayLap"].Value == null)
                {
                    dtgLuong.Rows[i].Cells["NgayLap"].Value = DateTime.Now;
                }

            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = null;
            try
            {
                regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$"); return regex.IsMatch(pText);
            }
            catch (Exception ex)
            {
                return regex.IsMatch(pText);
            }
        }
        private bool kiemTraDuLieu()
        {
            if (txtThang.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tháng !");
                txtThang.Focus();
                return false;
            }
            if (!IsNumber(txtThang.Text))
            {
                MessageBox.Show("Vui lòng nhập tháng là số !");
                txtThang.Focus();
                return false;
            }
            if (txtNam.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập năm !");
                txtNam.Focus();
                return false;
            }
            if (!IsNumber(txtNam.Text))
            {
                MessageBox.Show("Vui lòng nhập năm là số !");
                txtNam.Focus();
                return false;
            }

            return true;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            // load len
            dtgLuong.DataSource = null;
            dtgLuong.Rows.Clear();
            dtgLuong.Refresh();
            //
            var ds = db.layDSBL_LuaChon(5, 2021);
            dtgLuong.DataSource = ds;
            // kiem tra thang , nam
            int thang = int.Parse(txtThang.Text);
            int nam = int.Parse(txtNam.Text);
            // load
            tinhToan_LuaChon(thang, nam);
        }
    }
}
