using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SMS
{
    public class DAL_Product : DBConnection
    {
        public DataTable getAllProducts()
        {
            string sql = "SELECT Products.*,Categories.CategoryName,Suppliers.SupplierName FROM Products inner join Categories on Categories.CategoryID = Products.CategoryID inner join Suppliers on Suppliers.SupplierID = Products.SupplierID";
            SqlDataAdapter DA = new SqlDataAdapter(sql, con);
            DataTable productData = new DataTable();
            DA.Fill(productData);
            productData.Columns.Add("Ord");
            for (int i = 1; i <= productData.Rows.Count; i++)
                productData.Rows[i - 1]["Ord"] = i.ToString();
            return productData;
        }

        public bool insertProduct(string ProductName, string Unit, float Price, int CategoryID, int SupplierID)
        {
            bool result = false;
            string str = string.Format("INSERT INTO Products (ProductName,SupplierID,CategoryID,Unit,Price,Photo) VALUES ('N{0}', {1}, {2}, N'{3}',{4},'{5}')",
            ProductName, SupplierID, CategoryID, Unit, Price,"/250x250.png/5fa2dd/ffffff&text=ProductPhoto");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                return false;
            }
            con.Close();
            return result;
        }
        public bool updateProduct(string ProductName, string Unit, float Price, int CategoryID, int SupplierID, int ProductID)
        {
            bool result = false;
            string str = string.Format("UPDATE Products SET ProductName = 'N{0}',SupplierID= {1},CategoryID ={2},Unit ='N{3}',Price = {4},Photo = '{5}' WHERE ProductID = '{6}'",
            ProductName, SupplierID, CategoryID, Unit, Price, "/250x250.png/5fa2dd/ffffff&text=ProductPhoto", ProductID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                return false;
            }
            con.Close();
            return result;
        }
        public bool deleteProduct(int ProductID)
        {
            bool result = false;
            string str = string.Format("delete from Products where ProductID='{0}'", ProductID);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                return result;
            }
            con.Close();
            return result;
        }

    }
}
