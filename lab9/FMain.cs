using lab9.HoaDon;
using lab9.Sach;
using lab9.ChiTietHoaDon;
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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            dangxuat();
        }

        public void dangxuat()
        {
            mQLNS.Enabled = false;
            mTKBC.Enabled = false;
            mDX.Enabled = false;
            mDN.Enabled = true;
            mDMK.Enabled = false;
        }

        public void dangnhap()
        {
            mQLNS.Enabled = true;
            mTKBC.Enabled = true;
            mDX.Enabled = true;
            mDN.Enabled = false;
            mDMK.Enabled = true;
        }
        public string Ten;
        public void setTenDN(string ten)
        {
            lblTen.Text = "Xin chào: " + ten;
            Ten = ten;
        }
        
        private void thốngKêBáoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                new FTKBC().Show();
        }

        private void mTTK_Click(object sender, EventArgs e)
        {
            new FRegistration().Show();
        }

        private void mDN_Click(object sender, EventArgs e)
        {
            new FLogin(this).Show();
        }

        private void mDX_Click(object sender, EventArgs e)
        {
            lblTen.Text = "";
            dangxuat();
        }

        private void mDMK_Click(object sender, EventArgs e)
        {
            new FChangePassword(this).Show();
        }

        private void mQLNV_Click(object sender, EventArgs e)
        {
            new FQLNV().Show();
        }

        private void mQLKH_Click(object sender, EventArgs e)
        {
            new FQLKH().Show();
        }

        private void mQLHD_Click(object sender, EventArgs e)
        {
            new FQLHD().Show();
        }

        private void mQLS_Click(object sender, EventArgs e)
        {
            new FQLS().Show();
        }

        private void quảnLýChiTiếtĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FCTHD().Show();
        }
    }
}
