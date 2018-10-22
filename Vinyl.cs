using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class Vinyl : INotifyPropertyChanged
    {
        public Vinyl(Int64 ProdID, int FullSheet, int ThreeQuarterSheet, int HalfSheet, int Quartersheet)
        {
            this.ID = ProdID;
            this.FullSheet = FullSheet;
            this.ThreeQuarterSheet = ThreeQuarterSheet;
            this.HalfSheet = HalfSheet;
            this.QuarterSheet = QuarterSheet;
        }

        public static Vinyl Getvinyl(Int64 colorID, string vinylType)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            VinylType type = dbContext.VinylTypes.Where(t => t.TypeName == vinylType).First();

            return dbContext.Vinyls.Where(v => v.ColorID == colorID && v.VinylType == type.ID).First();
        }

        public bool AddNewVinyl(Int64 ColorID, int Quantity, decimal Cost, int NotificationLevel,
                                    long SupplierID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Vinyl vinyl = new Vinyl
            {
                ColorID = ColorID,
                FullSheet = Quantity,
                CostperSqFt = Cost,
                NotificationLevel = NotificationLevel,
                SupplierID = SupplierID,
            };

            dbContext.Vinyls.InsertOnSubmit(vinyl);

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

        public static bool AddExisting(long ID, int Quantity)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Vinyl vinyl = dbContext.Vinyls.Where(s => s.ID == ID).First();

            vinyl.FullSheet += Quantity;

            try
            {
                dbContext.SubmitChanges();
                //SendPropertyChanged("FullSheet");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message, e.StackTrace);
            }

            return true;
        }

        public static bool Outgoing(long ID, double OrderQuantity)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Vinyl vinyl = dbContext.Vinyls.Where(s => s.ID == ID).First();

            double? vinylQuant = GetvinylTotal(vinyl);

            if (vinylQuant >= OrderQuantity)
            {
                DecideUsage(ref vinyl, OrderQuantity); //Need to get vinyl back out
            }
            else
            {
                OrderQuantity -= (double)vinylQuant;

                vinyl.FullSheet = 0;
                vinyl.ThreeQuarterSheet = 0;
                vinyl.HalfSheet = 0;
                vinyl.QuarterSheet = 0;

                Vinyl vinyl2 = dbContext.Vinyls.Where(p => p.ColorID == vinyl.ColorID && (p.FullSheet > 0 || p.ThreeQuarterSheet > 0 || p.HalfSheet > 0 || p.QuarterSheet > 0)).First();

                if (vinyl2 != null)
                {
                    double vinyl2Quant = GetvinylTotal(vinyl2);
                    if (vinyl2Quant >= OrderQuantity)
                    {
                        DecideUsage(ref vinyl2, OrderQuantity);
                    }
                }
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

        public static bool Outgoing(Vinyl vinyl, long orderID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Vinyl orderedvinyl = dbContext.Vinyls.Where(p => p.ID == vinyl.ID).First();

            if (orderedvinyl.FullSheet >= vinyl.FullSheet)
            {
                orderedvinyl.FullSheet -= vinyl.FullSheet;
            }
            if (orderedvinyl.ThreeQuarterSheet >= vinyl.ThreeQuarterSheet)
            {
                orderedvinyl.ThreeQuarterSheet -= vinyl.FullSheet;
            }
            if (orderedvinyl.HalfSheet >= vinyl.HalfSheet)
            {
                orderedvinyl.HalfSheet -= vinyl.HalfSheet;
            }
            if (orderedvinyl.QuarterSheet >= vinyl.QuarterSheet)
            {
                orderedvinyl.QuarterSheet -= vinyl.QuarterSheet;
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

        protected static void DecideUsage(ref Vinyl vinyl, double Quantity)
        {
            while (Quantity > 0)
            {
                if (Quantity >= 1)
                {
                    vinyl.FullSheet -= 1;
                    Quantity -= 1;
                    continue;
                }
                if (Quantity == .75)
                {
                    if (vinyl.QuarterSheet >= 1)
                    {
                        vinyl.QuarterSheet -= 1;
                        Quantity -= .75;
                    }
                    else
                    {
                        vinyl.FullSheet -= 1;
                        vinyl.QuarterSheet += 1;
                        Quantity -= .75;
                    }
                }
                if (Quantity == .5)
                {
                    if (vinyl.HalfSheet >= 1)
                    {
                        vinyl.HalfSheet -= 1;
                        Quantity -= .5;
                    }
                    else if (vinyl.ThreeQuarterSheet >= 1)
                    {
                        vinyl.ThreeQuarterSheet -= 1;
                        vinyl.QuarterSheet += 1;
                        Quantity -= .5;
                    }
                    else
                    {
                        vinyl.FullSheet -= 1;
                        vinyl.HalfSheet += 1;
                        Quantity -= .5;
                    }
                }
                if (Quantity == .25)
                {
                    if (vinyl.QuarterSheet >= 1)
                    {
                        vinyl.QuarterSheet -= 1;
                        Quantity -= .25;
                    }
                    else if (vinyl.HalfSheet >= 1)
                    {
                        vinyl.HalfSheet -= 1;
                        vinyl.QuarterSheet += 1;
                        Quantity -= .25;
                    }
                    else if (vinyl.ThreeQuarterSheet >= 1)
                    {
                        vinyl.ThreeQuarterSheet -= 1;
                        vinyl.HalfSheet += 1;
                        Quantity -= .25;
                    }
                    else
                    {
                        vinyl.FullSheet -= 1;
                        vinyl.ThreeQuarterSheet += 1;
                        Quantity -= .25;
                    }
                }
            }

            return;
        }

        //protected static void OnPropertyChanged(string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public static double GetvinylTotal(Vinyl vinyl)
        {
            if (vinyl != null)
            {
                return (double)vinyl.FullSheet + (double)vinyl.ThreeQuarterSheet * .75 + (double)vinyl.HalfSheet * .5 + (double)vinyl.QuarterSheet * .25;
            }
            else
            {
                return 0;
            }
            
        }

        public static bool CheckNotify(Int64 vinylID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Vinyl vinyl = dbContext.Vinyls.Where(p => p.ID == vinylID).FirstOrDefault();
            double vinylQuant = GetvinylTotal(vinyl);
            return vinylQuant <= vinyl.NotificationLevel;
        }
    }
}
