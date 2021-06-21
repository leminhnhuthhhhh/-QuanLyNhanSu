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
    public partial class frmChamCong : Form
    {
        DB_BUS db = new DB_BUS();
        public frmChamCong()
        {
            InitializeComponent();
            load_dtgChamCong();
            dtgThoiGian.Text = DateTime.Now.Date.ToString();
            dtpNgayCham.Enabled = false;
            btnChamCong.Image = Image.FromFile("./../../Icons/Luu.PNG");
            button1.Image = Image.FromFile("./../../Icons/Xoa.PNG");
        }
        private void load_dtgChamCong()
        {
            var ds = db.layDSCC();
            dtgChamCong.DataSource = ds;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if(db.ktKhoaChinh_ChamCong() == true)
            {

                if (chkTatCa.Checked == false)
                {
                    for (int i = 0; i < dtgChamCong.RowCount; i++)
                    {
                        if (dtgChamCong.Rows[i].Cells["TrinhTrang"].Value == null)
                        {
                            MessageBox.Show("Nhân viên " + dtgChamCong.Rows[i].Cells["MaNhanVien"].Value + "chưa chấm công !");
                            dtgChamCong.Rows[i].Cells["TrinhTrang"].Selected = true;
                            return;
                        }
                    }
                    for (int i = 0; i < dtgChamCong.RowCount; i++)
                    {
                        string tinhtrang = dtgChamCong.Rows[i].Cells["TrinhTrang"].Value.ToString();
                        string maNV = dtgChamCong.Rows[i].Cells["MaNhanVien"].Value.ToString();
                        db.themChamCong(int.Parse(maNV), tinhtrang);
                    }
                }
                else
                {
                    for (int i = 0; i < dtgChamCong.RowCount; i++)
                    {
                        string tinhtrang = "Đi Làm";
                        string maNV = dtgChamCong.Rows[i].Cells["MaNhanVien"].Value.ToString();
                        db.themChamCong(int.Parse(maNV), tinhtrang);
                    }

                }
                load_dtgChamCong();
                MessageBox.Show("Đã chấm công");
            }
            else
            {
                MessageBox.Show("Ngày hôm nay đã chấm công");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dtgChamCong == null)
            {
                MessageBox.Show("Có gì đâu xóa");
                return;
            }
            if(db.ktKhoaChinh_ChamCong() == false)
            {
                for (int i = 0; i < dtgChamCong.RowCount; i++)
                {
                    string maNV = dtgChamCong.Rows[i].Cells["MaNhanVien"].Value.ToString();
                    DateTime ngay = DateTime.Parse(dtgThoiGian.Text);
                    db.xoaChamCong(int.Parse(maNV), ngay);
                }
                MessageBox.Show("Đã xóa chấm công ngày " + dtgThoiGian.Text);
                dtgChamCong.Refresh();
                load_dtgChamCong();
            }
            else
            {
                MessageBox.Show("Hôm nay chưa chấm công");
            }
                
        }
        private void DataBinding()
        {
            try
            {
                lblMaNhanVien.Text = dtgChamCong.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                lblTenNhanVien.Text = dtgChamCong.CurrentRow.Cells["TenNhanVien"].Value.ToString();
                lblTinhTrang.Text = dtgChamCong.CurrentRow.Cells["TrinhTrang"].Value.ToString();
            }
            catch (Exception)
            {
            }

        }
        private void frmChamCong_Load(object sender, EventArgs e)
        {

        }

        private void dtgChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBinding();
        }
    }
}
