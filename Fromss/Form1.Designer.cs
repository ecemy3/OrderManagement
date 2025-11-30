namespace OrderManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.btnMusteriOlustur = new System.Windows.Forms.Button();
            this.StokDurumBtn = new System.Windows.Forms.Button();
            this.AdminSignBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(43, 28);
            this.dgvMusteriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.RowHeadersWidth = 51;
            this.dgvMusteriler.Size = new System.Drawing.Size(825, 258);
            this.dgvMusteriler.TabIndex = 0;
            this.dgvMusteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriler_CellDoubleClick);
            // 
            // btnMusteriOlustur
            // 
            this.btnMusteriOlustur.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnMusteriOlustur.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriOlustur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMusteriOlustur.Location = new System.Drawing.Point(43, 315);
            this.btnMusteriOlustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMusteriOlustur.Name = "btnMusteriOlustur";
            this.btnMusteriOlustur.Size = new System.Drawing.Size(249, 87);
            this.btnMusteriOlustur.TabIndex = 1;
            this.btnMusteriOlustur.Text = "Create Costumer";
            this.btnMusteriOlustur.UseVisualStyleBackColor = false;
            this.btnMusteriOlustur.Click += new System.EventHandler(this.btnMusteriOlustur_Click_1);
            // 
            // StokDurumBtn
            // 
            this.StokDurumBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.StokDurumBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokDurumBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StokDurumBtn.Location = new System.Drawing.Point(999, 60);
            this.StokDurumBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StokDurumBtn.Name = "StokDurumBtn";
            this.StokDurumBtn.Size = new System.Drawing.Size(265, 101);
            this.StokDurumBtn.TabIndex = 2;
            this.StokDurumBtn.Text = "Stok Durumu Görüntüleme";
            this.StokDurumBtn.UseVisualStyleBackColor = false;
            this.StokDurumBtn.Click += new System.EventHandler(this.StokDurumBtn_Click);
            // 
            // AdminSignBtn
            // 
            this.AdminSignBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.AdminSignBtn.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdminSignBtn.Location = new System.Drawing.Point(999, 182);
            this.AdminSignBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminSignBtn.Name = "AdminSignBtn";
            this.AdminSignBtn.Size = new System.Drawing.Size(265, 89);
            this.AdminSignBtn.TabIndex = 3;
            this.AdminSignBtn.Text = "Admin Sign In";
            this.AdminSignBtn.UseVisualStyleBackColor = false;
            this.AdminSignBtn.Click += new System.EventHandler(this.AdminSignBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1307, 705);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1304, 704);
            this.Controls.Add(this.AdminSignBtn);
            this.Controls.Add(this.StokDurumBtn);
            this.Controls.Add(this.btnMusteriOlustur);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Button btnMusteriOlustur;
        private System.Windows.Forms.Button StokDurumBtn;
        private System.Windows.Forms.Button AdminSignBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

