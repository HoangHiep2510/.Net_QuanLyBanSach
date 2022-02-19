using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.HoaDon
{
    class DALHoaDon
    {
        ConnectDataBase connectDB;
        SqlDataAdapter adapter;
        public DALHoaDon()
        {
            connectDB = new ConnectDataBase();
        }

        public DataTable getAllHoaDon()
        {
            string query = "select * from HoaDon";

            SqlConnection con = ConnectDataBase.getConnection();

            adapter = new SqlDataAdapter(query, con);
            
            con.Open();
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);
            con.Close();
            return dTable;
        }

        public bool insertHoaDon(HoaDon hd)
        {
            String query = "insert into HoaDon values (@SoHD, @NgayBan, @MaKH, @MaNV)";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@SoHD", SqlDbType.Char).Value = hd.SoHD;
                cmd.Parameters.Add("@NgayBan", SqlDbType.Date).Value = hd.NgayBan.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = hd.MaKH;
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = hd.MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch{
                return false;
            }
            return true;
        }

        public bool updateHoaDon(HoaDon hd)
        {
            String query = "update HoaDon set NgayBan = @NgayBan, MaKH = @MaKH, MaNV = @MaNV where SoHD = @SoHD";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@NgayBan", SqlDbType.Date).Value = hd.NgayBan.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = hd.MaKH;
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = hd.MaNV;
                cmd.Parameters.Add("@SoHD", SqlDbType.Char).Value = hd.SoHD;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteHoaDon(HoaDon hd)
        {
            String query = "delete HoaDon where SoHD = @SoHD";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@SoHD", SqlDbType.Char).Value = hd.SoHD;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
