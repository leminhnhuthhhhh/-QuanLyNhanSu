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
    public partial class frmNhanVien : Form
    {
        DB_BUS db = new DB_BUS();
        public frmNhanVien()
        {
            InitializeComponent();
            load_cbHopDong();
            load_cbPhongBan();
            load_cbHocVan();
            load_cbGioiTinh();
            load_dtgNhanVien();
            txtMaNV.Enabled = false;
            btnLuu.Enabled = false;
            btnThemMoi.Image = Image.FromFile("./../../Icons/Them.PNG");
            btnLuu.Image = Image.FromFile("./../../Icons/Luu.PNG");
            btnXoa.Image = Image.FromFile("./../../Icons/Xoa.PNG");
            btnSua.Image = Image.FromFile("./../../Icons/Sua.PNG");
        }
        private void load_cbHopDong()
        {
            var ds = db.layCbHopDong();
            cbLoaiHopDong.DataSource = ds;
            cbLoaiHopDong.DisplayMember = "LoaiHopDong";
            cbLoaiHopDong.ValueMember = "MaHopDong";
        }
        private void load_cbHocVan()
        {
            List<String> lst = new List<String>(){ "Đại Học", "Cao Đẳng", "Thạc Sĩ", "Tiến Sĩ"};
            cbHocVan.DataSource = lst;
        }

        private void load_cbGioiTinh()
        {
            List<String> lst = new List<String>() { "Nam", "Nữ", "Khác" };
            cbGioiTinh.DataSource = lst;
        }
        private void load_cbPhongBan()
        {
            var ds = db.layDSPhongBan();
            cbPhongBan.DataSource = ds;
            cbPhongBan.DisplayMember = "TenPhong";
            cbPhongBan.ValueMember = "MaPhong";
        }
        private void load_dtgNhanVien()
        {
            var ds = db.layDSNhanVien();
            dtgNhanVien.DataSource = ds;
        }
        private void DataBinding()
        {
            txtMaNV.Text = dtgNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dtgNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dtgNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dtgNhanVien.CurrentRow.Cells[3].Value.ToString();
            cbGioiTinh.Text = dtgNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dtgNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dtgNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtCMND.Text = dtgNhanVien.CurrentRow.Cells[7].Value.ToString(); ;
            txtDanToc.Text = dtgNhanVien.CurrentRow.Cells[8].Value.ToString();
            cbHocVan.Text = dtgNhanVien.CurrentRow.Cells[9].Value.ToString();
            txtTTHN.Text = dtgNhanVien.CurrentRow.Cells[10].Value.ToString();
            dtpNgayVL.Text = dtgNhanVien.CurrentRow.Cells[11].Value.ToString();
            txtHeSoLuong.Text = dtgNhanVien.CurrentRow.Cells[12].Value.ToString();
            pictureBox1.Image = Image.FromFile(".\\..\\..\\Images\\" + dtgNhanVien.CurrentRow.Cells[13].Value.ToString().Trim());
            //pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + dtgNhanVien.CurrentRow.Cells[13].Value.ToString().Trim());
            lblLink.Text = dtgNhanVien.CurrentRow.Cells[13].Value.ToString();
            cbLoaiHopDong.Text = dtgNhanVien.CurrentRow.Cells[14].Value.ToString();
            cbPhongBan.Text = dtgNhanVien.CurrentRow.Cells[15].Value.ToString();
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!btnThemMoi.Text.Equals("Đóng"))
            {
                DataBinding();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (btnThemMoi.Text.ToString().Trim().Equals("Thêm"))
            {
                lblLink.Text = "";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtMaNV.Text = "AUTO";
                txtTenNV.Text = txtDiaChi.Text = cbGioiTinh.Text = txtSDT.Text = txtEmail.Text = txtCMND.Text = txtDanToc.Text = cbHocVan.Text = txtTTHN.Text = txtHeSoLuong.Text = cbLoaiHopDong.Text = cbPhongBan.Text = "";
                pictureBox1.Image = null;
                btnThemMoi.Image = Image.FromFile("./../../Icons/Dong.PNG");
                btnThemMoi.Text = "Đóng";
            }
            else
            {
                btnThemMoi.Image = Image.FromFile("./../../Icons/Them.PNG");
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThemMoi.Text = "Thêm";
                // chọn 1 dòng
                dtgNhanVien.Rows[0].Selected = true;
                txtMaNV.Text = dtgNhanVien.Rows[0].Cells[0].Value.ToString();
                txtTenNV.Text = dtgNhanVien.Rows[0].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dtgNhanVien.Rows[0].Cells[2].Value.ToString();
                txtDiaChi.Text = dtgNhanVien.Rows[0].Cells[3].Value.ToString();
                cbGioiTinh.Text = dtgNhanVien.Rows[0].Cells[4].Value.ToString();
                txtSDT.Text = dtgNhanVien.Rows[0].Cells[5].Value.ToString();
                txtEmail.Text = dtgNhanVien.Rows[0].Cells[6].Value.ToString();
                txtCMND.Text = dtgNhanVien.Rows[0].Cells[7].Value.ToString();
                txtDanToc.Text = dtgNhanVien.Rows[0].Cells[8].Value.ToString();
                cbHocVan.Text = dtgNhanVien.Rows[0].Cells[9].Value.ToString();
                txtTTHN.Text = dtgNhanVien.Rows[0].Cells[10].Value.ToString();
                dtpNgayVL.Text = dtgNhanVien.Rows[0].Cells[11].Value.ToString();
                txtHeSoLuong.Text = dtgNhanVien.Rows[0].Cells[12].Value.ToString();
                pictureBox1.Image = Image.FromFile(".\\..\\..\\Images\\" + dtgNhanVien.CurrentRow.Cells[13].Value.ToString().Trim());
                lblLink.Text = dtgNhanVien.CurrentRow.Cells[13].Value.ToString();
                cbLoaiHopDong.Text = dtgNhanVien.Rows[0].Cells[14].Value.ToString();
                cbPhongBan.Text = dtgNhanVien.Rows[0].Cells[15].Value.ToString();
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
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private bool kiemTraDuLieu()
        {
            if (txtTenNV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên !");
                txtTenNV.Focus();
                return false;
            }
            if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ !");
                txtDiaChi.Focus();
                return false;
            }
            if (cbGioiTinh.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn giới tính !");
                return false;
            }
            if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại !");
                txtSDT.Focus();
                return false;
            }
            if (!IsNumber(txtSDT.Text.Trim().ToString()))
            {
                MessageBox.Show("Vui lòng nhập đúng dạng số điện thoại !");
                txtSDT.Focus();
                return false;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập email !");
                txtEmail.Focus();
                return false;
            }
            if (!isEmail(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email !");
                txtEmail.Focus();
                return false;
            }
            if (txtCMND.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số chứng minh !");
                txtCMND.Focus();
                return false;
            }
            if (!IsNumber(txtCMND.Text.Trim().ToString()))
            {
                MessageBox.Show("Vui lòng nhập số chứng minh đúng định dạng!");
                txtCMND.Focus();
                return false;
            }
            if (txtDanToc.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập dân tộc !");
                txtDanToc.Focus();
                return false;
            }
            if (cbHocVan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn học vấn !");
                return false;
            }
            if (txtTTHN.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập trình trạng hôn nhân !");
                txtTTHN.Focus();
                return false;
            }
            if (txtHeSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập hệ số lương !");
                txtHeSoLuong.Focus();
                return false;
            }
            if (!IsNumber(txtHeSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập hệ số lương là số!");
                txtHeSoLuong.Focus();
                return false;
            }
            if (cbLoaiHopDong.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn loại hợp đồng !");
                return false;
            }
            if (cbPhongBan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn phòng ban !");
                return false;
            }
            if(lblLink.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh !");
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieu())
                return;
            //int maPb = int.Parse(cbPhongBan.ValueMember.ToString());
            //int maHopDong = int.Parse(cbLoaiHopDong.ValueMember.ToString());


            db.themNhanVien(txtTenNV.Text, DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, cbGioiTinh.Text, txtSDT.Text,
                txtEmail.Text, txtCMND.Text, txtDanToc.Text, cbHocVan.Text, txtTTHN.Text, DateTime.Parse(dtpNgayVL.Text), 
                float.Parse(txtHeSoLuong.Text), lblLink.Text, int.Parse(cbLoaiHopDong.SelectedValue.ToString()), int.Parse(cbPhongBan.SelectedValue.ToString()));

            MessageBox.Show("Thêm nhân viên thành công");
            load_dtgNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            int ma = int.Parse(txtMaNV.Text);

            if(db.ktKhoaNgoai_NhanVien_TaiKhoan(ma) && db.ktKhoaNgoai_NhanVien_BaoHiem(ma) && db.ktKhoaNgoai_NhanVien_Luong(ma) && db.ktKhoaNgoai_NhanVien_CTCV(ma) && db.ktKhoaNgoai_NhanVien_KTKL(ma) && db.ktKhoaNgoai_NhanVien_ChamCong(ma))
            {
                if (MessageBox.Show("Bạn muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    db.xoaNhanVien(ma);
                    MessageBox.Show("Xóa nhân viên thành công");
                    load_dtgNhanVien();
                }
               
            }
            else
            {
                MessageBox.Show("Không thể xóa nhân viên này");
            }

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }
            if (!kiemTraDuLieu())
                return;
            db.capnhatNhanVien(int.Parse(txtMaNV.Text),txtTenNV.Text, DateTime.Parse(dtpNgaySinh.Text), txtDiaChi.Text, cbGioiTinh.Text, txtSDT.Text,
                txtEmail.Text, txtCMND.Text, txtDanToc.Text, cbHocVan.Text, txtTTHN.Text, DateTime.Parse(dtpNgayVL.Text),
                float.Parse(txtHeSoLuong.Text), lblLink.Text, int.Parse(cbLoaiHopDong.SelectedValue.ToString()), int.Parse(cbPhongBan.SelectedValue.ToString()));

            MessageBox.Show("Cập nhật nhân viên thành công");
            load_dtgNhanVien();
        }
        OpenFileDialog open;
        private void btnChooseAnh_Click(object sender, EventArgs e)
        {
            // chọn ảnh
            open = new OpenFileDialog();
            open.Filter = "|*.png;*.jpg;*.jpeg;*.jfif";
            if(open.ShowDialog() == DialogResult.OK)
            {
                //xu ly link anh
                string filename = "";

                string link = open.FileName;

                //// luu anh
                //SaveFileDialog sf = new SaveFileDialog();
                //sf.Filter = "|*.png;*.jpg;*.jpeg;*.jfif";
                //if(sf.ShowDialog() == DialogResult.OK)
                //{
                //    Image img = Image.FromFile(sf.FileName);
                //    img.Save(sf.FileName);
                //}


                string[] lstName = link.ToString().Split('\\');

                MessageBox.Show(lstName[lstName.Length - 1]);

                filename = lstName[lstName.Length - 1];

                lblLink.Text = filename;

                pictureBox1.Image = Image.FromFile(".\\..\\..\\Images\\" + lblLink.Text.ToString().Trim());
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            //if(txtSearch.Text == string.Empty)
            //{
            //    MessageBox.Show("Vui lòng nhập giá trị tìm kiếm");
            //    txtSearch.Focus();
            //    return;
            //}
            dtgNhanVien.DataSource = null;
            dtgNhanVien.Rows.Clear();
            dtgNhanVien.Refresh();
            var ds = db.timKiemTheoTen(txtSearch.Text);
            dtgNhanVien.DataSource = ds;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
