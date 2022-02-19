using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.HoaDon
{
    class BULHoaDon
    {
        DALHoaDon dalHD;

        public BULHoaDon()
        {
            dalHD = new DALHoaDon();
        }

        public DataTable showAllHoaDon()
        {
            return dalHD.getAllHoaDon();
        }

        public bool insert1HoaDon(HoaDon hd)
        {
            return dalHD.insertHoaDon(hd);
        }

        public bool update1HoaDon(HoaDon hd)
        {
            return dalHD.updateHoaDon(hd);
        }

        public bool delete1HoaDon(HoaDon hd)
        {
            return dalHD.deleteHoaDon(hd);
        }
    }
}
