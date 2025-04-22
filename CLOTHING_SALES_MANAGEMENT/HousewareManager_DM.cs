using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class HousewareManager_DM : MetroForm
    {
        public HousewareManager_DM()
        {
            InitializeComponent();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelThemDanhMuc.Visible = true;
            txtTenDanhMuc.Text = ""; // Reset lại textbox khi mở panel
            txtTenDanhMuc.Focus();   // Đặt con trỏ vào ô nhập
        }
        private void btnLuu_Click(object sender, EventArgs e)
        { }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            panelThemDanhMuc.Visible = false;
        }

        
    }
}
