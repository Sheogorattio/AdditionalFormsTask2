namespace AdditionalFormsTask2
{
    partial class Sale
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
            this.ItemsForSale = new System.Windows.Forms.ListBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemsForSale
            // 
            this.ItemsForSale.FormattingEnabled = true;
            this.ItemsForSale.ItemHeight = 16;
            this.ItemsForSale.Location = new System.Drawing.Point(12, 12);
            this.ItemsForSale.Name = "ItemsForSale";
            this.ItemsForSale.Size = new System.Drawing.Size(218, 260);
            this.ItemsForSale.TabIndex = 0;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(307, 145);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.PriceTextBox.TabIndex = 1;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(307, 173);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cart";
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(239, 79);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(86, 60);
            this.AddItem.TabIndex = 5;
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = true;
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(321, 79);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(86, 60);
            this.DeleteItem.TabIndex = 5;
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.UseVisualStyleBackColor = true;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(239, 201);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(168, 71);
            this.BuyButton.TabIndex = 6;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 293);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ItemsForSale);
            this.Name = "Sale";
            this.Text = "Sale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsForSale;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button BuyButton;
    }
}