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
    public partial class ThongKeCauHoi : MetroFramework.Forms.MetroForm
    {
        public ThongKeCauHoi()
        {
            InitializeComponent();
        }

        private void ThongKeCauHoi_Load(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                var soluongdethi = (from i in db.deThis
                                    select i).Count();
                var TiLeXuatHien = (from i in db.chiTietDethis
                                    group i by i.maCauHoi into groupResult
                                    select new
                                    {
                                        MaCauHoi = groupResult.Key,
                                        TongLanXuatHienCau = (groupResult.Count() * 100 / soluongdethi),
                                    }).ToList();

                var cauhoi = (from i in TiLeXuatHien
                              join j in db.cauHois
                              on i.MaCauHoi equals j.ma
                              select new { j.noiDung, TongLanXuatHienCau = i.TongLanXuatHienCau.ToString() + "%" }).ToList();
                dgvDanhSachCauHoi.DataSource = cauhoi;
            }

        }

    }
}
