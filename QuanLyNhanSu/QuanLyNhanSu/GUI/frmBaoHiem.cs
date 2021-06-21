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
    public partial class frmBaoHiem : Form
    {
        DB_BUS db = new DB_BUS();
        public frmBaoHiem()
        {
            InitializeComponent();
            load_dtgBaoHiem();
            load_dtgNhanVien();
            load_cbLoaiBH();
            btnLuuBH.Enabled = false;
            txtMaNhanVien.Enabled = false;
            btnThemBH.Image = Image.FromFile("./../../Icons/Them.PNG");
            btnLuuBH.Image = Image.FromFile("./../../Icons/Luu.PNG");
            btnXoaBH.Image = Image.FromFile("./../../Icons/Xoa.PNG");
        }
        private void load_dtgBaoHiem()
        {
            var dsBH = db.layDSBH();
            dtgBaoHiem.DataSource = dsBH;
        }
        private void load_cbLoaiBH()
        {
            List<String> lst = new List<string>() { "Bảo hiểm y tế", "Bảo hiểm tai nạn"};
            cbLoaiBaoHiem.DataSource = lst;
        }
        private void load_dtgNhanVien()
        {
            var dsNV = db.layDSNV_BH();
            dtgNhanVien.DataSource = dsNV;
        }
        private bool kiemTraDuLieu()
        {
            if (txtMaNhanVien.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn nhân viên !");
                return false;
            }
            if (cbLoaiBaoHiem.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn loai bao hiem !");
                return false;
            }
           
            if (txtSoThe.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số thẻ bảo hiểm !");
                return false;
            }
            if (txtNoiCap.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập nơi cấp !");
                return false;
            }
            return true;
        }
        private void btnThemBH_Click(object sender, EventArgs e)
        {
            if (btnThemBH.Text.ToString().Trim().Equals("Thêm"))
            {
                btnLuuBH.Enabled = true;
                btnXoaBH.Enabled = false;
                //btnSuaBH.Enabled = false;
                txtMaNhanVien.Text = txtNoiCap.Text = txtSoThe.Text = "";
                cbLoaiBaoHiem.Text = "";
                btnThemBH.Text = "Đóng";
                btnThemBH.Image = Image.FromFile("./../../Icons/Dong.PNG");
            }
            else
            {
                btnLuuBH.Enabled = false;
                btnXoaBH.Enabled = true;
                btnThemBH.Image = Image.FromFile("./../../Icons/Them.PNG");
                //btnSuaBH.Enabled = true;
                btnThemBH.Text = "Thêm";
                // chọn 1 dòng
                dtgBaoHiem.Rows[0].Selected = true;
                txtMaNhanVien.Text = dtgBaoHiem.Rows[0].Cells[0].Value.ToString();
                cbLoaiBaoHiem.Text = dtgBaoHiem.Rows[0].Cells[2].Value.ToString();
                txtSoThe.Text = dtgBaoHiem.Rows[0].Cells[3].Value.ToString();
                dtpNgayCap.Text = dtgBaoHiem.Rows[0].Cells[4].Value.ToString();
                dtpNgayHetHan.Text = dtgBaoHiem.Rows[0].Cells[5].Value.ToString();
                txtNoiCap.Text = dtgBaoHiem.Rows[0].Cells[6].Value.ToString();
            }
        }

        private void btnLuuBH_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            if(db.ktKhoaChinh_BaoHiem(int.Parse(txtMaNhanVien.Text), cbLoaiBaoHiem.Text))
            {
                db.themBaoHiem(int.Parse(txtMaNhanVien.Text), cbLoaiBaoHiem.Text, txtSoThe.Text, DateTime.Parse(dtpNgayCap.Text), DateTime.Parse(dtpNgayHetHan.Text), txtNoiCap.Text);
                MessageBox.Show("Thêm bảo hiểm thành công");
                load_dtgBaoHiem();
            }
            else
            {
                MessageBox.Show("Nhân viên đã có bảo hiểm loại này");
            }
        }

        private void btnXoaBH_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn bảo hiểm cần xóa !");
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                int maNV = int.Parse(txtMaNhanVien.Text);
                String loai = cbLoaiBaoHiem.Text;
                db.xoaBaoHiem(maNV, loai);
                MessageBox.Show("Xóa bảo hiểm thành công");
                load_dtgBaoHiem();
            }

            

        }

        private void btnSuaBH_Click(object sender, EventArgs e)
        {

            db.capnhatBaoHiem(int.Parse(txtMaNhanVien.Text), cbLoaiBaoHiem.Text, txtSoThe.Text, DateTime.Parse(dtpNgayCap.Text), DateTime.Parse(dtpNgayHetHan.Text), txtNoiCap.Text);
            MessageBox.Show("Cập nhật bảo hiểm thành công");
            load_dtgBaoHiem();
        }

        private void DataBinding()
        {
            txtMaNhanVien.Text = dtgBaoHiem.CurrentRow.Cells[0].Value.ToString();
            cbLoaiBaoHiem.Text = dtgBaoHiem.CurrentRow.Cells[2].Value.ToString();
            txtSoThe.Text = dtgBaoHiem.CurrentRow.Cells[3].Value.ToString();
            dtpNgayCap.Text = dtgBaoHiem.CurrentRow.Cells[4].Value.ToString();
            dtpNgayHetHan.Text = dtgBaoHiem.CurrentRow.Cells[5].Value.ToString();
            txtNoiCap.Text = dtgBaoHiem.CurrentRow.Cells[6].Value.ToString();
        }
        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btnThemBH.Text.Equals("Đóng"))
            {
                txtMaNhanVien.Text = dtgNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
           
        }

        private void dtgBaoHiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btnThemBH.Text.Equals("Đóng"))
            {
                DataBinding();
            }
           
        }
    }
}
