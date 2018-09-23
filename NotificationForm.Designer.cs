namespace VinVentory
{
    partial class NotificationForm
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
            this.NeedToOrderDataGrid = new System.Windows.Forms.DataGridView();
            this.vNeedToOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nicsInventory1DataSet = new VinVentory.NicsInventory1DataSet();
            this.vAllQuantitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_AllQuantitiesTableAdapter = new VinVentory.NicsInventory1DataSetTableAdapters.V_AllQuantitiesTableAdapter();
            this.v_NeedToOrderTableAdapter = new VinVentory.NicsInventory1DataSetTableAdapters.V_NeedToOrderTableAdapter();
            this.tableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NeedToOrderDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNeedToOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicsInventory1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAllQuantitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NeedToOrderDataGrid
            // 
            this.NeedToOrderDataGrid.AutoGenerateColumns = false;
            this.NeedToOrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.NeedToOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NeedToOrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.ItemLink});
            this.NeedToOrderDataGrid.DataSource = this.vNeedToOrderBindingSource;
            this.NeedToOrderDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NeedToOrderDataGrid.Location = new System.Drawing.Point(0, 0);
            this.NeedToOrderDataGrid.Name = "NeedToOrderDataGrid";
            this.NeedToOrderDataGrid.RowTemplate.Height = 24;
            this.NeedToOrderDataGrid.Size = new System.Drawing.Size(800, 450);
            this.NeedToOrderDataGrid.TabIndex = 0;
            this.NeedToOrderDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NeedToOrderDataGrid_CellContentClick);
            // 
            // vNeedToOrderBindingSource
            // 
            this.vNeedToOrderBindingSource.DataMember = "V_NeedToOrder";
            this.vNeedToOrderBindingSource.DataSource = this.nicsInventory1DataSet;
            // 
            // nicsInventory1DataSet
            // 
            this.nicsInventory1DataSet.DataSetName = "NicsInventory1DataSet";
            this.nicsInventory1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vAllQuantitiesBindingSource
            // 
            this.vAllQuantitiesBindingSource.DataMember = "V_AllQuantities";
            this.vAllQuantitiesBindingSource.DataSource = this.nicsInventory1DataSet;
            // 
            // v_AllQuantitiesTableAdapter
            // 
            this.v_AllQuantitiesTableAdapter.ClearBeforeFill = true;
            // 
            // v_NeedToOrderTableAdapter
            // 
            this.v_NeedToOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableDataGridViewTextBoxColumn
            // 
            this.tableDataGridViewTextBoxColumn.DataPropertyName = "Table";
            this.tableDataGridViewTextBoxColumn.HeaderText = "Table";
            this.tableDataGridViewTextBoxColumn.Name = "tableDataGridViewTextBoxColumn";
            this.tableDataGridViewTextBoxColumn.Width = 73;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 90;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 89;
            // 
            // ItemLink
            // 
            this.ItemLink.DataPropertyName = "ItemLink";
            this.ItemLink.HeaderText = "Link";
            this.ItemLink.Name = "ItemLink";
            this.ItemLink.Width = 63;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NeedToOrderDataGrid);
            this.Name = "NotificationForm";
            this.Text = "Need to Order Items";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NeedToOrderDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNeedToOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicsInventory1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAllQuantitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NeedToOrderDataGrid;
        private NicsInventory1DataSet nicsInventory1DataSet;
        private System.Windows.Forms.BindingSource vAllQuantitiesBindingSource;
        private NicsInventory1DataSetTableAdapters.V_AllQuantitiesTableAdapter v_AllQuantitiesTableAdapter;
        private System.Windows.Forms.BindingSource vNeedToOrderBindingSource;
        private NicsInventory1DataSetTableAdapters.V_NeedToOrderTableAdapter v_NeedToOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemLink;
    }
}