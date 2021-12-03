using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SMS
{
    public class DAL_Supplier : DBConnection
    {
        public DataTable getAllSuppliers()
        {
            string sql = "SELECT * FROM Suppliers";
            SqlDataAdapter DA = new SqlDataAdapter(sql, con);
            DataTable supplierData = new DataTable();
            DA.Fill(supplierData);
            return supplierData;
        }

    }
}
