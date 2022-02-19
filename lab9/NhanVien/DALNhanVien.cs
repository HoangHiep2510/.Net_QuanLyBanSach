using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class DALNhanVien
    {
        ConnectDataBase connectDB;
        SqlDataAdapter adapter;
        public DALNhanVien()
        {
            connectDB = new ConnectDataBase();
        }

        public DataTable getAllNhanVien()
        {
            string query = "select * from NhanVien";
            SqlConnection con = ConnectDataBase.getConnection();
            adapter = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);
            con.Close();
            return dTable;
        }

        public bool insertNhanVien(NhanVien nv)
        {
            String query = "insert into NhanVien values (@MaNV, @HoTenNV, @NamSinh)";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = nv.MaNV;
                cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar).Value = nv.HoTenNV;
                cmd.Parameters.Add("@NamSinh", SqlDbType.Int).Value = nv.NamSinh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch{
                return false;
            }
            return true;
        }

        public bool updateNhanVien(NhanVien nv)
        {
            String query = "update NhanVien set HoTen = @HoTen, NamSinh = @NamSinh where MaNV= @MaNV";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = nv.MaNV;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTenNV;
                cmd.Parameters.Add("@NamSinh", SqlDbType.Int).Value = nv.NamSinh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteNhanVien(NhanVien nv)
        {
            String query = "delete NhanVien where MaNV = @MaNV";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = nv.MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable findNhanVien(string nv)
        {
            string query = "select * from NhanVien where HoTen like N'%" + nv + "%'";
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
