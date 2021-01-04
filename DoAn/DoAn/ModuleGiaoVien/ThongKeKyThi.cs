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
    public partial class ThongKeKyThi : Form
    {
        public ThongKeKyThi()
        {
            InitializeComponent();
        }

        private void ThongKeKyThi_Load(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                cbbKyThi.DataSource = (from i in db.kyThis select i.ma).ToList();

                cbbMaDe.DataSource = (from i in db.kyThis join j in db.ketQuas on i.ma equals j.maKythi where i.ma == cbbKyThi.SelectedValue.ToString() select j.maDe).Distinct().ToList();
            }
        }

        private void cbbKyThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                cbbMaDe.DataSource = (from i in db.kyThis join j in db.ketQuas on i.ma equals j.maKythi where i.ma == cbbKyThi.SelectedValue.ToString() select j.maDe).Distinct().ToList();
            }
        }

        private void cbbMaDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var db = new DoAnDataContext())
            {
                var Ketqua = (from i in db.ketQuas
                              join j in db.hocSinhs
                              on i.maHs equals j.ma
                              where i.maKythi == cbbKyThi.SelectedValue.ToString() && i.maDe == cbbMaDe.SelectedValue.ToString()
                              select new
                              {
                                  j.ma,
                                  j.ten,
                                  j.maLop,
                                  i.diem
                              }).ToList();
                var ListKetQua = (from i in Ketqua
                                  join j in db.lops
                                  on i.maLop equals j.ma
                                  select new
                                  {
                                      TENHS = i.ten,
                                      DIEM = i.diem,
                                      TENLOP = j.ten
                                  }).ToList();

                dgvThongKe.DataSource = ListKetQua;
                txtDiemTrungBinh.Text = ListKetQua.Average(x => x.DIEM).ToString();
            }
        }
    }
}
