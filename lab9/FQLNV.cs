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
    public partial class FQLNV : Form
    {
        BULNhanVien bulNhanVien;
        public FQLNV()
        {
            InitializeComponent();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bulNhanVien = new BULNhanVien();
            ShowAllNV();
        }
        public void ShowAllNV()
        {
            DataTable dTable = bulNhanVien.showAllNhanVien();
            dgvNhanVien.DataSource = dTable;
        }
      
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[index].Cells["MaNV"].Value.ToString();
            txtHT.Text = dgvNhanVien.Rows[index].Cells["HoTen"].Value.ToString();
            txtNS.Text = dgvNhanVien.Rows[index].Cells["NamSinh"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHT.Text == "" || txtNS.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.HoTenNV = txtHT.Text;
                nv.NamSinh = int.Parse(txtNS.Text);
                if (bulNhanVien.insert1NhanVien(nv))
                {
                    ShowAllNV();
                    MessageBox.Show("Đã thêm thành công nhân viên " + txtHT.Text);
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên muốn xoá");
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.HoTenNV = txtHT.Text;
                nv.NamSinh = int.Parse(txtNS.Text);

                if (bulNhanVien.delete1NhanVien(nv)){
                    ShowAllNV();
                    MessageBox.Show("Đã xoá thành công nhân viên " + txtHT.Text);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên muốn xoá");
            }
            else
            {
                NhanVien kh = new NhanVien();
                kh.MaNV = txtMaNV.Text;
                kh.HoTenNV = txtHT.Text;
                kh.NamSinh = int.Parse(txtNS.Text);

                if (bulNhanVien.update1NhanVien(kh)){
                    ShowAllNV();
                    MessageBox.Show("Đã sửa thành công nhân viên " + txtHT.Text);
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            String kh = txtTim.Text;
            if (kh != "")
            {
                DataTable dTable = bulNhanVien.find1NhanVien(kh);
                dgvNhanVien.DataSource = dTable;
            }
            else
                bulNhanVien.showAllNhanVien();
        }

        
    }
}
