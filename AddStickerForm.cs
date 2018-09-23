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
    public partial class AddStickerForm : Form
    {
        public AddStickerForm()
        {
            InitializeComponent();
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
                supplier.ID = 5;
            }



            Sticker sticker = new Sticker();
            bool success = sticker.AddSticker(NameTextBox.Text, Quantity, ItemCost, Convert.ToInt16(NotificationUpDown.Value), supplier.ID);

            if (success)
            {
                Close();
            }
            else
            {
                MessageBox.Show("An error occurred. This item was not added");
            }
        }
    }
}
