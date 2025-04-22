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
    public partial class frm_thanhtoan : Form
    {
        public frm_thanhtoan()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frm_HoaDon n =new frm_HoaDon();
            this.Close();
            n.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Salestaff_Page n=new frm_Salestaff_Page();
            n.Show();
        }
    }
}
