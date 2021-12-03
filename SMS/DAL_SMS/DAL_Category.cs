using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SMS
{
    public class DAL_Category : DBConnection
    {
        public DataTable getAllCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataAdapter DA = new SqlDataAdapter(sql, con);
            DataTable categoriesData = new DataTable();
            DA.Fill(categoriesData);
            return categoriesData;
        }
    }
}
