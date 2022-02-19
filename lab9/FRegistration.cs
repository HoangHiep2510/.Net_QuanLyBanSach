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
    public partial class FRegistration : Form
    {
        public FRegistration()
        {
            InitializeComponent();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            string nlmk = txtNLMK.Text;
            int kq = int.Parse(XLDL.Thuc_hien_lenh_tinh_toan("select count(*) from userdn where username = '" + tk + "'").ToString());
            if (txtTK.Text == "" || txtMK.Text== "" || txtNLMK.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else if (kq>0) {
                MessageBox.Show("Tài khoản đã tồn tại");
                txtTK.SelectAll();
                txtTK.Focus();
            }
            else if (mk != nlmk)
            {
                MessageBox.Show("Nhập lại mật khẩu sai");
                txtNLMK.SelectAll();
                txtNLMK.Focus();
            }
            else {
                SqlConnection kn = ConnectDataBase.getConnection();
                try
                {
                    kn.Open();
                    string sql = "insert into userdn values('"+tk+"','"+mk+"')";
                    SqlCommand cmd = new SqlCommand(sql, kn);
                    cmd.ExecuteNonQuery();
                    kn.Close();
                    MessageBox.Show("Đã đăng kí thành công");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
