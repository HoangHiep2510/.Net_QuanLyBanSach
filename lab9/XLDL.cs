using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class XLDL
    {
        public static object Thuc_hien_lenh_tinh_toan(string cau_lenh)
        {
            try
            {
                SqlConnection ket_noi = new SqlConnection(ConnectDataBase.connectDB);
                SqlCommand bo_lenh = new SqlCommand(cau_lenh, ket_noi);
                ket_noi.Open();
                object ket_qua = bo_lenh.ExecuteScalar();
                ket_noi.Close();
                return ket_qua;
            }
            catch
            {
                return null;
            }
        }
    }
}
