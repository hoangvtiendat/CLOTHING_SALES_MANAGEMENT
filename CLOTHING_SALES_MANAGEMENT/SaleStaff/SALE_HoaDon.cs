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
    public partial class frmSaleHoaDon : MetroFramework.Forms.MetroForm
    {
        public frmSaleHoaDon()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            var gioHangForm = new frmSaleGioHang();
            this.Hide();
            gioHangForm.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("THANH TOÁN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rs == DialogResult.OK)
            {
                this.Hide();
                var trangChuForm = new frmSaleTrangChu();
                trangChuForm.Show();
            }




        }
    }
}
