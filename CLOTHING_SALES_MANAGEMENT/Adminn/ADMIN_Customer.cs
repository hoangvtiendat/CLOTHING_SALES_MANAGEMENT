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
    public partial class frmAdminCustomer : MetroFramework.Forms.MetroForm
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();

        public frmAdminCustomer()
        {
            InitializeComponent();
            LoadData();
            ResetFields();
        }

        public void LoadData()
        {
            string query = "SELECT * FROM customer";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
        }

        public void ResetFields()
        {
            txtTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTimKim.Text = "";
            lbl_ID.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ TÊN, SỐ ĐIỆN THOẠI VÀ ĐỊA CHỈ");
                return;
            }

            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            // CUSTOMER_PHONENUMBER
            string query = $@"
                INSERT INTO customer (customer_name, customer_address, CUSTOMER_PHONENUMBER)
                VALUES (N'{ten}', N'{diaChi}', '{sdt}')
            ";

            int result = sqlServerConnection.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("THÊM THÀNH CÔNG");
                LoadData();
                ResetFields();
            }
            else
            {
                MessageBox.Show("THÊM THẤT BẠI");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ TÊN, SỐ ĐIỆN THOẠI VÀ ĐỊA CHỈ");
                return;
            }

            if (!int.TryParse(lbl_ID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("VUI LÒNG CHỌN KHÁCH HÀNG CẦN SỬA");
                return;
            }

            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;

            string query = $@"
                UPDATE customer
                SET customer_name = N'{ten}',
                    customer_address = N'{diaChi}',
                    CUSTOMER_PHONENUMBER = '{sdt}'
                WHERE customer_id = {id}
            ";

            int result = sqlServerConnection.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("CẬP NHẬT THÔNG TIN KHÁCH HÀNG THÀNH CÔNG");
                LoadData();
                ResetFields();
            }
            else
            {
                MessageBox.Show("CẬP NHẬT THẤT BẠI");
            }
        }

   

        private void rdTang_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customer ORDER BY customer_name ASC";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
        }

        private void rdGiam_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customer ORDER BY customer_name DESC";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKim.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP TÊN KHÁCH HÀNG CẦN TÌM KIẾM");
                return;
            }

            string timKiem = txtTimKim.Text;
            string query = $@"SELECT * FROM customer WHERE customer_name LIKE N'%{timKiem}%'";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["customer_id"].Value != null)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                lbl_ID.Text = row.Cells["customer_id"].Value?.ToString();
                txtTen.Text = row.Cells["customer_name"].Value?.ToString();
                txtDiaChi.Text = row.Cells["customer_address"].Value?.ToString();
                txtSDT.Text = row.Cells["CUSTOMER_PHONENUMBER"].Value?.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không cần xử lý ở đây nếu không dùng.
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
    }
}
