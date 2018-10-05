using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    class Payments
    {
        public decimal listedPrice;
        public decimal listedShipping;
        public decimal customerPaid;
        public int itemsInOrder;
        public decimal listingFee;
        private static decimal listingItemFee = .20m;
        private static decimal commissionFeeRate = .05m;
        public decimal commissionFee;
        private static decimal paymentFeeRate = .03m;
        public decimal paymentFee;
        private static decimal transactionFee = 0.25m;
        public decimal profitBeforeShipping;
        public decimal actualShipping;
        public decimal profit;

        public Payments(decimal listPrice, decimal listShipping, decimal custPaid, int itemCount)
        {
            this.listedPrice = listPrice;
            this.listedShipping = listShipping;
            this.customerPaid = custPaid;
            this.itemsInOrder = itemCount;
            this.actualShipping = listShipping;
        }

        public Payments(decimal listPrice, decimal listShipping, decimal custPaid, int itemCount, decimal actualShip)
        {
            this.listedPrice = listPrice;
            this.listedShipping = listShipping;
            this.customerPaid = custPaid;
            this.itemsInOrder = itemCount;
            this.actualShipping = actualShip;
        }

        public static void ComputeEtsyFees(Payments payment)
        {
            payment.listingFee = GetEtsyListingFee(payment.itemsInOrder);
            payment.commissionFee = GetEtsyCommisionFee(payment.customerPaid);
            payment.paymentFee = GetEtsyPaymentFee(payment.customerPaid);
            payment.profitBeforeShipping = payment.customerPaid - payment.commissionFee - payment.listingFee - payment.paymentFee;
            payment.profit = payment.profitBeforeShipping - payment.actualShipping;
        }

        public static decimal GetEtsyCommisionFee(decimal customerPaid)
        {
            return customerPaid * commissionFeeRate;
        }

        public static decimal GetEtsyListingFee(int itemCount)
        {
            return itemCount * listingItemFee;
        }

        public static decimal GetEtsyPaymentFee(decimal customerPaid)
        {
            return customerPaid * paymentFeeRate + transactionFee;
        }

        public static decimal GetTotalEtsyFees(Payments payment)
        {
            return payment.listingFee + payment.commissionFee + payment.paymentFee;
        }

    }
}
