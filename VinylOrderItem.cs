using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    public partial class VinylOrderItem
    {
        public VinylOrderItem(Int64 OrderID, Int64 VinylID, double Quantity)
        {
            this.OrderID = OrderID;
            this.ProductID = VinylID;
            this.Quantity = (decimal)Quantity; //TO DO, fix table so they're all the same type
        }

        public static bool AddToOrder(VinylOrderItem vinylOrderItem)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            dbContext.VinylOrderItems.InsertOnSubmit(vinylOrderItem);

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

        public static bool AddToOrder(Int64 OrderID, Int64 VinylID, double Quantity)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            VinylOrderItem vinylOrderItem = new VinylOrderItem(OrderID, VinylID, Quantity);
            dbContext.VinylOrderItems.InsertOnSubmit(vinylOrderItem);

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
