﻿using System;
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
        public HocSinh()
        {
            InitializeComponent();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinHocSinh thongTinHocSinh = new ThongTinHocSinh();
            thongTinHocSinh.Show();
        }

        private void btnDongGopCauHoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinHocSinh thongTinHocSinh = new ThongTinHocSinh();
            thongTinHocSinh.Show();
        }
    }
}
