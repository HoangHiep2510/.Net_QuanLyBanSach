using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.ChiTietHoaDon
{
    class BULChiTietHoaDon
    {
        DALChiTietHoaDon dalCT;

        public BULChiTietHoaDon()
        {
            dalCT = new DALChiTietHoaDon();
        }

        public DataTable showAllChiTietHoaDon()
        {
            return dalCT.getAllChiTietHoaDon();
        }

        public bool insert1ChiTietHoaDon(ChiTietHoaDon ct)
        {
            return dalCT.insertChiTietHoaDon(ct);
        }

        public bool update1ChiTietHoaDon(ChiTietHoaDon ct)
        {
            return dalCT.updateChiTietHoaDon(ct);
        }

        public bool delete1ChiTietHoaDon(ChiTietHoaDon ct)
        {
            return dalCT.deleteChiTietHoaDon(ct);
        }

        public DataTable find1ChiTietHoaDon(string ct)
        {
            return dalCT.findChiTietHoaDon(ct);
        }
    }
}
