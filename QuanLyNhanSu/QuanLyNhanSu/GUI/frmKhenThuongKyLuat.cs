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
    public partial class frmKhenThuongKyLuat : Form
    {
        DB_BUS db = new DB_BUS();
        public frmKhenThuongKyLuat()
        {
            InitializeComponent();
            load_dtgKTKL();
            load_cbLoai();
            load_cbTrinhTrang();
            load_cbNV();
            txtmaKTKL.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Image = Image.FromFile("./../../Icons/Them.PNG");
            btnLuu.Image = Image.FromFile("./../../Icons/Luu.PNG");
            btnXoa.Image = Image.FromFile("./../../Icons/Xoa.PNG");
            btnSua.Image = Image.FromFile("./../../Icons/Sua.PNG");
        }
        private void load_dtgKTKL()
        {
            var ds = db.layDSKTKL();
            dtgKTKL.DataSource = ds;
        }
        private void load_cbLoai()
        {
            List<String> lst = new List<string>() { "Khen Thưởng", "Kỷ Luật" };
            cbLoai.DataSource = lst;
        }
        private void load_cbNV()
        {
            var ds = db.layDSMaNV();
            cbMaNV.DataSource = ds;
            cbMaNV.DisplayMember = "MaNhanVien";
        }
        private void load_cbTrinhTrang()
        {
            List<String> lst = new List<string>() { "Đã Thanh Toán", "Chưa Thanh Toán" };
            cbTrinhTrang.DataSource = lst;
        }

        private void frmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {

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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.ToString().Trim().Equals("Thêm"))
            {
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtmaKTKL.Text = "AUTO";
                cbMaNV.Text = cbLoai.Text = txtLyDo.Text = txtTien.Text = cbTrinhTrang.Text = "";
                btnThem.Image = Image.FromFile("./../../Icons/Dong.PNG");
                btnThem.Text = "Đóng";
            }
            else
            {
                btnThem.Image = Image.FromFile("./../../Icons/Them.PNG");
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Text = "Thêm";
                // chọn 1 dòng
                dtgKTKL.Rows[0].Selected = true;
                txtmaKTKL.Text = dtgKTKL.Rows[0].Cells[0].Value.ToString();
                cbMaNV.Text = dtgKTKL.Rows[0].Cells[1].Value.ToString();
                dtpNgayLap.Text = dtgKTKL.Rows[0].Cells[3].Value.ToString();
                cbLoai.Text = dtgKTKL.Rows[0].Cells[4].Value.ToString();
                txtLyDo.Text = dtgKTKL.Rows[0].Cells[5].Value.ToString();
                txtTien.Text = dtgKTKL.Rows[0].Cells[6].Value.ToString();
                cbTrinhTrang.Text = dtgKTKL.Rows[0].Cells[7].Value.ToString();
            }
        }
        private bool kiemTraDuLieu()
        {
            if (cbMaNV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên !");
                return false;
            }
            if (cbLoai.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn loại KTKL !");
                return false;
            }
            if (txtLyDo.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập lý do !");
                txtLyDo.Focus();
                return false;
            }
            if (txtTien.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số tiền !");
                txtTien.Focus();
                return false;
            }
            if (!IsNumber(txtTien.Text))
            {
                MessageBox.Show("Vui lòng nhập số !");
                txtTien.Focus();
                return false;
            }
            if (cbTrinhTrang.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng tình trạng !");
                return false;
            }

            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            db.themKTKL(int.Parse(cbMaNV.Text), DateTime.Parse(dtpNgayLap.Text), cbLoai.Text, txtLyDo.Text, Decimal.Parse(txtTien.Text), cbTrinhTrang.Text);
            MessageBox.Show("Thêm khen thưởng/ kỷ luật thành công");
            load_dtgKTKL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmaKTKL.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa !");
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa không?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                int ma = int.Parse(txtmaKTKL.Text);
                db.xoaKTKL(ma);
                MessageBox.Show("Xóa khen thưởng/ kỷ luật thành công");
                load_dtgKTKL();
            }
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtmaKTKL.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa !");
                return;
            }
            if (!kiemTraDuLieu())
                return;
            db.capnhatKTKL(int.Parse(txtmaKTKL.Text), int.Parse(cbMaNV.Text), DateTime.Parse(dtpNgayLap.Text), cbLoai.Text, txtLyDo.Text, Decimal.Parse(txtTien.Text), cbTrinhTrang.Text);
            MessageBox.Show("Cập nhật khen thưởng/ kỷ luật thành công");
            load_dtgKTKL();
        }
        private void DataBinding()
        {
            txtmaKTKL.Text = dtgKTKL.CurrentRow.Cells[0].Value.ToString();
            cbMaNV.Text = dtgKTKL.CurrentRow.Cells[1].Value.ToString();
            dtpNgayLap.Text = dtgKTKL.CurrentRow.Cells[3].Value.ToString();
            cbLoai.Text = dtgKTKL.CurrentRow.Cells[4].Value.ToString();
            txtLyDo.Text = dtgKTKL.CurrentRow.Cells[5].Value.ToString();
            txtTien.Text = dtgKTKL.CurrentRow.Cells[6].Value.ToString();
            cbTrinhTrang.Text = dtgKTKL.CurrentRow.Cells[7].Value.ToString();
        }
        private void dtgKTKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!btnThem.Text.Equals("Đóng"))
            {
                DataBinding();
            }
        
        }

        private void btnTraNV_Click(object sender, EventArgs e)
        {

        }
    }
}
