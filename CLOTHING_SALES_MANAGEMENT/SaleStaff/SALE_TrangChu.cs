using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLOTHING_SALES_MANAGEMENT.Models; // Import the Models namespace

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmSaleTrangChu : MetroFramework.Forms.MetroForm
    {
        private string connectionString = @"Data Source=DESKTOP-9897340;Initial Catalog=CMU_CS_447_GROUP_PROJECT;Integrated Security=True;Encrypt=False;";
        int totalQuantity = 0;
        private List<Catalog> categories = new List<Catalog>();
        private List<Product> shoppingCart = new List<Product>();

        public frmSaleTrangChu()
        {
            InitializeComponent();
            Instance = this;
            cbSapXep.Items.Add("GIÁ THẤP ĐẾN CAO");
            cbSapXep.Items.Add("GIÁ CAO ĐẾN THẤP");
           
        }
        public static frmSaleTrangChu Instance;

        private void frmSaleTrangChu_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadAndDisplayProducts(); // Tải tất cả sản phẩm khi form được tải
        }
        public void ResetGioHang()
        {
            // Thêm code để đặt lại giỏ hàng ở đây
             totalQuantity =0;  // Ví dụ: Đặt lại số lượng sản phẩm trong giỏ hàng
            UpdateShoppingCartButtonText(); // Cập nhật hiển thị trên nút giỏ hàng
        }

        private void LoadAndDisplayProducts(int? catalogId = null)
        {
            List<Product> products = LoadProducts(catalogId);
            DisplayProducts(products);
        }

        private void LoadCategories()
        {
            categories.Clear(); // Xóa danh sách hiện tại trước khi tải lại
            Catalog allCatalog = new Catalog { CatalogId = -1, CatalogName = "TẤT CẢ" };
            categories.Add(allCatalog); // Thêm mục "Tất cả" vào đầu

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CATALOG_ID, CATALOG_NAME FROM CATALOG";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new Catalog
                            {
                                CatalogId = Convert.ToInt32(reader["CATALOG_ID"]),
                                CatalogName = reader["CATALOG_NAME"].ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL khi tải danh mục: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định khi tải danh mục: {ex.Message}");
            }

            // Thiết lập DataSource cho ComboBox danh mục
            cbDanhMuc.DataSource = null; // Đặt lại DataSource trước khi gán lại
            cbDanhMuc.DataSource = categories;
            cbDanhMuc.DisplayMember = "CatalogName";
            cbDanhMuc.ValueMember = "CatalogId";
            cbDanhMuc.SelectedIndex = 0; // Chọn mục "Tất cả" mặc định
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Có thể dùng để vẽ thêm lên panel nếu cần
        }

        private void cbSapXep_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Lấy danh sách sản phẩm đang hiển thị từ panel2
            List<Product> currentProducts = new List<Product>();
            foreach (Control control in panel2.Controls)
            {
                if (control is Panel productPanel && productPanel.Tag is Product product)
                {
                    currentProducts.Add(product);
                }
            }

            // Sắp xếp sản phẩm
            if (currentProducts.Count > 0)
            {
                if (cbSapXep.SelectedIndex == 0)
                {
                    // Sắp xếp theo giá thấp đến cao
                    currentProducts.Sort((p1, p2) => p1.UnitPrice.CompareTo(p2.UnitPrice));
                }
                else if (cbSapXep.SelectedIndex == 1)
                {
                    // Sắp xếp theo giá cao đến thấp
                    currentProducts.Sort((p1, p2) => p2.UnitPrice.CompareTo(p1.UnitPrice));
                }

                // Hiển thị lại sản phẩm đã sắp xếp
                DisplayProducts(currentProducts);
            }
        }


        private void txtTenSanPham_Click(object sender, EventArgs e)
        {
            // Xử lý khi người dùng click vào textbox tìm kiếm
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDanhMuc.SelectedItem is Catalog selectedCatalog)
            {
                int? catalogIdToLoad = selectedCatalog.CatalogId;
                LoadAndDisplayProducts(catalogIdToLoad);
            }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            string searchText = txtTenSanPham.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadAndDisplayProducts(null);
                return;
            }

            List<Product> allProducts = LoadProducts(null);

            if (allProducts == null || allProducts.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Product> searchResults = allProducts
                .Where(p => p.ProductName != null && p.ProductName.ToLower().Contains(searchText))
                .ToList();

            if (searchResults.Count == 0)
            {
                panel2.Controls.Clear(); // Dọn panel hiển thị
                MessageBox.Show($"Không tìm thấy sản phẩm nào có tên chứa '{txtTenSanPham.Text}'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DisplayProducts(searchResults);
            }
        }

        private void DisplayProducts(List<Product> products)
        {
            panel2.Controls.Clear();
            if (products == null || products.Count == 0)
            {
                return;
            }

            int x = 10, y = 10;
            int cardWidth = 160, cardHeight = 250;
            int padding = 10;
            int maxPerRow = Math.Max(1, panel2.Width / (cardWidth + padding));
            int count = 0;

            foreach (var product in products)
            {
                Panel card = new Panel
                {
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Size = new Size(cardWidth, cardHeight),
                    Location = new Point(x, y),
                    Tag = product
                };

                Label lblName = new Label
                {
                    Text = product.ProductName,
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblPrice = new Label
                {
                    Text = $"{product.UnitPrice:N0} VND",
                    Location = new Point(10, 30),
                    AutoSize = true
                };

                PictureBox pic = new PictureBox
                {
                    Size = new Size(140, 100),
                    Location = new Point(10, 60),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.LightGray
                };

                // Nếu có ảnh, gán vào PictureBox
                if (product.ImageData != null && product.ImageData.Length > 0)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(product.ImageData))
                        {
                            Image img = Image.FromStream(ms);
                            pic.Image = img;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        // Lỗi này thường xảy ra nếu dữ liệu không phải là định dạng ảnh hợp lệ
                        MessageBox.Show($"Lỗi ArgumentException khi tạo ảnh cho sản phẩm ID {product.ProductId}: {ex.Message}");
                        pic.BackColor = Color.Red; // Đánh dấu lỗi bằng màu nền khác
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi không xác định khi tạo ảnh cho sản phẩm ID {product.ProductId}: {ex.Message}");
                        pic.BackColor = Color.DarkGray; // Đánh dấu lỗi bằng màu nền khác
                    }
                }

                Button btnAddToCart = new Button
                {
                    Text = "THÊM VÀO GIỎ",
                    Location = new Point(10, 170),
                    Size = new Size(140, 30),
                    BackColor = Color.LightGreen
                };
                btnAddToCart.Click += AddToCart_Click;

                // Thêm các control vào card
                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(pic);
                card.Controls.Add(btnAddToCart);

                // Thêm card vào panel chính
                panel2.Controls.Add(card);

                // Tính vị trí card tiếp theo
                count++;
                if (count % maxPerRow == 0)
                {
                    x = 10;
                    y += cardHeight + padding;
                }
                else
                {
                    x += cardWidth + padding;
                }
            }
        }




        private void AddToCart_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Panel productCard = (Panel)clickedButton.Parent;
            Product selectedProduct = (Product)productCard.Tag; // Lấy Product từ Tag

            // Tìm sản phẩm trong giỏ hàng
            var existingProduct = shoppingCart.FirstOrDefault(p => p.ProductId == selectedProduct.ProductId);

            if (existingProduct == null)
            {
                // Tạo bản sao sản phẩm để tránh sửa trực tiếp sản phẩm gốc
                Product productToAdd = new Product
                {
                    ProductId = selectedProduct.ProductId,
                    ProductName = selectedProduct.ProductName,
                    UnitPrice = selectedProduct.UnitPrice,
                    ImageData = selectedProduct.ImageData,
                    CatalogId = selectedProduct.CatalogId,
                    Quantity = 1 // Bắt đầu với 1 sản phẩm
                };

                shoppingCart.Add(productToAdd);
                MessageBox.Show($"Đã thêm '{selectedProduct.ProductName}' vào giỏ hàng!");
            }
            else
            {
                existingProduct.Quantity += 1; // Tăng số lượng sản phẩm trong giỏ
                MessageBox.Show($"Đã tăng số lượng '{selectedProduct.ProductName}' trong giỏ hàng!");
            }

            UpdateShoppingCartButtonText();
        }

        public void UpdateShoppingCartButtonText()
        {
            int itemCount = shoppingCart.Count; // Số lượng sản phẩm khác nhau
            btnGioHang.Text = itemCount > 0 ? $"GIỎ HÀNG ({itemCount})" : "GIỎ HÀNG";
        }
        private List<Product> LoadProducts(int? catalogId = null)
        {
            List<Product> products = new List<Product>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PRODUCT_ID, PRODUCT_NAME, PRODUCT_QUANTITY, PRODUCT_IMAGE, PRODUCT_UNITPRICE, CATALOG_ID FROM PRODUCT";
                    if (catalogId.HasValue && catalogId != -1)
                    {
                        query += " WHERE CATALOG_ID = @CatalogId";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (catalogId.HasValue && catalogId != -1)
                    {
                        cmd.Parameters.AddWithValue("@CatalogId", catalogId.Value);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = null;
                            // Kiểm tra xem giá trị có phải là DBNull và có phải là một mảng byte không
                            if (reader["PRODUCT_IMAGE"] != DBNull.Value && reader["PRODUCT_IMAGE"] is byte[])
                            {
                                imageData = (byte[])reader["PRODUCT_IMAGE"];
                            }

                            products.Add(new Product
                            {
                                ProductId = Convert.ToInt32(reader["PRODUCT_ID"]),
                                ProductName = reader["PRODUCT_NAME"].ToString(),
                                Quantity = Convert.ToInt32(reader["PRODUCT_QUANTITY"]),
                                ImageData = imageData,
                                UnitPrice = Convert.ToDecimal(reader["PRODUCT_UNITPRICE"]),
                                CatalogId = Convert.ToInt32(reader["CATALOG_ID"])
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL khi tải sản phẩm: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định khi tải sản phẩm: {ex.Message}");
                return null;
            }
            return products;
        }






        private void btn_load_Click(object sender, EventArgs e)
        {

            LoadCategories();
            LoadAndDisplayProducts(null);
            txtTenSanPham.Text = "";
            shoppingCart.Clear(); // Xóa giỏ hàng
             totalQuantity = 0; // Reset số lượng item
            UpdateShoppingCartButtonText();
            MessageBox.Show("Đã tải lại dữ liệu từ đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            // Giả sử shoppingCart là List<Product> bạn đã có từ trước
            frmSaleGioHang.GioHangItems = shoppingCart;

            var gioHangForm = new frmSaleGioHang();
            gioHangForm.Show();
            
        }
        
        private void frmSaleTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Huỷ việc đóng form
            }
          
        }
    }
}

