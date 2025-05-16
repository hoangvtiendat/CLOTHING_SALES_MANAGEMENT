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
using System.Data.SqlClient;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmSaleHoaDon : MetroFramework.Forms.MetroForm
    {
        public List<Product> GioHangItems { get; set; }
        private string connectionString = @"Data Source=DESKTOP-9897340;Initial Catalog=CMU_CS_447_GROUP_PROJECT;Integrated Security=True;Encrypt=False;";

        public frmSaleHoaDon(List<Product> gioHang)
        {
            InitializeComponent();
            GioHangItems = gioHang;
        }


        private string GenerateMaHoaDonFromDatabase()
        {
            int nextPurchaseId = 1; // Giá trị mặc định nếu bảng rỗng

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(PURCHASE_ID), 0) + 1 FROM PURCHASE_HISTORY;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        nextPurchaseId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy PURCHASE_ID từ database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể xử lý khác tùy thuộc vào yêu cầu của bạn
            }

            // Tạo mã hóa đơn theo định dạng HD-yyyyMMdd-PURCHASE_ID
            return $"HD-{DateTime.Now.ToString("yyyyMMdd")}-{nextPurchaseId:D4}";
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            frmSaleGioHang gioHangForm = new frmSaleGioHang();
            gioHangForm.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textTenKH.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongHoaDon = decimal.Parse(txtTongTien.Text.Replace(" VND", ""));
            decimal chietKhau = 0;
            int customerId = -1; // Khởi tạo CustomerId

            // Kiểm tra xem số điện thoại đã tồn tại trong database chưa
            bool khachHangTonTai = KiemTraKhachHangTonTai(txtSDT.Text, out string tenKH, out string diaChi); // Thêm 2 biến out

            if (!khachHangTonTai)
            {
                // Nếu số điện thoại chưa tồn tại, áp dụng giảm giá lần đầu 5%
                chietKhau = tongHoaDon * 0.05m;
                txtChietKhau.Text = $"{chietKhau:N0} VND";
                tongHoaDon -= chietKhau;
                txtTongTien.Text = $"{tongHoaDon:N0} VND";

                // Thêm khách hàng mới vào database
                customerId = ThemKhachHangMoi(textTenKH.Text, txtSDT.Text, txtDiaChi.Text);
                if (customerId == -1)
                {
                    MessageBox.Show("Lỗi khi thêm khách hàng mới vào cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Không tiến hành thanh toán nếu không thêm được khách hàng
                }
            }
            else
            {
                txtChietKhau.Text = "0 VND"; // Số điện thoại đã tồn tại, không giảm giá
                // Lấy CustomerId của khách hàng đã tồn tại
                customerId = LayCustomerIdTheoSoDienThoai(txtSDT.Text);
                //Hiển thị thông tin khách hàng
                textTenKH.Text = tenKH;
                txtDiaChi.Text = diaChi;
            }

            if (decimal.TryParse(txtTienKhachTra.Text, out decimal tienKhachTra))
            {
                if (tienKhachTra >= tongHoaDon)
                {
                    // Thực hiện lưu hóa đơn vào database
                    bool luuHoaDonThanhCong = SaveHoaDonToDatabase(chietKhau, customerId); // Truyền CustomerId
                    if (luuHoaDonThanhCong)
                    {
                        DialogResult rs = MessageBox.Show("THANH TOÁN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (rs == DialogResult.OK)
                        {
                            this.Hide();
                            var trangChuForm = Application.OpenForms.OfType<frmSaleTrangChu>().FirstOrDefault();
                            if (trangChuForm != null)
                            {
                                trangChuForm.Show();
                                frmSaleTrangChu trangchu = new frmSaleTrangChu();
                                trangchu.ResetGioHang();
                                trangchu.Show();
                                // Cần reset giỏ hàng ở trang chủ hoặc form giỏ hàng
                            }
                            else
                            {
                                trangChuForm = new frmSaleTrangChu();
                                trangChuForm.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi lưu hóa đơn vào cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Số tiền khách trả không đủ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền khách trả hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private int LayCustomerIdTheoSoDienThoai(string soDienThoai)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CUSTOMER_ID FROM CUSTOMER WHERE CUSTOMER_NUMBERPHONE = @SoDienThoai;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy Customer ID: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1; // Trả về -1 nếu không tìm thấy hoặc có lỗi
        }
        private int ThemKhachHangMoi(string tenKH, string sdt, string diaChi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO CUSTOMER (CUSTOMER_NAME, CUSTOMER_ADDRESS, CUSTOMER_NUMBERPHONE) VALUES (@TenKH, @DiaChi, @SDT); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    return -1; // Lỗi khi thêm khách hàng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        private bool KiemTraKhachHangTonTai(string soDienThoai, out string tenKH, out string diaChi)
        {
            tenKH = string.Empty;
            diaChi = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CUSTOMER_NAME, CUSTOMER_ADDRESS FROM CUSTOMER WHERE CUSTOMER_NUMBERPHONE = @SoDienThoai;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        tenKH = reader["CUSTOMER_NAME"].ToString();
                        diaChi = reader["CUSTOMER_ADDRESS"].ToString();
                        return true; // Trả về true nếu tồn tại
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Trả về false nếu có lỗi
            }
        }

        private bool SaveHoaDonToDatabase(decimal chietKhau, int customerId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        // 1. Insert vào bảng PURCHASE_HISTORY
                        string insertHoaDonQuery = @"
                            INSERT INTO PURCHASE_HISTORY (CUSTOMER_ID, PURCHASE_DATE, PURCHASE_TOTAL)
                            VALUES (@CustomerId, @PurchaseDate, @PurchaseTotal);
                            SELECT SCOPE_IDENTITY();"; // Lấy ID hóa đơn vừa tạo

                        SqlCommand insertHoaDonCmd = new SqlCommand(insertHoaDonQuery, conn, transaction);
                        insertHoaDonCmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);
                        insertHoaDonCmd.Parameters.AddWithValue("@PurchaseTotal", decimal.Parse(txtTongTien.Text.Replace(" VND", "")));
                        insertHoaDonCmd.Parameters.AddWithValue("@CustomerId", customerId); // Sử dụng CustomerId


                        int purchaseId = Convert.ToInt32(insertHoaDonCmd.ExecuteScalar());

                        // 2. Insert vào bảng PURCHASE_DETAIL
                        string insertChiTietQuery = @"
                            INSERT INTO PURCHASE_DETAIL (PURCHASE_ID, PRODUCT_ID, PRODUCT_QUANTITY, PRODUCT_DETAIL_UNITPRICE, PRODUCT_DETAIL_SUBTOTAL)
                            VALUES (@PurchaseId, @ProductId, @Quantity, @UnitPrice, @Subtotal);";
                        SqlCommand insertChiTietCmd = new SqlCommand(insertChiTietQuery, conn, transaction);

                        foreach (var item in GioHangItems)
                        {
                            insertChiTietCmd.Parameters.Clear();
                            insertChiTietCmd.Parameters.AddWithValue("@PurchaseId", purchaseId);
                            insertChiTietCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                            insertChiTietCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            insertChiTietCmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                            insertChiTietCmd.Parameters.AddWithValue("@Subtotal", item.UnitPrice * item.Quantity);
                            insertChiTietCmd.ExecuteNonQuery();
                        }

                        // 3. Cập nhật số lượng sản phẩm trong bảng PRODUCT
                        string updateProductQuery = "UPDATE PRODUCT SET PRODUCT_QUANTITY = PRODUCT_QUANTITY - @Quantity WHERE PRODUCT_ID = @ProductId;";
                        SqlCommand updateProductCmd = new SqlCommand(updateProductQuery, conn, transaction);

                        foreach (var item in GioHangItems)
                        {
                            updateProductCmd.Parameters.Clear();
                            updateProductCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                            updateProductCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            updateProductCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        private void frmSaleHoaDon_Load(object sender, EventArgs e)
        {
            // Lấy và hiển thị mã hóa đơn tự động tăng từ database
            txtMaHD.Text = GenerateMaHoaDonFromDatabase();

            // Hiển thị các sản phẩm đã mua trong DataGridView
            if (GioHangItems != null && GioHangItems.Count > 0)
            {
                // Tạo một DataTable để chứa dữ liệu hiển thị
                DataTable dt = new DataTable();
                dt.Columns.Add("Tên sản phẩm", typeof(string));
                dt.Columns.Add("Số lượng", typeof(int));
                dt.Columns.Add("Đơn giá", typeof(decimal));
                dt.Columns.Add("Thành tiền", typeof(decimal));

                foreach (var item in GioHangItems)
                {
                    dt.Rows.Add(item.ProductName, item.Quantity, item.UnitPrice, item.UnitPrice * item.Quantity);
                }

                // Thiết lập DataSource cho DataGridView (giả sử tên DataGridView là dtHoaDon)
                dtHoaDon.DataSource = dt;

                decimal totalAmount = GioHangItems.Sum(item => item.UnitPrice * item.Quantity);
                txtTongTien.Text = $"{totalAmount:N0} VND";
                tongHoaDonBanDauValue = totalAmount; // Lưu giá trị tổng tiền ban đầu
            }
            else
            {
                // Hiển thị thông báo nếu không có sản phẩm trong DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("Thông báo", typeof(string));
                dt.Rows.Add("Không có sản phẩm nào trong giỏ hàng.");
                dtHoaDon.DataSource = dt;
                txtTongTien.Text = "0 VND";
            }

            // Đặt ngày lập hóa đơn mặc định là ngày hiện tại
            dateTimePicker1.Value = DateTime.Now;

        }

        private void txtTienKhachTra_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTongTien.Text.Replace(" VND", ""), out decimal tongHoaDon) &&
                decimal.TryParse(txtTienKhachTra.Text, out decimal tienKhachTra))
            {
                decimal tienThoi = tienKhachTra - tongHoaDon;
                if (tienThoi < 0)
                {
                    txtTienThoi.Text = "0 VND";
                }
                else
                {
                    txtTienThoi.Text = $"{tienThoi:N0} VND";
                }
            }
            else
            {
                txtTienThoi.Text = "0 VND";
            }
        }
        private decimal tongHoaDonBanDauValue = 0;
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSDT.Text))
            {
                decimal chietKhau = 0;
                string tenKH = string.Empty;
                string diaChi = string.Empty;

                if (!KiemTraKhachHangTonTai(txtSDT.Text, out tenKH, out diaChi)) // Gọi hàm mới
                {
                    chietKhau = tongHoaDonBanDauValue * 0.05m;
                    txtChietKhau.Text = $"{chietKhau:N0} VND";
                    txtTongTien.Text = $"{(tongHoaDonBanDauValue - chietKhau):N0} VND";
                    textTenKH.Text = string.Empty;
                    txtDiaChi.Text = string.Empty;
                }
                else
                {
                    txtChietKhau.Text = "0 VND";
                    txtTongTien.Text = $"{tongHoaDonBanDauValue:N0} VND"; // Hiển thị lại tổng tiền gốc
                    textTenKH.Text = tenKH;
                    txtDiaChi.Text = diaChi;
                }
            }
            else
            {
                txtChietKhau.Text = "0 VND";
                txtTongTien.Text = $"{tongHoaDonBanDauValue:N0} VND"; // Hiển thị lại tổng tiền gốc khi xóa SĐT
                textTenKH.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
            }
        }

        private void frmSaleHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Huỷ việc đóng form
            }
        }
    }
}
