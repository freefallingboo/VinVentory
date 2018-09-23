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
    public partial class AddSecondaryItemForm : Form
    {
        public AddSecondaryItemForm()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            this.Text = "Required";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check values
            if (!int.TryParse(QuantityTextBox.Text, out int Quantity))
            {
                MessageBox.Show("Item not added. Please enter a whole number for the quantity");
                QuantityTextBox.Text = "0";
                return;
            }

            decimal ItemCost;
            if (!decimal.TryParse(CostTextBox.Text, out ItemCost))
            {
                MessageBox.Show("Item not added. Please enter a valid price as #.## or ##");
                CostTextBox.Text = "0.00";
                return;
            }

            if (TotalRadio.Checked)
            {
                ItemCost = ItemCost / Quantity;
            }

            Supplier supplier = new Supplier();
            if (SupplierTextBox.Text != "")
            {
                supplier.ID = supplier.AddNewSupplier(SupplierTextBox.Text, OrderLinkTextBox.Text);
            }
            else
            {
                //TO DO! For testing only, fix type to be nullable
                supplier.ID = 1;
            }

            

            SecondaryItem secondary = new SecondaryItem();
            bool success = secondary.AddSecondaryItem(NameTextBox.Text, Quantity, ItemCost, Convert.ToInt16(NotificationUpDown.Value), supplier.ID, AppKitBox.Checked, MailerBox.Checked);

            if (success)
            {
                Close();
            }
            else
            {
                MessageBox.Show("An error occurred. This item was not added");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
