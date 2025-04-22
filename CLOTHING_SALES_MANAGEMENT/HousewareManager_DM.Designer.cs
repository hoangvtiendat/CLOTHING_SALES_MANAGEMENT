namespace CLOTHING_SALES_MANAGEMENT
{
    partial class HousewareManager_DM
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.metroLabelTitle = new MetroFramework.Controls.MetroLabel();
            this.comboDanhMuc = new MetroFramework.Controls.MetroComboBox();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.panelThemDanhMuc = new System.Windows.Forms.Panel();
            this.txtTenDanhMuc = new MetroFramework.Controls.MetroTextBox();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panelHeader.SuspendLayout();
            this.panelThemDanhMuc.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelHeader.Controls.Add(this.metroLabelTitle);
            this.panelHeader.Controls.Add(this.comboDanhMuc);
            this.panelHeader.Controls.Add(this.btnThem);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(20, 60);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(912, 79);
            this.panelHeader.TabIndex = 0;
            // 
            // metroLabelTitle
            // 
            this.metroLabelTitle.AutoSize = true;
            this.metroLabelTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelTitle.Location = new System.Drawing.Point(47, 27);
            this.metroLabelTitle.Name = "metroLabelTitle";
            this.metroLabelTitle.Size = new System.Drawing.Size(118, 25);
            this.metroLabelTitle.TabIndex = 0;
            this.metroLabelTitle.Text = "DANH MỤC";
            // 
            // comboDanhMuc
            // 
            this.comboDanhMuc.FormattingEnabled = true;
            this.comboDanhMuc.ItemHeight = 24;
            this.comboDanhMuc.Location = new System.Drawing.Point(196, 25);
            this.comboDanhMuc.Name = "comboDanhMuc";
            this.comboDanhMuc.Size = new System.Drawing.Size(250, 30);
            this.comboDanhMuc.TabIndex = 1;
            this.comboDanhMuc.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(495, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseCustomBackColor = true;
            this.btnThem.UseCustomForeColor = true;
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelThemDanhMuc
            // 
            this.panelThemDanhMuc.BackColor = System.Drawing.Color.Azure;
            this.panelThemDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThemDanhMuc.Controls.Add(this.txtTenDanhMuc);
            this.panelThemDanhMuc.Controls.Add(this.btnLuu);
            this.panelThemDanhMuc.Controls.Add(this.btnHuy);
            this.panelThemDanhMuc.Location = new System.Drawing.Point(395, 3);
            this.panelThemDanhMuc.Name = "panelThemDanhMuc";
            this.panelThemDanhMuc.Size = new System.Drawing.Size(310, 154);
            this.panelThemDanhMuc.TabIndex = 1;
            this.panelThemDanhMuc.Visible = false;
            // 
            // txtTenDanhMuc
            // 
            // 
            // 
            // 
            this.txtTenDanhMuc.CustomButton.Image = null;
            this.txtTenDanhMuc.CustomButton.Location = new System.Drawing.Point(232, 2);
            this.txtTenDanhMuc.CustomButton.Name = "";
            this.txtTenDanhMuc.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTenDanhMuc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenDanhMuc.CustomButton.TabIndex = 1;
            this.txtTenDanhMuc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenDanhMuc.CustomButton.UseSelectable = true;
            this.txtTenDanhMuc.CustomButton.Visible = false;
            this.txtTenDanhMuc.Lines = new string[0];
            this.txtTenDanhMuc.Location = new System.Drawing.Point(20, 20);
            this.txtTenDanhMuc.MaxLength = 32767;
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.PasswordChar = '\0';
            this.txtTenDanhMuc.PromptText = "Nhập tên danh mục...";
            this.txtTenDanhMuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenDanhMuc.SelectedText = "";
            this.txtTenDanhMuc.SelectionLength = 0;
            this.txtTenDanhMuc.SelectionStart = 0;
            this.txtTenDanhMuc.ShortcutsEnabled = true;
            this.txtTenDanhMuc.Size = new System.Drawing.Size(260, 30);
            this.txtTenDanhMuc.TabIndex = 0;
            this.txtTenDanhMuc.UseSelectable = true;
            this.txtTenDanhMuc.WaterMark = "Nhập tên danh mục...";
            this.txtTenDanhMuc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenDanhMuc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(50, 70);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(150, 70);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panelThemDanhMuc);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 142);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(952, 426);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // HousewareManager_DM
            // 
            this.ClientSize = new System.Drawing.Size(952, 563);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "HousewareManager_DM";
            this.Text = "Houseware Managerment";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelThemDanhMuc.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelThemDanhMuc;
        private MetroFramework.Controls.MetroTextBox txtTenDanhMuc;
        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroButton btnHuy;
        private System.Windows.Forms.Panel panelHeader;
        private MetroFramework.Controls.MetroLabel metroLabelTitle;
        private MetroFramework.Controls.MetroComboBox comboDanhMuc;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
