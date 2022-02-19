using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9.ChiTietHoaDon
{
    public partial class FCTHD : Form
    {
        BULChiTietHoaDon bulChiTietHoaDon;
        public FCTHD()
        {
            InitializeComponent();
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bulChiTietHoaDon = new BULChiTietHoaDon();
            ShowAllCT();
        }
        public void ShowAllCT()
        {
            DataTable dTable = bulChiTietHoaDon.showAllChiTietHoaDon();
            dgvCTHD.DataSource = dTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoHD.Text == "" || txtMaSach.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            ChiTietHoaDon ct = new ChiTietHoaDon();
            ct.SoHD = txtSoHD.Text;
            ct.MaSach = txtMaSach.Text;
            ct.NgayGiao = dtpNG.Value;
            ct.SoLuong = int.Parse(txtSoLuong.Text);
            ct.Gia = int.Parse(txtDonGia.Text);
            if (bulChiTietHoaDon.insert1ChiTietHoaDon(ct)){
                ShowAllCT();
                MessageBox.Show("Thêm chi tiết hoá đơn thành công");
            }
            else
                MessageBox.Show("Lỗi");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoHD.Text == "" || txtMaSach.Text == "")
            {
                MessageBox.Show("Phải nhập số hoá đơn và mã sách");
            }
            else
            {
                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.SoHD = txtSoHD.Text;
                ct.MaSach = txtMaSach.Text;
                ct.NgayGiao = dtpNG.Value;
                ct.SoLuong = int.Parse(txtSoLuong.Text);
                ct.Gia = int.Parse(txtDonGia.Text);
                if (bulChiTietHoaDon.delete1ChiTietHoaDon(ct))
                {
                    ShowAllCT();
                    MessageBox.Show("Xoá chi tiết hoá đơn thành công");
                }
                    
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoHD.Text == "" || txtMaSach.Text == "")
            {
                MessageBox.Show("Phải nhập số hoá đơn và mã sách");
            }
            else
            {
                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.SoHD = txtSoHD.Text;
                ct.MaSach = txtMaSach.Text;
                ct.NgayGiao = dtpNG.Value;
                ct.SoLuong = int.Parse(txtSoLuong.Text);
                ct.Gia = int.Parse(txtDonGia.Text);
                if (bulChiTietHoaDon.update1ChiTietHoaDon(ct))
                {
                    ShowAllCT();
                    MessageBox.Show("Sửa chi tiết đơn hàng thành công");
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            String ct = txtTim.Text;
            if (ct != "")
            {
                DataTable dTable = bulChiTietHoaDon.find1ChiTietHoaDon(ct);
                dgvCTHD.DataSource = dTable;
            }
            else
                bulChiTietHoaDon.showAllChiTietHoaDon();
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtSoHD.Text = dgvCTHD.Rows[index].Cells["SoHD"].Value.ToString();
            txtMaSach.Text = dgvCTHD.Rows[index].Cells["MaSach"].Value.ToString();
            dtpNG.Text = dgvCTHD.Rows[index].Cells["NgayGiao"].Value.ToString();
            txtSoLuong.Text = dgvCTHD.Rows[index].Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = dgvCTHD.Rows[index].Cells["Gia"].Value.ToString();
        }
    }
}
