namespace VinVentory
{
    partial class AddStickerForm
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
            this.NotificationUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderLinkTextBox = new System.Windows.Forms.TextBox();
            this.TotalRadio = new System.Windows.Forms.RadioButton();
            this.PerUnitRadio = new System.Windows.Forms.RadioButton();
            this.label36 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationUpDown
            // 
            this.NotificationUpDown.Location = new System.Drawing.Point(321, 169);
            this.NotificationUpDown.Name = "NotificationUpDown";
            this.NotificationUpDown.Size = new System.Drawing.Size(120, 22);
            this.NotificationUpDown.TabIndex = 30;
            this.NotificationUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Notification amount";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 35;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Reorder Link";
            // 
            // OrderLinkTextBox
            // 
            this.OrderLinkTextBox.Location = new System.Drawing.Point(321, 109);
            this.OrderLinkTextBox.MaxLength = 1024;
            this.OrderLinkTextBox.Name = "OrderLinkTextBox";
            this.OrderLinkTextBox.Size = new System.Drawing.Size(220, 22);
            this.OrderLinkTextBox.TabIndex = 28;
            // 
            // TotalRadio
            // 
            this.TotalRadio.AutoSize = true;
            this.TotalRadio.Checked = true;
            this.TotalRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRadio.Location = new System.Drawing.Point(24, 198);
            this.TotalRadio.Name = "TotalRadio";
            this.TotalRadio.Size = new System.Drawing.Size(50, 17);
            this.TotalRadio.TabIndex = 24;
            this.TotalRadio.TabStop = true;
            this.TotalRadio.Text = "Total";
            this.TotalRadio.UseVisualStyleBackColor = true;
            // 
            // PerUnitRadio
            // 
            this.PerUnitRadio.AutoSize = true;
            this.PerUnitRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerUnitRadio.Location = new System.Drawing.Point(80, 198);
            this.PerUnitRadio.Name = "PerUnitRadio";
            this.PerUnitRadio.Size = new System.Drawing.Size(64, 17);
            this.PerUnitRadio.TabIndex = 25;
            this.PerUnitRadio.Text = "Per unit";
            this.PerUnitRadio.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(21, 150);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(45, 17);
            this.label36.TabIndex = 29;
            this.label36.Text = "Cost *";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(24, 170);
            this.CostTextBox.MaxLength = 10;
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(120, 22);
            this.CostTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Supplier Name";
            // 
            // SupplierTextBox
            // 
            this.SupplierTextBox.Location = new System.Drawing.Point(321, 49);
            this.SupplierTextBox.MaxLength = 128;
            this.SupplierTextBox.Name = "SupplierTextBox";
            this.SupplierTextBox.Size = new System.Drawing.Size(220, 22);
            this.SupplierTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quanity *";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(21, 109);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(220, 22);
            this.QuantityTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Item Name *";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(21, 49);
            this.NameTextBox.MaxLength = 128;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(220, 22);
            this.NameTextBox.TabIndex = 19;
            // 
            // AddStickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.NotificationUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderLinkTextBox);
            this.Controls.Add(this.TotalRadio);
            this.Controls.Add(this.PerUnitRadio);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupplierTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Name = "AddStickerForm";
            this.Text = "AddStickerForm";
            ((System.ComponentModel.ISupportInitialize)(this.NotificationUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NotificationUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderLinkTextBox;
        private System.Windows.Forms.RadioButton TotalRadio;
        private System.Windows.Forms.RadioButton PerUnitRadio;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplierTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}