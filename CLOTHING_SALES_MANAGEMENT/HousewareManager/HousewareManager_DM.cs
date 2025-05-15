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
using System.Data.SqlClient;
using System.IO;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmHousewareManagerDM : MetroForm
    {
        private SqlServerConnection dbConnection;
        private bool isLoading = false;
        SqlServerConnection sqlServerConnection = new SqlServerConnection();
        public frmHousewareManagerDM()
        {
            InitializeComponent();

            dbConnection = new SqlServerConnection();
            LoadCategories(); // Load categories on form load
            comboDanhMuc.SelectedIndexChanged += comboDanhMuc_SelectedIndexChanged;
        }

        private void frmHousewareManagerDM_Load(object sender, EventArgs e)
        {
            LoadCategories(); // Đảm bảo load danh mục khi form tải
        }

        private void LoadCategories()
        {
            try
            {
                isLoading = true; // Đánh dấu bắt đầu load

                DataTable categories = dbConnection.ExecuteQuery("SELECT CATALOG_ID, CATALOG_NAME FROM CATALOG");

                comboDanhMuc.DataSource = categories;
                comboDanhMuc.DisplayMember = "CATALOG_NAME";
                comboDanhMuc.ValueMember = "CATALOG_ID";

                if (categories.Rows.Count > 0)
                {
                    comboDanhMuc.SelectedIndex = 0; // Chọn mặc định danh mục đầu tiên
                    int catalogId = (int)categories.Rows[0]["CATALOG_ID"];
                    LoadProductsByCatalog(catalogId); // Tải sản phẩm theo danh mục đầu tiên
                }
                else
                {
                    comboDanhMuc.DataSource = null;
                    comboDanhMuc.Items.Clear();
                    comboDanhMuc.Text = "Không có danh mục";
                    panelCards.Controls.Clear(); // Xóa sản phẩm nếu không có danh mục
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message);
            }
            finally
            {
                isLoading = false; // Kết thúc load
            }
        }

        private void comboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; // Bỏ qua nếu đang load

            // Kiểm tra nếu có sự kiện thay đổi và tránh trường hợp ComboBox không có dữ liệu
            if (comboDanhMuc.SelectedItem != null && comboDanhMuc.SelectedValue is int catalogId)
            {
                panelCards.Controls.Clear(); // Xóa hết sản phẩm trước khi load mới
                LoadProductsByCatalog(catalogId);
            }
        }

        private void LoadProductsByCatalog(int catalogId)
        {
            try
            {
                // Truy vấn để lấy sản phẩm theo CatalogID.
                string query = @"SELECT p.PRODUCT_ID, p.PRODUCT_NAME, p.PRODUCT_PRICE, p.PRODUCT_QUANTITY, p.PRODUCT_IMAGE
                             FROM PRODUCT p
                             WHERE p.CATALOG_ID = " + catalogId;

                DataTable products = dbConnection.ExecuteQuery(query);

                // Tạo và hiển thị card sản phẩm.
                if (products.Rows.Count > 0)
                {
                    panelCards.Controls.Clear(); // Xóa các sản phẩm cũ mỗi lần tải lại
                    for (int i = 0; i < products.Rows.Count; i++)
                    {
                        DataRow row = products.Rows[i];
                        Panel card = CreateProductCard(row);
                        card.Location = new Point(20 + (i % 4) * 220, 10 + (i / 4) * 120); // Sắp xếp theo lưới, điều chỉnh chiều cao phù hợp
                        panelCards.Controls.Add(card);
                    }
                }
                else
                {
                    Label noProductsLabel = new Label();
                    noProductsLabel.Text = "Không có sản phẩm trong danh mục này.";
                    noProductsLabel.AutoSize = true;
                    noProductsLabel.Location = new Point(20, 20);
                    panelCards.Controls.Add(noProductsLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải sản phẩm: " + ex.Message);
            }
        }

        private Panel CreateProductCard(DataRow productData)
        {
            Panel card = new Panel();
            card.Size = new Size(200, 220);
            card.BackColor = ColorTranslator.FromHtml("#B3FFFF");

            if (productData["PRODUCT_IMAGE"] != DBNull.Value)
            {
                byte[] imageBytes = (byte[])productData["PRODUCT_IMAGE"];
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    PictureBox pb = new PictureBox()
                    {
                        Image = Image.FromStream(ms),
                        Size = new Size(180, 120),
                        Location = new Point(10, 10),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    card.Controls.Add(pb);
                }
            }
            Label lblTen = new Label()
            {
                Text = "Tên sản phẩm: " + productData["PRODUCT_NAME"].ToString(),
                Location = new Point(10, 135),
                AutoSize = true
            };
            card.Controls.Add(lblTen);

            Label lblGia = new Label()
            {
                Text = "Đơn Giá: " + ((decimal)productData["PRODUCT_PRICE"]).ToString("N0") + "₫",
                Location = new Point(10, 150),
                AutoSize = true
            };
            card.Controls.Add(lblGia);

            Label lblSL = new Label()
            {
                Text = "Số lượng: " + productData["PRODUCT_QUANTITY"].ToString(),
                Location = new Point(10, 165),
                AutoSize = true
            };
            card.Controls.Add(lblSL);

            Button btnSua = new Button()
            {
                Text = "Sửa",
                Size = new Size(60, 25),
                Location = new Point(10, 185)
            };
            btnSua.Click += (s, e) =>
            {
                // Gán ID sản phẩm đang sửa
                currentProductId = Convert.ToInt32(productData["PRODUCT_ID"]);

                // Hiển thị panel sửa
                panelAddProduct.Visible = true;
                btnSaveProduct.Visible = false; // Ẩn nút lưu
                btn_UpdateP.Visible = true;     // Hiện nút cập nhật
                

                // Đổ dữ liệu sản phẩm vào form
                txtProductName.Text = productData["PRODUCT_NAME"].ToString();

                //txtProductPrice.Text = productData["PRODUCT_PRICE"].ToString();
                txtProductPrice.Text = ((int)(decimal)productData["PRODUCT_PRICE"]).ToString();

                nudProductQuantity.Value = Convert.ToInt32(productData["PRODUCT_QUANTITY"]);

                // Nếu có hình ảnh thì hiển thị
                if (productData["PRODUCT_IMAGE"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])productData["PRODUCT_IMAGE"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbProductImage.Image = Image.FromStream(ms);
                        pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        selectedImageBytes = imageBytes; // Gán lại hình ảnh hiện tại
                    }
                }
                else
                {
                    pbProductImage.Image = null;
                    selectedImageBytes = null;
                }            
                // Đặt combobox về đúng danh mục (nếu bạn cần load từ PRODUCT.CATALOG_ID thì mở rộng câu truy vấn gốc)
            };
            card.Controls.Add(btnSua);

            Button btnXoa = new Button()
            {
                Text = "Xóa",
                Size = new Size(60, 25),
                Location = new Point(80, 185)
            };
            btnXoa.Click += (s, e) =>
            {
                string productName = productData["PRODUCT_NAME"].ToString();
                string productId = productData["PRODUCT_ID"].ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm \"{productName}\" (ID: {productId})?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string deleteQuery = $"DELETE FROM PRODUCT WHERE PRODUCT_ID = {productId}";
                        int rowsAffected = sqlServerConnection.ExecuteNonQuery(deleteQuery);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa sản phẩm thành công.");
                            LoadProductsByCatalog((int)comboDanhMuc.SelectedValue); // Tải lại sản phẩm theo danh mục hiện tại
                            // Gợi ý: bạn nên gọi lại LoadProductsByCatalog() nếu cần cập nhật giao diện
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa sản phẩm. Có thể ID không tồn tại.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
                    }
                }
            };

            card.Controls.Add(btnXoa);

            return card;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelThemDanhMuc.Visible = true;
            panelEditDanhMuc.Visible = false; // Ẩn panel sửa danh mục nếu đang mở
            panelAddProduct.Visible = false; // Ẩn panel thêm sản phẩm nếu đang mở

            txtTenDanhMuc.Text = "";
            txtTenDanhMuc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục.");
                txtTenDanhMuc.Focus();
                return;
            }

            try
            {
                string catalogName = txtTenDanhMuc.Text.Trim();
                string query = "INSERT INTO CATALOG (CATALOG_NAME) VALUES (N'" + catalogName + "')";
                int result = dbConnection.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Thêm danh mục thành công.");
                    panelThemDanhMuc.Visible = false;
                    LoadCategories(); // Refresh the combobox.
                }
                else
                {
                    MessageBox.Show("Thêm danh mục thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm danh mục: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            panelThemDanhMuc.Visible = false;
        }

        private void btnEditDanhMuc_Click(object sender, EventArgs e)
        {
            if (comboDanhMuc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một danh mục để sửa.");
                return;
            }

            panelEditDanhMuc.Visible = true;
            panelThemDanhMuc.Visible = false; // Ẩn panel thêm danh mục nếu đang mở
            panelAddProduct.Visible = false; // Ẩn panel thêm sản phẩm nếu đang mở

            txtSuaDanhMuc.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSuaDanhMuc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục mới.");
                txtSuaDanhMuc.Focus();
                return;
            }
            try
            {
                int catalogId = (int)comboDanhMuc.SelectedValue;
                string newCatalogName = txtSuaDanhMuc.Text.Trim();
                string query = "UPDATE CATALOG SET CATALOG_NAME = N'" + newCatalogName + "' WHERE CATALOG_ID = " + catalogId;
                int result = dbConnection.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật danh mục thành công.");
                    panelEditDanhMuc.Visible = false;
                    LoadCategories(); // Refresh combobox
                }
                else
                {
                    MessageBox.Show("Cập nhật danh mục thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật danh mục: " + ex.Message);
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (comboDanhMuc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục để xóa.");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int catalogId = (int)comboDanhMuc.SelectedValue;
                    string query = "DELETE FROM CATALOG WHERE CATALOG_ID = " + catalogId;
                    int deleteResult = dbConnection.ExecuteNonQuery(query);

                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Xóa danh mục thành công.");
                        panelEditDanhMuc.Visible = false;
                        LoadCategories(); // Refresh
                        LoadProductsByCatalog(catalogId); // Cần tải lại sản phẩm sau khi xóa danh mục.
                    }
                    else
                    {
                        MessageBox.Show("Xóa danh mục thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa danh mục: " + ex.Message);
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            panelEditDanhMuc.Visible = false;
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            //load lại toàn bộ danh mục
                       

            panelAddProduct.Visible = true;
            btnLuu.Visible = true; // Hiện nút lưu khi thêm sản phẩm mới
            panelEditDanhMuc.Visible = false; // Ẩn panel sửa danh mục nếu đang mở
            panelThemDanhMuc.Visible = false; // Ẩn panel thêm danh mục nếu đang mở
            btn_UpdateP.Visible = false; // Ẩn nút cập nhật khi thêm sản phẩm mới
        }

        private int currentProductId = -1; // Gán biến này khi chọn sản phẩm để sửa

        private void btn_UpdateP_Click(object sender, EventArgs e)
        {
            if (currentProductId == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để cập nhật.");
                return;
            }
            

            // Lấy dữ liệu mới từ giao diện
            string newName = txtProductName.Text.Trim();
            int newQuantity = (int)nudProductQuantity.Value;
            string newCatalogId = comboDanhMuc.SelectedValue.ToString(); // dùng luôn không cần kiểm tra
            string imageHex = selectedImageBytes != null ? "0x" + BitConverter.ToString(selectedImageBytes).Replace("-", "") : null;
            if (!int.TryParse(txtProductPrice.Text, out int newPrice))
            {
                MessageBox.Show("Giá không hợp lệ.");
                return;
            }   


            try
            {
                List<string> updateFields = new List<string>();

                // Thêm các trường cần update (chỉ khi có thay đổi)
                string selectQuery = $"SELECT PRODUCT_NAME, PRODUCT_PRICE, PRODUCT_QUANTITY FROM PRODUCT WHERE PRODUCT_ID = {currentProductId}";
                DataTable dt = sqlServerConnection.ExecuteQuery(selectQuery);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.");
                    return;
                }

                DataRow current = dt.Rows[0];

                if (current["PRODUCT_NAME"].ToString().Trim() != newName)
                    updateFields.Add($"PRODUCT_NAME = N'{newName}'");

                if (Convert.ToInt32(current["PRODUCT_PRICE"]) != newPrice)
                    updateFields.Add($"PRODUCT_PRICE = {newPrice}");

                if (Convert.ToInt32(current["PRODUCT_QUANTITY"]) != newQuantity)
                    updateFields.Add($"PRODUCT_QUANTITY = {newQuantity}");

                // CATALOG_ID: luôn gán lại
                updateFields.Add($"CATALOG_ID = {newCatalogId}");

                if (selectedImageBytes != null)
                    updateFields.Add($"PRODUCT_IMAGE = {imageHex}");

                if (updateFields.Count == 0)
                {
                    MessageBox.Show("Không có thay đổi nào.");
                    return;
                }

                string updateQuery = $"UPDATE PRODUCT SET {string.Join(", ", updateFields)} WHERE PRODUCT_ID = {currentProductId}";

                int rowsAffected = sqlServerConnection.ExecuteNonQuery(updateQuery);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công.");
                    panelAddProduct.Visible = false;
                    LoadProductsByCatalog(Convert.ToInt32(newCatalogId));
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật sản phẩm.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void btnCancelAddProduct_Click(object sender, EventArgs e)
        {
            panelAddProduct.Visible = false;
        }
        private byte[] selectedImageBytes = null;
        private void btnChooseProductImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pbProductImage.Image = Image.FromFile(filePath);
                pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage;

                selectedImageBytes = File.ReadAllBytes(filePath);

            }
        }
        
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }

            string productName = txtProductName.Text.Trim();
            string catalogId = comboDanhMuc.SelectedValue.ToString(); // lấy CATALOG_ID
            int quantity = (int)nudProductQuantity.Value;
            string imageHex = selectedImageBytes != null ? "0x" + BitConverter.ToString(selectedImageBytes).Replace("-", "") : "NULL";
            if (!int.TryParse(txtProductPrice.Text, out int price))
            {
                MessageBox.Show("Giá không hợp lệ.");
                return;
            }

            try
            {
                string insertQuery = $@"
                INSERT INTO PRODUCT 
                (PRODUCT_NAME, PRODUCT_PRICE, PRODUCT_QUANTITY, PRODUCT_IMAGE, CATALOG_ID)
                VALUES 
                (N'{productName}', {price},{quantity} , {imageHex}, '{catalogId}')";

                
                int rowsAffected = sqlServerConnection.ExecuteNonQuery(insertQuery);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("THÊM SẢN PHẨM THÀNH CÔNG");
                    // Có thể reset các textbox ở đây
                    txtProductName.Clear();
                    txtProductPrice.Clear();
                    nudProductQuantity.Value = 0;
                    comboDanhMuc.SelectedIndex = 0;
                    selectedImageBytes = null;
                    pbProductImage.Image = null;
                }
                else
                {
                    MessageBox.Show("KHÔNG THỂ THÊM SẢN PHẨM");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("XONG!!!!");
            }
        }

        private void panelCards_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel1_Click(object sender, EventArgs e)
        {
            panelThemDanhMuc.Visible = false;
            panelEditDanhMuc.Visible = false; // Ẩn panel sửa danh mục nếu đang mở
            panelAddProduct.Visible = false; // Ẩn panel thêm sản phẩm nếu đang mở
        }

        private void panelCards_Click(object sender, EventArgs e)
        {
            panelThemDanhMuc.Visible = false;
            panelEditDanhMuc.Visible = false; // Ẩn panel sửa danh mục nếu đang mở
            panelAddProduct.Visible = false; // Ẩn panel thêm sản phẩm nếu đang mở
        }
    }
}
