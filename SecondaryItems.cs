using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class SecondaryItem
    {
        public SecondaryItem(long ID, int Quantity)
        {
            this.ID = ID;
            this.Quantity = Quantity;
        }


        public int GetID(string ItemName)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            var ItemID = from items in dbContext.SecondaryItems
                         where items.Name == ItemName
                         select items.ID;

            return (int)ItemID.First();
        }

        public bool AddSecondaryItem(string Name, int Quantity, decimal Cost, int NotificationLevel,
                                    long SupplierID, bool ApplicationKit, bool Mailer)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            SecondaryItem secondary = new SecondaryItem
            {
                Name = Name,
                Quantity = Quantity,
                Cost = Cost,
                NotificationLevel = NotificationLevel,
                SupplierID = SupplierID,
                ApplicationKit = ApplicationKit,
                Mailer = Mailer
            };

            dbContext.SecondaryItems.InsertOnSubmit(secondary);

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

        public static bool Outgoing(SecondaryItem secondary)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            SecondaryItem secondaryItem = dbContext.SecondaryItems.Where(si => si.ID == secondary.ID).FirstOrDefault();

            secondaryItem.Quantity -= secondary.Quantity;

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

        public static bool CheckNotify(Int64 ItemID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            SecondaryItem item = dbContext.SecondaryItems.Where(si => si.ID == ItemID).FirstOrDefault();
            return item.Quantity <= item.NotificationLevel;
        }

        public static bool ApplicationKitUsed(Int64 orderId, int quantity)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            IEnumerable<SecondaryItem> AppKitItems = dbContext.SecondaryItems.Where(si => si.ApplicationKit == true);

            foreach(SecondaryItem si in AppKitItems)
            {
                si.Quantity -= 1;
                SecondaryOrderItem secondaryOrderItem = new SecondaryOrderItem(orderId, si.ID, quantity);
                dbContext.SecondaryOrderItems.InsertOnSubmit(secondaryOrderItem);
            }

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
