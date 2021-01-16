using DoAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmAdmin : MetroFramework.Forms.MetroForm
    {
        string nguoidunghientai;
        public void LayNguoiDungHienTai(TextBox txtTenTaiKhoan)
        {
            nguoidunghientai = txtTenTaiKhoan.Text;
        }
        public delegate void NguoiDungHienTai(string value);
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung frmQLND = new QuanLyNguoiDung();
            frmQLND.Show();
        }

        private void btnQuanLyHeThong_Click(object sender, EventArgs e)
        {
            QuanLyHeThong frmQuanLyHeThong = new QuanLyHeThong();
            frmQuanLyHeThong.Show();
        }
    }
}
