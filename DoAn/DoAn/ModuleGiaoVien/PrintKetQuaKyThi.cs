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
    public partial class PrintKetQuaKyThi : MetroFramework.Forms.MetroForm
    {
        string maKyThi;

        BindingSource BsKetQuaKT;
        ReportDataSource rdsKetQuaKT;

        public void NhanMaKyThi(string ID)
        {
            maKyThi = ID;
        }

        public PrintKetQuaKyThi()
        {
            InitializeComponent();
        }

        private void PrintKetQuaKyThi_Load(object sender, EventArgs e)
        {
            BsKetQuaKT = new BindingSource();
            rdsKetQuaKT = new ReportDataSource();

            reportViewer1.LocalReport.DataSources.Clear();

            try
            {
                using (var db = new DoAnDataContext())
                {
                    BsKetQuaKT.DataSource = db.ketQuas.Where(kq => kq.maKythi == maKyThi)
                                            .Join(db.hocSinhs, kq => kq.maHs, hs => hs.ma, (kq, hs) => new { kq, hs })
                                            .Join(db.kyThis, kq => kq.kq.maKythi, kt => kt.ma, (kq, kt) => new { kq, kt })
                                            .Join(db.monHocs, kt => kt.kt.maMonHoc, mh => mh.ma, (kt, mh) => new { kt, mh })
                                            .Join(db.kyThiChinhThucs, kt => kt.kt.kt.ma, ktct => ktct.maKyThi, (kt, ktct) => new { kt, ktct })
                                            .Select(kqhs => new ThongTinBangDiem
                                            {

                                                MaKyThi = maKyThi,
                                                MonHoc = kqhs.kt.mh.ten,
                                                NgayThi = DateTime.Parse(kqhs.ktct.ngayDienRa.ToString()).ToString("dd/MM/yyyy"),
                                                MaHocSinh = kqhs.kt.kt.kq.hs.ma,
                                                Ten = kqhs.kt.kt.kq.hs.ten,
                                                Lop = kqhs.kt.kt.kq.hs.maLop,
                                                MaDeThi = kqhs.kt.kt.kq.kq.maDe,
                                                Diem = kqhs.kt.kt.kq.kq.diem.ToString()
                                            });
                    
                    rdsKetQuaKT.Value = BsKetQuaKT;
                    rdsKetQuaKT.Name = "KQKyThiDataset";

                    reportViewer1.LocalReport.DataSources.Add(rdsKetQuaKT);


                    this.reportViewer1.RefreshReport();
                }
            }
            catch { }
          
        }
    }
}
