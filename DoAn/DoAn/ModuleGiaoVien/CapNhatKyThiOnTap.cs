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
    public partial class CapNhatKyThiOnTap : Form
    {
        string maKhoiGVChon;
        string maMonHocGVChon;

        //delegate
        // 1 -> insert, 0 -> update
        int updateOrInsert = 1;
        string maKyThiCapNhat = null; //sử dụng cho khi form đang thực hiện cập nhật kỳ thi

        public void UpdateOrInsert(int value)
        {
            updateOrInsert = value;
        }

        public void nhanMaKyThi(string value)
        {
            maKyThiCapNhat = value;
        }


        public CapNhatKyThiOnTap()
        {
            InitializeComponent();

            this.Load += CapNhatKyThiOnTap_Load;

            cbKhoi.SelectedIndexChanged += CbKhoi_SelectedIndexChanged;
            cbMonHoc.SelectedIndexChanged += CbMonHoc_SelectedIndexChanged;

            btnLuuKyThi.Click += BtnLuuKyThi_Click;
        }

        private void BtnLuuKyThi_Click(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                if (updateOrInsert == 0) // update
                {
                    // xóa danh sách học sinh tham gia cũ và thêm danh sách học sinh mới
                    var hsThamGia = db.thamGiaKyThis.Where(tg => tg.maKyThi == maKyThiCapNhat).ToList();
                    db.thamGiaKyThis.DeleteAllOnSubmit(hsThamGia);

                    //lưu thông tin danh sách học sinh kỳ thi 
                    for (int i = 0; i < dtgHocSinh.Rows.Count; i++)
                    {
                        //kiểm tra nếu chọn học sinh cho kỳ thi
                        var chk = (bool)dtgHocSinh.Rows[i].Cells[0].Value;
                        if (chk == true)
                        {
                            db.thamGiaKyThis.InsertOnSubmit(new thamGiaKyThi
                            {
                                maHs = dtgHocSinh.Rows[i].Cells[1].Value.ToString(),
                                maKyThi = maKyThiCapNhat,
                                //thi thử sẽ tự do chọn đề
                            });
                        }
                    }

                    db.SubmitChanges();


                    MessageBox.Show("Cập nhật kỳ thi thành công", "Quản lý kỳ thi");
                    return;

                }

                else
                {
                    int numKyThi = db.kyThis.Count();
                    string maKyThiMoi = "KT000" + (numKyThi + 1).ToString();
                    db.kyThis.InsertOnSubmit(new kyThi
                    {
                        ma = maKyThiMoi,
                        maMonHoc = cbMonHoc.SelectedValue.ToString()

                    });
                    db.kyThiThus.InsertOnSubmit(new kyThiThu
                    {
                        maKyThi = maKyThiMoi,
                        ngayGioiHan = dtpNgayThi.Value
                    });

                    //lưu thông tin danh sách học sinh kỳ thi 
                    for (int i = 0; i < dtgHocSinh.Rows.Count; i++)
                    {
                        //kiểm tra nếu chọn học sinh cho kỳ thi
                        var chk = (bool)dtgHocSinh.Rows[i].Cells[0].Value;
                        if (chk == true)
                        {
                            db.thamGiaKyThis.InsertOnSubmit(new thamGiaKyThi
                            {
                                maHs = dtgHocSinh.Rows[i].Cells[1].Value.ToString(),
                                maKyThi = maKyThiMoi,
                               // thi thử sẽ tự do chọn đề
                            });

                        }
                    }

                    db.SubmitChanges();


                    MessageBox.Show("Thêm kỳ thi thành công", "Quản lý kỳ thi");
                    return;
                }

            }

        }

        private void CbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMonHocGVChon = cbMonHoc.SelectedValue.ToString();
            loadDataDeThi();
        }

        private void CbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKhoiGVChon = cbKhoi.SelectedValue.ToString();
            loadDataHocSinh();
            loadDataDeThi();
        }

        //load dữ liệu tương ứng lên data gird view học sinh và đề thi
        private void loadDataDeThi()
        {
            using (var db = new DoAnDataContext())
            {
                var deThi = db.deThis
                    .Where(dt => dt.maMonHoc == maMonHocGVChon)
                    .Join(db.chiTietDethis, dt => dt.ma, ctdt => ctdt.maDethi, (dt, ctdt) => new { dt, ctdt })
                    .Join(db.cauHois, dt => dt.ctdt.maCauHoi, ch => ch.ma, (dt, ch) => new { dt, ch })
                    .Where(ch => ch.ch.makhoi == maKhoiGVChon)
                    .Select(dt => new
                    {
                        MaDeThi = dt.dt.dt.ma,
                        SoLuongCauHoi = dt.dt.dt.slCauHoi,
                        ThoiGianLamBai = dt.dt.dt.thoiGianLamBai_phut

                    }).ToList();

                dtgDeThi.DataSource = deThi;
            }
        }

        private void loadDataHocSinh()
        {
            dtgHocSinh.Columns.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.Name = "chon";
            col1.HeaderText = "Chọn học sinh";
            col1.Width = 100;
            dtgHocSinh.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "masv";
            col2.HeaderText = "Mã học sinh";
            col2.Width = 100;
            col2.ReadOnly = true;
            dtgHocSinh.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "hoten";
            col3.HeaderText = "Họ tên";
            col3.Width = 120;
            col3.ReadOnly = true;
            dtgHocSinh.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "ngaysinh";
            col4.HeaderText = "Ngày sinh";
            col4.Width = 100;
            col4.ReadOnly = true;
            dtgHocSinh.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "lop";
            col5.HeaderText = "Lớp";
            col5.Width = 80;
            col5.ReadOnly = true;
            dtgHocSinh.Columns.Add(col5);

            using (var db = new DoAnDataContext())
            {
                if (updateOrInsert == 0) // cập nhật kỳ thi
                {
                    // hiển thị danh sách thí sinh và những hs không trong kỳ thi
                    var dtHocSinhTgKyThi = db.hocSinhs
                              .Join(db.thamGiaKyThis, hs => hs.ma, tg => tg.maHs, (hs, tg) => new { hs, tg })
                              .Where(tg => tg.tg.maKyThi == maKyThiCapNhat)
                              .Select(hs => hs.hs).ToList();

                    var dtHocSinh = db.hocSinhs.ToList();
                    var dtHocSinhKhongTgKyThi = dtHocSinh.Except(dtHocSinhTgKyThi).ToList();

                    for (int i = 0; i < dtHocSinhTgKyThi.Count; i++)
                    {
                        string ngaySinh = null;
                        if (dtHocSinh[i].ngaySinh != null)
                        {
                            ngaySinh = DateTime.Parse(dtHocSinhTgKyThi[i].ngaySinh.ToString()).ToString("MM/dd/yyyy");
                        }
                        dtgHocSinh.Rows.Add(true, dtHocSinhTgKyThi[i].ma, dtHocSinhTgKyThi[i].ten, ngaySinh, dtHocSinhTgKyThi[i].maLop);
                    }

                    for (int i = 0; i < dtHocSinhKhongTgKyThi.Count; i++)
                    {
                        string ngaySinh = null;
                        if (dtHocSinh[i].ngaySinh != null)
                        {
                            ngaySinh = DateTime.Parse(dtHocSinhKhongTgKyThi[i].ngaySinh.ToString()).ToString("MM/dd/yyyy");
                        }
                        dtgHocSinh.Rows.Add(false, dtHocSinhKhongTgKyThi[i].ma, dtHocSinhKhongTgKyThi[i].ten, ngaySinh, dtHocSinhKhongTgKyThi[i].maLop);
                    }

                }

                else //thêm kỳ thi mới
                {
                    var dtHocSinh = db.hocSinhs
                                     .Join(db.lops, hs => hs.maLop, l => l.ma, (hs, l) => new { hs, l })
                                     .Where(hsl => hsl.l.makhoi == maKhoiGVChon).ToList();

                    for (int i = 0; i < dtHocSinh.Count; i++)
                    {
                        string ngaySinh = null;
                        if (dtHocSinh[i].hs.ngaySinh != null)
                        {
                            ngaySinh = DateTime.Parse(dtHocSinh[i].hs.ngaySinh.ToString()).ToString("MM/dd/yyyy");
                        }
                        dtgHocSinh.Rows.Add(false, dtHocSinh[i].hs.ma.ToString(), dtHocSinh[i].hs.ten, ngaySinh, dtHocSinh[i].hs.maLop);
                    }


                }

            }
        }

        private void CapNhatKyThiOnTap_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DoAnDataContext())
                {
                    var DSMonHoc = db.monHocs.ToList();
                    var DSKhoi = db.khois.ToList();

                    //load khối lớp
                    cbKhoi.DataSource = DSKhoi;
                    cbKhoi.ValueMember = "ma";
                    cbKhoi.DisplayMember = "ten";


                    //load môn học
                    cbMonHoc.DataSource = DSMonHoc;
                    cbMonHoc.ValueMember = "ma";
                    cbMonHoc.DisplayMember = "ten";

                    //kiểm tra nếu đang cập nhật
                    if (updateOrInsert == 0)
                    {
                        var kyThi = db.kyThiThus
                                    .Where(kt => kt.maKyThi == maKyThiCapNhat)
                                    .Join(db.kyThis, ktt => ktt.maKyThi, kt => kt.ma, (ktt, kt) => new { ktt, kt })
                                    .Join(db.monHocs, kt => kt.kt.maMonHoc, mh => mh.ma, (kt, mh) => new { kt, mh })
                                    .Select(kt => new
                                    {
                                        NgayGioiHan = kt.kt.ktt.ngayGioiHan,
                                        monThi = kt.mh.ten
                                    }).FirstOrDefault();

                        var khoiThi = db.thamGiaKyThis
                            .Where(tg => tg.maKyThi == maKyThiCapNhat)
                            .Join(db.hocSinhs, tg => tg.maHs, hs => hs.ma, (tg, hs) => new { tg, hs })
                            .Join(db.lops, hs => hs.hs.maLop, l => l.ma, (hs, l) => new { hs, l })
                            .Join(db.khois, l => l.l.makhoi, k => k.ma, (l, k) => new { l, k })
                            .Select(k => new { tenKhoi = k.k.ten }).FirstOrDefault();

                        dtpNgayThi.Value = DateTime.Parse(kyThi.NgayGioiHan.ToString());

                        if (khoiThi != null)
                        {
                            cbKhoi.Text = khoiThi.tenKhoi.ToString();
                            maKhoiGVChon = cbKhoi.Text;
                        }


                        cbMonHoc.Text = kyThi.monThi.ToString();
                        maMonHocGVChon = cbMonHoc.Text;
                    }
                }

                loadDataHocSinh();
                loadDataDeThi();
            }
            catch { }
           
        }
    }
}
