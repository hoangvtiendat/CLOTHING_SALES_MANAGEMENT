using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmAdminEmployee : MetroFramework.Forms.MetroForm
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();
        public frmAdminEmployee()
        {
            InitializeComponent();
            loadData();
        }


        public void reset()
        {
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
            txtTimKiem.Text = "";
        }

        public void loadData()
        {
            string query = "select * from EMPLOYEE";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN");
                return;
            }
            if (txtEmail.Text.Contains("@") == false)
            {
                MessageBox.Show("EMAIL KHÔNG HỢP LỆ");
                return;
            }

            if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ");
                return;
            }

            string diachi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string ten = txtTen.Text;

            var checkEmailQuery = $"SELECT COUNT(*) FROM EMPLOYEE WHERE EMPLOYEE_EMAIL = '{email}'";
            var checkEmailCommand = sqlServerConnection.ExecuteScalar(checkEmailQuery);

            if (checkEmailCommand != null && Convert.ToInt32(checkEmailCommand) > 0)
            {
                MessageBox.Show("EMAIL ĐÃ TỒN TẠI");
                return;
            }


            var checkSDTQuery = $"SELECT COUNT(*) FROM EMPLOYEE WHERE EMPLOYEE_PHONENUMBER = '{sdt}'";
            var checkSDTCommand = sqlServerConnection.ExecuteScalar(checkSDTQuery);

            if (checkSDTCommand != null && Convert.ToInt32(checkSDTCommand) > 0)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI ĐÃ TỒN TẠI");
                return;
            }

            string insertQuery = $"insert into EMPLOYEE (EMPLOYEE_NAME, EMPLOYEE_EMAIL, EMPLOYEE_ADDRESS, EMPLOYEE_PHONENUMBER) values ('{ten}', '{email}', '{diachi}', '{sdt}' )";

            int rowsAffected = sqlServerConnection.ExecuteNonQuery(insertQuery);

            if (rowsAffected > 0)
            {
                MessageBox.Show("THÊM NHÂN VIÊN THÀNH CÔNG");
                // Có thể reset các textbox ở đây
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ THÊM NHÂN VIÊN");
            }


            reset();
            loadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
            loadData();

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lblMaNhanVien.Text == "")
            {
                MessageBox.Show("VUi LÒNG CHỌN NHÂN VIÊN ĐỂ CẬP NHẬT");
                return;
            }
            if (txtDiaChi.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐẦY ĐỦ THÔNG TIN");
                return;
            }
            if (txtEmail.Text.Contains("@") == false)
            {
                MessageBox.Show("EMAIL KHÔNG HỢP LỆ");
                return;
            }
            if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ");
                return;
            }
            string query = $"UPDATE EMPLOYEE SET EMPLOYEE_NAME = '{txtTen.Text}', EMPLOYEE_EMAIL = '{txtEmail.Text}', EMPLOYEE_ADDRESS = '{txtDiaChi.Text}', EMPLOYEE_PHONENUMBER = '{txtSDT.Text}' WHERE EMPLOYEE_NAME = '{lblMaNhanVien.Text}'";
            int rowsAffected = sqlServerConnection.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("CẬP NHẬT THÀNH CÔNG");
                reset();
                loadData();
            }
            else
            {
                MessageBox.Show("CẬP NHẬT KHÔNG THÀNH CÔNG");
                reset();
                loadData();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lblMaNhanVien.Text = row.Cells["EMPLOYEE_NAME"].Value.ToString();
                txtDiaChi.Text = row.Cells["EMPLOYEE_ADDRESS"].Value.ToString();
                txtEmail.Text = row.Cells["EMPLOYEE_EMAIL"].Value.ToString();
                txtSDT.Text = row.Cells["EMPLOYEE_PHONENUMBER"].Value.ToString();
                txtTen.Text = row.Cells["EMPLOYEE_NAME"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lblMaNhanVien.Text == "")
            {
                MessageBox.Show("VUI LÒNG CHỌN NHÂN VIÊN MUỐN XÓA");
                return;
            }

            string query = $"DELETE FROM EMPLOYEE WHERE EMPLOYEE_NAME = '{lblMaNhanVien.Text}'";
            int rowsAffected = sqlServerConnection.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("XÓA NHÂN VIÊN THÀNH CÔNG");
                reset();
                loadData();
            }
            else
            {
                MessageBox.Show("XÓA NHÂN VIÊN KHÔNG THÀNH CÔNG");
                reset();
                loadData();
            }
        }

        private void rdTang_CheckedChanged(object sender, EventArgs e)
        {
            //sắp xếp tăng dần
            string query = "SELECT * FROM EMPLOYEE ORDER BY EMPLOYEE_NAME ASC";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;


        }

        private void rdGiam_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM EMPLOYEE ORDER BY EMPLOYEE_NAME DESC";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("VUI LÒNG NHẬP TÊN NHÂN VIÊN CẦN TÌM KIẾM");
                return;
            }
            string query = $"SELECT * FROM EMPLOYEE WHERE EMPLOYEE_NAME LIKE '%{txtTimKiem.Text}%'";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            if (list.Rows.Count == 0)
            {
                MessageBox.Show("KHÔNG TÌM THẤY NHÂN VIÊN NÀO");
                return;
            }
        }
    }
}
