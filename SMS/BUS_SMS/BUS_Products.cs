using DAL_SMS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_SMS
{
    public class BUS_Products
    {
        DAL_Product dalProducts = new DAL_Product();
        public DataTable getAllProducts()
        {
            return dalProducts.getAllProducts();
        }
        public bool insertProduct(string ProductName, string Unit, float Price, int CategoryID, int SupplierID)
        {
            return dalProducts.insertProduct(ProductName, Unit, Price, CategoryID, SupplierID);
        }
        public bool updateProduct(string ProductName, string Unit, float Price, int CategoryID, int SupplierID, int ProductID)
        {
            return dalProducts.updateProduct(ProductName, Unit, Price, CategoryID, SupplierID, ProductID);
        }
        public bool deleteProduct(int ProductID)
        {
            return dalProducts.deleteProduct(ProductID);
        }
    } 
  
}
