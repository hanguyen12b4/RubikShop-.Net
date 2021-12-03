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
    public class BUS_HoSoNV
    {
        DAL_HoSoNV dalHoSoNV = new DAL_HoSoNV();
        public DataTable getHoSoNV()
        {
            return dalHoSoNV.getHoSoNV();
        }
        public bool insertHoSoNV(int MaNV, string ChucVu, string Luong, string Ca, string ChamCong)
        {
            return dalHoSoNV.insertHoSoNV(MaNV, ChucVu, Luong, Ca, ChamCong);
        }
        public bool updateHoSoNV(int MaHoSo, int MaNV, string ChucVu, string Luong, string Ca, string ChamCong)
        {
            return dalHoSoNV.updateHoSoNV(MaHoSo, MaNV, ChucVu, Luong, Ca, ChamCong);
        }
        public bool deleteHoSoNV(int MaHoSo)
        {
            return dalHoSoNV.deleteHoSoNV(MaHoSo);
        }
    }
}
