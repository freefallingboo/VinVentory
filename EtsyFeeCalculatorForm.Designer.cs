namespace VinVentory
{
    partial class EtsyFeeCalculatorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.FeeEntryDGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.SavedFeeDGV = new System.Windows.Forms.DataGridView();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtsyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PmtFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBFShip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FeeEntryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavedFeeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FeeEntryDGV
            // 
            this.FeeEntryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.FeeEntryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeeEntryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListPrice,
            this.ShippingPrice,
            this.Payment,
            this.Items,
            this.Commision,
            this.EtsyFee,
            this.PmtFee,
            this.TotalFees,
            this.PriceBFShip,
            this.ShippingCost,
            this.Profit});
            this.FeeEntryDGV.Location = new System.Drawing.Point(13, 12);
            this.FeeEntryDGV.Name = "FeeEntryDGV";
            this.FeeEntryDGV.RowTemplate.Height = 24;
            this.FeeEntryDGV.Size = new System.Drawing.Size(1327, 131);
            this.FeeEntryDGV.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1170, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SavedFeeDGV
            // 
            this.SavedFeeDGV.AllowUserToAddRows = false;
            this.SavedFeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.SavedFeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SavedFeeDGV.Location = new System.Drawing.Point(13, 246);
            this.SavedFeeDGV.Name = "SavedFeeDGV";
            this.SavedFeeDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.SavedFeeDGV.RowTemplate.Height = 24;
            this.SavedFeeDGV.Size = new System.Drawing.Size(1335, 202);
            this.SavedFeeDGV.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(1170, 164);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(170, 35);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Saved Fee Calculations";
            // 
            // ListPrice
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ListPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.ListPrice.HeaderText = "Listed Price";
            this.ListPrice.MaxInputLength = 20;
            this.ListPrice.Name = "ListPrice";
            this.ListPrice.Width = 111;
            // 
            // ShippingPrice
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ShippingPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.ShippingPrice.HeaderText = "Listed Shipping";
            this.ShippingPrice.Name = "ShippingPrice";
            this.ShippingPrice.Width = 123;
            // 
            // Payment
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Payment.DefaultCellStyle = dataGridViewCellStyle3;
            this.Payment.HeaderText = "Total Payment";
            this.Payment.Name = "Payment";
            this.Payment.Width = 118;
            // 
            // Items
            // 
            this.Items.HeaderText = "Items";
            this.Items.Name = "Items";
            this.Items.Width = 70;
            // 
            // Commision
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Commision.DefaultCellStyle = dataGridViewCellStyle4;
            this.Commision.HeaderText = "Commision";
            this.Commision.Name = "Commision";
            this.Commision.ReadOnly = true;
            this.Commision.Width = 105;
            // 
            // EtsyFee
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.EtsyFee.DefaultCellStyle = dataGridViewCellStyle5;
            this.EtsyFee.HeaderText = "EtsyFee";
            this.EtsyFee.Name = "EtsyFee";
            this.EtsyFee.Width = 88;
            // 
            // PmtFee
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.PmtFee.DefaultCellStyle = dataGridViewCellStyle6;
            this.PmtFee.HeaderText = "Payment Fee";
            this.PmtFee.Name = "PmtFee";
            this.PmtFee.ReadOnly = true;
            this.PmtFee.Width = 110;
            // 
            // TotalFees
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.TotalFees.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalFees.HeaderText = "Total Fees";
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.ReadOnly = true;
            this.TotalFees.Width = 96;
            // 
            // PriceBFShip
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.PriceBFShip.DefaultCellStyle = dataGridViewCellStyle8;
            this.PriceBFShip.HeaderText = "Profit Before Shipping";
            this.PriceBFShip.Name = "PriceBFShip";
            this.PriceBFShip.ReadOnly = true;
            this.PriceBFShip.Width = 160;
            // 
            // ShippingCost
            // 
            this.ShippingCost.HeaderText = "Actual Shipping";
            this.ShippingCost.Name = "ShippingCost";
            this.ShippingCost.Width = 124;
            // 
            // Profit
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Profit.DefaultCellStyle = dataGridViewCellStyle9;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 70;
            // 
            // EtsyFeeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SavedFeeDGV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FeeEntryDGV);
            this.Controls.Add(this.button1);
            this.Name = "EtsyFeeCalculatorForm";
            this.Text = "EstyFeeCalculatorForm";
            this.Load += new System.EventHandler(this.EtsyFeeCalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeeEntryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavedFeeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView FeeEntryDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView SavedFeeDGV;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commision;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtsyFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PmtFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBFShip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}