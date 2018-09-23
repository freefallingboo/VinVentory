namespace VinVentory
{
    partial class EstyFeeCalculatorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtsyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PmtFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBFShip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(994, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListPrice,
            this.ShippingPrice,
            this.Payment,
            this.Commision,
            this.Items,
            this.EtsyFee,
            this.PmtFee,
            this.PriceBFShip,
            this.ShippingCost,
            this.TotalFees,
            this.Profit});
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1357, 433);
            this.dataGridView1.TabIndex = 2;
            // 
            // ListPrice
            // 
            this.ListPrice.HeaderText = "List Price";
            this.ListPrice.MaxInputLength = 20;
            this.ListPrice.Name = "ListPrice";
            // 
            // ShippingPrice
            // 
            this.ShippingPrice.HeaderText = "Shipping";
            this.ShippingPrice.Name = "ShippingPrice";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Total Payment";
            this.Payment.Name = "Payment";
            // 
            // Commision
            // 
            this.Commision.HeaderText = "Commision";
            this.Commision.Name = "Commision";
            // 
            // Items
            // 
            this.Items.HeaderText = "Items";
            this.Items.Name = "Items";
            // 
            // EtsyFee
            // 
            this.EtsyFee.HeaderText = "EtsyFee";
            this.EtsyFee.Name = "EtsyFee";
            // 
            // PmtFee
            // 
            this.PmtFee.HeaderText = "Payment Fee";
            this.PmtFee.Name = "PmtFee";
            this.PmtFee.ReadOnly = true;
            // 
            // PriceBFShip
            // 
            this.PriceBFShip.HeaderText = "Price Before Shipping";
            this.PriceBFShip.Name = "PriceBFShip";
            // 
            // ShippingCost
            // 
            this.ShippingCost.HeaderText = "Shipping Cost";
            this.ShippingCost.Name = "ShippingCost";
            // 
            // TotalFees
            // 
            this.TotalFees.HeaderText = "Total Fees";
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1200, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EstyFeeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 513);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "EstyFeeCalculatorForm";
            this.Text = "EstyFeeCalculatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtsyFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PmtFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBFShip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Button button2;
    }
}