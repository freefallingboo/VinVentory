using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinVentory
{
    partial class Supplier
    {

        public long AddNewSupplier(string Name, string ItemLink)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();

            Supplier supplier = new Supplier();
            supplier._Name = Name;
            supplier._ItemLink = ItemLink;

            dbContext.Suppliers.InsertOnSubmit(supplier);

            try
            {
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message, e.StackTrace);
            }

            return supplier._ID;
        }

        
    }
}
