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
    public partial class CapNhatKyThi : MetroFramework.Forms.MetroForm
    {
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

        DataGridViewComboBoxColumn comboBoxColumnDeThi = new DataGridViewComboBoxColumn();
        string maKhoiGVChon;
        string maMonHocGVChon;



        public CapNhatKyThi()
        {
            InitializeComponent();
            this.Load += CapNhatKyThi_Load;
            cbKhoi.SelectedIndexChanged += CbKhoi_SelectedIndexChanged;
            cbMonHoc.SelectedIndexChanged += CbMonHoc_SelectedIndexChanged;
            btnSubmit.Click += BtnSubmit_Click;

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //lưu thông tin kỳ thi
                using (var db = new DoAnDataContext())
                {
                    if (updateOrInsert == 0) // update
                    {
                        // xóa danh sách học sinh tham gia cũ và thêm danh sách học sinh mới
                        var hsThamGia = db.thamGiaKyThis.Where(tg => tg.maKyThi == maKyThiCapNhat).ToList();
                        db.thamGiaKyThis.DeleteAllOnSubmit(hsThamGia);

                        //lưu thông tin danh sách học sinh kỳ thi 
                        for (int i = 0; i < dtgHocSinhDeThi.Rows.Count; i++)
                        {
                            //kiểm tra nếu chọn học sinh cho kỳ thi
                            var chk = (bool)dtgHocSinhDeThi.Rows[i].Cells[0].Value;
                            if (chk == true)
                            {
                                db.thamGiaKyThis.InsertOnSubmit(new thamGiaKyThi
                                {
                                    maHs = dtgHocSinhDeThi.Rows[i].Cells[1].Value.ToString(),
                                    maKyThi = maKyThiCapNhat,
                                    maDe = dtgHocSinhDeThi.Rows[i].Cells[5].Value.ToString(),
                                });
                            }
                        }

                        db.SubmitChanges();


                        MessageBox.Show("Cập nhật kỳ thi thành công","Quản lý kỳ thi");
                        return;

                    }

                    else //insert
                    {
                        int numKyThi = db.kyThis.Count();
                        string maKyThiMoi = "KT000" + (numKyThi + 1).ToString();
                        db.kyThis.InsertOnSubmit(new kyThi
                        {
                            ma = maKyThiMoi,
                            maMonHoc = cbMonHoc.SelectedValue.ToString()

                        });
                        db.kyThiChinhThucs.InsertOnSubmit(new kyThiChinhThuc
                        {
                            maKyThi = maKyThiMoi,
                            ngayDienRa = dtpNgayThi.Value
                        });

                        //lưu thông tin danh sách học sinh kỳ thi 
                        for (int i = 0; i < dtgHocSinhDeThi.Rows.Count; i++)
                        {
                            //kiểm tra nếu chọn học sinh cho kỳ thi
                            var chk = (bool)dtgHocSinhDeThi.Rows[i].Cells[0].Value;
                            if (chk == true)
                            {
                                db.thamGiaKyThis.InsertOnSubmit(new thamGiaKyThi
                                {
                                    maHs = dtgHocSinhDeThi.Rows[i].Cells[1].Value.ToString(),
                                    maKyThi = maKyThiMoi,
                                    maDe = dtgHocSinhDeThi.Rows[i].Cells[5].Value.ToString(),
                                });

                            }
                        }

                        db.SubmitChanges();


                        MessageBox.Show("Thêm kỳ thi thành công", "Quản lý kỳ thi");
                        return;
                    }

                }
            }
             
            catch (Exception error)
            {
                MessageBox.Show("Bạn chưa chọn đề thi đầy đủ cho học sinh","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void CapNhatKyThi_Load(object sender, EventArgs e)
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


                if (updateOrInsert == 0)
                {
                    var kyThi = db.kyThiChinhThucs
                                .Where(kt => kt.maKyThi == maKyThiCapNhat)
                                .Join(db.kyThis, ktct => ktct.maKyThi, kt => kt.ma, (ktct, kt) => new { ktct, kt })
                                .Join(db.monHocs, kt => kt.kt.maMonHoc, mh => mh.ma, (kt, mh) => new { kt, mh })
                                .Select(kt => new
                                {
                                    ngayThi = kt.kt.ktct.ngayDienRa,
                                    monThi = kt.mh.ten
                                }).FirstOrDefault();

                    var khoiThi = db.thamGiaKyThis
                        .Where(tg => tg.maKyThi == maKyThiCapNhat)
                        .Join(db.hocSinhs, tg => tg.maHs, hs => hs.ma, (tg, hs) => new { tg, hs })
                        .Join(db.lops, hs => hs.hs.maLop, l => l.ma, (hs, l) => new { hs, l })
                        .Join(db.khois, l => l.l.makhoi, k => k.ma, (l, k) => new { l, k })
                        .Select(k => new { tenKhoi = k.k.ten }).FirstOrDefault();

                    dtpNgayThi.Value = DateTime.Parse(kyThi.ngayThi.ToString());

                    if(khoiThi!=null)
                    {
                        cbKhoi.Text = khoiThi.tenKhoi.ToString();
                        maKhoiGVChon = cbKhoi.Text;
                    }
         

                    cbMonHoc.Text = kyThi.monThi.ToString();
                    maMonHocGVChon = cbMonHoc.Text;
                }

            }
        }



        private void CbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMonHocGVChon = cbMonHoc.SelectedValue.ToString();

            initGirdView();
        }

        private void CbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKhoiGVChon = cbKhoi.SelectedValue.ToString();

            initGirdView();
        }

        //khởi tạo gridview
        private void initGirdView()
        {
            dtgHocSinhDeThi.Columns.Clear();

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.Name = "chon";
            col1.HeaderText = "Chọn học sinh";
            col1.Width = 100;
            dtgHocSinhDeThi.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "masv";
            col2.HeaderText = "Mã học sinh";
            col2.Width = 100;
            col2.ReadOnly = true;
            dtgHocSinhDeThi.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "hoten";
            col3.HeaderText = "Họ tên";
            col3.Width = 120;
            col3.ReadOnly = true;
            dtgHocSinhDeThi.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "ngaysinh";
            col4.HeaderText = "Ngày sinh";
            col4.Width = 100;
            col4.ReadOnly = true;
            dtgHocSinhDeThi.Columns.Add(col4);

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "lop";
            col5.HeaderText = "Lớp";
            col5.Width = 80;
            col5.ReadOnly = true;
            dtgHocSinhDeThi.Columns.Add(col5);

            //combobox đề thi
            comboBoxColumnDeThi.Name = "dethi";
            comboBoxColumnDeThi.HeaderText = "Chọn đề thi";
            comboBoxColumnDeThi.Width = 80;

            try
            {
                using (var db = new DoAnDataContext())
                {
                    var deThi = db.deThis
                                .Where(dt => dt.maMonHoc == maMonHocGVChon && dt.ma.Substring(0,3)==maKhoiGVChon)
                                .ToList();

                    comboBoxColumnDeThi.DataSource = deThi;
                    comboBoxColumnDeThi.DisplayMember = "ma";
                    comboBoxColumnDeThi.ValueMember = "ma";
                }
                dtgHocSinhDeThi.Columns.Add(comboBoxColumnDeThi);


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
                            if(dtHocSinh[i].ngaySinh!=null)
                            {
                                ngaySinh = DateTime.Parse(dtHocSinhTgKyThi[i].ngaySinh.ToString()).ToString("MM/dd/yyyy");
                            }
                            dtgHocSinhDeThi.Rows.Add(true, dtHocSinhTgKyThi[i].ma, dtHocSinhTgKyThi[i].ten,ngaySinh , dtHocSinhTgKyThi[i].maLop, null);
                        }

                        for (int i = 0; i < dtHocSinhKhongTgKyThi.Count; i++)
                        {
                            string ngaySinh = null;
                            if (dtHocSinh[i].ngaySinh != null)
                            {
                                ngaySinh = DateTime.Parse(dtHocSinhKhongTgKyThi[i].ngaySinh.ToString()).ToString("MM/dd/yyyy");
                            }

                            dtgHocSinhDeThi.Rows.Add(false, dtHocSinhKhongTgKyThi[i].ma, dtHocSinhKhongTgKyThi[i].ten, ngaySinh, dtHocSinhKhongTgKyThi[i].maLop, null);
                        }

                    }

                    else // thêm kỳ thi mới
                    {
                        var dtHocSinh = db.hocSinhs
                                        .Join(db.lops, hs => hs.maLop, l => l.ma, (hs, l) => new { hs, l })
                                        .Where(hsl => hsl.l.makhoi == maKhoiGVChon).ToList();

                        for (int i = 0; i < dtHocSinh.Count; i++)
                        {
                            string ngaySinh = null;
                            if(dtHocSinh[i].hs.ngaySinh!=null)
                            {
                                ngaySinh = DateTime.Parse(dtHocSinh[i].hs.ngaySinh.ToString()).ToString("MM/dd/yyyy");
                            }
                            dtgHocSinhDeThi.Rows.Add(false, dtHocSinh[i].hs.ma.ToString(), dtHocSinh[i].hs.ten, ngaySinh,dtHocSinh[i].hs.maLop, null);
                        }

                    }

                }
            }
            catch (Exception error){ MessageBox.Show(error.Message); }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
