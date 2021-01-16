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
    public partial class PrintDanhSachHS : MetroFramework.Forms.MetroForm
    {
        string maKyThi;

        BindingSource BsHocSinh;

        ReportDataSource rdsHocSinh;



        public void NhanMaKyThi(string ID)
        {
            maKyThi = ID;
        }

        public PrintDanhSachHS()
        {
            InitializeComponent();

        }

        private void PrintDanhSachHS_Load(object sender, EventArgs e)
        {
            BsHocSinh = new BindingSource();
            rdsHocSinh = new ReportDataSource();

            rptVDsHocSinh.LocalReport.DataSources.Clear();

            using (var db = new DoAnDataContext())
            {
                BsHocSinh.DataSource = db.thamGiaKyThis.Where(tg => tg.maKyThi == maKyThi)
                                        .Join(db.hocSinhs, tg => tg.maHs, hs => hs.ma, (tg, hs) => new { tg, hs })
                                        .Join(db.kyThiChinhThucs,tg=>tg.tg.maKyThi,ktct=>ktct.maKyThi,(tg,ktct)=>new { tg,ktct})
                                        .Join(db.kyThis,tg=>tg.ktct.maKyThi,kt=>kt.ma,(ktct,kt)=>new { ktct,kt})
                                        .Join(db.monHocs,tg=>tg.kt.maMonHoc,mh=>mh.ma,(tg,mh)=> new{ tg,mh})
                                        .Select(hs => new ThongTinBangDiem
                                        {
                                            MaKyThi=hs.tg.kt.ma,
                                            MonHoc=hs.mh.ten,
                                            NgayThi=DateTime.Parse(hs.tg.ktct.ktct.ngayDienRa.ToString()).ToString("dd/MM/yyyy"),
                                            MaHocSinh = hs.tg.ktct.tg.hs.ma,
                                            Ten = hs.tg.ktct.tg.hs.ten,
                                            Lop = hs.tg.ktct.tg.hs.maLop
                                        });
                
           
                rdsHocSinh.Value = BsHocSinh;
                rdsHocSinh.Name = "DsHocSinhDataSet";

                rptVDsHocSinh.LocalReport.DataSources.Add(rdsHocSinh);

                this.rptVDsHocSinh.RefreshReport();
                
            }


        }
    }
}
