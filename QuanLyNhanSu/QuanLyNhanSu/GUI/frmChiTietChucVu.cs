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
    public partial class frmChiTietChucVu : Form
    {
        DB_BUS db = new DB_BUS();
        public frmChiTietChucVu()
        {
            InitializeComponent();
            load_NvChuaCoChiTiet();
            load_dtgChucVu();
            load_dtgCTCV();
            btnLuuHD.Enabled = false;
            txtMaChucVu.Enabled = false;
            txtMaNhanVien.Enabled = false;
            btnThemHD.Image = Image.FromFile("./../../Icons/Them.PNG");
            btnLuuHD.Image = Image.FromFile("./../../Icons/Luu.PNG");
            btnXoaHD.Image = Image.FromFile("./../../Icons/Xoa.PNG");
            btnSuaHD.Image = Image.FromFile("./../../Icons/Sua.PNG");
        }

        public void load_NvChuaCoChiTiet()
        {
            var ds = db.layDSNV_ChuaCoCT();
            dtgNhanVien.DataSource = ds;
        }
        public void load_dtgChucVu()
        {
            var ds = db.layDSChucVu();
            dtgChucVu.DataSource = ds;
        }

        public void load_dtgCTCV()
        {
            var ds = db.layDS_CT_ChucVu();
            dtgChiTietCV.DataSource = ds;
        }
        private void DataBinding()
        {
            try
            {
                txtMaNhanVien.Text = dtgChiTietCV.CurrentRow.Cells[0].Value.ToString();
                txtMaChucVu.Text = dtgChiTietCV.CurrentRow.Cells[2].Value.ToString();
                txtLCB.Text = dtgChiTietCV.CurrentRow.Cells[3].Value.ToString();
                txtPC.Text = dtgChiTietCV.CurrentRow.Cells[4].Value.ToString();
                dtpngaybd.Text = dtgChiTietCV.CurrentRow.Cells[5].Value.ToString();
                dtpngaykt.Text = dtgChiTietCV.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
            }
           
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (btnThemHD.Text.ToString().Trim().Equals("Thêm"))
            {
                btnLuuHD.Enabled = true;
                btnXoaHD.Enabled = false;
                btnSuaHD.Enabled = false;
                txtMaChucVu.Text = txtMaNhanVien.Text = txtLCB.Text = txtPC.Text = "";
                
                btnThemHD.Image = Image.FromFile("./../../Icons/Dong.PNG");
                btnThemHD.Text = "Đóng";
            }
            else
            {
                btnThemHD.Image = Image.FromFile("./../../Icons/Them.PNG");
                btnLuuHD.Enabled = false;
                btnXoaHD.Enabled = true;
                btnSuaHD.Enabled = true;
                btnThemHD.Text = "Thêm";
                // chọn 1 dòng
                dtgChiTietCV.Rows[0].Selected = true;
                try
                {
                    txtMaNhanVien.Text = dtgChiTietCV.CurrentRow.Cells[0].Value.ToString();
                    txtMaChucVu.Text = dtgChiTietCV.CurrentRow.Cells[2].Value.ToString();
                    txtLCB.Text = dtgChiTietCV.CurrentRow.Cells[3].Value.ToString();
                    txtPC.Text = dtgChiTietCV.CurrentRow.Cells[4].Value.ToString();
                    dtpngaybd.Text = dtgChiTietCV.CurrentRow.Cells[5].Value.ToString();
                    dtpngaykt.Text = dtgChiTietCV.CurrentRow.Cells[6].Value.ToString();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void dtgChiTietCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!btnThemHD.Text.Equals("Đóng"))
            {
                DataBinding();
            }
            
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btnThemHD.Text.Equals("Đóng"))
            {
                txtMaNhanVien.Text = dtgNhanVien.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void dtgChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemHD.Text.Equals("Đóng"))
            {
                txtMaChucVu.Text = dtgChucVu.CurrentRow.Cells[0].Value.ToString();
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
            if (txtMaNhanVien.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn nhân viên !");
                return false;
            }
            if (txtMaChucVu.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn chức vụ !");
                return false;
            }
            if (txtLCB.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập lương cơ bản !");
                txtLCB.Focus();
                return false;
            }
            if (!IsNumber(txtLCB.Text))
            {
                MessageBox.Show("Vui lòng nhập lương cơ bản là số!");
                txtLCB.Focus();
                return false;
            }
            if (txtPC.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập phụ cấp !");
                txtPC.Focus();
                return false;
            }
            if (!IsNumber(txtPC.Text))
            {
                MessageBox.Show("Vui lòng nhập phụ cấp!");
                txtPC.Focus();
                return false;
            }
            return true;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            // kiem tra ton tai
            if (!db.ktKhoaChinh_CTCV(int.Parse(txtMaNhanVien.Text), int.Parse(txtMaChucVu.Text)))
            {
                MessageBox.Show("Đã tồn tại chi tiết chức vụ");
            }
            else
            {
                db.themCT(int.Parse(txtMaNhanVien.Text), int.Parse(txtMaChucVu.Text), float.Parse(txtLCB.Text), float.Parse(txtPC.Text), DateTime.Parse(dtpngaybd.Text), DateTime.Parse(dtpngaykt.Text));
                MessageBox.Show("Thêm chi tiêt chức vụ thành công");
                load_dtgCTCV();
                load_NvChuaCoChiTiet();
            }
            //    
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn nhân viên !");
                return;
            }
            if (txtMaChucVu.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn chức vụ !");
                return;
            }
            db.xoaCTChucVu(int.Parse(txtMaNhanVien.Text), int.Parse(txtMaChucVu.Text));
            MessageBox.Show("Xóa chi tiết chức vụ thành công !");
            load_dtgCTCV();
            load_NvChuaCoChiTiet();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            db.capnhatCTChucVu(int.Parse(txtMaNhanVien.Text), int.Parse(txtMaChucVu.Text), float.Parse(txtLCB.Text), float.Parse(txtPC.Text), DateTime.Parse(dtpngaybd.Text), DateTime.Parse(dtpngaykt.Text));
            MessageBox.Show("Cập nhật chi tiết chức vụ thành công !");
            load_dtgCTCV();
        }



    }
}
