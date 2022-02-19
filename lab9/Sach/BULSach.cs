using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.Sach
{
    class BULSach
    {
        DALSach dalS;

        public BULSach()
        {
            dalS = new DALSach();
        }

        public DataTable showAllSach()
        {
            return dalS.getAllSach();
        }

        public bool insert1Sach(Sach s)
        {
            return dalS.insertSach(s);
        }

        public bool update1Sach(Sach s)
        {
            return dalS.updateSach(s);
        }

        public bool delete1Sach(Sach s)
        {
            return dalS.deleteSach(s);
        }

        public DataTable find1Sach(string s)
        {
            return dalS.findSach(s);
        }
    }
}
