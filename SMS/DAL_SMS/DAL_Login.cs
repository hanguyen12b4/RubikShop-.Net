using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_Login : DBConnection
    {
        public bool checkLogin(string username, string password)
        {

            string str = string.Format("select * from ACCOUNT where username='{0}' and password='{1}' ", username, password);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch
            {
                con.Close();
                return false;
            }

        }
    }
}
