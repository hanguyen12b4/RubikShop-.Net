using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_HoSoNV : DBConnection
    {
        public DataTable getHoSoNV()
        {
            SqlDataAdapter dal = new SqlDataAdapter("select * from HOSONV", con);
            DataTable dalHoSoNV = new DataTable();
            dal.Fill(dalHoSoNV);
            dalHoSoNV.Columns.Add("Ord");
            for (int i = 1; i <= dalHoSoNV.Rows.Count; i++)
                dalHoSoNV.Rows[i - 1]["Ord"] = i.ToString();
            return dalHoSoNV;
        }
        
        public bool insertHoSoNV(int MaNV, string ChucVu, string Luong, string Ca, string ChamCong)
        {
            string str = string.Format("insert into HOSONV(MaNV,ChucVu,Luong,Ca,ChamCong) values('N{0}', N'{1}', N'{2}', N'{3}', N'{4}')"
            , MaNV, ChucVu, Luong, Ca, ChamCong);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool updateHoSoNV(int MaHoSo, int MaNV, string ChucVu, string Luong, string Ca, string ChamCong)
        {
            string str = string.Format("update HOSONV set MaNV=N'{0}', ChucVu=N'{1}', Luong=N'{2}', Ca=N'{3}', ChamCong=N'{4}' where MaHoSo=N'{5}'"
            , MaNV, ChucVu, Luong, Ca, ChamCong, MaHoSo);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool deleteHoSoNV(int MaHoSo)
        {
            string str = string.Format("delete from HOSONV where MaHoSo='{0}'", MaHoSo);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            con.Close();
            return true;
        }
    }
}
