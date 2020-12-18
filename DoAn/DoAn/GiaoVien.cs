using DoAn.tool_GV_quan_ly_cau_hoi;
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


        private void button_layDulieuTuExcel_Click_1(object sender, EventArgs e)
        {
            LayCauHoiTuExcel FormlayCauHoiTuExcel = new LayCauHoiTuExcel();
            FormlayCauHoiTuExcel.ShowDialog();
            this.Close();
        }
    }
}
