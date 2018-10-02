using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VinVentory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private DataClasses1DataContext db = new DataClasses1DataContext();
        private string vinylType = "651";
        private int stickerID = 1;
        private int vinylID = 1;
        CultureInfo ci = new CultureInfo("en-us");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.Stickers' table. You can move, or remove it, as needed.
            this.stickersTableAdapter.Fill(this.nicsInventory1DataSet.Stickers);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.SecondaryItems' table. You can move, or remove it, as needed.
            this.secondaryItemsTableAdapter.Fill(this.nicsInventory1DataSet.SecondaryItems);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nicsInventory1DataSet.Products);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.v_TotalStock' table. You can move, or remove it, as needed.
            this.v_TotalStockTableAdapter.Fill(this.nicsInventory1DataSet.v_TotalStock);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.v_ProductTotals' table. You can move, or remove it, as needed.
            this.v_ProductTotalsTableAdapter.Fill(this.nicsInventory1DataSet.v_ProductTotals);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.Colors' table. You can move, or remove it, as needed.
            this.colorsTableAdapter.Fill(this.nicsInventory1DataSet.Colors);

            Colorpicker.DataSource = db.Colors.OrderBy(c => c.Name);
            Colorpicker.DisplayMember = "Name";
            Colorpicker.ValueMember = "ID";

            int.TryParse(Colorpicker.SelectedValue.ToString(), out int colorID);
            UpdateLabels(colorID);

        }

        private void Colorpicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(Colorpicker.SelectedValue.ToString(), out int colorID);

            if (colorID > 0)
            {
                UpdateLabels(colorID);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incomingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void outgoingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutgoingOrderForm outOrder = new OutgoingOrderForm();
            outOrder.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void colorIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Colorpicker.SelectedValue != null)
            {
                int.TryParse(Colorpicker.SelectedValue.ToString(), out vinylID);
            }

            StickerQuantLbl.Text = VinVentory.DataLib.GetStickerQuantitiy(stickerID).ToString();
            StickerCostLbl.Text = "$" + VinVentory.DataLib.GetStickerCost(stickerID).ToString();
            StickerTotalStockLbl.Text = "$" + VinVentory.DataLib.GetStickerStock(stickerID).ToString();
        }

        private void Colorpicker_SelectedIndexChanged_1()
        {

        }

        private string FullSheetQuantity(string VinylType, string Color)
        {
            return ((from p in db.v_Products
                     where p.Color == Color && p.Vinyl_Type == VinylType
                     select p.Full_Sheets).FirstOrDefault()).ToString();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void newSecondaryItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void secondaryItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSecondaryItemForm addSecondary = new AddSecondaryItemForm();
            addSecondary.Show();
        }

        private void stickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStickerForm addSticker = new AddStickerForm();
            addSticker.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Make an add color form
        }

        private void StickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StickerAddStockBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(stickerAddTextBox.Text, out int Quantity))
            {
                MessageBox.Show("Stickers were not added. Please enter a whole number for the quantity");
                stickerAddTextBox.Text = "0";
                return;
            }

            Sticker sticker = new Sticker();
            bool result = sticker.AddSticker(stickerID, Quantity);

            if (result)
            {
                MessageBox.Show("The stickers were added");
                StickerQuantLbl.Text = VinVentory.DataLib.GetStickerQuantitiy(stickerID).ToString();
                StickerCostLbl.Text = "$" + VinVentory.DataLib.GetStickerCost(stickerID).ToString();
                StickerTotalStockLbl.Text = "$" + VinVentory.DataLib.GetStickerStock(stickerID).ToString();
            }
            else
            {
                MessageBox.Show("An error occurred. The stickers were not added");
            }
        }

        private void StickerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (StickerComboBox.SelectedValue != null)
            {
                int.TryParse(StickerComboBox.SelectedValue.ToString(), out stickerID);
            }

            StickerQuantLbl.Text = VinVentory.DataLib.GetStickerQuantitiy(stickerID).ToString();
            StickerCostLbl.Text = "$" + VinVentory.DataLib.GetStickerCost(stickerID).ToString();
            StickerTotalStockLbl.Text = "$" + VinVentory.DataLib.GetStickerStock(stickerID).ToString();
        }

        private void needToOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderHistoryForm OHF = new OrderHistoryForm();
            OHF.Show();
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotificationForm NF = new NotificationForm();
            NF.Show();
        }

        private void UpdateLabels(Int64 ColorID)
        {
            Product vinyl = new Product();
            vinyl = Product.GetProduct(ColorID, vinylType); // TO DO: enum for vinyl types? get tab name?
            FullSheet651quant.Text = vinyl.FullSheet.ToString();
            ThreeQuart651Quant.Text = vinyl.ThreeQuarterSheet.ToString();
            Half651Quant.Text = vinyl.HalfSheet.ToString();
            Quarter651Quant.Text = vinyl.QuarterSheet.ToString();

            double totalQuantity = Product.GetProductTotal(vinyl);
            TotalQuant651Lbl.Text = totalQuantity.ToString();
            decimal? totalStock = ((decimal)totalQuantity / vinyl.CostperSqFt);
            TotalStock651Lbl.Text = ((decimal)totalStock).ToString("C", ci);
        }
    }
}
