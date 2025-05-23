using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CLOTHING_SALES_MANAGEMENT.Models
{
    public class Catalog
    {
        public int CatalogId { get; set; }
        public string CatalogName { get; set; }
    }
    public class CartItem
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public string Size { get; set; }  // Optional
    }
    public class Product
    {
        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public byte[] ImageData { get; set; }
        public decimal UnitPrice { get; set; }
        public int CatalogId { get; set; }
        public string SelectedSize { get; set; }
        

        //public byte[] ProductImageBytes { get; set; } // ⬅ Thêm dòng này
        //public Image ProductImage { get; set; } // ⬅ Nếu bạn muốn convert luôn thành Image

        // Bỏ ImagePath nếu không còn dùng đường dẫn ảnh từ file
        //private List<Product> LoadProducts(int? catalogId = null)
        //{
        //    List<Product> products = new List<Product>();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();
        //            string query = "SELECT * FROM PRODUCT";
        //            if (catalogId.HasValue && catalogId != -1)
        //            {
        //                query += " WHERE CATALOG_ID = @CatalogId";
        //            }

        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            if (catalogId.HasValue && catalogId != -1)
        //            {
        //                cmd.Parameters.AddWithValue("@CatalogId", catalogId.Value);
        //            }

        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Product product = new Product
        //                    {
        //                        ProductId = Convert.ToInt32(reader["PRODUCT_ID"]),
        //                        ProductName = reader["PRODUCT_NAME"].ToString(),
        //                        Quantity = Convert.ToInt32(reader["PRODUCT_QUANTITY"]),
        //                        UnitPrice = Convert.ToDecimal(reader["PRODUCT_UNITPRICE"]),
        //                        CatalogId = Convert.ToInt32(reader["CATALOG_ID"])
        //                    };

        //                    if (!(reader["PRODUCT_IMAGE"] is DBNull))
        //                    {
        //                        byte[] imageBytes = (byte[])reader["PRODUCT_IMAGE"];
        //                        product.ProductImageBytes = imageBytes;

        //                        using (MemoryStream ms = new MemoryStream(imageBytes))
        //                        {
        //                            product.ProductImage = Image.FromStream(ms);
        //                        }
        //                    }

        //                    products.Add(product);
        //                }
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show($"Lỗi SQL khi tải sản phẩm: {ex.Message}");
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi không xác định khi tải sản phẩm: {ex.Message}");
        //        return null;
        //    }
        //    return products;
        //var gioHangForm = new frmSaleGioHang();
        //gioHangForm.GioHangItems = shoppingCart; // Đảm bảo truyền dữ liệu giỏ hàng
        //    gioHangForm.Show(); // Hoặc gioHangForm.ShowDialog();
        ////trang chu 
        //}
        //if (product.ProductImage != null)
        //{
        //    pic.Image = product.ProductImage;
        //}
        //else
        //{
        //    pic.BackColor = Color.LightGray;
        //}
        //giohang
        //if (item.ProductImageBytes != null && item.ProductImageBytes.Length > 0)
        //{
        //    using (var ms = new System.IO.MemoryStream(item.ProductImageBytes))
        //    {
        //        pic.Image = Image.FromStream(ms);
        //    }
        //}
        //else
        //{
        //    pic.BackColor = Color.LightGray;
        //}
    }

}
