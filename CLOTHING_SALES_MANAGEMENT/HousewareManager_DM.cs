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
            LoadCards();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelThemDanhMuc.Visible = true;
            txtTenDanhMuc.Text = ""; 
            txtTenDanhMuc.Focus();   
        }
        private void btnLuu_Click(object sender, EventArgs e)
        { }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            panelThemDanhMuc.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã cập nhật danh mục: " + txtSuaDanhMuc.Text);
            panelEditDanhMuc.Visible = false;
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Đã xóa danh mục.");
                panelEditDanhMuc.Visible = false;
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            panelEditDanhMuc.Visible = false;
        }
        private void btnEditDanhMuc_Click(object sender, EventArgs e)
        {
            txtSuaDanhMuc.Text = txtDanhMuc.Text;
            panelEditDanhMuc.Visible = true;
        }
        private void LoadCards()
        {
            panelCards.Controls.Clear();
            for (int i = 0; i < 4; i++) // sau này replace bằng danh sách sản phẩm
            {
                Panel card = new Panel();
                card.Size = new Size(200, 250);
                card.BackColor = Color.White;
                //card.BorderStyle = BorderStyle.FixedSingle;
                card.Location = new Point(20 + (i % 4) * 220, 10 + (i / 4) * 270);

                PictureBox pic = new PictureBox();
                pic.Size = new Size(180, 120);
                pic.Location = new Point(10, 10);
                pic.BackColor = Color.LightGray;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                card.Controls.Add(pic);

                Label lblTen = new Label()
                {
                    Text = "Sản phẩm " + (i + 1),
                    Location = new Point(10, 135),
                    AutoSize = true
                };
                card.Controls.Add(lblTen);

                Label lblGia = new Label()
                {
                    Text = "Giá: 100.000₫",
                    Location = new Point(10, 160),
                    AutoSize = true
                };
                card.Controls.Add(lblGia);

                Label lblSL = new Label()
                {
                    Text = "SL: 10",
                    Location = new Point(10, 185),
                    AutoSize = true
                };
                card.Controls.Add(lblSL);

                Button btnSua = new Button()
                {
                    Text = "Sửa",
                    Size = new Size(60, 25),
                    Location = new Point(10, 210)
                };
                btnSua.Click += (s, e) => { MessageBox.Show("Sửa sản phẩm " + (i + 1)); };
                card.Controls.Add(btnSua);

                Button btnXoa = new Button()
                {
                    Text = "Xóa",
                    Size = new Size(60, 25),
                    Location = new Point(80, 210)
                };
                btnXoa.Click += (s, e) => { MessageBox.Show("Xóa sản phẩm " + (i + 1)); };
                card.Controls.Add(btnXoa);

                panelCards.Controls.Add(card);
            }
        }
    }
}
