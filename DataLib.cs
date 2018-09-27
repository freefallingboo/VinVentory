using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    class DataLib
    {
        public static IEnumerable<V_OrderItem> GetOrderDetails (long OrderID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            return dbContext.V_OrderItems.Where(o => o.Order_Number == OrderID);
        }

        public static IEnumerable<ShirtColor> GetShirtColors()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            return dbContext.ShirtColors;
        }

        public static IEnumerable<ShirtSize> GetShirtSizes()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            return dbContext.ShirtSizes;
        }

        public static IEnumerable<ShirtStyle> GetShirtStyles()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            return dbContext.ShirtStyles;
        }

        public static int GetStickerQuantitiy(int StickerID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            Sticker sticker = dbContext.Stickers.Where(s => s.ID == StickerID).First();
            return sticker.Quantity;
        }

        public static decimal GetStickerCost(int StickerID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            Sticker sticker = dbContext.Stickers.Where(s => s.ID == StickerID).First();
            return sticker.Cost;
        }

        public static decimal GetStickerStock(int StickerID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            Sticker sticker = dbContext.Stickers.Where(s => s.ID == StickerID).First();
            return (sticker.Quantity * sticker.Cost);
        }

        public static IEnumerable<Sticker> GetStickers()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            return dbContext.Stickers.Where(s => s.Quantity > 0);
        }

        public static double GetVinylQuantity(Int64 VinylID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Product product = dbContext.Products.Where(p => p.ID == VinylID).First();
            double total = product.FullSheet.Value
                + product.ThreeQuarterSheet.Value * .75
                + product.HalfSheet.Value * .5
                + product.QuarterSheet.Value * .25;

            return total;
        }

        public static bool GetVinylNotify(Int64 VinylID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Product product = dbContext.Products.Where(p => p.ID == VinylID).First();
            if (GetVinylQuantity(VinylID) <= product.NotificationLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool GetStickerNotify(Int64 StickerID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Sticker sticker = dbContext.Stickers.Where(s => s.ID == StickerID).First();
            if (sticker.Quantity <= sticker.NotificationLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static IEnumerable<SecondaryItem> GetOther()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            return dbContext.SecondaryItems.Where(s => s.Quantity > 0 && s.ApplicationKit == false);
        }

        public static bool GetOtherNotify(Int64 SecondaryID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            SecondaryItem secondary = dbContext.SecondaryItems.Where(s => s.ID == SecondaryID).First();
            if (secondary.Quantity <= secondary.NotificationLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static IEnumerable<v_Color_Type> GetVinylColors()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            return dbContext.v_Color_Types;
        }
    }
}