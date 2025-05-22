using System;
using System.Data;
using System.Windows.Forms;

namespace CLOTHING_SALES_MANAGEMENT
{
    public partial class frmAdminAccount : MetroFramework.Forms.MetroForm
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();

        public frmAdminAccount()
        {
            InitializeComponent();
            loadRole();
            loadData();
        }

        public void loadData()
        {
            string query = @"SELECT * FROM ACCOUNT a, ROLE r WHERE a.ROLE_ID = r.ROLE_ID";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
        }

        public void loadRole()
        {
            string query = @"SELECT * FROM ROLE";
            var list = sqlServerConnection.ExecuteQuery(query);
            cboViTri.DataSource = list;
            cboViTri.ValueMember = "ROLE_ID";
            cboViTri.DisplayMember = "ROLE_NAME";
        }

        public void reset()
        {
            txtTenTK.Text = "";
            txtPassword.Text = "";
            cboViTri.SelectedIndex = 0;
            txtTimKim.Text = "";
            lbl_ID.Text = ""; // FIXED: Reset cả ID sau khi cập nhật hoặc thao tác
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("CHƯA NHẬP TÊN TÀI KHOẢN HOẶC MẬT KHẨU");
                return;
            }

            string ten = txtTenTK.Text.Trim();
            string checkquery = $@"SELECT COUNT(*) FROM ACCOUNT WHERE ACCOUNT_USERNAME = N'{ten}'";
            int count = (int)sqlServerConnection.ExecuteScalar(checkquery);

            if (count > 0)
            {
                MessageBox.Show("TÊN TÀI KHOẢN ĐÃ TỒN TẠI");
                return;
            }

            string pass = txtPassword.Text.Trim();
            int role_id = (int)cboViTri.SelectedValue;

            string query = $@"INSERT INTO ACCOUNT(ACCOUNT_USERNAME, ACCOUNT_PASSWORD, ROLE_ID)
                              VALUES (N'{ten}', N'{pass}', '{role_id}')";
            int result = sqlServerConnection.ExecuteNonQuery(query);

            if (result > 0)
            {
                MessageBox.Show("THÊM THÀNH CÔNG");
                loadData();
                reset();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("CHƯA NHẬP TÊN TÀI KHOẢN HOẶC MẬT KHẨU");
                return;
            }

            if (string.IsNullOrWhiteSpace(lbl_ID.Text))
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN ĐỂ CẬP NHẬT");
                return;
            }

            string ten = txtTenTK.Text.Trim();
            string pass = txtPassword.Text.Trim();
            int role_id = (int)cboViTri.SelectedValue;
            int id = int.Parse(lbl_ID.Text);

            string query = $@"UPDATE ACCOUNT
                              SET ACCOUNT_USERNAME = N'{ten}',
                                  ACCOUNT_PASSWORD = N'{pass}',
                                  ROLE_ID = '{role_id}'
                              WHERE ACCOUNT_ID = '{id}'";
            int rs = sqlServerConnection.ExecuteNonQuery(query);

            if (rs > 0)
            {
                MessageBox.Show("CẬP NHẬT THÀNH CÔNG");
                loadData();
                reset();
            }
            else
            {
                MessageBox.Show("CẬP NHẬT THẤT BẠI");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_ID.Text))
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN ĐỂ XÓA");
                return;
            }

            if (!int.TryParse(lbl_ID.Text, out int id))
            {
                MessageBox.Show("ID KHÔNG HỢP LỆ");
                return;
            }

            DialogResult dialog = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA KHÔNG?",
                                                  "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                string query = $@"DELETE FROM ACCOUNT WHERE ACCOUNT_ID = {id}";
                int rs = sqlServerConnection.ExecuteNonQuery(query);

                if (rs > 0)
                {
                    MessageBox.Show("XÓA THÀNH CÔNG");
                    loadData();
                    reset();
                }
                else
                {
                    MessageBox.Show("XÓA THẤT BẠI");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
            loadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKim.Text.Trim();
            if (string.IsNullOrWhiteSpace(timkiem))
            {
                MessageBox.Show("CHƯA NHẬP TÊN ĐỂ TÌM KIẾM");
                return;
            }

            string query = $@"SELECT * FROM ACCOUNT a, ROLE r 
                              WHERE a.ROLE_ID = r.ROLE_ID 
                              AND ACCOUNT_USERNAME LIKE N'%{timkiem}%'";
            var list = sqlServerConnection.ExecuteQuery(query);

            if (list == null || list.Rows.Count == 0)
            {
                MessageBox.Show("KHÔNG TÌM THẤY TÀI KHOẢN VỚI TÊN TÌM KIẾM");
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.DataSource = list;
            }
        }

        private void rdTang_CheckedChanged(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM ACCOUNT a, ROLE r WHERE a.ROLE_ID = r.ROLE_ID ORDER BY ACCOUNT_USERNAME ASC";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
        }

        private void rdGiam_CheckedChanged(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM ACCOUNT a, ROLE r WHERE a.ROLE_ID = r.ROLE_ID ORDER BY ACCOUNT_USERNAME DESC";
            var list = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                lbl_ID.Text = row.Cells["ACCOUNT_ID"].Value?.ToString();
                txtTenTK.Text = row.Cells["ACCOUNT_USERNAME"].Value?.ToString();
                txtPassword.Text = row.Cells["ACCOUNT_PASSWORD"].Value?.ToString();
                cboViTri.SelectedValue = row.Cells["ROLE_ID"].Value;
            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            // Không sử dụng
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không sử dụng
        }
    }
}
