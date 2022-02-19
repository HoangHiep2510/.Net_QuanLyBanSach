using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class ConnectDataBase
    {

        public static string connectDB = @"Data Source=DESKTOP-LQRS80Q\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True";

        public static SqlConnection getConnection()
        {
            SqlConnection connect = new SqlConnection(connectDB);
            return connect;
        }
    }
}
