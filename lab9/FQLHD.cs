using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9.HoaDon
{
    public partial class FQLHD : Form
    {
        BULHoaDon bulHoaDon;
        public FQLHD()
        {
            InitializeComponent();
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bulHoaDon = new BULHoaDon();
            ShowAllHD();
        }

        public void ShowAllHD()
        {
            DataTable dTable = bulHoaDon.showAllHoaDon();
            dgvHD.DataSource = dTable;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (txtSHD.Text == "" || txtMKH.Text == "" || txtMNV.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                HoaDon hd = new HoaDon();
                hd.SoHD = txtSHD.Text;
                hd.NgayBan = dtpNB.Value;
                hd.MaKH = txtMKH.Text;
                hd.MaNV = txtMNV.Text;
                if (bulHoaDon.insert1HoaDon(hd)){
                    ShowAllHD();
                    MessageBox.Show("Thêm đơn hàng thành công");
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (txtMKH.Text == "" || txtMNV.Text == "")
            {
                MessageBox.Show("Phải nhập mã khách hàng và mã nhân viên");
            }
            else
            {
                HoaDon hd = new HoaDon();
                hd.SoHD = txtSHD.Text;
                hd.NgayBan = dtpNB.Value;
                hd.MaKH = txtMKH.Text;
                hd.MaNV = txtMNV.Text;
                if (bulHoaDon.delete1HoaDon(hd))
                {
                    ShowAllHD();
                    MessageBox.Show("Xoá đơn hàng thành công");
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (txtMKH.Text == "" || txtMNV.Text == "")
            {
                MessageBox.Show("Phải nhập mã khách hàng và mã nhân viên");
            }
            else
            {
                HoaDon hd = new HoaDon();
                hd.SoHD = txtSHD.Text;
                hd.NgayBan = dtpNB.Value;
                hd.MaKH = txtMKH.Text;
                hd.MaNV = txtMNV.Text;
                if (bulHoaDon.update1HoaDon(hd))
                {
                    ShowAllHD();
                    MessageBox.Show("Sửa đơn hàng thành công");
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtSHD.Text = dgvHD.Rows[index].Cells["SoHD"].Value.ToString();
            dtpNB.Text = dgvHD.Rows[index].Cells["NgayBan"].Value.ToString();
            txtMKH.Text = dgvHD.Rows[index].Cells["MaKH"].Value.ToString();
            txtMNV.Text = dgvHD.Rows[index].Cells["MaNV"].Value.ToString();
        }
    }
}
