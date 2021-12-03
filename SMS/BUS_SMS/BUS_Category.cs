using DAL_SMS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_SMS
{
    public class BUS_Category
    {
        DAL_Category dalCategory = new DAL_Category();
        public DataTable getAllCategory()
        {
            return dalCategory.getAllCategories();
        }
    }
}
