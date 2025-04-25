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
    public partial class frmTrangChu : MetroFramework.Forms.MetroForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
            cbSapXep.Items.Add("GIÁ THẤP ĐẾN CAO");
            cbSapXep.Items.Add("GIÁ CAO ĐẾN THẤP");
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            var gioHangForm = new frmGioHang();
            gioHangForm.Show();
            this.Hide();
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Giả sử bạn có một danh sách các sản phẩm
            //List<Product> products = GetProducts(); // Hàm này sẽ trả về danh sách sản phẩm

            // Kiểm tra lựa chọn của người dùng trong ComboBox
            if (cbSapXep.SelectedIndex == 0) // Giá thấp đến cao
            {
                // Sắp xếp theo giá tăng dần
                //products = products.OrderBy(p => p.Price).ToList();
            }
            else if (cbSapXep.SelectedIndex == 1) // Giá cao đến thấp
            {
                // Sắp xếp theo giá giảm dần
                //products = products.OrderByDescending(p => p.Price).ToList();
            }

            // Cập nhật danh sách sản phẩm trên giao diện (ví dụ sử dụng DataGridView)
            //dataGridView.DataSource = products;
        }
    }
}
