﻿using System;
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
    public partial class frmAdminManage : MetroFramework.Forms.MetroForm
    {
        public frmAdminManage()
        {
            InitializeComponent();
            this.Width = 1200;
            this.Height = 1200;

        }

        // Hàm dùng để mở form con
        private void OpenChildForm(Form childForm)
        {
            // Ẩn groupbox


            // Đóng tất cả form con đang mở và gỡ sự kiện đã gán
            foreach (Form frm in this.MdiChildren)
            {

                frm.Close();
            }

            // Cấu hình form con
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;

            childForm.Show();
        }

        // Hàm xử lý khi form con đóng

        // Các sự kiện MenuStrip gọi form con

        private void custommnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdminCustomer());
        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdminAccount());
        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdminEmployee());
        }

        private void mnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdminProduct());
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdminPurcharHistory());
        }

        // Biểu đồ Doanh thu - không liên quan đến form MDI, giữ nguyên

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void mnstripThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdminDashboard());
        }

        private void frmAdminManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
            }
            catch (ObjectDisposedException ex)
            {
                // Ghi log lỗi hoặc thực hiện hành động phù hợp
                System.Diagnostics.Debug.WriteLine($"Lỗi khi đóng form con: {ex.Message}");
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               var loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
        }
    }
}

