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
    public partial class frm_cart : Form
    {
        public frm_cart()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frm_Salestaff_Page f=new frm_Salestaff_Page();
            this.Close();
            f.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_thanhtoan n=new frm_thanhtoan();
            this.Close();
            n.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frm_Salestaff_Page n = new frm_Salestaff_Page();
            this.Close();
            n.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frm_Salestaff_Page n=new frm_Salestaff_Page();
            this.Close();
            n.Show();
        }
    }
}
