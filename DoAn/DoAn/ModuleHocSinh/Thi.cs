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
    public partial class Thi : Form
    {
        public delegate void NguoiDungHienTai(string userName);

        //delegate mục đích truyền dấu hiệu nhận biết là thi thật hay luyện tập tới form Làm bài trắc nghiệm 
        public delegate void LoaiHinhBaiThi(bool loaiBaiThi, string maDeThi);
        public delegate void deMaKyThi(string ma);

        string ngayThi;
        string nguoiDung;
        public void layNguoiDungHienTai(string value)
        {
            nguoiDung = value;
        }
        public Thi()
        {
            InitializeComponent();

            this.Load += Thi_Load;
            btnVaoThi.Click += BtnVaoThi_Click;

        }

        private void BtnVaoThi_Click(object sender, EventArgs e)
        {

            string maKyThi = dtgKyThi.Rows[dtgKyThi.CurrentCell.RowIndex].Cells["ma"].Value.ToString();
            string maDeThi = dtgKyThi.Rows[dtgKyThi.CurrentCell.RowIndex].Cells["made"].Value.ToString();
           
            //xử lý nhận dữ liệu
            LamBaiTracNghiem lamBaiTracNghiem = new LamBaiTracNghiem();

            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(lamBaiTracNghiem.LayNguoiDungHienTai);
            nguoiDungHienTai(nguoiDung);

            LoaiHinhBaiThi loai = new LoaiHinhBaiThi(lamBaiTracNghiem.ThongTinBaiThiTracNghiem);
            loai(true, maDeThi);

            deMaKyThi nhanMaKyThi = new deMaKyThi(lamBaiTracNghiem.NhanMaKyThi);
            nhanMaKyThi(maKyThi);

            lamBaiTracNghiem.Show();
        }

        private void Thi_Load(object sender, EventArgs e)
        {
            ngayThi = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString("dd/MM/yyyy");
            lbThongBao.Text = "Các môn thi ngày " + ngayThi;

            using (var db = new DoAnDataContext())
            {
                var monThi = db.kyThiChinhThucs
                            .Join(db.kyThis, ktct => ktct.maKyThi, kt => kt.ma, (ktct, kt) => new { ktct, kt })
                            .Join(db.monHocs, kt => kt.kt.maMonHoc, mh => mh.ma, (kt, mh) => new { kt, mh })
                            .Join(db.thamGiaKyThis,mt=>mt.kt.kt.ma,tg=>tg.maKyThi,(mt,tg)=>new { mt,tg})
                            .Select(mt => new
                            {
                                MaKyThi = mt.mt.kt.kt.ma,
                                MonHoc = mt.mt.mh.ten,
                                ngayThi = mt.mt.kt.ktct.ngayDienRa.ToString(),
                                DeThi=mt.tg.maDe
                            }).ToList();

                for(int i=0;i<monThi.Count;i++)
                {
                    if (DateTime.Parse(monThi[i].ngayThi).ToString("dd/MM/yyyy") == ngayThi)
                    {
                        dtgKyThi.Rows.Add(monThi[i].MaKyThi, monThi[i].MonHoc,monThi[i].DeThi);
                    }
                }

            }

        }
    }
}
