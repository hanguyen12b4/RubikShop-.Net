using DAL_SMS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_SMS
{
    public class BUS_Supplier
    {
        DAL_Supplier dalProducts = new DAL_Supplier();
        public DataTable getAllSupplier()
        {
            return dalProducts.getAllSuppliers();
        }
    }
}
