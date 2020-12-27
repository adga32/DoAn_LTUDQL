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
    public partial class GiaoVien : Form
    {
        string nguoidunghientai;
        public void LayNguoiDungHienTai(TextBox txtTenTaiKhoan)
        {
            nguoidunghientai = txtTenTaiKhoan.Text;
        }
        public delegate void NguoiDungHienTai(string value);
        public GiaoVien()
        {
            InitializeComponent();
        }

        private void btnQuanLyCauHoi_Click(object sender, EventArgs e)
        {
            LayCauHoiTuExcel FormlayCauHoiTuExcel = new LayCauHoiTuExcel();
            FormlayCauHoiTuExcel.ShowDialog();
            this.Close();
        }

        private void btnDongGopCauHoi_Click(object sender, EventArgs e)
        {
            DongGopCauHoi frmDongGopCauHoi = new DongGopCauHoi();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(frmDongGopCauHoi.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);
            frmDongGopCauHoi.ShowDialog();
            this.Close();
        }
    }
}
