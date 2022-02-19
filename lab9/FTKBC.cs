using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab9.Sach;
using System.Data.SqlClient;

namespace lab9
{
    public partial class FTKBC : Form
    {
        BULKhachHang bulKhachHang;
        BULSach bulSach;
        public FTKBC()
        {
            InitializeComponent();
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bulKhachHang = new BULKhachHang();
            dgvS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bulSach = new BULSach();
            ShowAllKH();
            ShowAllS();
        }
        public void ShowAllKH()
        {
            DataTable dTable = bulKhachHang.showAllKhachHang();
            dgvKH.DataSource = dTable;
        }
        public void ShowAllS()
        {
            DataTable dTable = bulSach.showAllSach();
            dgvS.DataSource = dTable;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            dgvDT.DataSource = ThongKe().Tables[0];
        }

        DataSet ThongKe()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DoanhThu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = ConnectDataBase.getConnection();
            cmd.Parameters.Add(new SqlParameter("@ngayban", dtpNB.Value.ToString("yyyy/MM/dd")));
            cmd.Parameters.Add(new SqlParameter("@ngaygiao", dtpNG.Value.ToString("yyyy/MM/dd")));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
    }
}
