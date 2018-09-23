using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinVentory
{
    public partial class OrderHistoryForm : Form
    {
        protected Int64 selectedOrderID = 1;

        public OrderHistoryForm()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.V_OrderItems' table. You can move, or remove it, as needed.
            this.v_OrderItemsTableAdapter.Fill(this.nicsInventory1DataSet.V_OrderItems);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nicsInventory1DataSet.Orders);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventHandler e)
        {
            Order order = (Order)dataGridView1.CurrentRow.DataBoundItem;
            selectedOrderID = order.ID;

            decimal.TryParse(MatCostLbl.Text.ToString(), out decimal cost);
            decimal.TryParse(OrderPriceLbl.Text.ToString(), out decimal quant);
            decimal revenue = cost * quant;

            RevenueLbl.Text = revenue.ToString();

            RevenueLbl.Refresh();

            dataGridView2.DataSource = DataLib.GetOrderDetails(selectedOrderID);
            dataGridView2.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
