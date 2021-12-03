using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_SMS
{
    public class DAL_NV : DBConnection
    {
        public DataTable getNV()
        {
            SqlDataAdapter dal = new SqlDataAdapter("select * from NHANVIEN", con);
            DataTable dalNV = new DataTable();
            dal.Fill(dalNV);
            dalNV.Columns.Add("Ord");
            for (int i = 1; i <= dalNV.Rows.Count; i++)
                dalNV.Rows[i - 1]["Ord"] = i.ToString();
            return dalNV;
        }
        public DataTable getNV(string TenNV)
        {
            SqlDataAdapter dal = new SqlDataAdapter("select * from NHANVIEN where TenNV like '%" + TenNV + "%'", con);
            DataTable dalNV = new DataTable();
            dal.Fill(dalNV);
            dalNV.Columns.Add("Ord");
            for (int i = 1; i <= dalNV.Rows.Count; i++)
                dalNV.Rows[i - 1]["Ord"] = i.ToString();
            return dalNV;
        }
        public bool insertNV(string TenNV, string GioiTinh, string SDT, string Email, string DiaChi)
        {
            string str = string.Format("insert into NHANVIEN(TenNV,GioiTinh,SDT,Email,DiaChi) values('N{0}', N'{1}', N'{2}', N'{3}', N'{4}')"
            , TenNV, GioiTinh, SDT, Email, DiaChi);
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
        public bool updateNV(int MaNV, string TenNV, string GioiTinh, string SDT, string Email, string DiaChi)
        {
            string str = string.Format("update NHANVIEN set TenNV=N'{0}', GioiTinh=N'{1}', SDT=N'{2}', Email=N'{3}', DiaChi=N'{4}' where MaNV=N'{5}'"
            , TenNV, GioiTinh, SDT, Email, DiaChi, MaNV);
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
        public bool deleteNV(int MaNV)
        {
            string str = string.Format("delete from NHANVIEN where MaNV='{0}'", MaNV);
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
