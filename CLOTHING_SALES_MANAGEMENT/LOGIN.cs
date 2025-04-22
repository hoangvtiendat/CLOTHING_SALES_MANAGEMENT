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
    public partial class btnLogin: MetroFramework.Forms.MetroForm
    {
        public btnLogin()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="tu" && txtPassword.Text == "123")
            {
                frm_Salestaff_Page f = new frm_Salestaff_Page();
                this.Hide();
                f.Show();
            }
            else
            {
                
                txtPassword.Clear();
            }
            



        }
    }
}
