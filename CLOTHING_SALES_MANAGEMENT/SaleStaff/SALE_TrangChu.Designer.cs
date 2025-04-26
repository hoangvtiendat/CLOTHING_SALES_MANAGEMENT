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
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(27, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1881, 614);
            this.panel2.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(39, 198);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "DANH MỤC";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(753, 202);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 25);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "SẮP XẾP";
            // 
            // cbSapXep
            // 
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.ItemHeight = 23;
            this.cbSapXep.Location = new System.Drawing.Point(981, 202);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(310, 29);
            this.cbSapXep.TabIndex = 26;
            this.cbSapXep.UseSelectable = true;
            this.cbSapXep.SelectedIndexChanged += new System.EventHandler(this.cbSapXep_SelectedIndexChanged);
            // 
            // txtTenSanPham
            // 
            // 
            // 
            // 
            this.txtTenSanPham.CustomButton.Image = null;
            this.txtTenSanPham.CustomButton.Location = new System.Drawing.Point(519, 1);
            this.txtTenSanPham.CustomButton.Name = "";
            this.txtTenSanPham.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txtTenSanPham.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenSanPham.CustomButton.TabIndex = 1;
            this.txtTenSanPham.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenSanPham.CustomButton.UseSelectable = true;
            this.txtTenSanPham.CustomButton.Visible = false;
            this.txtTenSanPham.Lines = new string[0];
            this.txtTenSanPham.Location = new System.Drawing.Point(707, 75);
            this.txtTenSanPham.MaxLength = 32767;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.PasswordChar = '\0';
            this.txtTenSanPham.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenSanPham.SelectedText = "";
            this.txtTenSanPham.SelectionLength = 0;
            this.txtTenSanPham.SelectionStart = 0;
            this.txtTenSanPham.ShortcutsEnabled = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(563, 45);
            this.txtTenSanPham.TabIndex = 27;
            this.txtTenSanPham.UseSelectable = true;
            this.txtTenSanPham.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenSanPham.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1393, 75);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(40, 45);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "🔍";
            this.metroButton1.UseSelectable = true;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.ItemHeight = 23;
            this.cbDanhMuc.Location = new System.Drawing.Point(293, 198);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(350, 29);
            this.cbDanhMuc.TabIndex = 29;
            this.cbDanhMuc.UseSelectable = true;
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGioHang.Location = new System.Drawing.Point(1715, 153);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(193, 121);
            this.btnGioHang.TabIndex = 30;
            this.btnGioHang.Text = "GIỎ HÀNG";
            this.btnGioHang.UseVisualStyleBackColor = false;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click_1);
            // 
            // frmSaleTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1966, 1074);
            this.Controls.Add(this.btnGioHang);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmSaleTrangChu";
            this.Padding = new System.Windows.Forms.Padding(22, 62, 22, 21);
            this.Text = "SALE STAFF";
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
    }
}