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
            this.VinylGridView = new System.Windows.Forms.DataGridView();
            this.vProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StickerGridView = new System.Windows.Forms.DataGridView();
            this.StickerDGVComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stickerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StickerDGVQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherGridView = new System.Windows.Forms.DataGridView();
            this.OtherItemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondaryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Savebtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.vinylAppKitCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.secondaryItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.VinylGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StickerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stickerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinylKitCountNumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VinylGridView
            // 
            this.VinylGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VinylGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VinylDGVColorCB,
            this.FullSheetDGV,
            this.ThreeQuarterSheetDGV,
            this.HalfSheetDGV,
            this.QuarterSheetDGV,
            this.Scraps});
            this.VinylGridView.Location = new System.Drawing.Point(13, 12);
            this.VinylGridView.Name = "VinylGridView";
            this.VinylGridView.RowTemplate.Height = 24;
            this.VinylGridView.Size = new System.Drawing.Size(865, 150);
            this.VinylGridView.TabIndex = 0;
            this.VinylGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VinylGridView_CellContentClick);
            this.VinylGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.VinylGridView_DataError);
            this.VinylGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.VinylGridView_UserAddedRow);
            this.VinylGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.VinylGridView_UserDeletedRow);
            // 
            // vProductBindingSource
            // 
            this.vProductBindingSource.DataSource = typeof(VinVentory.v_Product);
            // 
            // StickerGridView
            // 
            this.StickerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StickerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StickerDGVComboBox,
            this.StickerDGVQuantity});
            this.StickerGridView.Location = new System.Drawing.Point(12, 195);
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
            this.StickerDGVComboBox.Width = 140;
            // 
            // stickerBindingSource
            // 
            this.stickerBindingSource.DataSource = typeof(VinVentory.Sticker);
            // 
            // StickerDGVQuantity
            // 
            this.StickerDGVQuantity.HeaderText = "Quantity";
            this.StickerDGVQuantity.Name = "StickerDGVQuantity";
            // 
            // OtherGridView
            // 
            this.OtherGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtherGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OtherItemName,
            this.Quantity});
            this.OtherGridView.Location = new System.Drawing.Point(12, 378);
            this.OtherGridView.Name = "OtherGridView";
            this.OtherGridView.RowTemplate.Height = 24;
            this.OtherGridView.Size = new System.Drawing.Size(377, 150);
            this.OtherGridView.TabIndex = 2;
            this.OtherGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OtherGridView_CellContentClick);
            this.OtherGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.OtherGridView_DataError);
            this.OtherGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OtherGridView_UserAddedRow);
            // 
            // OtherItemName
            // 
            this.OtherItemName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.OtherItemName.HeaderText = "Name";
            this.OtherItemName.Name = "OtherItemName";
            this.OtherItemName.Width = 140;
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
            // secondaryItemBindingSource
            // 
            this.secondaryItemBindingSource.DataSource = typeof(VinVentory.SecondaryItem);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(379, 558);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(143, 37);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(719, 558);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(143, 37);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // vinylAppKitCheckBox
            // 
            this.vinylAppKitCheckBox.AutoSize = true;
            this.vinylAppKitCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vinylAppKitCheckBox.Location = new System.Drawing.Point(453, 195);
            this.vinylAppKitCheckBox.Name = "vinylAppKitCheckBox";
            this.vinylAppKitCheckBox.Size = new System.Drawing.Size(290, 36);
            this.vinylAppKitCheckBox.TabIndex = 5;
            this.vinylAppKitCheckBox.Text = "Vinyl Application Kit";
            this.vinylAppKitCheckBox.UseVisualStyleBackColor = true;
            this.vinylAppKitCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(550, 558);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(143, 37);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "Order Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 315);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(388, 30);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // secondaryItemsBindingSource
            // 
            this.secondaryItemsBindingSource.DataSource = typeof(VinVentory.SecondaryItem);
            // 
            // ItemsInOrderTBox
            // 
            this.ItemsInOrderTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsInOrderTBox.Location = new System.Drawing.Point(458, 449);
            this.ItemsInOrderTBox.Name = "ItemsInOrderTBox";
            this.ItemsInOrderTBox.Size = new System.Drawing.Size(100, 30);
            this.ItemsInOrderTBox.TabIndex = 28;
            // 
            // ItemsInOrderlbl
            // 
            this.ItemsInOrderlbl.AutoSize = true;
            this.ItemsInOrderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsInOrderlbl.Location = new System.Drawing.Point(453, 421);
            this.ItemsInOrderlbl.Name = "ItemsInOrderlbl";
            this.ItemsInOrderlbl.Size = new System.Drawing.Size(134, 25);
            this.ItemsInOrderlbl.TabIndex = 29;
            this.ItemsInOrderlbl.Text = "Items in Order";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.Location = new System.Drawing.Point(676, 421);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(141, 25);
            this.Pricelbl.TabIndex = 31;
            this.Pricelbl.Text = "Customer Paid";
            // 
            // PriceTBox
            // 
            this.PriceTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTBox.Location = new System.Drawing.Point(681, 449);
            this.PriceTBox.Name = "PriceTBox";
            this.PriceTBox.Size = new System.Drawing.Size(100, 30);
            this.PriceTBox.TabIndex = 30;
            // 
            // VinylDGVColorCB
            // 
            this.VinylDGVColorCB.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.VinylDGVColorCB.HeaderText = "Color";
            this.VinylDGVColorCB.Name = "VinylDGVColorCB";
            this.VinylDGVColorCB.Width = 140;
            // 
            // FullSheetDGV
            // 
            this.FullSheetDGV.HeaderText = "Full Sheet";
            this.FullSheetDGV.Name = "FullSheetDGV";
            this.FullSheetDGV.Width = 90;
            // 
            // ThreeQuarterSheetDGV
            // 
            this.ThreeQuarterSheetDGV.HeaderText = "3/4 Sheet";
            this.ThreeQuarterSheetDGV.Name = "ThreeQuarterSheetDGV";
            this.ThreeQuarterSheetDGV.Width = 90;
            // 
            // HalfSheetDGV
            // 
            this.HalfSheetDGV.HeaderText = "1/2 Sheet";
            this.HalfSheetDGV.Name = "HalfSheetDGV";
            this.HalfSheetDGV.Width = 90;
            // 
            // QuarterSheetDGV
            // 
            this.QuarterSheetDGV.HeaderText = "1/4 Sheet";
            this.QuarterSheetDGV.Name = "QuarterSheetDGV";
            this.QuarterSheetDGV.Width = 90;
            // 
            // Scraps
            // 
            this.Scraps.HeaderText = "Used Scrap";
            this.Scraps.Name = "Scraps";
            // 
            // VinylKitCountNumBox
            // 
            this.VinylKitCountNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VinylKitCountNumBox.Location = new System.Drawing.Point(774, 195);
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
            // OutgoingOrderAlternate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 607);
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
            this.Text = "OutgoingOrderAlternate";
            ((System.ComponentModel.ISupportInitialize)(this.VinylGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StickerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stickerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondaryItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinylKitCountNumBox)).EndInit();
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
    }
}