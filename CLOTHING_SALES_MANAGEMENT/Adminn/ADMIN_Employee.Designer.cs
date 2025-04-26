namespace CLOTHING_SALES_MANAGEMENT
{
    partial class frmAdminEmployee
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKim = new System.Windows.Forms.TextBox();
            this.btnTim = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGiam = new MetroFramework.Controls.MetroRadioButton();
            this.rdTang = new MetroFramework.Controls.MetroRadioButton();
            this.btnLamMoi = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(408, 153);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(292, 31);
            this.txtTen.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(408, 216);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 31);
            this.txtEmail.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(408, 281);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(292, 31);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(408, 341);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(292, 31);
            this.txtSDT.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(214, 544);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 294);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 478);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "TÌM KÍM THEO TÊN";
            // 
            // txtTimKim
            // 
            this.txtTimKim.Location = new System.Drawing.Point(1041, 469);
            this.txtTimKim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKim.Name = "txtTimKim";
            this.txtTimKim.Size = new System.Drawing.Size(241, 31);
            this.txtTimKim.TabIndex = 13;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1317, 469);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 36);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "TÌM KÍM";
            this.btnTim.UseSelectable = true;
            this.btnTim.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(759, 344);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 59);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseSelectable = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(958, 344);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(144, 59);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1155, 344);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 59);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGiam);
            this.groupBox1.Controls.Add(this.rdTang);
            this.groupBox1.Location = new System.Drawing.Point(1113, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(366, 158);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SẮP XẾP THEO TÊN ";
            // 
            // rdGiam
            // 
            this.rdGiam.AutoSize = true;
            this.rdGiam.Location = new System.Drawing.Point(189, 77);
            this.rdGiam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdGiam.Name = "rdGiam";
            this.rdGiam.Size = new System.Drawing.Size(81, 15);
            this.rdGiam.TabIndex = 1;
            this.rdGiam.Text = "GIẢM DẦN";
            this.rdGiam.UseSelectable = true;
            // 
            // rdTang
            // 
            this.rdTang.AutoSize = true;
            this.rdTang.Location = new System.Drawing.Point(9, 77);
            this.rdTang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdTang.Name = "rdTang";
            this.rdTang.Size = new System.Drawing.Size(82, 15);
            this.rdTang.TabIndex = 0;
            this.rdTang.Text = "TĂNG DẦN";
            this.rdTang.UseSelectable = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1335, 341);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(144, 59);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(213, 153);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "NHẬP TÊN ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(214, 216);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "EMAIL";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(214, 284);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "ĐỊA CHỈ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(213, 341);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "SỐ ĐIỆN THOẠI";
            // 
            // frmAdminEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 941);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminEmployee";
            this.Padding = new System.Windows.Forms.Padding(30, 94, 30, 31);
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.EMPLOYEE_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKim;
        private MetroFramework.Controls.MetroButton btnTim;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rdGiam;
        private MetroFramework.Controls.MetroRadioButton rdTang;
        private MetroFramework.Controls.MetroButton btnLamMoi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}