namespace OrderManagement.Fromss
{
    partial class Shopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shopping));
            this.lstCustomerDetails = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnShop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCustomerDetails
            // 
            this.lstCustomerDetails.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lstCustomerDetails.FormattingEnabled = true;
            this.lstCustomerDetails.ItemHeight = 16;
            this.lstCustomerDetails.Location = new System.Drawing.Point(16, 15);
            this.lstCustomerDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCustomerDetails.Name = "lstCustomerDetails";
            this.lstCustomerDetails.Size = new System.Drawing.Size(529, 212);
            this.lstCustomerDetails.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1248, 641);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(576, 15);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(636, 213);
            this.dgvProducts.TabIndex = 2;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(877, 273);
            this.btnShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(163, 53);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Shopping";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 640);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lstCustomerDetails);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Shopping";
            this.Text = "Shopping";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomerDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnShop;
    }
}