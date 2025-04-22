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
    public partial class frm_Salestaff_Page : Form
    {
        public frm_Salestaff_Page()
        {
            InitializeComponent();
        }
        private void frm_Salestaff_Page_Load(object sender, EventArgs e)
        {
            uC_ALL1.Visible = false;
            uC_SHIRT1.Visible = false;
            uC_Pan1.Visible = false;
            uC_Jackets1.Visible = false;
            uC_Vest1.Visible = false;
            btnall.PerformClick();
        }


        private void btnall_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnall.Left + 50;
            uC_ALL1.Visible = true;
            uC_ALL1.BringToFront();
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void btnShirt_Click(object sender, EventArgs e)
        {
            PanelMoving.Left=btnShirt.Left + 60;
            uC_SHIRT1.Visible = true;
            uC_SHIRT1.BringToFront();
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            PanelMoving.Left=btnPan.Left + 50;
            uC_Pan1.Visible = true;
            uC_Pan1.BringToFront();
        }

        private void btnShirtKhoac_Click(object sender, EventArgs e)
        {
            PanelMoving.Left=btnShirtKhoac.Left + 30;
            uC_Jackets1.Visible = true;
            uC_Jackets1.BringToFront();
        }

        private void btnvest_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnvest.Left + 50;
            uC_Vest1.Visible = true;
            uC_Vest1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm_cart n=new frm_cart();
            this.Close();
            n.Show();

        }
    }
}
