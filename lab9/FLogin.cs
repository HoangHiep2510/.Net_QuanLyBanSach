using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class FLogin : Form
    {
        private FMain Main;
        public FLogin(FMain Main)
        {
            this.Main = Main;
            InitializeComponent();
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection kn = ConnectDataBase.getConnection();
            try
            {
                kn.Open();
                string tk = txtT.Text;
                string mk = txtP.Text;
                string sql = "select * from userdn where username = '" + tk + "' and password = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, kn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    //new FQLKH().Show();
                    Main.setTenDN(txtT.Text);
                    Main.dangnhap();
                }
                else
                    MessageBox.Show("Sai thông tin");
            }catch{
                MessageBox.Show("Lỗi kết nối");
            }
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnDK_Click(object sender, EventArgs e)
        {
            new FRegistration().Show();
        }
    }
}
