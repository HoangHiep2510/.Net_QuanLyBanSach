using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class FQLKH : Form
    {
        BULKhachHang bulKhachHang;
        public FQLKH()
        {
            InitializeComponent();
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bulKhachHang = new BULKhachHang();
            ShowAllKH();
        }

        public void ShowAllKH()
        {
            DataTable dTable = bulKhachHang.showAllKhachHang();
            dgvKhachHang.DataSource = dTable;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[index].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[index].Cells["HoTenKH"].Value.ToString();
            if (dgvKhachHang.Rows[index].Cells["GioiTinh"].Value.ToString() == "True") {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
            }
            else
            {
                rdbNam.Checked = false;
                rdbNu.Checked = true;
            }
            txtNamSinh.Text = dgvKhachHang.Rows[index].Cells["NamSinh"].Value.ToString();
            txtDT.Text = dgvKhachHang.Rows[index].Cells["SoDT"].Value.ToString();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            String kh = txtTim.Text;
            if (kh != "")
            {
                DataTable dTable = bulKhachHang.find1KhachHang(kh);
                dgvKhachHang.DataSource = dTable;
            }
            else
                bulKhachHang.showAllKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtNamSinh.Text == "" || txtDT.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.HoTenKH = txtTenKH.Text;
                kh.GioiTinh = (rdbNam.Checked ? true : false);
                kh.NamSinh = int.Parse(txtNamSinh.Text);
                kh.SoDT = txtDT.Text;
                if (bulKhachHang.insert1KhachHang(kh)){
                    MessageBox.Show("Đã thêm thành công khách hàng " + txtMaKH.Text);
                    ShowAllKH();
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") {
                MessageBox.Show("Chưa chọn mã khách hàng để xoá");
            }
            KhachHang kh = new KhachHang();
            kh.MaKH = txtMaKH.Text;
            kh.HoTenKH = txtTenKH.Text;
            kh.GioiTinh = (rdbNam.Checked ? true : false);
            kh.NamSinh = int.Parse(txtNamSinh.Text);
            kh.SoDT = txtDT.Text;

            if (bulKhachHang.delete1KhachHang(kh)){
                ShowAllKH();
                MessageBox.Show("Đã xoá thành công khách hàng " + txtMaKH.Text);
            }
            else
                MessageBox.Show("Lỗi");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Chưa chọn mã khách hàng để sửa");
            }
            KhachHang kh = new KhachHang();
            kh.MaKH = txtMaKH.Text;
            kh.HoTenKH = txtTenKH.Text;
            kh.GioiTinh = (rdbNam.Checked ? true : false);
            kh.NamSinh = int.Parse(txtNamSinh.Text);
            kh.SoDT = txtDT.Text;

            if (bulKhachHang.update1KhachHang(kh)){
                ShowAllKH();
                MessageBox.Show("Đã sửa thành công khách hàng " + txtMaKH.Text);
            }
            else
                MessageBox.Show("Lỗi");
        }

    }
}
