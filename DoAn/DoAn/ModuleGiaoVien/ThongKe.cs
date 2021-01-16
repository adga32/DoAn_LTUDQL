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
    public partial class ThongKe : MetroFramework.Forms.MetroForm
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKeHocSinh_Click(object sender, EventArgs e)
        {
            ThongKeHocSinh thongKeHocSinh = new ThongKeHocSinh();
            thongKeHocSinh.Show();   
        }

        private void btnThongKeKyThi_Click(object sender, EventArgs e)
        {
            ThongKeKyThi thongKeKyThi = new ThongKeKyThi();
            thongKeKyThi.Show();
        }

        private void btnThongKeCauHoi_Click(object sender, EventArgs e)
        {
            ThongKeCauHoi thongKeCauHoi = new ThongKeCauHoi();
            thongKeCauHoi.Show();
        }
    }
}
