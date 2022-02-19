using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace lab9
{
    class DALKhachHang
    {
        ConnectDataBase connectDB;
        SqlDataAdapter adapter;
        public DALKhachHang()
        {
            connectDB = new ConnectDataBase();
        }

        public DataTable getAllKhachHang()
        {
            string query = "select * from KhachHang";

            SqlConnection con = ConnectDataBase.getConnection();

            adapter = new SqlDataAdapter(query, con);
            
            con.Open();
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);
            con.Close();
            return dTable;
        }

        public bool insertKhachHang(KhachHang kh)
        {
            String query = "insert into KhachHang values (@MaKH, @HoTenKH, @GioiTinh, @NamSinh, @SoDT)";

            SqlConnection con = ConnectDataBase.getConnection();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = kh.MaKH;
                cmd.Parameters.Add("@HoTenKH", SqlDbType.NVarChar).Value = kh.HoTenKH;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = kh.GioiTinh;
                cmd.Parameters.Add("@NamSinh", SqlDbType.Int).Value = kh.NamSinh;
                cmd.Parameters.Add("@SoDT", SqlDbType.Char).Value = kh.SoDT;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch{
                return false;
            }
            return true;
        }

        public bool updateKhachHang(KhachHang kh)
        {
            String query = "update KhachHang set HoTenKH = @HoTenKH, GioiTinh = @GioiTinh, NamSinh = @NamSinh, SoDT = @SoDT where MaKH = @MaKH";

            SqlConnection con = ConnectDataBase.getConnection();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = kh.MaKH;
                cmd.Parameters.Add("@HoTenKH", SqlDbType.NVarChar).Value = kh.HoTenKH;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = kh.GioiTinh;
                cmd.Parameters.Add("@NamSinh", SqlDbType.Int).Value = kh.NamSinh;
                cmd.Parameters.Add("@SoDT", SqlDbType.Char).Value = kh.SoDT;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteKhachHang(KhachHang kh)
        {
            String query = "delete KhachHang where MaKH = @MaKH";

            SqlConnection con = ConnectDataBase.getConnection();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = kh.MaKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable findKhachHang(string kh)
        {
            string query = "select * from KhachHang where HoTenKH like N'%" + kh + "%'";
            SqlConnection con = ConnectDataBase.getConnection();
            adapter = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);
            con.Close();
            return dTable;
        }

        //public bool DangNhap(string tk, string mk) {
        //    string query = "select * from userdn where username = '" + tk + "' and password = '" + mk + "'";
        //    SqlConnection con = ConnectDataBase.getConnection();
        //    adapter = new SqlDataAdapter(query, con);
        //    con.Open();
        //    DataTable dTable = new DataTable();
        //    adapter.Fill(dTable);
        //    con.Close();
        //    if (dTable == "")
        //}


    }
}
