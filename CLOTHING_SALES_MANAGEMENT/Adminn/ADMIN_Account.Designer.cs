namespace CLOTHING_SALES_MANAGEMENT
{
    partial class frmAdminAccount
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTenTK = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGiam = new MetroFramework.Controls.MetroRadioButton();
            this.rdTang = new MetroFramework.Controls.MetroRadioButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnLamMoi = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cboViTri = new MetroFramework.Controls.MetroComboBox();
            this.txtTimKim = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ACCOUNT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE_ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new MetroFramework.Controls.MetroButton();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(170, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "NHẬP MẬT KHẨU";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(170, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "NHẬP TÊN TK";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(170, 186);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "VỊ TRÍ";
            // 
            // txtTenTK
            // 
            // 
            // 
            // 
            this.txtTenTK.CustomButton.Image = null;
            this.txtTenTK.CustomButton.Location = new System.Drawing.Point(175, 2);
            this.txtTenTK.CustomButton.Name = "";
            this.txtTenTK.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTenTK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenTK.CustomButton.TabIndex = 1;
            this.txtTenTK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenTK.CustomButton.UseSelectable = true;
            this.txtTenTK.CustomButton.Visible = false;
            this.txtTenTK.Lines = new string[0];
            this.txtTenTK.Location = new System.Drawing.Point(327, 92);
            this.txtTenTK.MaxLength = 32767;
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.PasswordChar = '\0';
            this.txtTenTK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenTK.SelectedText = "";
            this.txtTenTK.SelectionLength = 0;
            this.txtTenTK.SelectionStart = 0;
            this.txtTenTK.ShortcutsEnabled = true;
            this.txtTenTK.Size = new System.Drawing.Size(203, 30);
            this.txtTenTK.TabIndex = 7;
            this.txtTenTK.UseSelectable = true;
            this.txtTenTK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenTK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(175, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(328, 136);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(203, 30);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGiam);
            this.groupBox1.Controls.Add(this.rdTang);
            this.groupBox1.Location = new System.Drawing.Point(687, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 104);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XẮP XẾP THEO TÊN";
            // 
            // rdGiam
            // 
            this.rdGiam.AutoSize = true;
            this.rdGiam.Location = new System.Drawing.Point(125, 50);
            this.rdGiam.Name = "rdGiam";
            this.rdGiam.Size = new System.Drawing.Size(87, 17);
            this.rdGiam.TabIndex = 1;
            this.rdGiam.Text = "GIẢM DẦN";
            this.rdGiam.UseSelectable = true;
            this.rdGiam.CheckedChanged += new System.EventHandler(this.rdGiam_CheckedChanged);
            // 
            // rdTang
            // 
            this.rdTang.AutoSize = true;
            this.rdTang.Location = new System.Drawing.Point(12, 50);
            this.rdTang.Name = "rdTang";
            this.rdTang.Size = new System.Drawing.Size(88, 17);
            this.rdTang.TabIndex = 0;
            this.rdTang.Text = "TĂNG DẦN";
            this.rdTang.UseSelectable = true;
            this.rdTang.CheckedChanged += new System.EventHandler(this.rdTang_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(168, 237);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 38);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(303, 237);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(88, 38);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseSelectable = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(432, 237);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 38);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseSelectable = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(563, 237);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 38);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseSelectable = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(578, 291);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 20);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "TÌM KÍM ";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // cboViTri
            // 
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.ItemHeight = 24;
            this.cboViTri.Location = new System.Drawing.Point(328, 176);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(202, 30);
            this.cboViTri.TabIndex = 16;
            this.cboViTri.UseSelectable = true;
            // 
            // txtTimKim
            // 
            // 
            // 
            // 
            this.txtTimKim.CustomButton.Image = null;
            this.txtTimKim.CustomButton.Location = new System.Drawing.Point(112, 2);
            this.txtTimKim.CustomButton.Name = "";
            this.txtTimKim.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTimKim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimKim.CustomButton.TabIndex = 1;
            this.txtTimKim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimKim.CustomButton.UseSelectable = true;
            this.txtTimKim.CustomButton.Visible = false;
            this.txtTimKim.Lines = new string[0];
            this.txtTimKim.Location = new System.Drawing.Point(670, 291);
            this.txtTimKim.MaxLength = 32767;
            this.txtTimKim.Name = "txtTimKim";
            this.txtTimKim.PasswordChar = '\0';
            this.txtTimKim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKim.SelectedText = "";
            this.txtTimKim.SelectionLength = 0;
            this.txtTimKim.SelectionStart = 0;
            this.txtTimKim.ShortcutsEnabled = true;
            this.txtTimKim.Size = new System.Drawing.Size(140, 30);
            this.txtTimKim.TabIndex = 17;
            this.txtTimKim.UseSelectable = true;
            this.txtTimKim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACCOUNT_ID,
            this.ACCOUNT_USERNAME,
            this.ACCOUNT_PASSWORD,
            this.ROLE_ID,
            this.ROLE_ID1,
            this.ROLE_NAME});
            this.dataGridView1.Location = new System.Drawing.Point(186, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 157);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ACCOUNT_ID
            // 
            this.ACCOUNT_ID.DataPropertyName = "ACCOUNT_ID";
            this.ACCOUNT_ID.HeaderText = "ACCOUNT_ID";
            this.ACCOUNT_ID.MinimumWidth = 6;
            this.ACCOUNT_ID.Name = "ACCOUNT_ID";
            this.ACCOUNT_ID.Visible = false;
            this.ACCOUNT_ID.Width = 125;
            // 
            // ACCOUNT_USERNAME
            // 
            this.ACCOUNT_USERNAME.DataPropertyName = "ACCOUNT_USERNAME";
            this.ACCOUNT_USERNAME.HeaderText = "Tên Tài Khoản";
            this.ACCOUNT_USERNAME.MinimumWidth = 6;
            this.ACCOUNT_USERNAME.Name = "ACCOUNT_USERNAME";
            this.ACCOUNT_USERNAME.Width = 125;
            // 
            // ACCOUNT_PASSWORD
            // 
            this.ACCOUNT_PASSWORD.DataPropertyName = "ACCOUNT_PASSWORD";
            this.ACCOUNT_PASSWORD.HeaderText = "Mật Khẩu";
            this.ACCOUNT_PASSWORD.MinimumWidth = 6;
            this.ACCOUNT_PASSWORD.Name = "ACCOUNT_PASSWORD";
            this.ACCOUNT_PASSWORD.Width = 125;
            // 
            // ROLE_ID
            // 
            this.ROLE_ID.DataPropertyName = "ROLE_ID";
            this.ROLE_ID.HeaderText = "ROLE_ID";
            this.ROLE_ID.MinimumWidth = 6;
            this.ROLE_ID.Name = "ROLE_ID";
            this.ROLE_ID.Visible = false;
            this.ROLE_ID.Width = 125;
            // 
            // ROLE_ID1
            // 
            this.ROLE_ID1.DataPropertyName = "ROLE_ID1";
            this.ROLE_ID1.HeaderText = "ROLE_ID1";
            this.ROLE_ID1.MinimumWidth = 6;
            this.ROLE_ID1.Name = "ROLE_ID1";
            this.ROLE_ID1.Visible = false;
            this.ROLE_ID1.Width = 125;
            // 
            // ROLE_NAME
            // 
            this.ROLE_NAME.DataPropertyName = "ROLE_NAME";
            this.ROLE_NAME.HeaderText = "Vị Trí";
            this.ROLE_NAME.MinimumWidth = 6;
            this.ROLE_NAME.Name = "ROLE_NAME";
            this.ROLE_NAME.Width = 125;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(816, 291);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(71, 30);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseSelectable = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(954, 43);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(14, 16);
            this.lbl_ID.TabIndex = 20;
            this.lbl_ID.Text = "0";
            this.lbl_ID.Visible = false;
            // 
            // frmAdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 586);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTimKim);
            this.Controls.Add(this.cboViTri);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmAdminAccount";
            this.Text = "QUẢN LÝ TÀI KHOẢN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTenTK;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdTang;
        private MetroFramework.Controls.MetroRadioButton rdGiam;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnLamMoi;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboViTri;
        private MetroFramework.Controls.MetroTextBox txtTimKim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnTim;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE_ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE_NAME;
    }
}