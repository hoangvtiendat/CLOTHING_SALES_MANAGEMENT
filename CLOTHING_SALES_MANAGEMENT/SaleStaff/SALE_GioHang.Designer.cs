namespace CLOTHING_SALES_MANAGEMENT
{
    partial class frmSaleGioHang
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
            this.pnGioHang = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new MetroFramework.Controls.MetroButton();
            this.btnTroVe = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // pnGioHang
            // 
            this.pnGioHang.AutoScroll = true;
            this.pnGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnGioHang.Location = new System.Drawing.Point(21, 132);
            this.pnGioHang.Name = "pnGioHang";
            this.pnGioHang.Size = new System.Drawing.Size(893, 804);
            this.pnGioHang.TabIndex = 4;
            this.pnGioHang.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 961);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "TỔNG TIỀN:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 961);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "VND";
            this.label2.UseWaitCursor = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.White;
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTien.Location = new System.Drawing.Point(695, 961);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(91, 27);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "1000000";
            this.lblTongTien.UseWaitCursor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThanhToan.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnThanhToan.Location = new System.Drawing.Point(644, 1040);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(270, 86);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseCustomBackColor = true;
            this.btnThanhToan.UseCustomForeColor = true;
            this.btnThanhToan.UseSelectable = true;
            this.btnThanhToan.UseStyleColors = true;
            this.btnThanhToan.UseWaitCursor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.AutoSize = true;
            this.btnTroVe.Location = new System.Drawing.Point(21, 1040);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(270, 86);
            this.btnTroVe.TabIndex = 9;
            this.btnTroVe.Text = "TRỞ VỀ";
            this.btnTroVe.UseSelectable = true;
            this.btnTroVe.UseWaitCursor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // frmSaleGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1100, 1200);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnGioHang);
            this.Name = "frmSaleGioHang";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 19);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "GIỎ HÀNG";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmSaleGioHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnGioHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongTien;
        private MetroFramework.Controls.MetroButton btnThanhToan;
        private MetroFramework.Controls.MetroButton btnTroVe;
    }
}