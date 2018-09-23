using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class Product : INotifyPropertyChanged
    {
        public Product(Int64 ProdID, int FullSheet, int ThreeQuarterSheet, int HalfSheet, int Quartersheet)
        {
            this.ID = ProdID;
            this.FullSheet = FullSheet;
            this.ThreeQuarterSheet = ThreeQuarterSheet;
            this.HalfSheet = HalfSheet;
            this.QuarterSheet = QuarterSheet;
        }

        public bool AddNewVinyl(Int64 ColorID, int Quantity, decimal Cost, int NotificationLevel,
                                    long SupplierID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Product product = new Product
            {
                ColorID = ColorID,
                FullSheet = Quantity,
                CostperSqFt = Cost,
                NotificationLevel = NotificationLevel,
                SupplierID = SupplierID,
            };

            dbContext.Products.InsertOnSubmit(product);

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

            Product product = dbContext.Products.Where(s => s.ID == ID).First();

            product.FullSheet += Quantity;

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

            Product product = dbContext.Products.Where(s => s.ID == ID).First();

            double? productQuant = GetProductTotal(product);

            if (productQuant >= OrderQuantity)
            {
                DecideUsage(ref product, OrderQuantity); //Need to get product back out
            }
            else
            {
                OrderQuantity -= (double)productQuant;

                product.FullSheet = 0;
                product.ThreeQuarterSheet = 0;
                product.HalfSheet = 0;
                product.QuarterSheet = 0;

                Product product2 = dbContext.Products.Where(p => p.ColorID == product.ColorID && (p.FullSheet > 0 || p.ThreeQuarterSheet > 0 || p.HalfSheet > 0 || p.QuarterSheet > 0)).First();

                if (product2 != null)
                {
                    double product2Quant = GetProductTotal(product2);
                    if (product2Quant >= OrderQuantity)
                    {
                        DecideUsage(ref product2, OrderQuantity);
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

        public static bool Outgoing(Product product, long orderID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Product orderedProduct = dbContext.Products.Where(p => p.ID == product.ID).First();

            if (orderedProduct.FullSheet >= product.FullSheet)
            {
                orderedProduct.FullSheet -= product.FullSheet;
            }
            if (orderedProduct.ThreeQuarterSheet >= product.ThreeQuarterSheet)
            {
                orderedProduct.ThreeQuarterSheet -= product.FullSheet;
            }
            if (orderedProduct.HalfSheet >= product.HalfSheet)
            {
                orderedProduct.HalfSheet -= product.HalfSheet;
            }
            if (orderedProduct.QuarterSheet >= product.QuarterSheet)
            {
                orderedProduct.QuarterSheet -= product.QuarterSheet;
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

        protected static void DecideUsage(ref Product product, double Quantity)
        {
            while (Quantity > 0)
            {
                if (Quantity >= 1)
                {
                    product.FullSheet -= 1;
                    Quantity -= 1;
                    continue;
                }
                if (Quantity == .75)
                {
                    if (product.QuarterSheet >= 1)
                    {
                        product.QuarterSheet -= 1;
                        Quantity -= .75;
                    }
                    else
                    {
                        product.FullSheet -= 1;
                        product.QuarterSheet += 1;
                        Quantity -= .75;
                    }
                }
                if (Quantity == .5)
                {
                    if (product.HalfSheet >= 1)
                    {
                        product.HalfSheet -= 1;
                        Quantity -= .5;
                    }
                    else if (product.ThreeQuarterSheet >= 1)
                    {
                        product.ThreeQuarterSheet -= 1;
                        product.QuarterSheet += 1;
                        Quantity -= .5;
                    }
                    else
                    {
                        product.FullSheet -= 1;
                        product.HalfSheet += 1;
                        Quantity -= .5;
                    }
                }
                if (Quantity == .25)
                {
                    if (product.QuarterSheet >= 1)
                    {
                        product.QuarterSheet -= 1;
                        Quantity -= .25;
                    }
                    else if (product.HalfSheet >= 1)
                    {
                        product.HalfSheet -= 1;
                        product.QuarterSheet += 1;
                        Quantity -= .25;
                    }
                    else if (product.ThreeQuarterSheet >= 1)
                    {
                        product.ThreeQuarterSheet -= 1;
                        product.HalfSheet += 1;
                        Quantity -= .25;
                    }
                    else
                    {
                        product.FullSheet -= 1;
                        product.ThreeQuarterSheet += 1;
                        Quantity -= .25;
                    }
                }
            }

            return;
        }

        //protected static void OnPropertyChanged(string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public static double GetProductTotal(Product product)
        {
            if (product != null)
            {
                return (double)product.FullSheet + (double)product.ThreeQuarterSheet * .75 + (double)product.HalfSheet * .5 + (double)product.QuarterSheet * .25;
            }
            else
            {
                return 0;
            }
            
        }

        public static bool CheckNotify(Int64 vinylID)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Product product = dbContext.Products.Where(p => p.ID == vinylID).FirstOrDefault();
            double productQuant = GetProductTotal(product);
            return productQuant <= product.NotificationLevel;
        }
    }
}
