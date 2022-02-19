using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace lab9
{
    class BULKhachHang
    {
        DALKhachHang dalKH;

        public BULKhachHang()
        {
            dalKH = new DALKhachHang();
        }

        public DataTable showAllKhachHang()
        {
            return dalKH.getAllKhachHang();
        }

        public bool insert1KhachHang(KhachHang kh)
        {
            return dalKH.insertKhachHang(kh);
        }

        public bool update1KhachHang(KhachHang kh)
        {
            return dalKH.updateKhachHang(kh);
        }

        public bool delete1KhachHang(KhachHang kh)
        {
            return dalKH.deleteKhachHang(kh);
        }

        public DataTable find1KhachHang(string kh)
        {
            return dalKH.findKhachHang(kh);
        }
    }
}
