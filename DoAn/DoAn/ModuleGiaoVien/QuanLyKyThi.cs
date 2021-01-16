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
    public partial class QuanLyKyThi : MetroFramework.Forms.MetroForm
    {
        string maKyThiNguoiDungChon=null;

        // 1->insert, 0->update
        public delegate void DelegateInsertOrUpdate(int flag);
        public delegate void DelegateMaKyThi(string value);

        public QuanLyKyThi()
        {
            InitializeComponent();

            this.Load += QuanLyKyThi_Load;
            dtgKyThi.SelectionChanged += DtgKyThi_SelectionChanged;

            btnTaoKyThiMoi.Click += BtnTaoKyThiMoi_Click;
            btnCapNhatKyThi.Click += BtnCapNhatKyThi_Click;
            btnXoaKyThi.Click += BtnXoaKyThi_Click;

            btnDsThi.Click += BtnDsThi_Click;
            btnBangDiem.Click += BtnBangDiem_Click;
        }

        private void DtgKyThi_SelectionChanged(object sender, EventArgs e)
        {
            maKyThiNguoiDungChon = dtgKyThi.Rows[dtgKyThi.CurrentCell.RowIndex].Cells["ma"].Value.ToString();
        }

        private void BtnCapNhatKyThi_Click(object sender, EventArgs e)
        {
            CapNhatKyThi frmCapNhatKyThi = new CapNhatKyThi();
            DelegateInsertOrUpdate insertKyThi = new DelegateInsertOrUpdate(frmCapNhatKyThi.UpdateOrInsert);
            insertKyThi(0);

            DelegateMaKyThi maKyThi = new DelegateMaKyThi(frmCapNhatKyThi.nhanMaKyThi);
            maKyThi(maKyThiNguoiDungChon);

            frmCapNhatKyThi.Show();
        }

        private void BtnBangDiem_Click(object sender, EventArgs e)
        {
            PrintKetQuaKyThi frmKQKyThi = new PrintKetQuaKyThi();
            DelegateMaKyThi NhanMaKyThi = new DelegateMaKyThi(frmKQKyThi.NhanMaKyThi);
            NhanMaKyThi(maKyThiNguoiDungChon);
            frmKQKyThi.Show();

        }

        private void BtnDsThi_Click(object sender, EventArgs e)
        {
            if(maKyThiNguoiDungChon!=null)
            {
                PrintDanhSachHS frmDsHocSinh = new PrintDanhSachHS();
                DelegateMaKyThi NhanMaKyThi = new DelegateMaKyThi(frmDsHocSinh.NhanMaKyThi);
                NhanMaKyThi(maKyThiNguoiDungChon);
                frmDsHocSinh.Show();
            }
            
        }

        private void BtnXoaKyThi_Click(object sender, EventArgs e)
        {

            if (maKyThiNguoiDungChon != null)
            {
                string message = "Bạn có muốn xóa kỳ thi này?";
                string title = "Quản lý kỳ thi";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    //
                }
                else
                {
                    using (var db = new DoAnDataContext())
                    {
                        var lichThiChon = db.kyThis.Single(kt => kt.ma == maKyThiNguoiDungChon);
                        db.kyThis.DeleteOnSubmit(lichThiChon);

                        var lichThiChon1 = db.kyThiChinhThucs.Single(ktct => ktct.maKyThi == maKyThiNguoiDungChon);
                        db.kyThiChinhThucs.DeleteOnSubmit(lichThiChon1);

                        var dsThamGia = db.thamGiaKyThis.Where(tg => tg.maKyThi == maKyThiNguoiDungChon).ToList();
                        db.thamGiaKyThis.DeleteAllOnSubmit(dsThamGia);

                        db.SubmitChanges();
                    }
                    LoadDsLichThi();

                    MessageBox.Show("Xóa kỳ thi thành công");
                    return;
                }

            }

        }

        private void BtnTaoKyThiMoi_Click(object sender, EventArgs e)
        {
            CapNhatKyThi frmCapNhatKyThi = new CapNhatKyThi();
            DelegateInsertOrUpdate insertKyThi = new DelegateInsertOrUpdate(frmCapNhatKyThi.UpdateOrInsert);
            insertKyThi(1);

            frmCapNhatKyThi.ShowDialog();

        }

        public void LoadDsLichThi()
        {
            dtgKyThi.Columns.Clear();

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "ma";
            col2.HeaderText = "Mã kỳ thi";
            col2.Width = 100;
            col2.ReadOnly = true;
            dtgKyThi.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "ngaythi";
            col3.HeaderText = "Ngày diễn ra";
            col3.Width = 120;
            col3.ReadOnly = true;
            dtgKyThi.Columns.Add(col3);

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "monthi";
            col4.HeaderText = "Môn thi";
            col4.Width = 100;
            col4.ReadOnly = true;
            dtgKyThi.Columns.Add(col4);


            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "slhocSinh";
            col5.HeaderText = "Số lượng học sinh";
            col5.Width = 100;
            col5.ReadOnly = true;
            dtgKyThi.Columns.Add(col5);


            DataGridViewCheckBoxColumn colCheckBox = new DataGridViewCheckBoxColumn();
            colCheckBox.Name = "hoanThanh";
            colCheckBox.HeaderText = "Đã hoàn thành";
            colCheckBox.Width = 80;
            colCheckBox.ReadOnly = true;
            dtgKyThi.Columns.Add(colCheckBox);


            using (var db = new DoAnDataContext())
            {
                var lichThi = db.kyThiChinhThucs
                                  .Join(db.kyThis, ktct => ktct.maKyThi, kt => kt.ma, (ktct, kt) => new { ktct, kt })
                                  .Join(db.monHocs, kt => kt.kt.maMonHoc, mh => mh.ma, (kt, mh) => new { kt, mh })
                                  .Select(lt => new
                                  {
                                      maKyThi = lt.kt.ktct.maKyThi,
                                      ngayThi = lt.kt.ktct.ngayDienRa,
                                      monHoc = lt.mh.ten
                                  }).ToList();



                for (int i = 0; i < lichThi.Count; i++)
                {
                    int soHsThamGia = db.thamGiaKyThis.Where(tg => tg.maKyThi == lichThi[i].maKyThi).Count();
                    bool daDienRa = KiemTraKyThiDaHoanThanhChua(lichThi[i].maKyThi);
                    dtgKyThi.Rows.Add(lichThi[i].maKyThi.ToString(), DateTime.Parse(lichThi[i].ngayThi.ToString()).ToString("MM/dd/yyyy"), lichThi[i].monHoc.ToString(),soHsThamGia, daDienRa);
                }
            }
        }
        private void QuanLyKyThi_Load(object sender, EventArgs e)
        {
            LoadDsLichThi();

        }

        private bool KiemTraKyThiDaHoanThanhChua(string maKyThi)
        {
            try
            {
                using (var db = new DoAnDataContext())
                {
                    var ThamGiaKyThi = db.thamGiaKyThis.Where(tg => tg.maKyThi == maKyThi).ToList();
                    var KetQua = db.ketQuas.Where(kq => kq.maKythi == maKyThi).ToList();
                    if (ThamGiaKyThi.Count <= 0)
                        return false;
                    else
                    {
                        if (ThamGiaKyThi.Count == KetQua.Count)
                            return true;
                        else
                            return false;
                    }
                  
                }
            }
            catch { return false; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
