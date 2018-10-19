using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinVentory
{
    public partial class EtsyFeeCalculatorForm : Form
    {
        CultureInfo ci = new CultureInfo("en-us");

        public EtsyFeeCalculatorForm()
        {
            InitializeComponent();

            SavedFeeDGV.DataSource = DataLib.GetEtsyFees();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow Row in FeeEntryDGV.Rows)
            {
                if (Row.Cells[0].Value != null)
                {
                    if (Row.Cells[1].Value == null)
                    {
                        if (Row.Cells[0].Value != null && Row.Cells[2].Value != null)
                        {
                            Row.Cells[1].Value = Convert.ToDecimal(Row.Cells[2].Value) - Convert.ToDecimal(Row.Cells[0].Value);
                        }
                        else
                        {
                            MessageBox.Show("Please enter the listing's shipping cost");
                            return;
                        }
                    }

                    if (Row.Cells[2].Value == null)
                    {
                        MessageBox.Show("Please enter what the customer paid");
                        return;
                    }

                    if (Row.Cells[3].Value == null)
                    {
                        MessageBox.Show("Please enter the number of items");
                        return;
                    }

                    if (Row.Cells[9].Value == null)
                    {
                        Row.Cells[9].Value = Row.Cells[1].Value;
                    }

                    Payments payment = new Payments(Convert.ToDecimal(Row.Cells[0].Value),
                        Convert.ToDecimal(Row.Cells[1].Value), Convert.ToDecimal(Row.Cells[2].Value),
                        Convert.ToInt32(Row.Cells[3].Value), Convert.ToDecimal(Row.Cells[9].Value));

                    Payments.ComputeEtsyFees(payment);

                    //fill out the empty cells:
                    Row.Cells[4].Value = payment.commissionFee.ToString("C", ci);
                    Row.Cells[5].Value = payment.listingFee.ToString("C", ci);
                    Row.Cells[6].Value = payment.paymentFee.ToString("C", ci);

                    decimal totalFees = Payments.GetTotalEtsyFees(payment);
                    Row.Cells[7].Value = totalFees.ToString("C", ci);
                    Row.Cells[8].Value = (payment.customerPaid - totalFees).ToString("C",ci);
                    Row.Cells[10].Value = payment.profit.ToString("C", ci);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EtsyFeeCalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Globalization.NumberStyles ns = (System.Globalization.NumberStyles.Currency);
            List<Product> productsInOrder = new List<Product>();
            foreach (DataGridViewRow Row in FeeEntryDGV.Rows)
            {
                if (Row.Cells[10].Value != null)
                {
                    string commision = Row.Cells[4].Value.ToString();
                    decimal commisionNum = decimal.Parse(commision, ns);

                    string etsyFee = Row.Cells[5].Value.ToString();
                    decimal etsyFeeNum = decimal.Parse(etsyFee, ns);

                    string paymentFee = Row.Cells[6].Value.ToString();
                    decimal paymentFeeNum = decimal.Parse(paymentFee, ns);

                    string totalFees = Row.Cells[7].Value.ToString();
                    decimal totalFeesNum = decimal.Parse(totalFees, ns);

                    string profitBeforeShipping = Row.Cells[8].Value.ToString();
                    decimal profitBeforeShippingNum = decimal.Parse(profitBeforeShipping, ns);

                    string totalProfit = Row.Cells[10].Value.ToString();
                    decimal totalProfitNum = decimal.Parse(totalProfit, ns);

                    EtsyFees.AddFee(Convert.ToDecimal(Row.Cells[0].Value), Convert.ToDecimal(Row.Cells[1].Value), Convert.ToDecimal(Row.Cells[2].Value),
                        Convert.ToInt32(Row.Cells[3].Value), commisionNum, etsyFeeNum, paymentFeeNum, totalFeesNum,
                        profitBeforeShippingNum, Convert.ToDecimal(Row.Cells[9].Value), totalProfitNum);
                }
            }

            FeeEntryDGV.Rows.Clear();
            SavedFeeDGV.DataSource = DataLib.GetEtsyFees();
        }
    }
}
