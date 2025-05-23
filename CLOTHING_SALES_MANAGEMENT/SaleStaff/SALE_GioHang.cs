using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLOTHING_SALES_MANAGEMENT.Models;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Data.SqlClient;
using System.IO; // Thêm namespace này

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmSaleGioHang : MetroForm
    {
        // ... (Các khai báo khác)
        public static List<Product> GioHangItems { get; set; } = new List<Product>();

        public List<Product> AvailableProducts { get; set; }
        private decimal tongTien = 0;
        private Dictionary<int, int> initialQuantities = new Dictionary<int, int>();
        private const int ITEM_WIDTH = 360;
        private const int ITEM_HEIGHT = 150; // Tăng chiều cao để chứa nút Xóa
        private const int VERTICAL_SPACING = 15;
        private const int IMAGE_SIZE = 80;
        private string connectionString = "Data Source=LAPTOP-68GDOI8K\\MAYCUONG;Initial Catalog=CMU_CS_447_GROUP_PROJECT;Integrated Security=True";

        public frmSaleGioHang()
        {
            InitializeComponent();
            AvailableProducts = new List<Product>();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmSaleTrangChu trangChuForm = Application.OpenForms.OfType<frmSaleTrangChu>().FirstOrDefault();
            if (trangChuForm != null)
            {
                trangChuForm.Show();
            }
            else
            {
                trangChuForm = new frmSaleTrangChu();
                trangChuForm.Show();
            }
            this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (GioHangItems != null && GioHangItems.Count > 0)
            {
                frmSaleHoaDon hoaDonForm = new frmSaleHoaDon(GioHangItems.ToList());
                hoaDonForm.Show();
                this.Hide();
                //UpdateQuantitiesInDatabase();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào trong giỏ hàng để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void frmSaleGioHang_Load(object sender, EventArgs e)
        {
            DisplayCartItems();
        }

        private void UpdateQuantitiesInDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var item in GioHangItems)
                {
                    int quantityPurchased = item.Quantity;
                    if (quantityPurchased > 0)
                    {
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                int currentStock = 0;
                                string selectQuery = "SELECT PRODUCT_QUANTITY FROM PRODUCT WHERE PRODUCT_ID = @ProductId";
                                using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn, transaction))
                                {
                                    selectCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                                    object result = selectCmd.ExecuteScalar();
                                    if (result != null && result != DBNull.Value)
                                    {
                                        currentStock = Convert.ToInt32(result);
                                    }
                                }

                                if (currentStock >= quantityPurchased)
                                {
                                    string updateQuery = "UPDATE PRODUCT SET PRODUCT_QUANTITY = PRODUCT_QUANTITY - @Quantity WHERE PRODUCT_ID = @ProductId";
                                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                                    {
                                        updateCmd.Parameters.AddWithValue("@Quantity", quantityPurchased);
                                        updateCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                    transaction.Commit();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Không đủ hàng trong kho cho sản phẩm: {item.ProductName}. Chỉ còn {currentStock} sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Lỗi khi cập nhật số lượng trong kho: " + ex.Message);
                                return;
                            }
                        }
                    }
                }
            }
        }

        public void AddToCart(Product product)
        {
            var existingProduct = GioHangItems.FirstOrDefault(p => p.ProductId == product.ProductId);

            if (existingProduct != null)
            {
                existingProduct.Quantity += 1;
            }
            else
            {
                product.Quantity = 1;
                GioHangItems.Add(product);
            }

            DisplayCartItems();
        }

        private void DisplayCartItems()
        {
            pnGioHang.Controls.Clear();
            tongTien = 0;
            initialQuantities.Clear();

            if (GioHangItems == null || GioHangItems.Count == 0)
            {
                Label emptyCartLabel = new Label();
                emptyCartLabel.Text = "KHÔNG CÓ SẢN PHẨM NÀO TRONG GIỎ HÀNG.";
                emptyCartLabel.AutoSize = true;
                emptyCartLabel.Location = new Point(10, 10);
                pnGioHang.Controls.Add(emptyCartLabel);
                lblTongTien.Text = "0 VND";
                return;
            }

            int y = 10;

            var groupedItems = GioHangItems.GroupBy(p => p.ProductId);

            foreach (var group in groupedItems)
            {
                var item = group.First();
                int totalQuantity = group.Sum(p => p.Quantity);

                Panel itemPanel = new Panel();
                itemPanel.Location = new Point(10, y);
                itemPanel.Size = new Size(ITEM_WIDTH, ITEM_HEIGHT);
                itemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                itemPanel.BackColor = Color.White;

                Label lblName = new Label();
                lblName.Text = "Tên: " + item.ProductName;
                lblName.Location = new Point(10, 10);
                lblName.AutoSize = true;

                Label lblPrice = new Label();
                lblPrice.Text = "Giá: " + item.UnitPrice.ToString("N0") + " VND";
                lblPrice.Location = new Point(10, 35);
                lblPrice.AutoSize = true;

                NumericUpDown numQuantity = new NumericUpDown();
                numQuantity.Minimum = 1;
                numQuantity.Value = totalQuantity;
                numQuantity.Location = new Point(10, 60);
                numQuantity.Width = 60;

                int maxQuantity = GetProductQuantityFromDatabase(item.ProductId);
                numQuantity.Maximum = maxQuantity;

                numQuantity.Tag = item.ProductId;
                numQuantity.ValueChanged += numQuantity_ValueChanged;

                Button btnXoa = new Button();
                btnXoa.Text = "XÓA";
                btnXoa.BackColor = Color.Red;
                btnXoa.ForeColor = Color.White;
                btnXoa.Location = new Point(80, 58);
                btnXoa.Size = new Size(60, 25);

                btnXoa.Click += (s, e) =>
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này khỏi giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        GioHangItems.RemoveAll(p => p.ProductId == item.ProductId);
                        DisplayCartItems();

                        // Cập nhật lại nút giỏ hàng ở frmSaleTrangChu
                        var trangChu = Application.OpenForms.OfType<frmSaleTrangChu>().FirstOrDefault();
                        if (trangChu != null)
                        {
                            trangChu.UpdateShoppingCartButtonText();
                        }
                    }
                };


                PictureBox pic = new PictureBox();
                pic.Size = new Size(IMAGE_SIZE, IMAGE_SIZE);
                pic.Location = new Point(ITEM_WIDTH - IMAGE_SIZE - 10, 20);
                try
                {
                    if (item.ImageData != null && item.ImageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(item.ImageData))
                        {
                            pic.Image = Image.FromStream(ms);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        pic.BackColor = Color.LightGray;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                    pic.BackColor = Color.Gray;
                }

                itemPanel.Controls.Add(lblName);
                itemPanel.Controls.Add(lblPrice);
                itemPanel.Controls.Add(numQuantity);
                itemPanel.Controls.Add(btnXoa);
                itemPanel.Controls.Add(pic);

                pnGioHang.Controls.Add(itemPanel);
                y += ITEM_HEIGHT + VERTICAL_SPACING;
                tongTien += item.UnitPrice * totalQuantity;
                initialQuantities[item.ProductId] = totalQuantity;
            }

            lblTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            int productId = (int)num.Tag;
            int newQuantity = (int)num.Value;

            Product product = GioHangItems.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                product.Quantity = newQuantity;
                UpdateQuantityInCart(productId, newQuantity);
                DisplayCartItems();
            }
        }

        private void UpdateQuantityInCart(int productId, int quantity)
        {
            Product product = GioHangItems.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                product.Quantity = quantity;
            }
        }

        private int GetProductQuantityFromDatabase(int productId)
        {
            int quantity = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PRODUCT_QUANTITY FROM PRODUCT WHERE PRODUCT_ID = @ProductId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        quantity = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy số lượng sản phẩm từ database: " + ex.Message);
            }
            return quantity;
        }

        private void frmSaleGioHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Huỷ việc đóng form
            }
        }
    }
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public byte[] ImageData { get; set; }
        public decimal UnitPrice { get; set; }
        public int CatalogId { get; set; }
    }
}
