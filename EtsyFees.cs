using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class EtsyFees
    {
        public static void AddFee(decimal listedPrice, decimal listedShipping, decimal totalPayment, decimal commision, int items, decimal etsyFee, decimal paymentFee,
            decimal totalFees, decimal profitBeforeShipping, decimal actualShipping, decimal totalProfit)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            EtsyFee fee = new EtsyFee
            {
                ListedPrice = listedPrice,
                ListedShipping = listedShipping,
                TotalPayment = totalPayment,
                Commision = commision,
                Items = items,
                PaymentFee = paymentFee,
                TotalFees = totalFees,
                ProfitBeforeShipping = profitBeforeShipping,
                ActualShipping = actualShipping,
                TotalProfit = totalProfit
            };

            dbContext.EtsyFees.InsertOnSubmit(fee);

            try
            {
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message, e.StackTrace);
            }
        }
    }
}
