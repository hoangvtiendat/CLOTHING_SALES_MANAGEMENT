using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Collections;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmAdminDashboard : MetroFramework.Forms.MetroForm
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();
        public frmAdminDashboard()
        {
            InitializeComponent();
            

        }

     
        private void panelTDT_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // Nền màu xám nhạt
                e.Graphics.Clear(Color.LightGray);

                // Bo tròn góc
                GraphicsPath path = new GraphicsPath();
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panelTDT.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panelTDT.Width - radius, panelTDT.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panelTDT.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                panelTDT.Region = new Region(path);

                // Lấy dữ liệu tổng doanh thu
                string query = "SELECT ISNULL(CAST(SUM(PURCHASE_TOTAL) AS INT), 0) FROM PURCHASE_HISTORY";
                int totalRevenue = Convert.ToInt32(sqlServerConnection.ExecuteScalar(query));

                // Các phần chữ
                string titleText = "Tổng Doanh Thu";
                string valueText = $"{totalRevenue:N0} VNĐ";

                // Font
                Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
                Font valueFont = new Font("Segoe UI", 14, FontStyle.Bold);

                // Brush
                Brush titleBrush = new SolidBrush(Color.DodgerBlue); // Xanh dương
                Brush valueBrush = Brushes.White;
                Brush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));

                // Kích thước
                SizeF titleSize = e.Graphics.MeasureString(titleText, titleFont);
                SizeF valueSize = e.Graphics.MeasureString(valueText, valueFont);

                float xTitle = (panelTDT.Width - titleSize.Width) / 2;
                float yTitle = (panelTDT.Height / 2) - titleSize.Height - 5;

                float xValue = (panelTDT.Width - valueSize.Width) / 2;
                float yValue = (panelTDT.Height / 2) + 5;

                // Vẽ bóng + tiêu đề
                e.Graphics.DrawString(titleText, titleFont, shadowBrush, xTitle + 1, yTitle + 1);
                e.Graphics.DrawString(titleText, titleFont, titleBrush, xTitle, yTitle);

                // Vẽ bóng + giá trị
                e.Graphics.DrawString(valueText, valueFont, shadowBrush, xValue + 1, yValue + 1);
                e.Graphics.DrawString(valueText, valueFont, valueBrush, xValue, yValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ panel Tổng Doanh Thu: " + ex.Message);
            }
        }

        private void panelTongSanPham_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // Gradient nền xám nhạt
                LinearGradientBrush backgroundBrush = new LinearGradientBrush(panelTongSanPham.ClientRectangle,
                    Color.WhiteSmoke, Color.LightGray, LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(backgroundBrush, panelTongSanPham.ClientRectangle);

                // Bo tròn góc
                GraphicsPath path = new GraphicsPath();
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panelTongSanPham.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panelTongSanPham.Width - radius, panelTongSanPham.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panelTongSanPham.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                panelTongSanPham.Region = new Region(path);

                // Lấy dữ liệu tổng số lượng sản phẩm đã bán
                string query = "SELECT ISNULL(SUM(product_quantity), 0) FROM PURCHASE_DETAIL";
                // hoặc ORDER_DETAIL
                int totalSold = Convert.ToInt32(sqlServerConnection.ExecuteScalar(query));
                string displayText = $"{totalSold:N0} sản phẩm";
                string title = "Tổng Sản Phẩm ";

                // Font và màu
                Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold); // Changed to match the style of the "Tổng Doanh Thu"
                Font valueFont = new Font("Segoe UI", 14, FontStyle.Bold); // Same size as in the previous code
                Brush whiteBrush = new SolidBrush(Color.White);
                Brush blueBrush = new SolidBrush(Color.DodgerBlue); // Matching color from previous code
                Brush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));

                // Tính vị trí vẽ chữ
                SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
                SizeF valueSize = e.Graphics.MeasureString(displayText, valueFont);

                float titleX = (panelTongSanPham.Width - titleSize.Width) / 2;
                float valueX = (panelTongSanPham.Width - valueSize.Width) / 2;
                float titleY = (panelTongSanPham.Height / 2) - valueSize.Height - 5; // Adjusted for better placement
                float valueY = (panelTongSanPham.Height / 2) + 5; // Adjusted for better placement

                // Vẽ bóng và chữ
                e.Graphics.DrawString(title, titleFont, shadowBrush, titleX + 1, titleY + 1);
                e.Graphics.DrawString(title, titleFont, blueBrush, titleX, titleY);

                e.Graphics.DrawString(displayText, valueFont, shadowBrush, valueX + 1, valueY + 1);
                e.Graphics.DrawString(displayText, valueFont, whiteBrush, valueX, valueY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ panel Tổng Sản Phẩm Bán: " + ex.Message);
            }
        }

        private void PanelThue_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // Nền màu xám nhạt
                e.Graphics.Clear(Color.LightGray);

                // Bo tròn góc
                GraphicsPath path = new GraphicsPath();
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(PanelThue.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(PanelThue.Width - radius, PanelThue.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, PanelThue.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                PanelThue.Region = new Region(path);

                // Lấy dữ liệu tổng doanh thu
                string query = "SELECT ISNULL(CAST(SUM(PURCHASE_TOTAL) AS INT), 0) FROM PURCHASE_HISTORY";
                int totalRevenue = Convert.ToInt32(sqlServerConnection.ExecuteScalar(query));

                // Tính toán thuế 10% từ tổng doanh thu
                double taxAmount = totalRevenue * 0.15;

                // Các phần chữ
                string titleText = "Tổng Thuế";
                string valueText = $"{taxAmount:N0} VNĐ"; // Hiển thị tiền thuế

                // Font
                Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
                Font valueFont = new Font("Segoe UI", 14, FontStyle.Bold);

                // Brush
                Brush titleBrush = new SolidBrush(Color.DodgerBlue); // Xanh dương
                Brush valueBrush = Brushes.White;
                Brush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));

                // Kích thước
                SizeF titleSize = e.Graphics.MeasureString(titleText, titleFont);
                SizeF valueSize = e.Graphics.MeasureString(valueText, valueFont);

                float xTitle = (PanelThue.Width - titleSize.Width) / 2;
                float yTitle = (PanelThue.Height / 2) - titleSize.Height - 5;

                float xValue = (PanelThue.Width - valueSize.Width) / 2;
                float yValue = (PanelThue.Height / 2) + 5;

                // Vẽ bóng + tiêu đề
                e.Graphics.DrawString(titleText, titleFont, shadowBrush, xTitle + 1, yTitle + 1);
                e.Graphics.DrawString(titleText, titleFont, titleBrush, xTitle, yTitle);

                // Vẽ bóng + giá trị thuế
                e.Graphics.DrawString(valueText, valueFont, shadowBrush, xValue + 1, yValue + 1);
                e.Graphics.DrawString(valueText, valueFont, valueBrush, xValue, yValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ panel Tổng Thuế: " + ex.Message);
            }
        }

        private void panelLoiNhuanSauThue_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // Nền màu xám nhạt
                e.Graphics.Clear(Color.LightGray);

                // Bo tròn góc
                GraphicsPath path = new GraphicsPath();
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panelLoiNhuanSauThue.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panelLoiNhuanSauThue.Width - radius, panelLoiNhuanSauThue.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panelLoiNhuanSauThue.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                panelLoiNhuanSauThue.Region = new Region(path);

                // Lấy dữ liệu tổng doanh thu
                string query = "SELECT ISNULL(CAST(SUM(PURCHASE_TOTAL) AS INT), 0) FROM PURCHASE_HISTORY";
                int totalRevenue = Convert.ToInt32(sqlServerConnection.ExecuteScalar(query));

                // Tính toán thuế 10% từ tổng doanh thu
                double taxAmount = totalRevenue * 0.15;

                // Tính lợi nhuận sau thuế (doanh thu - thuế)
                double profitAfterTax = totalRevenue - taxAmount;

                // Các phần chữ
                string titleText = "Lợi Nhuận Sau Thuế";
                string valueText = $"{profitAfterTax:N0} VNĐ";  // Hiển thị lợi nhuận sau thuế

                // Font
                Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
                Font valueFont = new Font("Segoe UI", 14, FontStyle.Bold);

                // Brush
                Brush titleBrush = new SolidBrush(Color.DodgerBlue); // Xanh dương
                Brush valueBrush = Brushes.White;
                Brush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));

                // Kích thước
                SizeF titleSize = e.Graphics.MeasureString(titleText, titleFont);
                SizeF valueSize = e.Graphics.MeasureString(valueText, valueFont);

                float xTitle = (panelLoiNhuanSauThue.Width - titleSize.Width) / 2;
                float yTitle = (panelLoiNhuanSauThue.Height / 2) - titleSize.Height - 5;

                float xValue = (panelLoiNhuanSauThue.Width - valueSize.Width) / 2;
                float yValue = (panelLoiNhuanSauThue.Height / 2) + 5;

                // Vẽ bóng + tiêu đề
                e.Graphics.DrawString(titleText, titleFont, shadowBrush, xTitle + 1, yTitle + 1);
                e.Graphics.DrawString(titleText, titleFont, titleBrush, xTitle, yTitle);

                // Vẽ bóng + giá trị lợi nhuận sau thuế
                e.Graphics.DrawString(valueText, valueFont, shadowBrush, xValue + 1, yValue + 1);
                e.Graphics.DrawString(valueText, valueFont, valueBrush, xValue, yValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ panel Lợi Nhuận Sau Thuế: " + ex.Message);
            }
        }

        private void panelTongKhachHang_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // Nền màu xám nhạt
                e.Graphics.Clear(Color.LightGray);

                // Bo tròn góc
                GraphicsPath path = new GraphicsPath();
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panelTongKhachHang.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panelTongKhachHang.Width - radius, panelTongKhachHang.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panelTongKhachHang.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                panelTongKhachHang.Region = new Region(path);

                // Lấy tổng số khách hàng từ bảng CUSTOMER
                string query = "SELECT COUNT(*) FROM CUSTOMER";
                int customerCount = Convert.ToInt32(sqlServerConnection.ExecuteScalar(query));

                // Chuỗi hiển thị
                string titleText = "Tổng Khách Hàng";
                string valueText = $"{customerCount:N0} KH";

                // Font và Brush
                Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
                Font valueFont = new Font("Segoe UI", 14, FontStyle.Bold);

                Brush titleBrush = new SolidBrush(Color.DodgerBlue); // Xanh lá
                Brush valueBrush = Brushes.White;
                Brush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));

                // Kích thước
                SizeF titleSize = e.Graphics.MeasureString(titleText, titleFont);
                SizeF valueSize = e.Graphics.MeasureString(valueText, valueFont);

                float xTitle = (panelTongKhachHang.Width - titleSize.Width) / 2;
                float yTitle = (panelTongKhachHang.Height / 2) - titleSize.Height - 5;

                float xValue = (panelTongKhachHang.Width - valueSize.Width) / 2;
                float yValue = (panelTongKhachHang.Height / 2) + 5;

                // Vẽ bóng + tiêu đề
                e.Graphics.DrawString(titleText, titleFont, shadowBrush, xTitle + 1, yTitle + 1);
                e.Graphics.DrawString(titleText, titleFont, titleBrush, xTitle, yTitle);

                // Vẽ bóng + giá trị số khách hàng
                e.Graphics.DrawString(valueText, valueFont, shadowBrush, xValue + 1, yValue + 1);
                e.Graphics.DrawString(valueText, valueFont, valueBrush, xValue, yValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ panel Tổng Khách Hàng: " + ex.Message);
            }
        }

        private void panelTongHoaDon_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // Nền màu xám nhạt
                e.Graphics.Clear(Color.LightGray);

                // Bo tròn góc
                GraphicsPath path = new GraphicsPath();
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panelTongHoaDon.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panelTongHoaDon.Width - radius, panelTongHoaDon.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panelTongHoaDon.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                panelTongHoaDon.Region = new Region(path);

                // Lấy tổng số hóa đơn từ bảng PURCHASE_HISTORY
                string query = "SELECT COUNT(*) FROM PURCHASE_HISTORY";
                int orderCount = Convert.ToInt32(sqlServerConnection.ExecuteScalar(query));

                // Chuỗi hiển thị
                string titleText = "Tổng Hóa Đơn";
                string valueText = $"{orderCount:N0} Đơn";

                // Font và Brush
                Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
                Font valueFont = new Font("Segoe UI", 14, FontStyle.Bold);

                Brush titleBrush = new SolidBrush(Color.DodgerBlue); // Màu hồng đậm
                Brush valueBrush = Brushes.White;
                Brush shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));

                // Kích thước
                SizeF titleSize = e.Graphics.MeasureString(titleText, titleFont);
                SizeF valueSize = e.Graphics.MeasureString(valueText, valueFont);

                float xTitle = (panelTongHoaDon.Width - titleSize.Width) / 2;
                float yTitle = (panelTongHoaDon.Height / 2) - titleSize.Height - 5;

                float xValue = (panelTongHoaDon.Width - valueSize.Width) / 2;
                float yValue = (panelTongHoaDon.Height / 2) + 5;

                // Vẽ bóng + tiêu đề
                e.Graphics.DrawString(titleText, titleFont, shadowBrush, xTitle + 1, yTitle + 1);
                e.Graphics.DrawString(titleText, titleFont, titleBrush, xTitle, yTitle);

                // Vẽ bóng + giá trị tổng hóa đơn
                e.Graphics.DrawString(valueText, valueFont, shadowBrush, xValue + 1, yValue + 1);
                e.Graphics.DrawString(valueText, valueFont, valueBrush, xValue, yValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ panel Tổng Hóa Đơn: " + ex.Message);
            }
        }

        private void btnTheoNgay_Click(object sender, EventArgs e)
        {
            LoadChartTheoNgay();
        }
        private void LoadChartTheoNgay()
        {
            try
            {
                DateTime startDate = dtstart.Value.Date;
                DateTime endDate = dtend.Value.Date;

                // Kiểm tra nếu ngày kết thúc nhỏ hơn ngày bắt đầu
                if (endDate < startDate)
                {
                    MessageBox.Show("Chọn sai ngày! Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra khoảng cách không vượt quá 30 ngày
                if ((endDate - startDate).TotalDays > 30)
                {
                    MessageBox.Show("Dữ liệu quá nhiều! Vui lòng chọn khoảng thời gian không quá 30 ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Reset chart
                chartDoanhThu.Series.Clear();
                chartDoanhThu.Titles.Clear();
                chartDoanhThu.ChartAreas.Clear();
                chartDoanhThu.Legends.Clear();

                // Tạo ChartArea
                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.BackColor = Color.White;

                chartArea.AxisX.Title = "Ngày";
                chartArea.AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 10);
                chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisX.LabelStyle.Angle = -45;
                chartArea.AxisX.Interval = 1;

                chartArea.AxisY.Title = "Doanh thu (VNĐ)";
                chartArea.AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 10);
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

                chartDoanhThu.ChartAreas.Add(chartArea);

                // Tạo legend
                Legend legend = new Legend();
                legend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                legend.Docking = Docking.Top;
                chartDoanhThu.Legends.Add(legend);

                // Tạo series cột
                Series series = new Series("Doanh thu theo ngày");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.DodgerBlue;
                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.Black;
                series.BackGradientStyle = GradientStyle.VerticalCenter;
                series.BackSecondaryColor = Color.LightSkyBlue;
                series.BorderWidth = 1;
                series.BorderColor = Color.Gray;
                series.ShadowColor = Color.Gray;
                series.ShadowOffset = 2;

                // Truy vấn dữ liệu theo khoảng ngày được chọn (dùng định dạng ngày thường)
                string query = $@"
SELECT 
    CONVERT(DATE, PURCHASE_DATE) AS Ngay,
    SUM(PURCHASE_TOTAL) AS TongDoanhThu
FROM PURCHASE_HISTORY
WHERE CONVERT(DATE, PURCHASE_DATE) BETWEEN '{startDate:MM/dd/yyyy}' AND '{endDate:MM/dd/yyyy}'
GROUP BY CONVERT(DATE, PURCHASE_DATE)
ORDER BY Ngay ASC";

                DataTable dt = sqlServerConnection.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    DateTime ngay = Convert.ToDateTime(row["Ngay"]);
                    decimal tongDoanhThu = Convert.ToDecimal(row["TongDoanhThu"]);
                    series.Points.AddXY(ngay.ToString("dd/MM/yyyy"), tongDoanhThu);
                }

                chartDoanhThu.Series.Add(series);

                // Thêm tiêu đề cho chart
                Title chartTitle = new Title("BIỂU ĐỒ DOANH THU THEO NGÀY", Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.FromArgb(30, 30, 30));
                chartDoanhThu.Titles.Add(chartTitle);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu doanh thu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải biểu đồ: " + ex.Message);
            }
        }

        //    private void LoadChartTheoNgay()
        //        {
        //            try
        //            {
        //                DateTime startDate = dtstart.Value.Date;
        //                DateTime endDate = dtend.Value.Date;

        //                // Kiểm tra nếu ngày kết thúc nhỏ hơn ngày bắt đầu
        //                if (endDate < startDate)
        //                {
        //                    MessageBox.Show("Chọn sai ngày! Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return;
        //                }

        //                // Kiểm tra khoảng cách không vượt quá 30 ngày
        //                if ((endDate - startDate).TotalDays > 30)
        //                {
        //                    MessageBox.Show("Dữ liệu quá nhiều! Vui lòng chọn khoảng thời gian không quá 30 ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return;
        //                }

        //                // Reset chart
        //                chartDoanhThu.Series.Clear();
        //                chartDoanhThu.Titles.Clear();
        //                chartDoanhThu.ChartAreas.Clear();
        //                chartDoanhThu.Legends.Clear();

        //                // Tạo ChartArea
        //                ChartArea chartArea = new ChartArea("MainArea");
        //                chartArea.BackColor = Color.White;

        //                chartArea.AxisX.Title = "Ngày";
        //                chartArea.AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
        //                chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 10);
        //                chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
        //                chartArea.AxisX.LabelStyle.Angle = -45;
        //                chartArea.AxisX.Interval = 1;

        //                chartArea.AxisY.Title = "Doanh thu (VNĐ)";
        //                chartArea.AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
        //                chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 10);
        //                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

        //                chartDoanhThu.ChartAreas.Add(chartArea);

        //                // Tạo legend
        //                Legend legend = new Legend();
        //                legend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //                legend.Docking = Docking.Top;
        //                chartDoanhThu.Legends.Add(legend);

        //                // Tạo series cột
        //                Series series = new Series("Doanh thu theo ngày");
        //                series.ChartType = SeriesChartType.Column;
        //                series.Color = Color.DodgerBlue;
        //                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //                series.IsValueShownAsLabel = true;
        //                series.LabelForeColor = Color.Black;
        //                series.BackGradientStyle = GradientStyle.VerticalCenter;
        //                series.BackSecondaryColor = Color.LightSkyBlue;
        //                series.BorderWidth = 1;
        //                series.BorderColor = Color.Gray;
        //                series.ShadowColor = Color.Gray;
        //                series.ShadowOffset = 2;

        //                // Truy vấn dữ liệu theo khoảng ngày được chọn
        //                string query = @"
        //```

        //SELECT
        //CONVERT(DATE, PURCHASE\_DATE) AS Ngay,
        //SUM(PURCHASE\_TOTAL) AS TongDoanhThu
        //FROM PURCHASE\_HISTORY
        //WHERE CONVERT(DATE, PURCHASE\_DATE) BETWEEN @startDate AND @endDate
        //GROUP BY CONVERT(DATE, PURCHASE\_DATE)
        //ORDER BY Ngay ASC";

        //```
        //            SqlParameter[] parameters = new SqlParameter[]
        //            {
        //        new SqlParameter("@startDate", startDate),
        //        new SqlParameter("@endDate", endDate)
        //            };

        //                DataTable dt = sqlServerConnection.ExecuteQuery(query, parameters);

        //                foreach (DataRow row in dt.Rows)
        //                {
        //                    DateTime ngay = Convert.ToDateTime(row["Ngay"]);
        //                    decimal tongDoanhThu = Convert.ToDecimal(row["TongDoanhThu"]);
        //                    series.Points.AddXY(ngay.ToString("dd/MM/yyyy"), tongDoanhThu);
        //                }

        //                chartDoanhThu.Series.Add(series);

        //                // Thêm tiêu đề cho chart
        //                Title chartTitle = new Title("BIỂU ĐỒ DOANH THU THEO NGÀY", Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.FromArgb(30, 30, 30));
        //                chartDoanhThu.Titles.Add(chartTitle);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Lỗi khi tải biểu đồ: " + ex.Message);
        //            }
        //        }
        //        trong excutequery chỉ có 1 tham số  public DataTable ExecuteQuery(string query)
        //```

        //{
        //try
        //{
        //OpenConnection();
        //        SqlCommand command = new SqlCommand(query, connection);
        //        SqlDataAdapter adapter = new SqlDataAdapter(command);
        //        DataTable dataTable = new DataTable();
        //        adapter.Fill(dataTable);
        //return dataTable;

        //```
        // }
        // catch (Exception ex)
        // {
        //     throw new Exception("Error ExecuteQuery: ", ex);
        //}
        // finally
        // {
        //    CloseConnection();
        //}
        //```

        //} 


        private void LoadChartTheoThang()
        {
            try
            {
                // Lấy tháng/năm từ dtstart và dtend, đặt ngày = 1 để bỏ qua ngày
                DateTime startMonth = new DateTime(dtstart.Value.Year, dtstart.Value.Month, 1);
                DateTime endMonth = new DateTime(dtend.Value.Year, dtend.Value.Month, 1);

                // Kiểm tra hợp lệ
                if (endMonth < startMonth)
                {
                    MessageBox.Show("Chọn sai tháng! Tháng kết thúc phải lớn hơn hoặc bằng tháng bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Giới hạn không quá 24 tháng
                int monthDiff = ((endMonth.Year - startMonth.Year) * 12) + endMonth.Month - startMonth.Month;
                if (monthDiff > 23) // 0-based index: 0 là cùng tháng, 23 là 24 tháng
                {
                    MessageBox.Show("Vui lòng chọn khoảng thời gian không quá 24 tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Reset biểu đồ
                chartDoanhThu.Series.Clear();
                chartDoanhThu.Titles.Clear();
                chartDoanhThu.ChartAreas.Clear();
                chartDoanhThu.Legends.Clear();

                // ChartArea
                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.BackColor = Color.White;

                chartArea.AxisX.Title = "Tháng";
                chartArea.AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 10);
                chartArea.AxisX.LabelStyle.Angle = -45;
                chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisX.Interval = 1;

                chartArea.AxisY.Title = "Doanh thu (VNĐ)";
                chartArea.AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 10);
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

                chartDoanhThu.ChartAreas.Add(chartArea);

                // Legend
                Legend legend = new Legend();
                legend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                legend.Docking = Docking.Top;
                chartDoanhThu.Legends.Add(legend);

                // Series
                Series series = new Series("Doanh thu theo tháng");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.MediumSeaGreen;
                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.Black;
                series.BackGradientStyle = GradientStyle.VerticalCenter;
                series.BackSecondaryColor = Color.LightGreen;
                series.BorderWidth = 1;
                series.BorderColor = Color.DarkGreen;
                series.ShadowColor = Color.Gray;
                series.ShadowOffset = 2;

                // Truy vấn SQL: doanh thu theo tháng trong khoảng đã chọn
                string query = $@"
            SELECT 
                FORMAT(PURCHASE_DATE, 'MM/yyyy') AS ThangNam,
                SUM(PURCHASE_TOTAL) AS TongDoanhThu
            FROM PURCHASE_HISTORY
            WHERE PURCHASE_DATE >= '{startMonth:yyyy-MM-dd}' AND PURCHASE_DATE < '{endMonth.AddMonths(1):yyyy-MM-dd}'
            GROUP BY FORMAT(PURCHASE_DATE, 'MM/yyyy')
            ORDER BY MIN(PURCHASE_DATE)";

                DataTable dt = sqlServerConnection.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    string thangNam = row["ThangNam"].ToString();
                    decimal tongDoanhThu = Convert.ToDecimal(row["TongDoanhThu"]);
                    series.Points.AddXY(thangNam, tongDoanhThu);
                }

                chartDoanhThu.Series.Add(series);

                // Tiêu đề
                Title chartTitle = new Title("BIỂU ĐỒ DOANH THU THEO THÁNG", Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.FromArgb(30, 30, 30));
                chartDoanhThu.Titles.Add(chartTitle);

                // Thông báo nếu không có dữ liệu
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu doanh thu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải biểu đồ theo tháng: " + ex.Message);
            }
        }

        private void btnTheoNam_Click(object sender, EventArgs e)
        {
            LoadChartTheoNam();
        }
        private void LoadChartTheoNam()
        {
            try
            {
                // Reset chart
                chartDoanhThu.Series.Clear();
                chartDoanhThu.Titles.Clear();
                chartDoanhThu.ChartAreas.Clear();
                chartDoanhThu.Legends.Clear();

                // ChartArea
                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.BackColor = Color.White;

                chartArea.AxisX.Title = "Năm";
                chartArea.AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 10);
                chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisX.Interval = 1;

                chartArea.AxisY.Title = "Doanh thu (VNĐ)";
                chartArea.AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 10);
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

                chartDoanhThu.ChartAreas.Add(chartArea);

                // Legend
                Legend legend = new Legend();
                legend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                legend.Docking = Docking.Top;
                chartDoanhThu.Legends.Add(legend);

                // Series
                Series series = new Series("Doanh thu theo năm");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.SteelBlue;
                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.Black;
                series.BackGradientStyle = GradientStyle.VerticalCenter;
                series.BackSecondaryColor = Color.LightBlue;
                series.BorderWidth = 1;
                series.BorderColor = Color.DarkBlue;
                series.ShadowColor = Color.Gray;
                series.ShadowOffset = 2;

                // Truy vấn SQL: tổng doanh thu theo năm
                string query = @"
            SELECT 
                YEAR(PURCHASE_DATE) AS Nam,
                SUM(PURCHASE_TOTAL) AS TongDoanhThu
            FROM PURCHASE_HISTORY
            GROUP BY YEAR(PURCHASE_DATE)
            ORDER BY Nam ASC";

                DataTable dt = sqlServerConnection.ExecuteQuery(query);

                foreach (DataRow row in dt.Rows)
                {
                    string nam = row["Nam"].ToString();
                    decimal tongDoanhThu = Convert.ToDecimal(row["TongDoanhThu"]);
                    series.Points.AddXY(nam, tongDoanhThu);
                }

                chartDoanhThu.Series.Add(series);

                // Tiêu đề biểu đồ
                Title chartTitle = new Title("BIỂU ĐỒ DOANH THU THEO NĂM", Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.FromArgb(30, 30, 30));
                chartDoanhThu.Titles.Add(chartTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải biểu đồ theo năm: " + ex.Message);
            }
        }

        private void chartDoanhThu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấn vào biểu đồ doanh thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnTheoThang_Click(object sender, EventArgs e)
        {
            LoadChartTheoThang();
        }
    }
}
