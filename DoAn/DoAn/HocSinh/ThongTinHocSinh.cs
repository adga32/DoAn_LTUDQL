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
    public partial class ThongTinHocSinh : Form
    {
        string ID_hocSinh;

        //nhận thông tin nguoi dung từ form hoc sinh 
        public void LayNguoiDungHienTai(string userName)
        {
            using (var db = new DoAnDataContext())
            {
                ID_hocSinh = db.taiKhoans.Where(tk=>tk.username==userName).Select(tk=>tk.idNguoiSoHuu).Single();
            }
               
        }

        public ThongTinHocSinh()
        {
            InitializeComponent();

            this.Load += ThongTinHocSinh_Load;
            btnSave.Click += BtnSave_Click;
        }

        private void ThongTinHocSinh_Load(object sender, EventArgs e)
        {
            loadThongTinCaNhan();
            loadLichThi();
            loadKetQuaCacBaiThi();
        }

        //lưu thông tin cá nhân xuống database
        private void BtnSave_Click(object sender, EventArgs e)
        {

            var tenHocSinh = tbName.Text;
            var dob = dtPBirthday.Value;
            var lop = cbClass.SelectedValue.ToString();

            // update thông tin cá nhân 
            using (var db = new DoAnDataContext())
            {
                hocSinh hs = db.hocSinhs.Single(h => h.ma == ID_hocSinh);

                hs.ten = tenHocSinh;
                hs.ngaySinh = dob;
                hs.maLop = lop;

                db.SubmitChanges();
                MessageBox.Show("Lưu thông tin thành công");
            }

        }

        private void loadThongTinCaNhan()
        {
            lblMSSV.Text = "Mã số sinh viên: " + ID_hocSinh;

            using (var db = new DoAnDataContext())
            {
                //lamda syntax
                var HocSinh = db.hocSinhs.Where(h => h.ma == ID_hocSinh).Single();

                var lop = db.lops.ToList();
                cbClass.DataSource = lop;
                cbClass.ValueMember = "ma";
                cbClass.DisplayMember = "ma";

                cbClass.SelectedValue = HocSinh.maLop;

                try
                {
                    tbName.Text = HocSinh.ten;
                    cbClass.SelectedValue = HocSinh.maLop;
                    dtPBirthday.Value = DateTime.Parse(HocSinh.ngaySinh.ToString());

                }
                catch { };

            }
        }


        private void loadLichThi()
        {
            using (var db = new DoAnDataContext())
            {
                try
                {
                    var lichThi = db.thamGiaKyThis
                        .Where(tg => tg.maHs == ID_hocSinh)
                        .Join(db.kyThis, tg => tg.maKyThi, kt => kt.ma, (tg, kt) => new { tg, kt })
                        .Join(db.kyThiChinhThucs, kt => kt.kt.ma, ktct => ktct.maKyThi, (kt, ktct) => new { kt, ktct })
                        .Select(lt => new
                        {
                            MaKyThi = lt.kt.kt.ma,
                            NgayThi = lt.ktct.ngayDienRa,
                            MonHoc = lt.kt.kt.monHoc
                        });

                    dtgDSLichThi.DataSource = lichThi;
                }
                catch { }
            }
        }

        private void loadKetQuaCacBaiThi()
        {
            using (var db = new DoAnDataContext())
            {
                try
                {
                    var ketQua = db.ketQuas
                         .Where(kq => kq.maHs == ID_hocSinh)
                         .Join(db.kyThis, kq => kq.maKythi, kt => kt.ma, (kq, kt) => new { kt, kq })
                         .Select(kqhs => new
                         {
                             MaKyThi = kqhs.kt.ma,
                             MonHoc=kqhs.kt.monHoc,
                             MaDe=kqhs.kq.maDe,
                             Diem=kqhs.kq.diem,
                         });

                    dtgKetQua.DataSource = ketQua;
                }
                catch { }
            }
        }
    }
}
