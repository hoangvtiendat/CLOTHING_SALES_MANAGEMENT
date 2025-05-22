using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmAdminPurcharHistory : MetroFramework.Forms.MetroForm
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();
        public frmAdminPurcharHistory()
        {
            InitializeComponent();
        }

        public void loadHoaDon(DateTime start, DateTime end)
        {
            string startDateString = start.ToString("yyyy-MM-dd");
            string endDateString = end.ToString("yyyy-MM-dd");

            string query = $"SELECT * FROM PURCHASE_HISTORY " +
                           $"WHERE PURCHASE_DATE >= '{startDateString}' AND PURCHASE_DATE <= '{endDateString}'";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime start = dtStart.Value.Date;
            DateTime end = dtEnd.Value.Date;

            //check start < end
            if (start > end)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc");
                return;
            }
            loadHoaDon(start, end);
        }
    }
}
