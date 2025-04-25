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
    public partial class Manage: MetroFramework.Forms.MetroForm
    {
        public Manage()
        {
            InitializeComponent();
        }

        // Hàm dùng để mở form con
        private void OpenChildForm(Form childForm)
        {
            // Ẩn groupbox
            grmanage.Visible = false;

            // Đóng tất cả form con đang mở và gỡ sự kiện đã gán
            foreach (Form frm in this.MdiChildren)
            {
                frm.FormClosed -= ChildFormClosedHandler;
                frm.Close();
            }

            // Cấu hình form con
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.FormClosed += ChildFormClosedHandler;
            childForm.Show();
        }

        // Hàm xử lý khi form con đóng
        private void ChildFormClosedHandler(object sender, FormClosedEventArgs e)
        {
            // Kiểm tra khi không còn form con nào mở
            if (this.MdiChildren.Length == 0) // Kiểm tra MdiChildren.Length thay vì Count
            {
                // Đảm bảo thao tác với giao diện trên thread chính
                if (grmanage.InvokeRequired)
                {
                    grmanage.Invoke((Action)(() => grmanage.Visible = true));
                }
                else
                {
                    grmanage.Visible = true;
                }
            }
        }
        // Các sự kiện MenuStrip gọi form con

        private void custommnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer_frm());
        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account_frm());
        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EMPLOYEE_frm());
        }

        private void mnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product_frm());
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PuchaseHistory_frm());
        }

        // Biểu đồ Doanh thu - không liên quan đến form MDI, giữ nguyên
      
        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void chartDoanhThu_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> doanhThu = new Dictionary<string, double>
    {
        { "Tháng 1", 1000 },
        { "Tháng 2", 1500 },
        { "Tháng 3", 1800 },
        { "Tháng 4", 1200 },
        { "Tháng 5", 2000 }
    };

            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add("Biểu đồ Doanh thu theo tháng");
            chartDoanhThu.ChartAreas[0].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";

            var series = chartDoanhThu.Series.Add("Doanh thu");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (var item in doanhThu)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
        }
    }
}

