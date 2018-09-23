using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class Order
    {
        public Order(DateTime date, decimal price = 0)
        {
            this.OrderDate = date;
            this.OrderPrice = price;
        }

        public static Int64 NewOrder(DateTime date, decimal price)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Order order = new Order(date, price);
            dbContext.Orders.InsertOnSubmit(order);

            try
            {
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message, e.StackTrace);
            }

            return order.ID;
        }
    }
}
