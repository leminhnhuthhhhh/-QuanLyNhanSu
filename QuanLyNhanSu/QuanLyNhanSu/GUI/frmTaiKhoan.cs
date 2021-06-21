using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("./../../Icons/rpuser.png");
            pictureBox2.Image = Image.FromFile("./../../Icons/adduser.png");
            pictureBox3.Image = Image.FromFile("./../../Icons/logout.png");
            pictureBox4.Image = Image.FromFile("./../../Icons/off.png");
            pictureBox1_Click(pictureBox1, EventArgs.Empty);
        }

        private Form current_TaiKhoan = null;
        private void moForm_TaiKhoan(Form frmChange)
        {
            if (current_TaiKhoan != null)
                current_TaiKhoan.Close();
            current_TaiKhoan = frmChange;
            frmChange.TopLevel = false;
            frmChange.FormBorderStyle = FormBorderStyle.None;
            frmChange.Dock = DockStyle.Fill;
            pnlContentUser.Controls.Add(frmChange);
            pnlContentUser.Tag = frmChange;
            frmChange.BringToFront();
            frmChange.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            moForm_TaiKhoan(new frmDoiMatKhau());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            moForm_TaiKhoan(new frmThemTaiKhoan());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // mo lai form login
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
