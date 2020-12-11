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
    public partial class HocSinh : Form
    {
        string nguoidunghientai;
        public void LayNguoiDungHienTai(TextBox txtTenTaiKhoan)
        {
            nguoidunghientai = txtTenTaiKhoan.Text;
        }
        public delegate void NguoiDungHienTai(string value);


        public HocSinh()
        {
            InitializeComponent();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {   
            ThongTinHocSinh thongTinHocSinh = new ThongTinHocSinh();
            thongTinHocSinh.ShowDialog();
            this.Close();
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            LamBaiTracNghiem lamBaiTracNghiem = new LamBaiTracNghiem();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(lamBaiTracNghiem.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);
            lamBaiTracNghiem.ShowDialog();
            this.Close();
        }
    }
}
