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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("VUI LÒNG NHẬP ĐỦ TÊN ĐĂNG NHẬP VÀ MẬT KHẨU", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    string query = $"SELECT ACCOUNT_ID  FROM ACCOUNT WHERE ACCOUNT_USERNAME = '{username}' AND ACCOUNT_PASSWORD = '{password}'";

                    object rs = sqlServerConnection.ExecuteScalar(query);
                    int accountID = Convert.ToInt32(rs);
                    if (accountID == 0)
                    {
                        throw new Exception("TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU SAI");
                    }
                    //check role
                    string roleQuery = $"SELECT ROLE_NAME FROM ACCOUNT a JOIN ROLE r ON a.ROLE_ID = r.ROLE_ID WHERE a.ACCOUNT_ID = {accountID}";
                    var role = sqlServerConnection.ExecuteScalar(roleQuery);

                    if (role.ToString() == "")
                    {
                        MessageBox.Show("NGƯỜI DÙNG NÀY KHÔNG CÓ VAI TRÒ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;


                    }
                    else
                    {
                        if (role.ToString().Trim() == "QUẢN LÝ")
                        {

                            var adminForm = new frmAdminManage();
                            adminForm.Show();
                            this.Hide();
                            return;
                        }

                        if (role.ToString().Trim() == "NHÂN VIÊN BÁN HÀNG")
                        {
                            var staffForm = new frmSaleTrangChu();
                            staffForm.Show();
                            this.Hide();
                            return;
                        }

                        if (role.ToString().Trim() == "QUẢN LÝ KHO")
                        {
                            var warehouseForm = new frmHousewareManagerDM();
                            warehouseForm.Show();
                            this.Hide();
                            return;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI: " + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
