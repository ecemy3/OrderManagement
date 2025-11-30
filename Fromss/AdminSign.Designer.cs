namespace OrderManagement
{
    partial class AdminSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSign));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.UpdateStockBtn = new System.Windows.Forms.Button();
            this.numStockUpdate = new System.Windows.Forms.NumericUpDown();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPendingOrders = new System.Windows.Forms.DataGridView();
            this.ApproveOrderBtn = new System.Windows.Forms.Button();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.AddProductBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddProductBtn.Location = new System.Drawing.Point(223, 40);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(125, 63);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "AddProduct";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ProductNameTxt.Location = new System.Drawing.Point(35, 37);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(159, 22);
            this.ProductNameTxt.TabIndex = 2;
            // 
            // Pricetxt
            // 
            this.Pricetxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Pricetxt.Location = new System.Drawing.Point(35, 143);
            this.Pricetxt.Margin = new System.Windows.Forms.Padding(4);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(159, 22);
            this.Pricetxt.TabIndex = 3;
            // 
            // numStock
            // 
            this.numStock.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numStock.Location = new System.Drawing.Point(34, 85);
            this.numStock.Margin = new System.Windows.Forms.Padding(4);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(160, 22);
            this.numStock.TabIndex = 4;
            // 
            // UpdateStockBtn
            // 
            this.UpdateStockBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.UpdateStockBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStockBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateStockBtn.Location = new System.Drawing.Point(181, 203);
            this.UpdateStockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateStockBtn.Name = "UpdateStockBtn";
            this.UpdateStockBtn.Size = new System.Drawing.Size(183, 27);
            this.UpdateStockBtn.TabIndex = 5;
            this.UpdateStockBtn.Text = "Update Stock";
            this.UpdateStockBtn.UseVisualStyleBackColor = false;
            this.UpdateStockBtn.Click += new System.EventHandler(this.UpdateStockBtn_Click);
            // 
            // numStockUpdate
            // 
            this.numStockUpdate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numStockUpdate.Location = new System.Drawing.Point(13, 206);
            this.numStockUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.numStockUpdate.Name = "numStockUpdate";
            this.numStockUpdate.Size = new System.Drawing.Size(160, 22);
            this.numStockUpdate.TabIndex = 6;
            this.numStockUpdate.ValueChanged += new System.EventHandler(this.numStockUpdate_ValueChanged);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.DeleteProductBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteProductBtn.Location = new System.Drawing.Point(223, 130);
            this.DeleteProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(125, 49);
            this.DeleteProductBtn.TabIndex = 7;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1327, 682);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.BackColor = System.Drawing.Color.SaddleBrown;
            this.stock.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stock.Location = new System.Drawing.Point(32, 63);
            this.stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(53, 18);
            this.stock.TabIndex = 10;
            this.stock.Text = "Stock";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.SaddleBrown;
            this.Price.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Price.Location = new System.Drawing.Point(32, 111);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(49, 18);
            this.Price.TabIndex = 11;
            this.Price.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stock";
            // 
            // dgvPendingOrders
            // 
            this.dgvPendingOrders.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingOrders.Location = new System.Drawing.Point(447, 298);
            this.dgvPendingOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPendingOrders.Name = "dgvPendingOrders";
            this.dgvPendingOrders.RowHeadersWidth = 51;
            this.dgvPendingOrders.RowTemplate.Height = 24;
            this.dgvPendingOrders.Size = new System.Drawing.Size(804, 177);
            this.dgvPendingOrders.TabIndex = 13;
            // 
            // ApproveOrderBtn
            // 
            this.ApproveOrderBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.ApproveOrderBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveOrderBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ApproveOrderBtn.Location = new System.Drawing.Point(13, 268);
            this.ApproveOrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ApproveOrderBtn.Name = "ApproveOrderBtn";
            this.ApproveOrderBtn.Size = new System.Drawing.Size(280, 112);
            this.ApproveOrderBtn.TabIndex = 14;
            this.ApproveOrderBtn.Text = "Approve Order";
            this.ApproveOrderBtn.UseVisualStyleBackColor = false;
            this.ApproveOrderBtn.Click += new System.EventHandler(this.ApproveOrderBtn_Click);
            // 
            // dgvLogs
            // 
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(13, 481);
            this.dgvLogs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowHeadersWidth = 51;
            this.dgvLogs.Size = new System.Drawing.Size(915, 166);
            this.dgvLogs.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(7, 7);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.Size = new System.Drawing.Size(782, 239);
            this.dgvStock.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(447, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 282);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvStock);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartStock);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartStock
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStock.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStock.Legends.Add(legend1);
            this.chartStock.Location = new System.Drawing.Point(19, 19);
            this.chartStock.Name = "chartStock";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStock.Series.Add(series1);
            this.chartStock.Size = new System.Drawing.Size(758, 214);
            this.chartStock.TabIndex = 0;
            this.chartStock.Text = "chart1";
            // 
            // AdminSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 684);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.ApproveOrderBtn);
            this.Controls.Add(this.dgvPendingOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.numStockUpdate);
            this.Controls.Add(this.UpdateStockBtn);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminSign";
            this.Text = "AdminSign";
            this.Load += new System.EventHandler(this.AdminSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Button UpdateStockBtn;
        private System.Windows.Forms.NumericUpDown numStockUpdate;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPendingOrders;
        private System.Windows.Forms.Button ApproveOrderBtn;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
    }
}