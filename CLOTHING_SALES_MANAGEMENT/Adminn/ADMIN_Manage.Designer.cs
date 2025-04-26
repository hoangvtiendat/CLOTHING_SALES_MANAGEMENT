namespace CLOTHING_SALES_MANAGEMENT
{
    partial class frmAdminManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnstripNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripSanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripLichSuMuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnstripNhanVien,
            this.mnstripTaiKhoan,
            this.mnstripSanpham,
            this.mnstripKhachHang,
            this.mnstripLichSuMuaHang,
            this.mnstripThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(30, 94);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1502, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnstripNhanVien
            // 
            this.mnstripNhanVien.Name = "mnstripNhanVien";
            this.mnstripNhanVien.Size = new System.Drawing.Size(264, 36);
            this.mnstripNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            this.mnstripNhanVien.Click += new System.EventHandler(this.employeeManagementToolStripMenuItem_Click);
            // 
            // mnstripTaiKhoan
            // 
            this.mnstripTaiKhoan.Name = "mnstripTaiKhoan";
            this.mnstripTaiKhoan.Size = new System.Drawing.Size(259, 36);
            this.mnstripTaiKhoan.Text = "QUẢN LÝ TÀI KHOẢN";
            this.mnstripTaiKhoan.Click += new System.EventHandler(this.accountManagementToolStripMenuItem_Click);
            // 
            // mnstripSanpham
            // 
            this.mnstripSanpham.Name = "mnstripSanpham";
            this.mnstripSanpham.Size = new System.Drawing.Size(258, 36);
            this.mnstripSanpham.Text = "QUẢN LÝ SẢN PHẨM";
            this.mnstripSanpham.Click += new System.EventHandler(this.mnProduct_Click);
            // 
            // mnstripKhachHang
            // 
            this.mnstripKhachHang.Name = "mnstripKhachHang";
            this.mnstripKhachHang.Size = new System.Drawing.Size(289, 36);
            this.mnstripKhachHang.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.mnstripKhachHang.Click += new System.EventHandler(this.custommnerToolStripMenuItem_Click);
            // 
            // mnstripLichSuMuaHang
            // 
            this.mnstripLichSuMuaHang.Name = "mnstripLichSuMuaHang";
            this.mnstripLichSuMuaHang.Size = new System.Drawing.Size(252, 36);
            this.mnstripLichSuMuaHang.Text = "LỊCH SỬ MUA HÀNG";
            this.mnstripLichSuMuaHang.Click += new System.EventHandler(this.purchaseHistoryToolStripMenuItem_Click);
            // 
            // mnstripThongKe
            // 
            this.mnstripThongKe.Name = "mnstripThongKe";
            this.mnstripThongKe.Size = new System.Drawing.Size(149, 36);
            this.mnstripThongKe.Text = "THỐNG KÊ";
            this.mnstripThongKe.Click += new System.EventHandler(this.mnstripThongKe_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmAdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 961);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminManage";
            this.Padding = new System.Windows.Forms.Padding(30, 94, 30, 31);
            this.Text = "QUẢN LÝ";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Manage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnstripNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnstripTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnstripSanpham;
        private System.Windows.Forms.ToolStripMenuItem mnstripKhachHang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnstripLichSuMuaHang;
        private System.Windows.Forms.ToolStripMenuItem mnstripThongKe;
    }
}