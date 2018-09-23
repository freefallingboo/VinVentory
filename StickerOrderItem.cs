using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class StickerOrderItem
    {
        public StickerOrderItem(Int64 OrderID, Int64 StickerID, int Quantity)
        {
            this.OrderID = OrderID;
            this.StickerID = StickerID;
            this.Quantity = Quantity;
        }

        public static bool AddToOrder(Int64 OrderID, Int64 StickerID, int Quantity)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            StickerOrderItem stickerOrderItem = new StickerOrderItem(OrderID, StickerID, Quantity);
            dbContext.StickerOrderItems.InsertOnSubmit(stickerOrderItem);

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
