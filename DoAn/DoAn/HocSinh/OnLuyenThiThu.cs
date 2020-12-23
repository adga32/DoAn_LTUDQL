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
    public partial class OnLuyenThiThu : Form
    {
        public delegate void NguoiDungHienTai(string userName);

        //delegate mục đích truyền dấu hiệu nhận biết là thi thật hay luyện tập tới form Làm bài trắc nghiệm 
        public delegate void LoaiHinhBaiThi(bool loaiBaiThi,string maDeThi);
     
        //biến này tạm thời sử dụng để biết ai đang thi thử
        string nguoiDungHienTai;

        public void LayNguoiDungHienTai(string value)
        {
            nguoiDungHienTai = value;
        }


        public OnLuyenThiThu()
        {
            InitializeComponent();

            this.Load += OnLuyenThiThu_Load;
            dtgDeThi.SelectionChanged += DtgDeThi_SelectionChanged;
            btnTest.Click += BtnTest_Click;
        }

        private void OnLuyenThiThu_Load(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                var ListDeThi = db.deThis
                                .Join(db.monHocs, dt => dt.monHoc, mh => mh.ma, (dt, mh) => new { dt, mh })
                                .Select(dt => new
                                {
                                    maDe = dt.dt.ma,
                                    monHoc = dt.mh.ten,
                                    soLuongCauHoi = dt.dt.slCauHoi,
                                    thoiGianLamBai = dt.dt.thoiGianLamBai_phut
                                });

                dtgDeThi.DataSource = ListDeThi;

            }

        }
    

        private void DtgDeThi_SelectionChanged(object sender, EventArgs e)
        {
            string maDeThi = dtgDeThi.Rows[dtgDeThi.CurrentCell.RowIndex].Cells["maDe"].Value.ToString();

            using (var db = new DoAnDataContext())
            {
                var ListCauHoi = db.chiTietDethis.Where(dt => dt.maDethi == maDeThi)
                                .Join(db.cauHois, dt => dt.maCauHoi, ch => ch.ma, (dt, ch) => new { dt, ch })
                                .Select(listch => new
                                {
                                    maCauHoi=listch.ch.ma,
                                    noiDungCauHoi=listch.ch.noiDung,
                                    GoiY=listch.ch.goiY
                                }).ToList();

                dtgDapAn.Columns.Clear();
                dtgDapAn.DataSource = ListCauHoi;

            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            LamBaiTracNghiem lamBaiTracNghiem = new LamBaiTracNghiem();

            NguoiDungHienTai delegate_NguoiDungHienTai = new NguoiDungHienTai(lamBaiTracNghiem.LayNguoiDungHienTai);
            delegate_NguoiDungHienTai(nguoiDungHienTai);

            LoaiHinhBaiThi loai = new LoaiHinhBaiThi(lamBaiTracNghiem.ThongTinBaiThiTracNghiem);

            //lấy mã đề người dùng chọn
            string maDeThi = dtgDeThi.Rows[dtgDeThi.CurrentCell.RowIndex].Cells["maDe"].Value.ToString();
            loai(false, maDeThi); // thi thử

            lamBaiTracNghiem.ShowDialog();
           
        }

    }
}
