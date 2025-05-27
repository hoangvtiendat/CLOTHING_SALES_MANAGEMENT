namespace CLOTHING_SALES_MANAGEMENT
{
    partial class frmHousewareManagerDM
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
            this.btnEditDanhMuc = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panelThemDanhMuc = new System.Windows.Forms.Panel();
            this.txtTenDanhMuc = new MetroFramework.Controls.MetroTextBox();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panelEditDanhMuc = new System.Windows.Forms.Panel();
            this.txtSuaDanhMuc = new MetroFramework.Controls.MetroTextBox();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoaDanhMuc = new MetroFramework.Controls.MetroButton();
            this.btnTroVe = new MetroFramework.Controls.MetroButton();
            this.panelAddProduct = new System.Windows.Forms.Panel();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.txtProductPrice = new MetroFramework.Controls.MetroTextBox();
            this.nudProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.btnChooseProductImage = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btn_UpdateP = new System.Windows.Forms.Button();
            this.btnCancelAddProduct = new System.Windows.Forms.Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.btnDangXuat = new MetroFramework.Controls.MetroButton();
            this.panelHeader.SuspendLayout();
            this.panelThemDanhMuc.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelEditDanhMuc.SuspendLayout();
            this.panelAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelHeader.Controls.Add(this.metroLabelTitle);
            this.panelHeader.Controls.Add(this.comboDanhMuc);
            this.panelHeader.Controls.Add(this.btnThem);
            this.panelHeader.Controls.Add(this.btnEditDanhMuc);
            this.panelHeader.Controls.Add(this.btnAddProduct);
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
            this.metroLabelTitle.Size = new System.Drawing.Size(112, 25);
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
            this.btnThem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(503, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "➕ THÊM DANH MỤC";
            this.btnThem.UseCustomBackColor = true;
            this.btnThem.UseCustomForeColor = true;
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnEditDanhMuc
            // 
            this.btnEditDanhMuc.BackColor = System.Drawing.Color.MintCream;
            this.btnEditDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnEditDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDanhMuc.Location = new System.Drawing.Point(452, 25);
            this.btnEditDanhMuc.Name = "btnEditDanhMuc";
            this.btnEditDanhMuc.Size = new System.Drawing.Size(37, 30);
            this.btnEditDanhMuc.TabIndex = 5;
            this.btnEditDanhMuc.Text = "✏";
            this.btnEditDanhMuc.UseVisualStyleBackColor = false;
            this.btnEditDanhMuc.Click += new System.EventHandler(this.btnEditDanhMuc_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(673, 25);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(148, 30);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "➕ Thêm sản phẩm";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panelThemDanhMuc
            // 
            this.panelThemDanhMuc.BackColor = System.Drawing.Color.LightBlue;
            this.panelThemDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThemDanhMuc.Controls.Add(this.txtTenDanhMuc);
            this.panelThemDanhMuc.Controls.Add(this.btnLuu);
            this.panelThemDanhMuc.Controls.Add(this.btnHuy);
            this.panelThemDanhMuc.Location = new System.Drawing.Point(502, 4);
            this.panelThemDanhMuc.Name = "panelThemDanhMuc";
            this.panelThemDanhMuc.Size = new System.Drawing.Size(310, 149);
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
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "THÊM";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(150, 70);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 33);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panelThemDanhMuc);
            this.metroPanel1.Controls.Add(this.panelEditDanhMuc);
            this.metroPanel1.Controls.Add(this.panelAddProduct);
            this.metroPanel1.Controls.Add(this.panelCards);
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
            this.metroPanel1.Click += new System.EventHandler(this.metroPanel1_Click);
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // panelEditDanhMuc
            // 
            this.panelEditDanhMuc.BackColor = System.Drawing.Color.LightBlue;
            this.panelEditDanhMuc.Controls.Add(this.txtSuaDanhMuc);
            this.panelEditDanhMuc.Controls.Add(this.btnCapNhat);
            this.panelEditDanhMuc.Controls.Add(this.btnXoaDanhMuc);
            this.panelEditDanhMuc.Controls.Add(this.btnTroVe);
            this.panelEditDanhMuc.Location = new System.Drawing.Point(142, 3);
            this.panelEditDanhMuc.Name = "panelEditDanhMuc";
            this.panelEditDanhMuc.Size = new System.Drawing.Size(300, 130);
            this.panelEditDanhMuc.TabIndex = 3;
            this.panelEditDanhMuc.Visible = false;
            // 
            // txtSuaDanhMuc
            // 
            // 
            // 
            // 
            this.txtSuaDanhMuc.CustomButton.Image = null;
            this.txtSuaDanhMuc.CustomButton.Location = new System.Drawing.Point(232, 2);
            this.txtSuaDanhMuc.CustomButton.Name = "";
            this.txtSuaDanhMuc.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSuaDanhMuc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSuaDanhMuc.CustomButton.TabIndex = 1;
            this.txtSuaDanhMuc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSuaDanhMuc.CustomButton.UseSelectable = true;
            this.txtSuaDanhMuc.CustomButton.Visible = false;
            this.txtSuaDanhMuc.Lines = new string[0];
            this.txtSuaDanhMuc.Location = new System.Drawing.Point(20, 18);
            this.txtSuaDanhMuc.MaxLength = 32767;
            this.txtSuaDanhMuc.Name = "txtSuaDanhMuc";
            this.txtSuaDanhMuc.PasswordChar = '\0';
            this.txtSuaDanhMuc.PromptText = "Nhập tên mới...";
            this.txtSuaDanhMuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSuaDanhMuc.SelectedText = "";
            this.txtSuaDanhMuc.SelectionLength = 0;
            this.txtSuaDanhMuc.SelectionStart = 0;
            this.txtSuaDanhMuc.ShortcutsEnabled = true;
            this.txtSuaDanhMuc.Size = new System.Drawing.Size(260, 30);
            this.txtSuaDanhMuc.TabIndex = 0;
            this.txtSuaDanhMuc.UseSelectable = true;
            this.txtSuaDanhMuc.WaterMark = "Nhập tên mới...";
            this.txtSuaDanhMuc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSuaDanhMuc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(20, 72);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(77, 32);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "LƯU";
            this.btnCapNhat.UseSelectable = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaDanhMuc
            // 
            this.btnXoaDanhMuc.Location = new System.Drawing.Point(112, 72);
            this.btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            this.btnXoaDanhMuc.Size = new System.Drawing.Size(74, 32);
            this.btnXoaDanhMuc.TabIndex = 2;
            this.btnXoaDanhMuc.Text = "XÓA";
            this.btnXoaDanhMuc.UseSelectable = true;
            this.btnXoaDanhMuc.Click += new System.EventHandler(this.btnXoaDanhMuc_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(205, 72);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 32);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "HỦY";
            this.btnTroVe.UseSelectable = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // panelAddProduct
            // 
            this.panelAddProduct.BackColor = System.Drawing.Color.LightYellow;
            this.panelAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddProduct.Controls.Add(this.txtProductName);
            this.panelAddProduct.Controls.Add(this.txtProductPrice);
            this.panelAddProduct.Controls.Add(this.nudProductQuantity);
            this.panelAddProduct.Controls.Add(this.pbProductImage);
            this.panelAddProduct.Controls.Add(this.btnChooseProductImage);
            this.panelAddProduct.Controls.Add(this.btnSaveProduct);
            this.panelAddProduct.Controls.Add(this.btn_UpdateP);
            this.panelAddProduct.Controls.Add(this.btnCancelAddProduct);
            this.panelAddProduct.Location = new System.Drawing.Point(502, 4);
            this.panelAddProduct.Name = "panelAddProduct";
            this.panelAddProduct.Size = new System.Drawing.Size(330, 300);
            this.panelAddProduct.TabIndex = 5;
            this.panelAddProduct.Visible = false;
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(20, 20);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PromptText = "Tên sản phẩm";
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(280, 30);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "Tên sản phẩm";
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductPrice
            // 
            // 
            // 
            // 
            this.txtProductPrice.CustomButton.Image = null;
            this.txtProductPrice.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtProductPrice.CustomButton.Name = "";
            this.txtProductPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProductPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductPrice.CustomButton.TabIndex = 1;
            this.txtProductPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductPrice.CustomButton.UseSelectable = true;
            this.txtProductPrice.CustomButton.Visible = false;
            this.txtProductPrice.Lines = new string[0];
            this.txtProductPrice.Location = new System.Drawing.Point(20, 60);
            this.txtProductPrice.MaxLength = 32767;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.PromptText = "Giá sản phẩm";
            this.txtProductPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.SelectionLength = 0;
            this.txtProductPrice.SelectionStart = 0;
            this.txtProductPrice.ShortcutsEnabled = true;
            this.txtProductPrice.Size = new System.Drawing.Size(280, 30);
            this.txtProductPrice.TabIndex = 1;
            this.txtProductPrice.UseSelectable = true;
            this.txtProductPrice.WaterMark = "Giá sản phẩm";
            this.txtProductPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nudProductQuantity
            // 
            this.nudProductQuantity.Location = new System.Drawing.Point(20, 100);
            this.nudProductQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProductQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductQuantity.Name = "nudProductQuantity";
            this.nudProductQuantity.Size = new System.Drawing.Size(280, 22);
            this.nudProductQuantity.TabIndex = 2;
            this.nudProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pbProductImage
            // 
            this.pbProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProductImage.Location = new System.Drawing.Point(20, 140);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(150, 100);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 3;
            this.pbProductImage.TabStop = false;
            // 
            // btnChooseProductImage
            // 
            this.btnChooseProductImage.Location = new System.Drawing.Point(180, 140);
            this.btnChooseProductImage.Name = "btnChooseProductImage";
            this.btnChooseProductImage.Size = new System.Drawing.Size(120, 30);
            this.btnChooseProductImage.TabIndex = 4;
            this.btnChooseProductImage.Text = "Chọn ảnh";
            this.btnChooseProductImage.Click += new System.EventHandler(this.btnChooseProductImage_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(20, 250);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(80, 30);
            this.btnSaveProduct.TabIndex = 5;
            this.btnSaveProduct.Text = "Lưu";
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btn_UpdateP
            // 
            this.btn_UpdateP.Location = new System.Drawing.Point(229, 250);
            this.btn_UpdateP.Name = "btn_UpdateP";
            this.btn_UpdateP.Size = new System.Drawing.Size(80, 30);
            this.btn_UpdateP.TabIndex = 6;
            this.btn_UpdateP.Text = "Sửa";
            this.btn_UpdateP.Click += new System.EventHandler(this.btn_UpdateP_Click);
            // 
            // btnCancelAddProduct
            // 
            this.btnCancelAddProduct.Location = new System.Drawing.Point(124, 250);
            this.btnCancelAddProduct.Name = "btnCancelAddProduct";
            this.btnCancelAddProduct.Size = new System.Drawing.Size(80, 30);
            this.btnCancelAddProduct.TabIndex = 6;
            this.btnCancelAddProduct.Text = "Hủy";
            this.btnCancelAddProduct.Click += new System.EventHandler(this.btnCancelAddProduct_Click);
            // 
            // panelCards
            // 
            this.panelCards.AutoScroll = true;
            this.panelCards.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCards.Location = new System.Drawing.Point(20, 61);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(900, 350);
            this.panelCards.TabIndex = 4;
            this.panelCards.Click += new System.EventHandler(this.panelCards_Click);
            this.panelCards.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCards_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(817, 24);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(115, 30);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseSelectable = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmHousewareManagerDM
            // 
            this.ClientSize = new System.Drawing.Size(952, 563);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmHousewareManagerDM";
            this.Text = "WAREHOUSE MANAGEMENT";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelThemDanhMuc.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.panelEditDanhMuc.ResumeLayout(false);
            this.panelAddProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
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
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Button btnEditDanhMuc;
        private System.Windows.Forms.Panel panelEditDanhMuc;
        private MetroFramework.Controls.MetroTextBox txtSuaDanhMuc;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnXoaDanhMuc;
        private MetroFramework.Controls.MetroButton btnTroVe;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel panelAddProduct;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroTextBox txtProductPrice;
        private System.Windows.Forms.NumericUpDown nudProductQuantity;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Button btnChooseProductImage;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnCancelAddProduct;
        private System.Windows.Forms.Button btn_UpdateP;
        private MetroFramework.Controls.MetroButton btnDangXuat;
    }
}
