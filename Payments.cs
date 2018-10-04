using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    class Payments
    {
        private decimal listedPrice;
        private decimal listedShipping;
        private decimal customerPaid;
        private int itemsInOrder;
        private decimal listingFee;
        private static decimal listingItemFee = .20m;
        private static decimal commissionFeeRate = .05m;
        private decimal commissionFee;
        private static decimal paymentFeeRate = .03m;
        private decimal paymentFee;
        private static decimal transactionFee = 0.25m;
        private decimal profitBeforeShipping;
        private decimal actualShipping;
        private decimal profit;

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

        public Payments ComputeEtsyFees(Payments payment)
        {
            payment.listingFee = GetEtsyListingFee(payment.itemsInOrder);
            payment.commissionFee = GetEtsyCommisionFee(payment.customerPaid);
            payment.paymentFee = GetEtsyPaymentFee(payment.customerPaid);
            payment.profitBeforeShipping = payment.customerPaid - payment.commissionFee - payment.listingFee - payment.paymentFee;
            payment.profit = payment.profitBeforeShipping - payment.actualShipping;

            return payment;
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

        public decimal GetTotalEtsyFees(Payments payment)
        {
            return payment.listingFee + payment.commissionFee + payment.paymentFee;
        }

    }
}
