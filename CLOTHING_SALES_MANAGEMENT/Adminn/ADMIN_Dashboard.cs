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

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class ADMIN_Dashboard : MetroFramework.Forms.MetroForm
    {
        public ADMIN_Dashboard()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            // Giả lập dữ liệu cho biểu đồ  
            chartDashboard.Series.Clear();
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu mẫu  
            series.Points.AddXY("Tháng 1", 120);
            series.Points.AddXY("Tháng 2", 150);
            series.Points.AddXY("Tháng 3", 90);
            series.Points.AddXY("Tháng 4", 180);

            chartDashboard.Series.Add(series);
        }
    }
}
