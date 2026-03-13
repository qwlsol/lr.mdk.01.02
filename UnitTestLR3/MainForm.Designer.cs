namespace UnitTestLR3
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalOrdersDish = new System.Windows.Forms.NumericUpDown();
            this.RichTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.ButtonOrderDish = new System.Windows.Forms.Button();
            this.ComboBoxDish = new System.Windows.Forms.ComboBox();
            this.ListBoxGroup = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.totalOrdersDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выбериете кол-во порций";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выберите блюдо";
            // 
            // totalOrdersDish
            // 
            this.totalOrdersDish.Location = new System.Drawing.Point(352, 73);
            this.totalOrdersDish.Margin = new System.Windows.Forms.Padding(2);
            this.totalOrdersDish.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalOrdersDish.Name = "totalOrdersDish";
            this.totalOrdersDish.Size = new System.Drawing.Size(86, 20);
            this.totalOrdersDish.TabIndex = 12;
            this.totalOrdersDish.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RichTextBoxInfo
            // 
            this.RichTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxInfo.Location = new System.Drawing.Point(443, 15);
            this.RichTextBoxInfo.Name = "RichTextBoxInfo";
            this.RichTextBoxInfo.Size = new System.Drawing.Size(458, 125);
            this.RichTextBoxInfo.TabIndex = 11;
            this.RichTextBoxInfo.Text = "";
            // 
            // ButtonOrderDish
            // 
            this.ButtonOrderDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOrderDish.Location = new System.Drawing.Point(302, 168);
            this.ButtonOrderDish.Name = "ButtonOrderDish";
            this.ButtonOrderDish.Size = new System.Drawing.Size(126, 30);
            this.ButtonOrderDish.TabIndex = 10;
            this.ButtonOrderDish.Text = "Отчёт";
            this.ButtonOrderDish.UseVisualStyleBackColor = true;
            // 
            // ComboBoxDish
            // 
            this.ComboBoxDish.FormattingEnabled = true;
            this.ComboBoxDish.Location = new System.Drawing.Point(288, 17);
            this.ComboBoxDish.Name = "ComboBoxDish";
            this.ComboBoxDish.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxDish.TabIndex = 9;
            // 
            // ListBoxGroup
            // 
            this.ListBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxGroup.FormattingEnabled = true;
            this.ListBoxGroup.ItemHeight = 16;
            this.ListBoxGroup.Location = new System.Drawing.Point(2, 0);
            this.ListBoxGroup.Name = "ListBoxGroup";
            this.ListBoxGroup.Size = new System.Drawing.Size(126, 436);
            this.ListBoxGroup.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(475, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 224);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(907, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalOrdersDish);
            this.Controls.Add(this.RichTextBoxInfo);
            this.Controls.Add(this.ButtonOrderDish);
            this.Controls.Add(this.ComboBoxDish);
            this.Controls.Add(this.ListBoxGroup);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.totalOrdersDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrderLog;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ComboBox comboBoxDishes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBoxDish;
        private System.Windows.Forms.Label lblGroupInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown totalOrdersDish;
        private System.Windows.Forms.RichTextBox RichTextBoxInfo;
        private System.Windows.Forms.Button ButtonOrderDish;
        private System.Windows.Forms.ComboBox ComboBoxDish;
        private System.Windows.Forms.ListBox ListBoxGroup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}