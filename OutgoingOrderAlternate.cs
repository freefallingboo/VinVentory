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
    public partial class OutgoingOrderAlternate : Form
    {
        public OutgoingOrderAlternate()
        {
            InitializeComponent();

            StickerDGVComboBox.DisplayMember = "Name";
            StickerDGVComboBox.ValueMember = "ID";
            StickerDGVComboBox.DataSource = DataLib.GetStickers();

            VinylDGVColorCB.DisplayMember = "Color";
            VinylDGVColorCB.ValueMember = "ProductID";
            VinylDGVColorCB.DataSource = DataLib.GetVinyl();

            OtherItemName.DisplayMember = "Name";
            OtherItemName.ValueMember = "ID";
            OtherItemName.DataSource = DataLib.GetOther();

            this.StickerGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            this.Load += new EventHandler(OutgoingOrderAlternate_Load);

            ItemsInOrderTBox.Text = "0";
            PriceTBox.Text = "0";

        }

        private void OutgoingOrderAlternate_Load(Object sender, EventArgs e)
        {
            //Can probably get rid of this.
        }

        private void StickerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.StickerGridView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void StickerGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void VinylGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VinylGridView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void OtherGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.OtherGridView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void VinylGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Something went wrong: " + e.Context.ToString() + "?");
            MessageBox.Show(e.Exception.ToString());
        }

        private void StickerGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // If the data source raises an exception when a cell value is 
            // commited, display an error message.
            if (e.Exception != null &&
                e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("CustomerID value must be unique.");
            }
        }

        private void OtherGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Something tried to change in the database?");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            VinylGridView.Rows.Clear();
            StickerGridView.Rows.Clear();
            OtherGridView.Rows.Clear();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            List<Product> productsInOrder = new List<Product>();
            foreach (DataGridViewRow Row in VinylGridView.Rows)
            {
                if (Row.Cells[0].Value != null)
                {
                    Product vinyl = new Product(Convert.ToInt64(Row.Cells[0].Value),
                        Convert.ToInt32(Row.Cells[1].Value), Convert.ToInt32(Row.Cells[2].Value),
                        Convert.ToInt32(Row.Cells[3].Value), Convert.ToInt32(Row.Cells[4].Value));
                    productsInOrder.Add(vinyl);
                }
            }

            List<Sticker> stickersInOrder = new List<Sticker>();
            foreach (DataGridViewRow Row in StickerGridView.Rows)
            {
                if (Row.Cells[0].Value != null)
                {
                    Sticker sticker = new Sticker(Convert.ToInt64(Row.Cells[0].Value), Convert.ToInt32(Row.Cells[1].Value));
                    stickersInOrder.Add(sticker);
                }
            }


            List<SecondaryItem> otherItemsInOrder = new List<SecondaryItem>();
            foreach (DataGridViewRow Row in OtherGridView.Rows)
            {
                if (Row.Cells[0].Value != null)
                {
                    SecondaryItem secondary = new SecondaryItem(Convert.ToInt64(Row.Cells[0].Value), Convert.ToInt32(Row.Cells[1].Value));
                    otherItemsInOrder.Add(secondary);
                }
                if (vinylAppKitCheckBox.Checked)
                {
                    //make an add kit function
                }
            }


            string message = "Vinyl in order = " + productsInOrder.Count.ToString() +
                "\nStickers in order = " + stickersInOrder.Count.ToString() +
                "\nOther grid row count = " + otherItemsInOrder.Count.ToString();
            MessageBox.Show(message);


            // Make an order
            DateTime date = dateTimePicker1.Value;
            if (!decimal.TryParse(PriceTBox.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid order price");
                return;
            }
            Int64 orderID = Order.NewOrder(date, price);

            if (productsInOrder.Any())
            {
                foreach (Product p in productsInOrder)
                {
                    bool success = true;
                    double vinylQuantity = Product.GetProductTotal(p);
                    VinylOrderItem.AddToOrder(orderID, p.ID, vinylQuantity);
                    if (p.FullSheet < 1 && p.FullSheet > 0)
                    {
                        success = Product.Outgoing(p, orderID);
                    }
                    else
                    {
                        success = Product.Outgoing(p.ID, vinylQuantity);
                    }

                    if (!success)
                    {
                        MessageBox.Show("There was an error adjusting quantity of {0} vinyl, please double check your stock", p.Color.Name);
                    }

                    if (Product.CheckNotify(p.ID))
                    {
                        MessageBox.Show("You're getting low on {0}", p.Color.Name);
                    }
                }
            }

            if (stickersInOrder.Any())
            {
                foreach (Sticker s in stickersInOrder)
                {
                    StickerOrderItem.AddToOrder(orderID, s.ID, s.Quantity);
                    bool success = Sticker.Outgoing(s.ID, s.Quantity);

                    if (!success)
                    {
                        MessageBox.Show("There was an error adjusting quantity of {0} sticker, please double check your stock", s.Name);
                    }

                    if (Sticker.CheckNotify(s.ID))
                    {
                        MessageBox.Show("You're getting low on {0}", s.Name);
                    }
                }
            }

            if (otherItemsInOrder.Any())
            {
                foreach (SecondaryItem si in otherItemsInOrder)
                {
                    SecondaryOrderItem.AddToOrder(orderID, si.ID, si.Quantity);
                    bool success = SecondaryItem.Outgoing(si);

                    if (!success)
                    {
                        MessageBox.Show("There was an error adjusting quantity of {0} item, please double check your stock", si.Name);
                    }

                    if (SecondaryItem.CheckNotify(si.ID))
                    {
                        MessageBox.Show("You're getting low on {0}", si.Name);
                    }
                }
            }

            if (vinylAppKitCheckBox.Checked== true)
            {
                SecondaryItem.ApplicationKitUsed(orderID, (int)VinylKitCountNumBox.Value);
            }
        }

        private void IncreaseItemsInOrder()
        {
            int.TryParse(ItemsInOrderTBox.Text, out int itemCount);
            itemCount++;
            ItemsInOrderTBox.Text = itemCount.ToString();
        }

        private void DecreaseItemsInOrder()
        {
            int.TryParse(ItemsInOrderTBox.Text, out int itemCount);
            itemCount++;
            ItemsInOrderTBox.Text = itemCount.ToString();
        }

        private void VinylGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            IncreaseItemsInOrder();
        }

        private void StickerGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //StickerGridView.Rows.Add(NameDGVComboBox, 1);
            IncreaseItemsInOrder();
        }

        private void OtherGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.vinylAppKitCheckBox.Checked == true) VinylKitCountNumBox.Show();
            else VinylKitCountNumBox.Hide();
        }

        private void VinylGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DecreaseItemsInOrder();
        }

        private void StickerGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DecreaseItemsInOrder();
        }
    }
}
