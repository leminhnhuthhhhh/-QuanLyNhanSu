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
    public partial class frmPhongBan : Form
    {
        DB_BUS db = new DB_BUS();
        public frmPhongBan()
        {
            InitializeComponent();
            loadPhongBan();
            txtMaPhong.Enabled = false;
            btnLuuPb.Enabled = false;
            btnThemPB.Image = Image.FromFile("./../../Icons/Them.PNG");
            btnLuuPb.Image = Image.FromFile("./../../Icons/Luu.PNG");
            btnXoaPb.Image = Image.FromFile("./../../Icons/Xoa.PNG");
            btnSuaPB.Image = Image.FromFile("./../../Icons/Sua.PNG");
        }
        private void DataBinding()
        {
            txtMaPhong.Text = dtgPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dtgPhongBan.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dtgPhongBan.CurrentRow.Cells[2].Value.ToString();
        }
        private bool kiemTraDuLieu()
        {
            if (txtTenPhong.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên phòng !");
                txtTenPhong.Focus();
                return false;
            }
            if (txtGhiChu.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập ghi chú !");
                txtGhiChu.Focus();
                return false;
            }
            return true;
        }
        private void loadPhongBan()
        {
            List<tblPHONGBAN> dsPB = db.layDSPhongBan();
            dtgPhongBan.DataSource = dsPB;
            //if(dsPB.Count() > 0)
            //{
            //    dtgPhongBan.Rows[0].Selected = true;
            //    txtMaPhong.Text = dtgPhongBan.Rows[0].Cells[0].Value.ToString();
            //    txtTenPhong.Text = dtgPhongBan.Rows[0].Cells[1].Value.ToString();
            //    txtGhiChu.Text = dtgPhongBan.Rows[0].Cells[2].Value.ToString();
            //}
        }

        private void btnLuuPb_Click(object sender, EventArgs e)
        {

            // kiểm tra dữ liệu
            if (!kiemTraDuLieu())
                return;
            // kiểm tra khóa chính + ngoại

            db.themPhongBan(txtTenPhong.Text, txtGhiChu.Text);
            MessageBox.Show("Thêm phòng ban thành công");
            loadPhongBan();
        }

        private void btnXoaPb_Click(object sender, EventArgs e)
        {
            // kt dl

            if (txtMaPhong.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa !");
                return;
            }
            if (db.ktKhoaNgoai_PhongBan(int.Parse(txtMaPhong.Text)))
            {
                if (MessageBox.Show("Bạn muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    int ma = int.Parse(txtMaPhong.Text);
                    db.xoaPhongBan(ma);
                    MessageBox.Show("Xóa phòng ban thành công");
                    loadPhongBan();
                }

            }
            else
                MessageBox.Show("Xóa phòng ban thất bại");

        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa !");
                return;
            }
            if (!kiemTraDuLieu())
                return;

            db.capnhatPhongBan(int.Parse(txtMaPhong.Text), txtTenPhong.Text, txtGhiChu.Text);
            MessageBox.Show("Cập nhật phòng ban thành công");
            loadPhongBan();
        }

        private void dtgPhongBan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!btnThemPB.Text.Equals("Đóng"))
            {
                DataBinding();
            }

        }

        private void btnThemPB_Click(object sender, EventArgs e)
        {
            if (btnThemPB.Text.ToString().Trim().Equals("Thêm"))
            {
                btnLuuPb.Enabled = true;
                btnXoaPb.Enabled = false;
                btnSuaPB.Enabled = false;
                txtMaPhong.Text = "AUTO";
                txtTenPhong.Text = txtGhiChu.Text = "";
                btnThemPB.Text = "Đóng";
            }
            else
            {
                btnLuuPb.Enabled = false;
                btnXoaPb.Enabled = true;
                btnSuaPB.Enabled = true;
                btnThemPB.Text = "Thêm";
                // chọn 1 dòng
                dtgPhongBan.Rows[0].Selected = true;
                txtMaPhong.Text = dtgPhongBan.Rows[0].Cells[0].Value.ToString();
                txtTenPhong.Text = dtgPhongBan.Rows[0].Cells[1].Value.ToString();
                txtGhiChu.Text = dtgPhongBan.Rows[0].Cells[2].Value.ToString();
            }


        }

        private void txtTenPhong_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
