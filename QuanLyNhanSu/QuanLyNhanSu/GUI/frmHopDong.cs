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
    public partial class frmHopDong : Form
    {
        DB_BUS db = new DB_BUS();
        public frmHopDong()
        {
            InitializeComponent();
            txtMaHD.Enabled = false;
            btnLuuHD.Enabled = false;
            load_dtgHopDong();
            btnThemHD.Image = Image.FromFile("./../../Icons/Them.PNG");
            btnLuuHD.Image = Image.FromFile("./../../Icons/Luu.PNG");
            btnXoaHD.Image = Image.FromFile("./../../Icons/Xoa.PNG");
            btnSuaHD.Image = Image.FromFile("./../../Icons/Sua.PNG");
            
        }
        private void load_dtgHopDong()
        {
            var dsHD = db.layDSHopDong();
            dtgHopDong.DataSource = dsHD;
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
            if (txtLoaiHD.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập loại hợp đồng !");
                txtLoaiHD.Focus();
                return false;
            }
            if (txtTHHD.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập thời hạn hợp đồng !");
                txtTHHD.Focus();
                return false;
            }
            if (IsNumber(txtTHHD.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập thời hạn hợp đồng là số !");
                txtTHHD.Focus();
                return false;
            }
            return true;
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (btnThemHD.Text.ToString().Trim().Equals("Thêm"))
            {
                btnLuuHD.Enabled = true;
                btnXoaHD.Enabled = false;
                btnSuaHD.Enabled = false;
                txtMaHD.Text = "AUTO";
                txtLoaiHD.Text = txtTHHD.Text = "";
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
                dtgHopDong.Rows[0].Selected = true;
                txtMaHD.Text = dtgHopDong.Rows[0].Cells[0].Value.ToString();

                txtLoaiHD.Text = dtgHopDong.Rows[0].Cells[1].Value.ToString();

                txtTHHD.Text = dtgHopDong.Rows[0].Cells[2].Value.ToString();

            }
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieu() == false)
                return;
            db.themHopDong(txtLoaiHD.Text, int.Parse(txtTHHD.Text));
            MessageBox.Show("Thêm hợp đồng thành công");
            load_dtgHopDong();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa !");
                return;
            }
            int ma = int.Parse(txtMaHD.Text);
            if(db.ktKhoaNgoai_NhanVien_HD(ma) == false)
            {
                MessageBox.Show("Không thể xóa hợp đồng này");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    db.xoaHopDong(ma);
                    MessageBox.Show("Xóa hợp đồng thành công");
                    load_dtgHopDong();
                }
               
            } 
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần sửa !");
                return;
            }
            if (kiemTraDuLieu() == false)
                return;
            db.capnhatHopDong(int.Parse(txtMaHD.Text), txtLoaiHD.Text, int.Parse(txtTHHD.Text));
            MessageBox.Show("Cập nhật hợp đồng thành công");
            load_dtgHopDong();
        }

        private void dtgHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btnThemHD.Text.Equals("Đóng"))
            {
                try
                {
                    txtMaHD.Text = dtgHopDong.Rows[e.RowIndex].Cells[0].Value.ToString();

                    txtLoaiHD.Text = dtgHopDong.Rows[e.RowIndex].Cells[1].Value.ToString();

                    txtTHHD.Text = dtgHopDong.Rows[e.RowIndex].Cells[2].Value.ToString();

                }
                catch
                {

                    //throw;
                }
            }

           
        }
    }
}
