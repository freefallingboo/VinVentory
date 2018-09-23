namespace VinVentory
{
    partial class AddSecondaryItemForm
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
            this.components = new System.ComponentModel.Container();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierTextBox = new System.Windows.Forms.TextBox();
            this.TotalRadio = new System.Windows.Forms.RadioButton();
            this.PerUnitRadio = new System.Windows.Forms.RadioButton();
            this.label36 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderLinkTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AppKitBox = new System.Windows.Forms.CheckBox();
            this.MailerBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NotificationUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 43);
            this.NameTextBox.MaxLength = 128;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(220, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quanity *";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(12, 103);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(220, 22);
            this.QuantityTextBox.TabIndex = 2;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier Name";
            // 
            // SupplierTextBox
            // 
            this.SupplierTextBox.Location = new System.Drawing.Point(312, 43);
            this.SupplierTextBox.MaxLength = 128;
            this.SupplierTextBox.Name = "SupplierTextBox";
            this.SupplierTextBox.Size = new System.Drawing.Size(220, 22);
            this.SupplierTextBox.TabIndex = 6;
            this.SupplierTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TotalRadio
            // 
            this.TotalRadio.AutoSize = true;
            this.TotalRadio.Checked = true;
            this.TotalRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRadio.Location = new System.Drawing.Point(15, 192);
            this.TotalRadio.Name = "TotalRadio";
            this.TotalRadio.Size = new System.Drawing.Size(50, 17);
            this.TotalRadio.TabIndex = 4;
            this.TotalRadio.TabStop = true;
            this.TotalRadio.Text = "Total";
            this.TotalRadio.UseVisualStyleBackColor = true;
            // 
            // PerUnitRadio
            // 
            this.PerUnitRadio.AutoSize = true;
            this.PerUnitRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerUnitRadio.Location = new System.Drawing.Point(71, 192);
            this.PerUnitRadio.Name = "PerUnitRadio";
            this.PerUnitRadio.Size = new System.Drawing.Size(64, 17);
            this.PerUnitRadio.TabIndex = 5;
            this.PerUnitRadio.Text = "Per unit";
            this.PerUnitRadio.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(12, 144);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(45, 17);
            this.label36.TabIndex = 8;
            this.label36.Text = "Cost *";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(15, 164);
            this.CostTextBox.MaxLength = 10;
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(120, 22);
            this.CostTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Reorder Link";
            // 
            // OrderLinkTextBox
            // 
            this.OrderLinkTextBox.Location = new System.Drawing.Point(312, 103);
            this.OrderLinkTextBox.MaxLength = 1024;
            this.OrderLinkTextBox.Name = "OrderLinkTextBox";
            this.OrderLinkTextBox.Size = new System.Drawing.Size(220, 22);
            this.OrderLinkTextBox.TabIndex = 7;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // AppKitBox
            // 
            this.AppKitBox.AutoSize = true;
            this.AppKitBox.Location = new System.Drawing.Point(312, 201);
            this.AppKitBox.Name = "AppKitBox";
            this.AppKitBox.Size = new System.Drawing.Size(119, 21);
            this.AppKitBox.TabIndex = 9;
            this.AppKitBox.Text = "Application Kit";
            this.AppKitBox.UseVisualStyleBackColor = true;
            // 
            // MailerBox
            // 
            this.MailerBox.AutoSize = true;
            this.MailerBox.Location = new System.Drawing.Point(464, 201);
            this.MailerBox.Name = "MailerBox";
            this.MailerBox.Size = new System.Drawing.Size(68, 21);
            this.MailerBox.TabIndex = 10;
            this.MailerBox.Text = "Mailer";
            this.MailerBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Notification amount";
            // 
            // NotificationUpDown
            // 
            this.NotificationUpDown.Location = new System.Drawing.Point(312, 163);
            this.NotificationUpDown.Name = "NotificationUpDown";
            this.NotificationUpDown.Size = new System.Drawing.Size(120, 22);
            this.NotificationUpDown.TabIndex = 8;
            this.NotificationUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddSecondaryItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.NotificationUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MailerBox);
            this.Controls.Add(this.AppKitBox);
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
            this.Name = "AddSecondaryItemForm";
            this.Text = "AddSecondaryItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.NotificationUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplierTextBox;
        private System.Windows.Forms.RadioButton TotalRadio;
        private System.Windows.Forms.RadioButton PerUnitRadio;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderLinkTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox AppKitBox;
        private System.Windows.Forms.CheckBox MailerBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NotificationUpDown;
    }
}