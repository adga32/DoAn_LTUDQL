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
    public partial class QuanLyKyThiOnTap : Form
    {
        // 1->insert, 0->update
        public delegate void DelegateInsertOrUpdate(int flag);
        public delegate void DelegateMaKyThi(string value);

        string maKyThiNguoiDungChon;

        public QuanLyKyThiOnTap()
        {
            InitializeComponent();

            this.Load += QuanLyKyThiOnTap_Load;

            btnTaoKyThi.Click += BtnTaoKyThi_Click;
            btnCapNhat.Click += BtnCapNhat_Click;
            btnXoa.Click += BtnXoa_Click;

            dtgKyThi.SelectionChanged += DtgKyThi_SelectionChanged;
        }

        private void DtgKyThi_SelectionChanged(object sender, EventArgs e)
        {
            maKyThiNguoiDungChon = dtgKyThi.Rows[dtgKyThi.CurrentCell.RowIndex].Cells["MaKyThi"].Value.ToString();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (maKyThiNguoiDungChon != null)
            {
                string message = "Bạn có muốn xóa kỳ thi này?";
                string title = "Quản lý kỳ thi ôn tập";
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

                        var lichThiChon1 = db.kyThiThus.Single(ktct => ktct.maKyThi == maKyThiNguoiDungChon);
                        db.kyThiThus.DeleteOnSubmit(lichThiChon1);

                        var dsThamGia = db.thamGiaKyThis.Where(tg => tg.maKyThi == maKyThiNguoiDungChon).ToList();
                        db.thamGiaKyThis.DeleteAllOnSubmit(dsThamGia);  

                        db.SubmitChanges();
                    }

                    LoadDsLichThiThu();
                    MessageBox.Show("Xóa kỳ thi thành công");
                    return;
                }

            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatKyThiOnTap frmCapNhatKyThi = new CapNhatKyThiOnTap();
            DelegateInsertOrUpdate insertKyThi = new DelegateInsertOrUpdate(frmCapNhatKyThi.UpdateOrInsert);
            insertKyThi(0);

            DelegateMaKyThi maKyThi = new DelegateMaKyThi(frmCapNhatKyThi.nhanMaKyThi);
            maKyThi(maKyThiNguoiDungChon);

            frmCapNhatKyThi.ShowDialog();
        }

        private void BtnTaoKyThi_Click(object sender, EventArgs e)
        {
            CapNhatKyThiOnTap frmCapNhatOnTap = new CapNhatKyThiOnTap();
            frmCapNhatOnTap.ShowDialog();
            this.Close();
        }

        private void LoadDsLichThiThu()
        {
            using (var db = new DoAnDataContext())
            {
                var kyThiThu = db.kyThiThus
                            .Join(db.kyThis, ktt => ktt.maKyThi, kt => kt.ma, (ktt, kt) => new { ktt, kt })
                            .Join(db.monHocs, kt => kt.kt.maMonHoc, mh => mh.ma, (kt, mh) => new { kt, mh })
                            .Select(kt => new
                            {
                                MaKyThi = kt.kt.kt.ma,
                                MonHoc = kt.mh.ten,
                                NgayGioiHan = DateTime.Parse(kt.kt.ktt.ngayGioiHan.ToString()).ToString("MM/dd/yyyy")

                            });


                dtgKyThi.DataSource = kyThiThu;
            }
        }
        private void QuanLyKyThiOnTap_Load(object sender, EventArgs e)
        {
            LoadDsLichThiThu();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
