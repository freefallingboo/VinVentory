using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class Sticker : INotifyPropertyChanged
    {
        public Sticker(Int64 ID, int Quantity)
        {
            this.ID = ID;
            this.Quantity = Quantity;
        }

        public bool AddSticker(string Name, int Quantity, decimal Cost, int NotificationLevel,
                                    long SupplierID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Sticker sticker = new Sticker
            {
                Name = Name,
                Quantity = Quantity,
                Cost = Cost,
                NotificationLevel = NotificationLevel,
                SupplierID = SupplierID,
            };

            dbContext.Stickers.InsertOnSubmit(sticker);

            try
            {
                dbContext.SubmitChanges();
                SendPropertyChanged("Text");
                OnPropertyChanged("Quantity");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message, e.StackTrace);
            }

            return true;
        }

        public bool AddSticker(long ID, int Quantity)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Sticker sticker = dbContext.Stickers.Where(s => s.ID == ID).First();

            sticker.Quantity += Quantity;

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

        public static string GetName(long stickerID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Sticker sticker = dbContext.Stickers.Where(s => s.ID == stickerID).First();
            return sticker.Name;
        }

        public static bool CheckNotify(long stickerID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Sticker sticker = dbContext.Stickers.Where(s => s.ID == stickerID).First();
            if (sticker.Quantity <= sticker.NotificationLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Outgoing(long ID, int Quantity)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Sticker sticker = dbContext.Stickers.Where(s => s.ID == ID).First();

            if (sticker.Quantity >= Quantity)
            {
                sticker.Quantity -= Quantity;
            }
            else
            {
                Quantity -= sticker.Quantity;
                sticker.Quantity = 0;
            }

            if (Quantity > 0)
            {
                Sticker sticker2 = dbContext.Stickers.Where(s => s.Name == sticker.Name && s.Quantity > 0).First();

                if (sticker2 != null) sticker2.Quantity -= Quantity;
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

        protected void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }   
}
