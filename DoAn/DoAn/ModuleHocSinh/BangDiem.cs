using Microsoft.Reporting.WinForms;
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
    public partial class BangDiem : Form
    {
        string maHocSinh;

        BindingSource BsBangDiem;
        ReportDataSource rdsBangDiem;

        public void NhanMaHocSinh(string ID)
        {
            maHocSinh = ID;
        }

        public BangDiem()
        {
            InitializeComponent();
           
        }

        private void BangDiem_Load(object sender, EventArgs e)
        {
            BsBangDiem = new BindingSource();
            rdsBangDiem = new ReportDataSource();

            reportViewer1.LocalReport.DataSources.Clear();

            using (var db = new DoAnDataContext())
            {
                BsBangDiem.DataSource = db.hocSinhs.Where(hs => hs.ma == maHocSinh)
                                        .Join(db.ketQuas, hs => hs.ma, kq => kq.maHs, (hs, kq) => new { hs, kq })
                                        .Join(db.kyThis, hs => hs.kq.maKythi, kt => kt.ma, (hs, kt) => new { hs, kt })
                                        .Join(db.monHocs, kt => kt.kt.maMonHoc, mh => mh.ma, (kt, mh) => new { kt, mh })
                                        .Select(hs => new ThongTinBangDiem
                                        {
                                            MaHocSinh = maHocSinh,
                                            Ten = hs.kt.hs.hs.ten,
                                            NgaySinh = DateTime.Parse(hs.kt.hs.hs.ngaySinh.ToString()).ToString("dd/MM/yyyy"),
                                            Lop = hs.kt.hs.hs.maLop,
                                            MaKyThi = hs.kt.kt.ma,
                                            MonHoc = hs.mh.ten,
                                            Diem=hs.kt.hs.kq.diem.ToString()         
                                        });

                

                rdsBangDiem.Value = BsBangDiem;
                rdsBangDiem.Name = "BangDiemDataSet";

                reportViewer1.LocalReport.DataSources.Add(rdsBangDiem);

            }
            this.reportViewer1.RefreshReport();
        }
    }
}
