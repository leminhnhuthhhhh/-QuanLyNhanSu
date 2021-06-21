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
    public partial class frmBaoCaoNhanVien : Form
    {
        DB_BUS db = new DB_BUS();
        public frmBaoCaoNhanVien()
        {
            InitializeComponent();
        }

        private void frmBaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            tblNHANVIENBindingSource.DataSource = db.layDSNhanVien();
            this.reportViewer1.RefreshReport();
        }
    }
}
