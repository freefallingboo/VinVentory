namespace VinVentory
{
    partial class OutgoingOrderAlternate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VinylGridView = new System.Windows.Forms.DataGridView();
            this.StickerGridView = new System.Windows.Forms.DataGridView();
            this.StickerDGVComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StickerDGVQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherGridView = new System.Windows.Forms.DataGridView();
            this.OtherItemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Savebtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.vinylAppKitCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ItemsInOrderTBox = new System.Windows.Forms.TextBox();
            this.ItemsInOrderlbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.PriceTBox = new System.Windows.Forms.TextBox();
            this.VinylDGVColorCB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FullSheetDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreeQuarterSheetDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HalfSheetDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuarterSheetDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scraps = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VinylKitCountNumBox = new System.Windows.Forms.NumericUpDown();
            this.ShirtGridView = new System.Windows.Forms.DataGridView();
            this.ShirtColorComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ShirtStyleComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ShirtSizeComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ShirtGridQuantityTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stickerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secondaryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secondaryItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VinylGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StickerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinylKitCountNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShirtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stickerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VinylGridView
            // 
            this.VinylGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VinylGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VinylGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VinylGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VinylDGVColorCB,
            this.FullSheetDGV,
            this.ThreeQuarterSheetDGV,
            this.HalfSheetDGV,
            this.QuarterSheetDGV,
            this.Scraps});
            this.VinylGridView.Location = new System.Drawing.Point(12, 30);
            this.VinylGridView.Name = "VinylGridView";
            this.VinylGridView.RowTemplate.Height = 24;
            this.VinylGridView.Size = new System.Drawing.Size(865, 150);
            this.VinylGridView.TabIndex = 0;
            this.VinylGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VinylGridView_CellContentClick);
            this.VinylGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.VinylGridView_DataError);
            this.VinylGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.VinylGridView_UserAddedRow);
            this.VinylGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.VinylGridView_UserDeletedRow);
            // 
            // StickerGridView
            // 
            this.StickerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StickerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StickerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StickerDGVComboBox,
            this.StickerDGVQuantity});
            this.StickerGridView.Location = new System.Drawing.Point(16, 419);
            this.StickerGridView.Name = "StickerGridView";
            this.StickerGridView.RowTemplate.Height = 24;
            this.StickerGridView.Size = new System.Drawing.Size(377, 150);
            this.StickerGridView.TabIndex = 1;
            this.StickerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StickerGridView_CellContentClick);
            this.StickerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StickerGridView_CellContentClick);
            this.StickerGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.StickerGridView_CellContentClick);
            this.StickerGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.StickerGridView_DataError);
            this.StickerGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.StickerGridView_UserAddedRow);
            this.StickerGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.StickerGridView_UserDeletedRow);
            this.StickerGridView.Leave += new System.EventHandler(this.StickerGridView_Leave);
            // 
            // StickerDGVComboBox
            // 
            this.StickerDGVComboBox.DataPropertyName = "Name";
            this.StickerDGVComboBox.DataSource = this.stickerBindingSource;
            this.StickerDGVComboBox.DisplayMember = "Name";
            this.StickerDGVComboBox.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.StickerDGVComboBox.HeaderText = "Name";
            this.StickerDGVComboBox.Name = "StickerDGVComboBox";
            this.StickerDGVComboBox.ValueMember = "ID";
            // 
            // StickerDGVQuantity
            // 
            this.StickerDGVQuantity.HeaderText = "Quantity";
            this.StickerDGVQuantity.Name = "StickerDGVQuantity";
            // 
            // OtherGridView
            // 
            this.OtherGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OtherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtherGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OtherItemName,
            this.Quantity});
            this.OtherGridView.Location = new System.Drawing.Point(16, 616);
            this.OtherGridView.Name = "OtherGridView";
            this.OtherGridView.RowTemplate.Height = 24;
            this.OtherGridView.Size = new System.Drawing.Size(377, 150);
            this.OtherGridView.TabIndex = 2;
            this.OtherGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OtherGridView_CellContentClick);
            this.OtherGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.OtherGridView_DataError);
            this.OtherGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.OtherGridView_DefaultValuesNeeded);
            this.OtherGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OtherGridView_UserAddedRow);
            // 
            // OtherItemName
            // 
            this.OtherItemName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.OtherItemName.HeaderText = "Name";
            this.OtherItemName.Name = "OtherItemName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MaxInputLength = 32;
            this.Quantity.Name = "Quantity";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(406, 797);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(127, 37);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(746, 797);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(127, 37);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // vinylAppKitCheckBox
            // 
            this.vinylAppKitCheckBox.AutoSize = true;
            this.vinylAppKitCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinylAppKitCheckBox.Location = new System.Drawing.Point(462, 419);
            this.vinylAppKitCheckBox.Name = "vinylAppKitCheckBox";
            this.vinylAppKitCheckBox.Size = new System.Drawing.Size(290, 36);
            this.vinylAppKitCheckBox.TabIndex = 5;
            this.vinylAppKitCheckBox.Text = "Vinyl Application Kit";
            this.vinylAppKitCheckBox.UseVisualStyleBackColor = true;
            this.vinylAppKitCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(577, 797);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(127, 37);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "Order Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(462, 539);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(388, 30);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // ItemsInOrderTBox
            // 
            this.ItemsInOrderTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsInOrderTBox.Location = new System.Drawing.Point(462, 687);
            this.ItemsInOrderTBox.Name = "ItemsInOrderTBox";
            this.ItemsInOrderTBox.Size = new System.Drawing.Size(100, 30);
            this.ItemsInOrderTBox.TabIndex = 28;
            // 
            // ItemsInOrderlbl
            // 
            this.ItemsInOrderlbl.AutoSize = true;
            this.ItemsInOrderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsInOrderlbl.Location = new System.Drawing.Point(457, 659);
            this.ItemsInOrderlbl.Name = "ItemsInOrderlbl";
            this.ItemsInOrderlbl.Size = new System.Drawing.Size(134, 25);
            this.ItemsInOrderlbl.TabIndex = 29;
            this.ItemsInOrderlbl.Text = "Items in Order";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.Location = new System.Drawing.Point(680, 659);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(141, 25);
            this.Pricelbl.TabIndex = 31;
            this.Pricelbl.Text = "Customer Paid";
            // 
            // PriceTBox
            // 
            this.PriceTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTBox.Location = new System.Drawing.Point(685, 687);
            this.PriceTBox.Name = "PriceTBox";
            this.PriceTBox.Size = new System.Drawing.Size(100, 30);
            this.PriceTBox.TabIndex = 30;
            // 
            // VinylDGVColorCB
            // 
            this.VinylDGVColorCB.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.VinylDGVColorCB.HeaderText = "Color";
            this.VinylDGVColorCB.Name = "VinylDGVColorCB";
            // 
            // FullSheetDGV
            // 
            this.FullSheetDGV.HeaderText = "Full Sheet";
            this.FullSheetDGV.Name = "FullSheetDGV";
            // 
            // ThreeQuarterSheetDGV
            // 
            this.ThreeQuarterSheetDGV.HeaderText = "3/4 Sheet";
            this.ThreeQuarterSheetDGV.Name = "ThreeQuarterSheetDGV";
            // 
            // HalfSheetDGV
            // 
            this.HalfSheetDGV.HeaderText = "1/2 Sheet";
            this.HalfSheetDGV.Name = "HalfSheetDGV";
            // 
            // QuarterSheetDGV
            // 
            this.QuarterSheetDGV.HeaderText = "1/4 Sheet";
            this.QuarterSheetDGV.Name = "QuarterSheetDGV";
            // 
            // Scraps
            // 
            this.Scraps.HeaderText = "Used Scrap";
            this.Scraps.Name = "Scraps";
            // 
            // VinylKitCountNumBox
            // 
            this.VinylKitCountNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VinylKitCountNumBox.Location = new System.Drawing.Point(783, 419);
            this.VinylKitCountNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VinylKitCountNumBox.Name = "VinylKitCountNumBox";
            this.VinylKitCountNumBox.Size = new System.Drawing.Size(67, 34);
            this.VinylKitCountNumBox.TabIndex = 32;
            this.VinylKitCountNumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VinylKitCountNumBox.Visible = false;
            // 
            // ShirtGridView
            // 
            this.ShirtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShirtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShirtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShirtColorComboBox,
            this.ShirtStyleComboBox,
            this.ShirtSizeComboBox,
            this.ShirtGridQuantityTextBox});
            this.ShirtGridView.Location = new System.Drawing.Point(12, 224);
            this.ShirtGridView.Name = "ShirtGridView";
            this.ShirtGridView.RowTemplate.Height = 24;
            this.ShirtGridView.Size = new System.Drawing.Size(537, 150);
            this.ShirtGridView.TabIndex = 33;
            this.ShirtGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ShirtGridView_DefaultValuesNeeded);
            this.ShirtGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ShirtGridView_UserAddedRow);
            this.ShirtGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ShirtGridView_UserDeletedRow);
            this.ShirtGridView.Click += new System.EventHandler(this.ShirtGridView_Click);
            this.ShirtGridView.Enter += new System.EventHandler(this.ShirtGridView_Enter);
            // 
            // ShirtColorComboBox
            // 
            this.ShirtColorComboBox.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ShirtColorComboBox.HeaderText = "Color";
            this.ShirtColorComboBox.Name = "ShirtColorComboBox";
            // 
            // ShirtStyleComboBox
            // 
            this.ShirtStyleComboBox.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ShirtStyleComboBox.HeaderText = "Style";
            this.ShirtStyleComboBox.Name = "ShirtStyleComboBox";
            // 
            // ShirtSizeComboBox
            // 
            this.ShirtSizeComboBox.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ShirtSizeComboBox.HeaderText = "Size";
            this.ShirtSizeComboBox.Name = "ShirtSizeComboBox";
            // 
            // ShirtGridQuantityTextBox
            // 
            this.ShirtGridQuantityTextBox.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.ShirtGridQuantityTextBox.DefaultCellStyle = dataGridViewCellStyle4;
            this.ShirtGridQuantityTextBox.HeaderText = "Quantity";
            this.ShirtGridQuantityTextBox.MaxInputLength = 32;
            this.ShirtGridQuantityTextBox.Name = "ShirtGridQuantityTextBox";
            // 
            // stickerBindingSource
            // 
            this.stickerBindingSource.DataSource = typeof(VinVentory.Sticker);
            // 
            // vProductBindingSource
            // 
            this.vProductBindingSource.DataSource = typeof(VinVentory.v_Product);
            // 
            // secondaryItemBindingSource
            // 
            this.secondaryItemBindingSource.DataSource = typeof(VinVentory.SecondaryItem);
            // 
            // secondaryItemsBindingSource
            // 
            this.secondaryItemsBindingSource.DataSource = typeof(VinVentory.SecondaryItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Vinyl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Shirts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Stickers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Shipping Items";
            // 
            // OutgoingOrderAlternate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 849);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShirtGridView);
            this.Controls.Add(this.VinylKitCountNumBox);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.PriceTBox);
            this.Controls.Add(this.ItemsInOrderlbl);
            this.Controls.Add(this.ItemsInOrderTBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.vinylAppKitCheckBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.OtherGridView);
            this.Controls.Add(this.StickerGridView);
            this.Controls.Add(this.VinylGridView);
            this.Name = "OutgoingOrderAlternate";
            this.Text = "Outgoing Order";
            ((System.ComponentModel.ISupportInitialize)(this.VinylGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StickerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinylKitCountNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShirtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stickerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VinylGridView;
        private System.Windows.Forms.DataGridView StickerGridView;
        private System.Windows.Forms.DataGridView OtherGridView;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.BindingSource vProductBindingSource;
        private System.Windows.Forms.BindingSource stickerBindingSource;
        private System.Windows.Forms.BindingSource secondaryItemBindingSource;
        private System.Windows.Forms.BindingSource secondaryItemsBindingSource;
        private System.Windows.Forms.CheckBox vinylAppKitCheckBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewComboBoxColumn OtherItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn StickerDGVComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn StickerDGVQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn VinylDGVColorCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullSheetDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreeQuarterSheetDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HalfSheetDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuarterSheetDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Scraps;
        private System.Windows.Forms.TextBox ItemsInOrderTBox;
        private System.Windows.Forms.Label ItemsInOrderlbl;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.TextBox PriceTBox;
        private System.Windows.Forms.NumericUpDown VinylKitCountNumBox;
        private System.Windows.Forms.DataGridView ShirtGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn ShirtColorComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn ShirtStyleComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn ShirtSizeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShirtGridQuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}