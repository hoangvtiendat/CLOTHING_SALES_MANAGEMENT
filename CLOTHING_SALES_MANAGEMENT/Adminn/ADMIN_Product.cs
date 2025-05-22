using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmAdminProduct : MetroFramework.Forms.MetroForm
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();
        public frmAdminProduct()
        {
            InitializeComponent();
            loadCB();
            loadData();
        }
        private byte[] selectedImageBytes = null;
        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ptImage.Image = Image.FromFile(filePath);
                ptImage.SizeMode = PictureBoxSizeMode.StretchImage;

                selectedImageBytes = File.ReadAllBytes(filePath);

            }
        }
        public void reset()
        {
            txtGia.Text = "";
            txtSoLuong.Text = "";
            txtTenSP.Text = "";
            ptImage.Image = null;
            if (cbDanhMuc.Items.Count > 0)
            {
                cbDanhMuc.SelectedIndex = 0;
            }
            txtTimKiem.Text = "";
            lblMaSanPham.Text = "";
        }

        public void loadData()
        {
            string query = "select * from PRODUCT p inner join CATALOG c on c.CATALOG_ID = p.CATALOG_ID";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
        }


        public void loadCB()
        {
            string query = "select * from CATALOG";
            var list = sqlServerConnection.ExecuteQuery(query);
            cbDanhMuc.DataSource = list;
            cbDanhMuc.ValueMember = "CATALOG_ID";
            cbDanhMuc.DisplayMember = "CATALOG_NAME";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" || txtGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐỦ THÔNG TIN SẢN PHẨM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenSP = txtTenSP.Text;
            double gia = double.Parse(txtGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            string danhmuc = cbDanhMuc.SelectedValue.ToString();
            string checkProduct = $"select COUNT(*) from PRODUCT where PRODUCT_NAME = '{tenSP}'";
            var checkProductCommand = sqlServerConnection.ExecuteScalar(checkProduct);
            if (checkProductCommand != null && Convert.ToInt32(checkProductCommand) > 0)
            {
                MessageBox.Show("SẢN PHẨM ĐÃ TỒN TẠI", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string imageHex = selectedImageBytes != null ? "0x" + BitConverter.ToString(selectedImageBytes).Replace("-", "") : "NULL";

            string insertQuery = $"INSERT INTO PRODUCT (PRODUCT_NAME, PRODUCT_PRICE, PRODUCT_QUANTITY, PRODUCT_IMAGE, CATALOG_ID) values ('{tenSP}', {gia}, {soLuong}, {imageHex}, '{danhmuc}' )";

            int rowsAffected = sqlServerConnection.ExecuteNonQuery(insertQuery);

            if (rowsAffected > 0)
            {
                MessageBox.Show("THÊM SẢN PHẨM THÀNH CÔNG");
                // Có thể reset các textbox ở đây
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ THÊM SẢN PHẨM");
            }

            reset();
            loadData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                lblMaSanPham.Text = row.Cells["PRODUCT_ID"].Value.ToString();
                txtTenSP.Text = row.Cells["PRODUCT_NAME"].Value.ToString();
                txtGia.Text = row.Cells["PRODUCT_PRICE"].Value.ToString();
                txtSoLuong.Text = row.Cells["PRODUCT_QUANTITY"].Value.ToString();
                cbDanhMuc.SelectedValue = row.Cells["CATALOG_ID"].Value.ToString();



                object imageValue = row.Cells["PRODUCT_IMAGE"].Value;
                if (imageValue != null && imageValue != DBNull.Value)
                {
                    if (imageValue is Image img)
                    {
                        ptImage.Image = img; // Nếu đã có sẵn Image, chỉ cần gán vào PictureBox
                        ptImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else if (imageValue is byte[] imgBytes && imgBytes.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                ptImage.Image = Image.FromStream(ms);
                                ptImage.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR UPLOAD  IMAGE: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ptImage.Image = null;
                        }
                    }
                    else
                    {
                        ptImage.Image = null;
                    }
                }
                else
                {
                    ptImage.Image = null; // Nếu không có ảnh thì đặt lại là null
                }


            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lblMaSanPham.Text == "")
            {
                MessageBox.Show("VUI LÒNG CHỌN SẢN PHẨM ĐỂ CẬP NHẬT");
                return;
            }

            if (txtTenSP.Text == "" || txtGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐỦ THÔNG TIN SẢN PHẨM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenSP = txtTenSP.Text;
            double gia = double.Parse(txtGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            string danhmuc = cbDanhMuc.SelectedValue.ToString();
            // string imageHex = selectedImageBytes != null ? "0x" + BitConverter.ToString(selectedImageBytes).Replace("-", "") : "NULL";
            string imageHex;

            // Kiểm tra xem người dùng có chọn ảnh mới hay không
            if (selectedImageBytes != null)
            {
                // Nếu có ảnh mới, chuyển đổi thành hex
                imageHex = "0x" + BitConverter.ToString(selectedImageBytes).Replace("-", "");
            }
            else
            {
                // Nếu không có ảnh mới, lấy giá trị ảnh cũ từ DataGridView
                DataGridViewRow selectedRow = dataGridView1.Rows.Cast<DataGridViewRow>().FirstOrDefault(row => row.Cells["PRODUCT_ID"].Value.ToString() == lblMaSanPham.Text);
                if (selectedRow != null && selectedRow.Cells["PRODUCT_IMAGE"].Value != null && selectedRow.Cells["PRODUCT_IMAGE"].Value != DBNull.Value)
                {
                    if (selectedRow.Cells["PRODUCT_IMAGE"].Value is byte[] existingImageBytes && existingImageBytes.Length > 0)
                    {
                        imageHex = "0x" + BitConverter.ToString(existingImageBytes).Replace("-", "");
                    }
                    else
                    {
                        imageHex = "NULL"; // Hoặc bạn có thể để trống nếu cột cho phép NULL
                    }
                }
                else
                {
                    imageHex = "NULL"; // Trường hợp không tìm thấy sản phẩm hoặc không có ảnh cũ
                }
            }

            string query = $@"UPDATE PRODUCT SET PRODUCT_NAME = '{tenSP}', PRODUCT_PRICE = {gia}, PRODUCT_QUANTITY = {soLuong}, PRODUCT_IMAGE = {imageHex},CATALOG_ID = '{danhmuc}' where PRODUCT_ID = {lblMaSanPham.Text}";
            int rowsAffected = sqlServerConnection.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("CẬP NHẬT SẢN PHẨM THÀNH CÔNG");
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ admin CẬP NHẬT SẢN PHẨM");
            }
            reset();
            loadData();



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lblMaSanPham.Text == "")
            {
                MessageBox.Show("VUI LÒNG CHỌN SẢN PHẨM ĐỂ XÓA");
                return;
            }

            string query = $"DELETE FROM PRODUCT WHERE PRODUCT_ID = {lblMaSanPham.Text}";
            int rowsAffected = sqlServerConnection.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("XÓA SẢN PHẨM THÀNH CÔNG");
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ XÓA SẢN PHẨM");
            }
            reset();
            loadData();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP TÊN SẢN PHẨM CẦN TÌM KIẾM");
                return;
            }
            string query = $"select * from PRODUCT p inner join CATALOG c on c.CATALOG_ID = p.CATALOG_ID where PRODUCT_NAME like '%{txtTimKiem.Text}%'";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            if (list.Rows.Count == 0)
            {
                MessageBox.Show("KHÔNG TÌM THẤY SẢN PHẨM NÀO");
                loadData();
            }

        }

        private void rdTang_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select * from PRODUCT p inner join CATALOG c on c.CATALOG_ID = p.CATALOG_ID order by PRODUCT_PRICE asc";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;

        }

        private void rdGiam_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select * from PRODUCT p inner join CATALOG c on c.CATALOG_ID = p.CATALOG_ID order by PRODUCT_PRICE desc";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
