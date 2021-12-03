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
    public class BUS_NV
    {
        DAL_NV dalNV = new DAL_NV();
        public DataTable getNV()
        {
            return dalNV.getNV();
        }
        public DataTable getNV(string TenNV)
        {
            return dalNV.getNV(TenNV);
        }
        public bool insertNV(string TenNV, string GioiTinh, string SDT, string Email, string DiaChi)
        {
            return dalNV.insertNV(TenNV, GioiTinh, SDT, Email, DiaChi);
        }
        public bool updateNV(int MaNV, string TenNV, string GioiTinh, string SDT, string Email, string DiaChi)
        {
            return dalNV.updateNV(MaNV, TenNV, GioiTinh, SDT, Email, DiaChi);
        }
        public bool deleteNV(int MaNV)
        {
            return dalNV.deleteNV(MaNV);
        }
    }
}
