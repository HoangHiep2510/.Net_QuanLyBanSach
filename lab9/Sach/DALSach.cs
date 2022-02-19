using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.Sach
{
    class DALSach
    {
        ConnectDataBase connectDB;
        SqlDataAdapter adapter;
        public DALSach()
        {
            connectDB = new ConnectDataBase();
        }

        public DataTable getAllSach()
        {
            string query = "select * from Sach";
            SqlConnection con = ConnectDataBase.getConnection();
            adapter = new SqlDataAdapter(query, con);
            con.Open();
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);
            con.Close();
            return dTable;
        }

        public bool insertSach(Sach s)
        {
            String query = "insert into Sach values (@MaSach, @TenSach, @TacGia, @NamXB,@DonGia, @MoTa, @MaNXB)";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaSach", SqlDbType.Char).Value = s.MaSach;
                cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = s.TenSach;
                cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = s.TacGia;
                cmd.Parameters.Add("@NamXB", SqlDbType.Int).Value = s.NamXB;
                cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = s.DonGia;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = s.MoTa;
                cmd.Parameters.Add("@MaNXB", SqlDbType.Char).Value = s.@MaNXB;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch{
                return false;
            }
            return true;
        }

        public bool updateSach(Sach s)
        {
            String query = "update Sach set TenSach = @TenSach, TacGia = @TacGia, NamXB = @NamXB,"
            +"DonGia = @DonGia, MoTa = @MoTa, MaNXB = @MaNXB where MaSach= @MaSach";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaSach", SqlDbType.Char).Value = s.MaSach;
                cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = s.TenSach;
                cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = s.TacGia;
                cmd.Parameters.Add("@NamXB", SqlDbType.Int).Value = s.NamXB;
                cmd.Parameters.Add("@DonGia", SqlDbType.Int).Value = s.DonGia;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = s.MoTa;
                cmd.Parameters.Add("@MaNXB", SqlDbType.Char).Value = s.@MaNXB;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteSach(Sach s)
        {
            String query = "delete Sach where MaSach = @MaSach";
            SqlConnection con = ConnectDataBase.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@MaSach", SqlDbType.Char).Value = s.MaSach;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable findSach(string s)
        {
            string query = "select * from Sach where TenSach like N'%" + s + "%'";
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
