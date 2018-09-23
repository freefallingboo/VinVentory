using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VinVentory
{
    public partial class OutgoingOrderForm : Form
    {

        private int OrderID;
        private int stickerID = 1;
        private bool isVinylOrder = true;
        private string TransferTapeType = "Clear Transfer Tape";

        private static int STICKER_DEFAULT_QUANTITY = 1;
        private static int STICKER_INCREMENT = 1;
        private static int TRANSFER_TAPE_DEFAULT_QUANTITY = 1;
        private static decimal VINYL_DEFAULT_QUANTITY = 0.25M;
        private static decimal VINYL_INCREMENT = 0.25M;

        string connstr = VinVentory.Utility.GetConnectionString();

        public OutgoingOrderForm()
        {
            InitializeComponent();


            StickerNameCombo.DisplayMember = "Name";
            StickerNameCombo.ValueMember = "ID";
            StickerNameCombo.DataSource = DataLib.GetStickers();
        }

        private void OutgoingOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.v_Color_Type' table. You can move, or remove it, as needed.
            this.v_Color_TypeTableAdapter.Fill(this.nicsInventory1DataSet.v_Color_Type);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.v_Products' table. You can move, or remove it, as needed.
            this.v_ProductsTableAdapter.Fill(this.nicsInventory1DataSet.v_Products);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.Mailers' table. You can move, or remove it, as needed.
            this.mailersTableAdapter.Fill(this.nicsInventory1DataSet.Mailers);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.Colors' table. You can move, or remove it, as needed.
            this.colorsTableAdapter.Fill(this.nicsInventory1DataSet.Colors);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.VinylType' table. You can move, or remove it, as needed.
            this.vinylTypeTableAdapter.Fill(this.nicsInventory1DataSet.VinylType);

            //DataContext db = new DataContext(connstr);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Decrement stock
            //
            Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NicsInventory1DataSet.ColorsDataTable Colors;

            //Add to order tables
            string ColorName = ColorComboBox.Text;
            int firstSpace = ColorName.IndexOf(" ");
            ColorName = ColorName.Substring(0, firstSpace);
            //int ColorID = Convert.ToInt32(comboBox5.SelectedValue);
            //MessageBox.Show(boxmessage);

            SqlConnection conn = new SqlConnection(connstr);

            using (conn)
            {
                conn.Open();

                /*using (var cmd = new SqlCommand("SELECT ID FROM Products WHERE VinylType = @VinylType AND ColorID = @ColorID", conn))
                {
                    cmd.Parameters.AddWithValue("@VinylType", VinylTypeID);
                    cmd.Parameters.AddWithValue("@ColorID", ColorID);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result != 0)
                    {
                        prodID = result;
                        MessageBox.Show("Product ID found");
                    }
                    else
                    {
                        MessageBox.Show("No Product found.");
                    }
                }*/

                string costTextBox = textBox1.Text;
                decimal orderPrice;
                if (!decimal.TryParse(costTextBox, out orderPrice))
                {
                    MessageBox.Show("Order not created. Please enter a valid price as #.## or ##");
                    textBox1.Text = "0.00";
                    return;
                }

                SqlCommand cmdNewOrder = new SqlCommand("spAddOrder", conn);
                cmdNewOrder.CommandType = CommandType.StoredProcedure;

                cmdNewOrder.Parameters.Add(new SqlParameter("@pDate", SqlDbType.DateTime));
                cmdNewOrder.Parameters["@pDate"].Value = dateTimePicker1.Value;

                cmdNewOrder.Parameters.Add(new SqlParameter("@pPrice", SqlDbType.Decimal));
                cmdNewOrder.Parameters["@pPrice"].Value = orderPrice;

                cmdNewOrder.Parameters.Add(new SqlParameter("@pID", SqlDbType.Int));
                cmdNewOrder.Parameters["@pID"].Direction = ParameterDirection.Output;

                try
                {
                    cmdNewOrder.ExecuteNonQuery();
                    this.OrderID = (int)cmdNewOrder.Parameters["@pID"].Value;
                    string boxmessage = "This returned order #" + OrderID;
                    MessageBox.Show(boxmessage);
                }
                catch
                {
                    //NC-14 A simple catch.  
                    MessageBox.Show("Order ID was not returned. Order could not be created.");
                }

                if (isVinylOrder)
                {
                    int prodID = Convert.ToInt32(ColorComboBox.SelectedValue);

                    DataClasses1DataContext context = new DataClasses1DataContext();
                    //TO DO -- Add product and quantities to a List object and iterate through

                    VinylOrderItem vinylOrderItem = new VinylOrderItem();
                    vinylOrderItem.ProductID = prodID;
                    vinylOrderItem.OrderID = OrderID;
                    vinylOrderItem.Quantity = numericUpDown1.Value;

                    context.VinylOrderItems.InsertOnSubmit(vinylOrderItem);

                    SecondaryOrderItem TransferTape = new SecondaryOrderItem();

                    TransferTape.SecondaryID = GetSecondaryItemID(TransferTapeType);
                    TransferTape.OrderID = OrderID;
                    TransferTape.Quantity = numericUpDown2.Value;

                    context.SecondaryOrderItems.InsertOnSubmit(TransferTape);
                  
                    try
                    {
                        context.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                    }

                    bool result = Product.Outgoing(prodID, (double)numericUpDown1.Value);
                    if (!result)
                    {
                        MessageBox.Show("There was a problem decreasing vinyl inventory. Tell your wife she did something wrong");
                    }
                }
                else
                {
                    DataClasses1DataContext context = new DataClasses1DataContext();

                    StickerOrderItem stickerOrderItem = new StickerOrderItem();
                    stickerOrderItem.OrderID = OrderID;
                    stickerOrderItem.Quantity = (int)numericUpDown1.Value;
                    stickerOrderItem.StickerID = stickerID;

                    try
                    {
                        context.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                    }

                    bool result = Sticker.Outgoing(stickerID, (int)numericUpDown1.Value);
                    if (!result)
                    {
                        MessageBox.Show("There was a problem decreasing sticker inventory. Tell your wife she did something wrong");
                    }

                    if (Sticker.CheckNotify(stickerID))
                    {
                        MessageBox.Show("You're getting low on " + Sticker.GetName(stickerID));
                    }
                }
            }
            
            //Decrement stock

            textBox3.Clear();
            ScrapLengthTB.Clear();
            ScrapWidthTB.Clear();
            textBox6.Clear();
            textBox1.Text = "0.00";

            checkBox1.Checked = false;
            checkBox5.Checked = false;

            numericUpDown1.Value = VINYL_DEFAULT_QUANTITY;
            numericUpDown2.Value = TRANSFER_TAPE_DEFAULT_QUANTITY;

            ColorComboBox.Show();
            StickerNameCombo.Hide();
        }

        private long GetSecondaryItemID(string ItemName)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connstr);

            // SecondaryItem secondaryItem = db;
            var ItemID = from items in db.SecondaryItems
                     where Name == ItemName
                     select items.ID;

            return ItemID.FirstOrDefault();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            StickerNameCombo.Show();

            label4.Hide();
            numericUpDown2.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            checkBox1.Text = "Sticker Kit";
            label1.Text = "Name";
            ColorComboBox.Hide();

            label2.Text = "Quantity";
            numericUpDown1.Value = STICKER_DEFAULT_QUANTITY;
            numericUpDown1.Increment = STICKER_INCREMENT;

            isVinylOrder = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Show();
            numericUpDown2.Show();
            radioButton1.Show();
            radioButton2.Show();
            checkBox1.Text = "Application kit";
            label1.Text = "Color";
            label2.Text = "Amount used (sheet)";
            numericUpDown1.Value = VINYL_DEFAULT_QUANTITY;
            numericUpDown1.Increment = VINYL_INCREMENT;

            StickerNameCombo.Hide();
            ColorComboBox.Show();

            isVinylOrder = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TransferTapeType = "Clear Transfer Tape";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TransferTapeType = "Paper Transfer Tape";
        }

        private void StickerNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            stickerID = Convert.ToInt32(StickerNameCombo.SelectedValue);
        }
    }
}
