using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_SMS;
using System.Data;
using System.Data.SqlClient;

namespace BUS_SMS
{
    public class BUS_Login
    {
        DAL_Login dalLogin = new DAL_Login();

        public bool checkLogin(string username, string password)
        {
            return dalLogin.checkLogin(username, password);
        }
    }
}
