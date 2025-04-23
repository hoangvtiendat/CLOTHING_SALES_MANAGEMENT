namespace CLOTHING_SALES_MANAGEMENT
{
    partial class Product_frm
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
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtQuanity = new MetroFramework.Controls.MetroTextBox();
            this.cbCatalog = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnFind = new MetroFramework.Controls.MetroButton();
            this.ptImage = new System.Windows.Forms.PictureBox();
            this.Sort = new System.Windows.Forms.GroupBox();
            this.rdDesend = new MetroFramework.Controls.MetroRadioButton();
            this.rdAcsend = new MetroFramework.Controls.MetroRadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).BeginInit();
            this.Sort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(64, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name Product";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[] {
        "Enter Product Name"};
            this.txtName.Location = new System.Drawing.Point(194, 105);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(137, 23);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Enter Product Name";
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 244);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Catalog";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(390, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Product Image";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(64, 197);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Product Quanity";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(64, 150);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 20);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Product Price";
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[] {
        "Enter Product Price"};
            this.txtPrice.Location = new System.Drawing.Point(194, 147);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(137, 23);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "Enter Product Price";
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuanity
            // 
            // 
            // 
            // 
            this.txtQuanity.CustomButton.Image = null;
            this.txtQuanity.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtQuanity.CustomButton.Name = "";
            this.txtQuanity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuanity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuanity.CustomButton.TabIndex = 1;
            this.txtQuanity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuanity.CustomButton.UseSelectable = true;
            this.txtQuanity.CustomButton.Visible = false;
            this.txtQuanity.Lines = new string[] {
        "Enter Product Quanity"};
            this.txtQuanity.Location = new System.Drawing.Point(194, 194);
            this.txtQuanity.MaxLength = 32767;
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.PasswordChar = '\0';
            this.txtQuanity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuanity.SelectedText = "";
            this.txtQuanity.SelectionLength = 0;
            this.txtQuanity.SelectionStart = 0;
            this.txtQuanity.ShortcutsEnabled = true;
            this.txtQuanity.Size = new System.Drawing.Size(137, 23);
            this.txtQuanity.TabIndex = 8;
            this.txtQuanity.Text = "Enter Product Quanity";
            this.txtQuanity.UseSelectable = true;
            this.txtQuanity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuanity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCatalog
            // 
            this.cbCatalog.FormattingEnabled = true;
            this.cbCatalog.ItemHeight = 24;
            this.cbCatalog.Location = new System.Drawing.Point(194, 244);
            this.cbCatalog.Name = "cbCatalog";
            this.cbCatalog.Size = new System.Drawing.Size(121, 30);
            this.cbCatalog.TabIndex = 9;
            this.cbCatalog.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(567, 311);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Search Name";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Enter Product Name"};
            this.metroTextBox1.Location = new System.Drawing.Point(666, 308);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(137, 23);
            this.metroTextBox1.TabIndex = 11;
            this.metroTextBox1.Text = "Enter Product Name";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(194, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(328, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(460, 295);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 40);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(809, 308);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(66, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Find";
            this.btnFind.UseSelectable = true;
            // 
            // ptImage
            // 
            this.ptImage.Location = new System.Drawing.Point(390, 147);
            this.ptImage.Name = "ptImage";
            this.ptImage.Size = new System.Drawing.Size(186, 109);
            this.ptImage.TabIndex = 17;
            this.ptImage.TabStop = false;
            // 
            // Sort
            // 
            this.Sort.Controls.Add(this.rdDesend);
            this.Sort.Controls.Add(this.rdAcsend);
            this.Sort.Location = new System.Drawing.Point(666, 105);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(200, 100);
            this.Sort.TabIndex = 18;
            this.Sort.TabStop = false;
            this.Sort.Text = "Sort by Name";
            // 
            // rdDesend
            // 
            this.rdDesend.AutoSize = true;
            this.rdDesend.Location = new System.Drawing.Point(100, 41);
            this.rdDesend.Name = "rdDesend";
            this.rdDesend.Size = new System.Drawing.Size(86, 17);
            this.rdDesend.TabIndex = 1;
            this.rdDesend.Text = "Desending";
            this.rdDesend.UseSelectable = true;
            // 
            // rdAcsend
            // 
            this.rdAcsend.AutoSize = true;
            this.rdAcsend.Location = new System.Drawing.Point(10, 41);
            this.rdAcsend.Name = "rdAcsend";
            this.rdAcsend.Size = new System.Drawing.Size(84, 17);
            this.rdAcsend.TabIndex = 0;
            this.rdAcsend.Text = "Acsending";
            this.rdAcsend.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(807, 200);
            this.dataGridView1.TabIndex = 19;
            // 
            // Product_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.ptImage);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbCatalog);
            this.Controls.Add(this.txtQuanity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Product_frm";
            this.Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).EndInit();
            this.Sort.ResumeLayout(false);
            this.Sort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtQuanity;
        private MetroFramework.Controls.MetroComboBox cbCatalog;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnFind;
        private System.Windows.Forms.PictureBox ptImage;
        private System.Windows.Forms.GroupBox Sort;
        private MetroFramework.Controls.MetroRadioButton rdDesend;
        private MetroFramework.Controls.MetroRadioButton rdAcsend;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}