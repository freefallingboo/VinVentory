using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class SecondaryOrderItem
    {
        public SecondaryOrderItem(Int64 OrderID, Int64 ItemID, int Quantity)
        {
            this.OrderID = OrderID;
            this.SecondaryID = ItemID;
            this.Quantity = Quantity;
        }

        public static bool AddToOrder(Int64 OrderID, Int64 ItemID, int Quantity)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            SecondaryOrderItem secondary = new SecondaryOrderItem(OrderID, ItemID, Quantity);
            dbContext.SecondaryOrderItems.InsertOnSubmit(secondary);

            try
            {
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message, e.StackTrace);
            }

            return true;
        }
    }
}
