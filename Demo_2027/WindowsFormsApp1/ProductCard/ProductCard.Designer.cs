namespace DemoUIComponents
{
    partial class ProductCard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.productImages = new System.Windows.Forms.PictureBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.CategoryLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(166, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Состав";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(277, 78);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(0, 23);
            this.CategoryLabel.TabIndex = 3;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLabel.ForeColor = System.Drawing.Color.Black;
            this.CountLabel.Location = new System.Drawing.Point(293, 103);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(56, 23);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "label4";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartsLabel.ForeColor = System.Drawing.Color.Black;
            this.PartsLabel.Location = new System.Drawing.Point(235, 136);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(56, 23);
            this.PartsLabel.TabIndex = 5;
            this.PartsLabel.Text = "label5";
            // 
            // productImages
            // 
            this.productImages.Image = global::ProductCard.Properties.Resources.picture;
            this.productImages.Location = new System.Drawing.Point(18, 38);
            this.productImages.Name = "productImages";
            this.productImages.Size = new System.Drawing.Size(140, 125);
            this.productImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImages.TabIndex = 6;
            this.productImages.TabStop = false;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierLabel.ForeColor = System.Drawing.Color.Black;
            this.supplierLabel.Location = new System.Drawing.Point(265, 24);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(74, 29);
            this.supplierLabel.TabIndex = 7;
            this.supplierLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(432, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "|";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(457, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 29);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "label7";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.ForeColor = System.Drawing.Color.Black;
            this.priceLabel.Location = new System.Drawing.Point(1166, 29);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 23);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "label8";
            // 
            // CategoryLabel1
            // 
            this.CategoryLabel1.AutoSize = true;
            this.CategoryLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel1.ForeColor = System.Drawing.Color.Black;
            this.CategoryLabel1.Location = new System.Drawing.Point(293, 72);
            this.CategoryLabel1.Name = "CategoryLabel1";
            this.CategoryLabel1.Size = new System.Drawing.Size(56, 23);
            this.CategoryLabel1.TabIndex = 14;
            this.CategoryLabel1.Text = "label4";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.CategoryLabel1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.productImages);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(1254, 190);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductCard_Paint);
            this.MouseLeave += new System.EventHandler(this.ProductCard_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProductCard_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.productImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.PictureBox productImages;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label CategoryLabel1;
    }
}
