using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyNhanSu.GUI;
using QuanLyNhanSu.BUS;
using QuanLyNhanSu.DAL;
namespace QuanLyNhanSu
{
    public partial class Main : Form
    {
        DB_BUS db = new DB_BUS();
        private IconButton currentBtn, FatherBtn;
        private Panel leftBorderBtn;
        private Form currentForm = null;
        public Main()
        {
            InitializeComponent();

            FatherBtn = null;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            pnlSlideMenu.Controls.Add(leftBorderBtn);
            timer1.Interval = 1000;
            timer1.Start();
            Tat_Panels();

            dangnhap();
        }
        public void dangnhap()
        {
            if (QuanLyNhanSu.GUI.frmDangNhap.LuuThongTin.ma > 0)
            {
                lblTenNV.Text = QuanLyNhanSu.GUI.frmDangNhap.LuuThongTin.taikhoan.ToString();
                tblNHANVIEN nv = db.timNVTheoMa(QuanLyNhanSu.GUI.frmDangNhap.LuuThongTin.ma);
                pictureBox1.Image = Image.FromFile(".\\..\\..\\Images\\img5.jfif");
            }
        }
       
        private void timer_day()
        {
            lblNgayHienTai.Text = "Ngày hôm nay: " + DateTime.Now.ToString();
        }

        private void Tat_Panels()
        {
            pnlQuanLySub.Visible = false;
            pnlChucNangSub.Visible = false;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableAllSub();
                DisableButton();
                if (FatherBtn != null)
                    DisableButton_ID(FatherBtn);
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
            // fix lỗi menu
            if (pnlQuanLySub.Visible == true || pnlChucNangSub.Visible == true)
            {
                An_Panels();
                ActivateButton(senderBtn, color);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void DisableButton_ID(IconButton btn)
        {
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(31, 30, 68);
                btn.ForeColor = Color.Gainsboro;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.IconColor = Color.Gainsboro;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ActivateButtonSub(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtonSub();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.IconSize = 15;
                currentBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
                currentBtn.IconColor = color;
                currentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
             
            }
        }
        private void DisableButtonSub()
        {
            if (currentBtn.Tag != null)
            {
                //MessageBox.Show("co vo day");
                FatherBtn = currentBtn;
                return;
            }
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconChar = FontAwesome.Sharp.IconChar.None;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void DisableButtonSub_ID(IconButton icon)
        {
            if (icon != null)
            {
                icon.ForeColor = Color.Gainsboro;
                icon.TextAlign = ContentAlignment.MiddleLeft;
                icon.IconChar = FontAwesome.Sharp.IconChar.None;
                icon.TextImageRelation = TextImageRelation.TextBeforeImage;
                icon.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void DisableAllSub()
        {
            DisableButtonSub_ID(btnBaoCao);
            DisableButtonSub_ID(btnChamCong);
            DisableButtonSub_ID(btnBangLuong);
            DisableButtonSub_ID(btnPhongBan);
            DisableButtonSub_ID(btnChucVu);
            DisableButtonSub_ID(btnHopDong);
            DisableButtonSub_ID(btnNhanVien);
            DisableButtonSub_ID(btnBaoHiem);
            DisableButtonSub_ID(btnKhenThuongKyLuat);
            DisableButtonSub_ID(btnTaiKhoan);
            DisableButtonSub_ID(btnChiTiet);
        }
       
        private void An_Panels()
        {
            if (pnlQuanLySub.Visible == true)
                pnlQuanLySub.Visible = false;
            if (pnlChucNangSub.Visible == true)
                pnlChucNangSub.Visible = false;
        }
        private void HienThi_Panel(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                An_Panels();
                pnl.Visible = true;
            }
            else
                pnl.Visible = false;
        }

        private void moForm(Form frmChange)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = frmChange;
            frmChange.TopLevel = false;
            frmChange.FormBorderStyle = FormBorderStyle.None;
            frmChange.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(frmChange);
            pnlContent.Tag = frmChange;
            frmChange.BringToFront();
            frmChange.Show();
        }


        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            An_Panels();
            ActivateButton(sender, RGBColors.color2);
            HienThi_Panel(pnlQuanLySub);
            lblTitle.Text = "QUẢN LÝ";
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            // code
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmPhongBan());
            lblTitle.Text = "PHÒNG BAN";
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            An_Panels();
            ActivateButton(sender, RGBColors.color1);
            moForm(new frmTrangChu());
            lblTitle.Text = "TRANG CHỦ";
            
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            An_Panels();
            ActivateButton(sender, RGBColors.color6);
            moForm(new frmHoTro());
            lblTitle.Text = "HỖ TRỢ";
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            An_Panels();
            ActivateButton(sender, RGBColors.color4);
            HienThi_Panel(pnlChucNangSub);
            lblTitle.Text = "CHỨC NĂNG";
        }
        // mở form khi click
        
        

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmChucVu());
            lblTitle.Text = "CHỨC VỤ";
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmHopDong());
            lblTitle.Text = "HỢP ĐỒNG";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmNhanVien());
            lblTitle.Text = "NHÂN VIÊN";
        }

        private void btnBaoHiem_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmBaoHiem());
            lblTitle.Text = "BẢO HIỂM";
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmTaiKhoan());
            lblTitle.Text = "TÀI KHOẢN";
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmChamCong());
            lblTitle.Text = "CHẤM CÔNG";
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmBangLuong());
            lblTitle.Text = "BẢNG LƯƠNG";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmBaoCaoNhanVien());
            lblTitle.Text = "BÁO CÁO";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_day();
        }

        private void btnKhenThuongKyLuat_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmKhenThuongKyLuat());
            lblTitle.Text = "KHEN THƯỞNG KỶ LUẬT";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnTrangChu_Click(btnTrangChu, e);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButtonSub(sender, RGBColors.color3);
            moForm(new frmChiTietChucVu());
            lblTitle.Text = "CHI TIẾT CHỨC VỤ";
        }
    }



}
