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
    public partial class FChangePassword : Form
    {
        private FMain Main;
        public FChangePassword(FMain Main)
        {
            InitializeComponent();
            this.Main = Main;
            lblTen.Text = "Chào bạn: " + Main.Ten;
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            int kq = int.Parse(XLDL.Thuc_hien_lenh_tinh_toan("select count(*) from userdn where username = '" + txtMKC.Text + "'").ToString());
            if (txtMKC.Text == "" || txtNLMKM.Text == "" || txtMKM.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else if(kq>0){
                MessageBox.Show("Sai mật khẩu cũ");
                txtMKC.SelectAll();
                txtMKC.Focus();
            }
            else if(txtNLMKM.Text != txtMKM.Text){
                MessageBox.Show("Nhập lại mật khẩu mới sai");
                txtNLMKM.SelectAll();
                txtNLMKM.Focus();
            }
            else{
                SqlConnection kn = ConnectDataBase.getConnection();
                try
                {
                    kn.Open();
                    string sql = "update userdn set password = '" + txtMKM.Text + "' where username = '"+lblTen.Text+"'";
                    SqlCommand cmd = new SqlCommand(sql, kn);
                    cmd.ExecuteNonQuery();
                    kn.Close();
                    MessageBox.Show("Đã đổi thành công");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }
    }
}
