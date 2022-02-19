using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.ChiTietHoaDon
{
    class DALChiTietHoaDon
    {
        ConnectDataBase connectDB;
        SqlDataAdapter adapter;
        public DALChiTietHoaDon()
        {
            connectDB = new ConnectDataBase();
        }

        public DataTable getAllChiTietHoaDon()
        {
            string query = "select * from CTHoaDon";
            SqlConnection con = ConnectDataBase.getConnection();
            adapter = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);
            con.Close();
            return dTable;
        }

        public bool insertChiTietHoaDon(ChiTietHoaDon ct)
        {
            String query = "insert into CTHoaDon values (@SoHD, @MaSach, @NgayGiao, @SoLuong, @Gia)";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@SoHD", SqlDbType.Char).Value = ct.SoHD;
                cmd.Parameters.Add("@MaSach", SqlDbType.Char).Value = ct.MaSach;
                cmd.Parameters.Add("@NgayGiao", SqlDbType.Date).Value = ct.NgayGiao;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ct.SoLuong;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = ct.Gia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch{
                return false;
            }
            return true;
        }

        public bool updateChiTietHoaDon(ChiTietHoaDon ct)
        {
            String query = "update CTHoaDon set NgayGiao = @NgayGiao, SoLuong = @SoLuong, Gia = @Gia where SoHD = @SoHD and MaSach = @MaSach";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@SoHD", SqlDbType.Char).Value = ct.SoHD;
                cmd.Parameters.Add("@MaSach", SqlDbType.Char).Value = ct.MaSach;
                cmd.Parameters.Add("@NgayGiao", SqlDbType.Date).Value = ct.NgayGiao;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ct.SoLuong;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = ct.Gia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteChiTietHoaDon(ChiTietHoaDon ct)
        {
            String query = "delete CTHoaDon where SoHD = @SoHD and MaSach = @MaSach";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@SoHD", SqlDbType.Char).Value = ct.SoHD;
                cmd.Parameters.Add("@MaSach", SqlDbType.Char).Value = ct.MaSach;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable findChiTietHoaDon(string ct)
        {
            string query = "select * from CTHoaDon where SoHD like '%" + ct + "%' or MaSach like '%" + ct + "%'";
            SqlConnection con = ConnectDataBase.getConnection();
            adapter = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);
            con.Close();
            return dTable;
        }
    }
}
