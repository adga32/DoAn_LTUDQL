using DoAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn
{
    public partial class GiaoVien : MetroFramework.Forms.MetroForm
    {
        Button[] arrBtn;

        string nguoidunghientai;

        public void LayNguoiDungHienTai(TextBox txtTenTaiKhoan)
        {
            nguoidunghientai = txtTenTaiKhoan.Text;
        }

        public delegate void NguoiDungHienTai(string value);

        public GiaoVien()
        {
            InitializeComponent();

            arrBtn = new Button[] { btnDongGopCauHoi, btnQuanLyCauHoi, btnQuanLyDeThi, btnQuanLyKyThi, btnQuanLyKyThiThu, btnQuanLyHocSinh };

            this.Load += GiaoVien_Load;
            btnLuuThongTin.Click += BtnLuuThongTin_Click;
        }

        private void BtnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DoAnDataContext())
                {
                    var giaoVien = db.giaoViens
                        .Join(db.taiKhoans, gv => gv.ma, tk => tk.idNguoiSoHuu, (gv, tk) => new { gv, tk })
                        .Single(gv => gv.tk.username == nguoidunghientai);

                    giaoVien.gv.ten = tbname.Text;
                    giaoVien.gv.ngaySinh = dtpNs.Value;

                    db.SubmitChanges();

                    MessageBox.Show("Lưu thông tin thành công");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void loadThongTinCaNhan()
        {
            try
            {
                using (var db = new DoAnDataContext())
                {
                    var giaoVien = db.taiKhoans.Where(tk => tk.username == nguoidunghientai)
                                .Join(db.giaoViens, tk => tk.idNguoiSoHuu, gv => gv.ma, (tk, gv) => new { tk, gv })
                                .FirstOrDefault();

                    lblMa.Text = "Mã giáo viên: " + giaoVien.gv.ma;
                    tbname.Text = giaoVien.gv.ten;
                    dtpNs.Value = DateTime.Parse(giaoVien.gv.ngaySinh.ToString());

                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            bool[] arrChucNang = new bool[20]; // mảng chứa vị tri các chức năng tương ứng

            using (var db = new DoAnDataContext())
            {
                var IDGiaoVien = db.taiKhoans.Where(tk => tk.username == nguoidunghientai)
                               .Select(tk => tk.idNguoiSoHuu).FirstOrDefault();

                var maPhanQuyenCuaGV = db.PhanQuyenChucNangs.Where(pq => pq.maNguoiDung == IDGiaoVien)
                                .Select(pq => pq.quyenSuDung).FirstOrDefault();

                //đọc dữ liệu từ mã phân quyền
                string[] arrPhanQuyen = maPhanQuyenCuaGV.Split('-');

                //gán dữ liệu true/false tương ứng vào mảng arrChucNang
                for (int count1 = 0; count1 < arrPhanQuyen.Count(); count1++)
                {
                    int index;
                    if (int.TryParse(arrPhanQuyen[count1], out index))
                    {
                        arrChucNang[(index - 1)] = true;
                    }

                }

                //thiết lập các button với các chức năng tương ứng
                if (arrChucNang[0] == false)
                {
                    btnDongGopCauHoi.Enabled = false;
                }
                for (int count2 = 1; count2 < arrBtn.Count(); count2++)
                {
                    arrBtn[count2].Enabled = arrChucNang[count2];
                }
            }
        }

        private void btnQuanLyCauHoi_Click(object sender, EventArgs e)
        {
            LayCauHoiTuExcel FormlayCauHoiTuExcel = new LayCauHoiTuExcel();
            FormlayCauHoiTuExcel.Show();
        }

        private void btnQuanLyKyThi_Click(object sender, EventArgs e)
        {
            QuanLyKyThi frmQuanLyKyThi = new QuanLyKyThi();
            frmQuanLyKyThi.Show();
        }

        private void btnQuanLyKyThiThu_Click(object sender, EventArgs e)
        {
            QuanLyKyThiOnTap frmQuanLyKyThiThu = new QuanLyKyThiOnTap();
            frmQuanLyKyThiThu.Show();
        }

        private void btnDongGopCauHoi_Click(object sender, EventArgs e)
        {
            DongGopCauHoi frmDongGopCauHoi = new DongGopCauHoi();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(frmDongGopCauHoi.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);
            frmDongGopCauHoi.Show();
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            ThongKe frmThongKe = new ThongKe();
            frmThongKe.Show();

        }

        private void btnQuanLyDeThi_Click(object sender, EventArgs e)
        {
            QuanLyDeThi frmQuanLyDeThi = new QuanLyDeThi();
            frmQuanLyDeThi.Show();
        }

    }
}
