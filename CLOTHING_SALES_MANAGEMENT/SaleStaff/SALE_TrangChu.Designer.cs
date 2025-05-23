namespace CLOTHING_SALES_MANAGEMENT
{
    partial class frmSaleTrangChu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbSapXep = new MetroFramework.Controls.MetroComboBox();
            this.txtTenSanPham = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbDanhMuc = new MetroFramework.Controls.MetroComboBox();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btnDangXuat = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(18, 207);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 518);
            this.panel2.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(26, 127);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "DANH MỤC";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(502, 129);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "SẮP XẾP";
            // 
            // cbSapXep
            // 
            this.cbSapXep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cbSapXep.ForeColor = System.Drawing.Color.White;
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.ItemHeight = 24;
            this.cbSapXep.Location = new System.Drawing.Point(654, 129);
            this.cbSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(208, 30);
            this.cbSapXep.TabIndex = 26;
            this.cbSapXep.UseSelectable = true;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged_1);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenSanPham.CustomButton.Image = null;
            this.txtTenSanPham.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtTenSanPham.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSanPham.CustomButton.Name = "";
            this.txtTenSanPham.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTenSanPham.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenSanPham.CustomButton.TabIndex = 1;
            this.txtTenSanPham.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenSanPham.CustomButton.UseSelectable = true;
            this.txtTenSanPham.CustomButton.Visible = false;
            this.txtTenSanPham.ForeColor = System.Drawing.Color.Black;
            this.txtTenSanPham.Lines = new string[0];
            this.txtTenSanPham.Location = new System.Drawing.Point(471, 69);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSanPham.MaxLength = 32767;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.PasswordChar = '\0';
            this.txtTenSanPham.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenSanPham.SelectedText = "";
            this.txtTenSanPham.SelectionLength = 0;
            this.txtTenSanPham.SelectionStart = 0;
            this.txtTenSanPham.ShortcutsEnabled = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(375, 29);
            this.txtTenSanPham.TabIndex = 27;
            this.txtTenSanPham.UseSelectable = true;
            this.txtTenSanPham.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenSanPham.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenSanPham.Click += new System.EventHandler(this.txtTenSanPham_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(884, 69);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 29);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "TÌM KIẾM";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.cbDanhMuc.ForeColor = System.Drawing.Color.White;
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.ItemHeight = 24;
            this.cbDanhMuc.Location = new System.Drawing.Point(196, 127);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(235, 30);
            this.cbDanhMuc.TabIndex = 29;
            this.cbDanhMuc.UseSelectable = true;
            this.cbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc_SelectedIndexChanged);
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGioHang.FlatAppearance.BorderSize = 0;
            this.btnGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioHang.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnGioHang.ForeColor = System.Drawing.Color.White;
            this.btnGioHang.Location = new System.Drawing.Point(1049, 107);
            this.btnGioHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(215, 57);
            this.btnGioHang.TabIndex = 30;
            this.btnGioHang.Text = "GIỎ HÀNG";
            this.btnGioHang.UseVisualStyleBackColor = false;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(1049, 168);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(215, 29);
            this.btn_load.TabIndex = 31;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(1149, 42);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(115, 30);
            this.btnDangXuat.TabIndex = 32;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseSelectable = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmSaleTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1311, 733);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btnGioHang);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSaleTrangChu";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 13);
            this.Text = "SALE STAFF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSaleTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.frmSaleTrangChu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbSapXep;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTenSanPham;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cbDanhMuc;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.Button btn_load;
        private MetroFramework.Controls.MetroButton btnDangXuat;
    }
}
