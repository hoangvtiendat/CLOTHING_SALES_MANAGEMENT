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
            this.panelEditDanhMuc = new System.Windows.Forms.Panel();
            this.txtSuaDanhMuc = new MetroFramework.Controls.MetroTextBox();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoaDanhMuc = new MetroFramework.Controls.MetroButton();
            this.btnTroVe = new MetroFramework.Controls.MetroButton();
            this.txtDanhMuc = new MetroFramework.Controls.MetroTextBox();
            this.panelCards = new System.Windows.Forms.Panel();
            this.btnEditDanhMuc = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelThemDanhMuc.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.panelEditDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.btnThem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(495, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "➕ THÊM";
            this.btnThem.UseCustomBackColor = true;
            this.btnThem.UseCustomForeColor = true;
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelThemDanhMuc
            // 
            this.panelThemDanhMuc.BackColor = System.Drawing.Color.LightBlue;
            this.panelThemDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThemDanhMuc.Controls.Add(this.txtTenDanhMuc);
            this.panelThemDanhMuc.Controls.Add(this.btnLuu);
            this.panelThemDanhMuc.Controls.Add(this.btnHuy);
            this.panelThemDanhMuc.Location = new System.Drawing.Point(502, 0);
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
            this.btnLuu.Text = "LƯU";
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
            this.metroPanel1.Controls.Add(this.panelEditDanhMuc);
            this.metroPanel1.Controls.Add(this.txtDanhMuc);
            this.metroPanel1.Controls.Add(this.panelThemDanhMuc);
            this.metroPanel1.Controls.Add(this.panelCards);
            this.metroPanel1.Controls.Add(this.btnEditDanhMuc);
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
            // panelEditDanhMuc
            // 
            this.panelEditDanhMuc.BackColor = System.Drawing.Color.LightBlue;
            this.panelEditDanhMuc.Controls.Add(this.txtSuaDanhMuc);
            this.panelEditDanhMuc.Controls.Add(this.btnCapNhat);
            this.panelEditDanhMuc.Controls.Add(this.btnXoaDanhMuc);
            this.panelEditDanhMuc.Controls.Add(this.btnTroVe);
            this.panelEditDanhMuc.Location = new System.Drawing.Point(196, 3);
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
            // txtDanhMuc
            // 
            // 
            // 
            // 
            this.txtDanhMuc.CustomButton.Image = null;
            this.txtDanhMuc.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.txtDanhMuc.CustomButton.Name = "";
            this.txtDanhMuc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDanhMuc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDanhMuc.CustomButton.TabIndex = 1;
            this.txtDanhMuc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDanhMuc.CustomButton.UseSelectable = true;
            this.txtDanhMuc.CustomButton.Visible = false;
            this.txtDanhMuc.Lines = new string[0];
            this.txtDanhMuc.Location = new System.Drawing.Point(20, 13);
            this.txtDanhMuc.MaxLength = 32767;
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.PasswordChar = '\0';
            this.txtDanhMuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDanhMuc.SelectedText = "";
            this.txtDanhMuc.SelectionLength = 0;
            this.txtDanhMuc.SelectionStart = 0;
            this.txtDanhMuc.ShortcutsEnabled = true;
            this.txtDanhMuc.Size = new System.Drawing.Size(136, 23);
            this.txtDanhMuc.TabIndex = 2;
            this.txtDanhMuc.UseSelectable = true;
            this.txtDanhMuc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDanhMuc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panelCards
            // 
            this.panelCards.AutoScroll = true;
            this.panelCards.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCards.Location = new System.Drawing.Point(20, 60);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(900, 350);
            this.panelCards.TabIndex = 4;
            // 
            // btnEditDanhMuc
            // 
            this.btnEditDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnEditDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDanhMuc.Location = new System.Drawing.Point(160, 13);
            this.btnEditDanhMuc.Name = "btnEditDanhMuc";
            this.btnEditDanhMuc.Size = new System.Drawing.Size(30, 23);
            this.btnEditDanhMuc.TabIndex = 5;
            this.btnEditDanhMuc.Text = "✏";
            this.btnEditDanhMuc.Click += new System.EventHandler(this.btnEditDanhMuc_Click);
            // 
            // HousewareManager_DM
            // 
            this.ClientSize = new System.Drawing.Size(952, 563);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "HousewareManager_DM";
            this.Text = "WAREHOUSE MANAGEMENT";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelThemDanhMuc.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.panelEditDanhMuc.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTextBox txtDanhMuc;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Button btnEditDanhMuc;
        private System.Windows.Forms.Panel panelEditDanhMuc;
        private MetroFramework.Controls.MetroTextBox txtSuaDanhMuc;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnXoaDanhMuc;
        private MetroFramework.Controls.MetroButton btnTroVe;
    }
}
