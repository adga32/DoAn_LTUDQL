using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoVien
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKeHocSinh_Click(object sender, EventArgs e)
        {
            ThongKeHocSinh thongKeHocSinh = new ThongKeHocSinh();
            thongKeHocSinh.ShowDialog();   
        }

        private void btnThongKeKyThi_Click(object sender, EventArgs e)
        {
            ThongKeKyThi thongKeKyThi = new ThongKeKyThi();
            thongKeKyThi.ShowDialog();
        }

        private void btnThongKeCauHoi_Click(object sender, EventArgs e)
        {
            ThongKeCauHoi thongKeCauHoi = new ThongKeCauHoi();
            thongKeCauHoi.ShowDialog();
        }
    }
}
