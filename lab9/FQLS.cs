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

namespace lab9.Sach
{
    public partial class FQLS : Form
    {
        BULSach bulSach;
        public FQLS()
        {
            InitializeComponent();
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bulSach = new BULSach();
            ShowAllS();
        }

        public void ShowAllS()
        {
            DataTable dTable = bulSach.showAllSach();
            dgvSach.DataSource = dTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtTacGia.Text == "" || txtNamXB.Text == "" || txtDG.Text == "" || txtMaNXB.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                s.MaSach = txtMaSach.Text;
                s.TenSach = txtTenSach.Text;
                s.TacGia = txtTacGia.Text;
                s.NamXB = int.Parse(txtNamXB.Text);
                s.DonGia = int.Parse(txtDG.Text);
                s.MoTa = txtMoTa.Text;
                s.MaNXB = txtMaNXB.Text;
                if (bulSach.insert1Sach(s)){
                    ShowAllS();
                    MessageBox.Show("Đã thêm thành công sách " + txtTenSach.Text);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Chọn mã sách cần xoá");
                txtMaSach.Focus();
            }
            else
            {
                s.MaSach = txtMaSach.Text;
                s.TenSach = txtTenSach.Text;
                s.TacGia = txtTacGia.Text;
                s.NamXB = int.Parse(txtNamXB.Text);
                s.DonGia = int.Parse(txtDG.Text);
                s.MoTa = txtMoTa.Text;
                s.MaNXB = txtMaNXB.Text;

                if (bulSach.delete1Sach(s)){
                    ShowAllS();
                    MessageBox.Show("Đã xoá thành công sách " + txtTenSach.Text);
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            if (txtMaSach.Text == "" || txtTenSach.Text == "" || txtTacGia.Text == "" || txtNamXB.Text == "" || txtDG.Text == "" || txtMaNXB.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
            else
            {
                s.MaSach = txtMaSach.Text;
                s.TenSach = txtTenSach.Text;
                s.TacGia = txtTacGia.Text;
                s.NamXB = int.Parse(txtNamXB.Text);
                s.DonGia = int.Parse(txtDG.Text);
                s.MoTa = txtMoTa.Text;
                s.MaNXB = txtMaNXB.Text;
                if (bulSach.update1Sach(s))
                {
                    ShowAllS();
                    MessageBox.Show("Đã sửa thành công sách " + txtTenSach.Text);
                }
                else
                    MessageBox.Show("Lỗi");
            }
            
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            String s = txtTim.Text;
            if (s != "")
            {
                DataTable dTable = bulSach.find1Sach(s);
                dgvSach.DataSource = dTable;
            }
            else
                bulSach.showAllSach();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaSach.Text = dgvSach.Rows[index].Cells["MaSach"].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[index].Cells["TenSach"].Value.ToString();
            txtTacGia.Text = dgvSach.Rows[index].Cells["TacGia"].Value.ToString();
            txtNamXB.Text = dgvSach.Rows[index].Cells["NamXB"].Value.ToString();
            txtDG.Text = dgvSach.Rows[index].Cells["DonGia"].Value.ToString();
            txtMoTa.Text = dgvSach.Rows[index].Cells["MoTa"].Value.ToString();
            txtMaNXB.Text = dgvSach.Rows[index].Cells["MaNXB"].Value.ToString();
        }

        
    }
}
