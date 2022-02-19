using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class BULNhanVien
    {
        DALNhanVien dalNV;

        public BULNhanVien()
        {
            dalNV = new DALNhanVien();
        }

        public DataTable showAllNhanVien()
        {
            return dalNV.getAllNhanVien();
        }

        public bool insert1NhanVien(NhanVien nv)
        {
            return dalNV.insertNhanVien(nv);
        }

        public bool update1NhanVien(NhanVien nv)
        {
            return dalNV.updateNhanVien(nv);
        }

        public bool delete1NhanVien(NhanVien nv)
        {
            return dalNV.deleteNhanVien(nv);
        }

        public DataTable find1NhanVien(string nv)
        {
            return dalNV.findNhanVien(nv);
        }
    }
}
