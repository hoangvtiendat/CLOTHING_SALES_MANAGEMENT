using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmGioHang : MetroFramework.Forms.MetroForm
    {
        public frmGioHang()
        {
            InitializeComponent();
            //this.AutoSize = false;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //this.Size = new Size(600, 300); 
            //this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void btnTroVe_Click(object sender, EventArgs e)
        {
            var trangChuForm = new frmTrangChu();
            trangChuForm.Show();
            this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var hoaDonForm = new frmHoaDon();
            hoaDonForm.Show();
            this.Hide();
        }
    }
}
