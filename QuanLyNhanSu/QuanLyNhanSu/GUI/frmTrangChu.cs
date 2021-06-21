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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("./../../Icons/background.jfif");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label1.BackColor = System.Drawing.Color.Transparent;
           
            label1.ForeColor = System.Drawing.Color.White;
          
        }
    }
}
