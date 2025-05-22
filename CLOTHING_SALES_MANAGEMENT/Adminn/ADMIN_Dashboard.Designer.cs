namespace CLOTHING_SALES_MANAGEMENT
{
    partial class frmAdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTDT = new System.Windows.Forms.Panel();
            this.PanelThue = new System.Windows.Forms.Panel();
            this.panelTongSanPham = new System.Windows.Forms.Panel();
            this.panelLoiNhuanSauThue = new System.Windows.Forms.Panel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTongHoaDon = new System.Windows.Forms.Panel();
            this.panelTongKhachHang = new System.Windows.Forms.Panel();
            this.btnTheoNgay = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTheoNam = new MetroFramework.Controls.MetroButton();
            this.btnTheoThang = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtend = new MetroFramework.Controls.MetroDateTime();
            this.dtstart = new MetroFramework.Controls.MetroDateTime();
            this.dtkethuc = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTDT
            // 
            this.panelTDT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTDT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTDT.Location = new System.Drawing.Point(23, 22);
            this.panelTDT.Name = "panelTDT";
            this.panelTDT.Size = new System.Drawing.Size(241, 94);
            this.panelTDT.TabIndex = 0;
            this.panelTDT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTDT_Paint);
            // 
            // PanelThue
            // 
            this.PanelThue.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelThue.Location = new System.Drawing.Point(575, 22);
            this.PanelThue.Name = "PanelThue";
            this.PanelThue.Size = new System.Drawing.Size(251, 94);
            this.PanelThue.TabIndex = 2;
            this.PanelThue.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelThue_Paint);
            // 
            // panelTongSanPham
            // 
            this.panelTongSanPham.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTongSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTongSanPham.Location = new System.Drawing.Point(305, 22);
            this.panelTongSanPham.Name = "panelTongSanPham";
            this.panelTongSanPham.Size = new System.Drawing.Size(233, 94);
            this.panelTongSanPham.TabIndex = 3;
            this.panelTongSanPham.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTongSanPham_Paint);
            // 
            // panelLoiNhuanSauThue
            // 
            this.panelLoiNhuanSauThue.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLoiNhuanSauThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLoiNhuanSauThue.Location = new System.Drawing.Point(872, 22);
            this.panelLoiNhuanSauThue.Name = "panelLoiNhuanSauThue";
            this.panelLoiNhuanSauThue.Size = new System.Drawing.Size(256, 94);
            this.panelLoiNhuanSauThue.TabIndex = 4;
            this.panelLoiNhuanSauThue.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoiNhuanSauThue_Paint);
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(262, 314);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(937, 382);
            this.chartDoanhThu.TabIndex = 5;
            this.chartDoanhThu.TabStop = false;
            this.chartDoanhThu.Text = "chartDoanhThu";
            this.chartDoanhThu.Click += new System.EventHandler(this.chartDoanhThu_Click);
            // 
            // panelTongHoaDon
            // 
            this.panelTongHoaDon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTongHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTongHoaDon.Location = new System.Drawing.Point(723, 133);
            this.panelTongHoaDon.Name = "panelTongHoaDon";
            this.panelTongHoaDon.Size = new System.Drawing.Size(251, 94);
            this.panelTongHoaDon.TabIndex = 3;
            this.panelTongHoaDon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTongHoaDon_Paint);
            // 
            // panelTongKhachHang
            // 
            this.panelTongKhachHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTongKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTongKhachHang.Location = new System.Drawing.Point(385, 133);
            this.panelTongKhachHang.Name = "panelTongKhachHang";
            this.panelTongKhachHang.Size = new System.Drawing.Size(251, 94);
            this.panelTongKhachHang.TabIndex = 3;
            this.panelTongKhachHang.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTongKhachHang_Paint);
            // 
            // btnTheoNgay
            // 
            this.btnTheoNgay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTheoNgay.Location = new System.Drawing.Point(27, 58);
            this.btnTheoNgay.Name = "btnTheoNgay";
            this.btnTheoNgay.Size = new System.Drawing.Size(116, 28);
            this.btnTheoNgay.TabIndex = 6;
            this.btnTheoNgay.Text = "Theo Ngày";
            this.btnTheoNgay.UseSelectable = true;
            this.btnTheoNgay.Click += new System.EventHandler(this.btnTheoNgay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTheoNam);
            this.groupBox1.Controls.Add(this.btnTheoThang);
            this.groupBox1.Controls.Add(this.btnTheoNgay);
            this.groupBox1.Location = new System.Drawing.Point(23, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 259);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc Doanh Thu ";
            // 
            // btnTheoNam
            // 
            this.btnTheoNam.Location = new System.Drawing.Point(27, 192);
            this.btnTheoNam.Name = "btnTheoNam";
            this.btnTheoNam.Size = new System.Drawing.Size(116, 30);
            this.btnTheoNam.TabIndex = 8;
            this.btnTheoNam.Text = "Theo Năm";
            this.btnTheoNam.UseSelectable = true;
            this.btnTheoNam.Click += new System.EventHandler(this.btnTheoNam_Click);
            // 
            // btnTheoThang
            // 
            this.btnTheoThang.Location = new System.Drawing.Point(27, 125);
            this.btnTheoThang.Name = "btnTheoThang";
            this.btnTheoThang.Size = new System.Drawing.Size(116, 29);
            this.btnTheoThang.TabIndex = 7;
            this.btnTheoThang.Text = "Theo Tháng";
            this.btnTheoThang.UseSelectable = true;
            this.btnTheoThang.Click += new System.EventHandler(this.btnTheoThang_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 426);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Ngày bắt đầu";
            // 
            // dtend
            // 
            this.dtend.Location = new System.Drawing.Point(32, 569);
            this.dtend.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtend.Name = "dtend";
            this.dtend.Size = new System.Drawing.Size(200, 30);
            this.dtend.TabIndex = 10;
            // 
            // dtstart
            // 
            this.dtstart.Location = new System.Drawing.Point(32, 465);
            this.dtstart.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtstart.Name = "dtstart";
            this.dtstart.Size = new System.Drawing.Size(200, 30);
            this.dtstart.TabIndex = 11;
            // 
            // dtkethuc
            // 
            this.dtkethuc.AutoSize = true;
            this.dtkethuc.Location = new System.Drawing.Point(32, 521);
            this.dtkethuc.Name = "dtkethuc";
            this.dtkethuc.Size = new System.Drawing.Size(96, 20);
            this.dtkethuc.TabIndex = 12;
            this.dtkethuc.Text = "Ngày kết thúc";
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 637);
            this.Controls.Add(this.dtkethuc);
            this.Controls.Add(this.dtstart);
            this.Controls.Add(this.dtend);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTongHoaDon);
            this.Controls.Add(this.panelTongKhachHang);
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.panelLoiNhuanSauThue);
            this.Controls.Add(this.PanelThue);
            this.Controls.Add(this.panelTongSanPham);
            this.Controls.Add(this.panelTDT);
            this.Name = "frmAdminDashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTDT;
        private System.Windows.Forms.Panel PanelThue;
        private System.Windows.Forms.Panel panelTongSanPham;
        private System.Windows.Forms.Panel panelLoiNhuanSauThue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Panel panelTongHoaDon;
        private System.Windows.Forms.Panel panelTongKhachHang;
        private MetroFramework.Controls.MetroButton btnTheoNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnTheoNam;
        private MetroFramework.Controls.MetroButton btnTheoThang;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtend;
        private MetroFramework.Controls.MetroDateTime dtstart;
        private MetroFramework.Controls.MetroLabel dtkethuc;
    }
}