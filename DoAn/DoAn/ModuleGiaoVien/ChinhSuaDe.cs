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
    public partial class ChinhSuaDe : Form
    {
        string MACAUHOIDANGCHON;
        string MAMONCUADEDANGCHON;
        string MACAUHOICUADEDANGCHON;

        public ChinhSuaDe()
        {
            InitializeComponent();
        }

        private void ChinhSuaDe_Load(object sender, EventArgs e)
        {
            //LOAD DATA CHO Chỉnh sửa đề
            using (var db = new DoAnDataContext())
            {
                cbbMaDe.DataSource = db.deThis.Select(i => i.ma.Substring(3));
                cbbMaDe.DisplayMember = "ma";

            }
        }

        private void cbbMaDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoLuongCauHoi.Text = "";
            txtThoiGianLamBai.Text = "";
            using (var db = new DoAnDataContext())
            {
                //load cbb Mon hoc
                var dethi = (from i in db.deThis
                                           join j in db.monHocs on i.maMonHoc equals j.ma
                                           where i.ma.Substring(3, 3).ToString() == cbbMaDe.SelectedValue.ToString()
                                           select new { j.ten,j.ma, khoi = i.ma.Substring(1,2), i.thoiGianLamBai_phut, i.slCauHoi }).Single();
                txtMonHoc.Text = dethi.ten;
                txtKhoi.Text = dethi.khoi;
                txtThoiGianLamBai.Text = dethi.thoiGianLamBai_phut.ToString();
                txtSoLuongCauHoi.Text = dethi.slCauHoi.ToString();
                MAMONCUADEDANGCHON = dethi.ma;

                //Load data cho dgvdanhsachcauhoi

                LOADDATACHODANHSACHCAUHOI();
                LOADDATACHODANHSACHCAUHOICUADE();
            }
        }

        private void LOADDATACHODANHSACHCAUHOI()
        {
            using (var db = new DoAnDataContext())
            {
                var CauHoi = (from i in db.cauHois
                              join j in db.dapAnCauhois
                              on i.ma equals j.maCauHoi
                              select new
                              {
                                  Ma = i.ma,
                                  NoiDung = i.noiDung,
                                  DapAn = j.dapAn,
                                  GoiY = i.goiY,
                                  MaMon = i.maMonHoc,
                                  MaKhoi = i.makhoi,
                                  LOAICAUHOI = i.loaiCauHoi,
                                  LADAPANCAUHOI = j.laDapAnDung
                              } into GroupDSCHLT
                              where GroupDSCHLT.LOAICAUHOI == "THI" && GroupDSCHLT.MaMon == MAMONCUADEDANGCHON && GroupDSCHLT.MaKhoi == "K"+ txtKhoi.Text
                              group new { GroupDSCHLT.DapAn, GroupDSCHLT.LADAPANCAUHOI } by new { GroupDSCHLT.Ma, GroupDSCHLT.NoiDung, GroupDSCHLT.GoiY, GroupDSCHLT.MaMon, GroupDSCHLT.MaKhoi } into DSCAUHOI
                              select new
                              {
                                  MACAUHOI = DSCAUHOI.Key.Ma,
                                  NOIDUNGCAUHOI = DSCAUHOI.Key.NoiDung,
                                  DAPANCUACAUHOI1 = DSCAUHOI.Take(1).First().DapAn,
                                  DAPANCUACAUHOI2 = DSCAUHOI.Skip(1).Take(1).First().DapAn,
                                  DAPANCUACAUHOI3 = DSCAUHOI.Skip(2).Take(1).First().DapAn,
                                  DAPANCUACAUHOI4 = DSCAUHOI.Skip(3).Take(1).First().DapAn,
                                  DAPANCUACAUHOI5 = DSCAUHOI.Skip(4).Take(1).First().DapAn,
                                  DAPANCUACAUHOI6 = DSCAUHOI.Skip(5).Take(1).First().DapAn,
                                  GOIY = DSCAUHOI.Key.GoiY,
                                  MaMon = DSCAUHOI.Key.MaMon,
                                  MaKhoi = DSCAUHOI.Key.MaKhoi,
                                  LADAPANCAUA = DSCAUHOI.Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUB = DSCAUHOI.Skip(1).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUC = DSCAUHOI.Skip(2).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUD = DSCAUHOI.Skip(3).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUE = DSCAUHOI.Skip(4).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUF = DSCAUHOI.Skip(5).Take(1).First().LADAPANCAUHOI
                              }).ToList();

                //gán dữ liệu cho datagridview danhsachcauhoi
                dgvDanhSachCauHoi.DataSource = CauHoi;
                dgvDanhSachCauHoi.ClearSelection();
;            }
        }


        private void LOADDATACHODANHSACHCAUHOICUADE()
        {

            using (var db = new DoAnDataContext())
            {
                var CauHoi = (from i in db.cauHois
                              join j in db.dapAnCauhois
                              on i.ma equals j.maCauHoi
                              join k in db.chiTietDethis
                              on j.maCauHoi equals k.maCauHoi
                              select new
                              {
                                  Ma = i.ma,
                                  NoiDung = i.noiDung,
                                  DapAn = j.dapAn,
                                  GoiY = i.goiY,
                                  MaMon = i.maMonHoc,
                                  MaKhoi = i.makhoi,
                                  LOAICAUHOI = i.loaiCauHoi,
                                  LADAPANCAUHOI = j.laDapAnDung,
                                  MADE = k.maDethi
                              } into GroupDSCHLT
                              where GroupDSCHLT.MADE == "K" + txtKhoi.Text + cbbMaDe.SelectedValue.ToString()
                              group new { GroupDSCHLT.DapAn, GroupDSCHLT.LADAPANCAUHOI } by new { GroupDSCHLT.Ma, GroupDSCHLT.NoiDung, GroupDSCHLT.GoiY, GroupDSCHLT.MaMon, GroupDSCHLT.MaKhoi } into DSCAUHOI
                              select new
                              {
                                  MACAUHOICUADE = DSCAUHOI.Key.Ma,
                                  NOIDUNGCAUHOI = DSCAUHOI.Key.NoiDung,
                                  DAPANCUACAUHOI1 = DSCAUHOI.Take(1).First().DapAn,
                                  DAPANCUACAUHOI2 = DSCAUHOI.Skip(1).Take(1).First().DapAn,
                                  DAPANCUACAUHOI3 = DSCAUHOI.Skip(2).Take(1).First().DapAn,
                                  DAPANCUACAUHOI4 = DSCAUHOI.Skip(3).Take(1).First().DapAn,
                                  DAPANCUACAUHOI5 = DSCAUHOI.Skip(4).Take(1).First().DapAn,
                                  DAPANCUACAUHOI6 = DSCAUHOI.Skip(5).Take(1).First().DapAn,
                                  GOIY = DSCAUHOI.Key.GoiY,
                                  MaMon = DSCAUHOI.Key.MaMon,
                                  MaKhoi = DSCAUHOI.Key.MaKhoi,
                                  LADAPANCAUA = DSCAUHOI.Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUB = DSCAUHOI.Skip(1).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUC = DSCAUHOI.Skip(2).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUD = DSCAUHOI.Skip(3).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUE = DSCAUHOI.Skip(4).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUF = DSCAUHOI.Skip(5).Take(1).First().LADAPANCAUHOI
                              }).ToList();


                //gán dữ liệu cho datagridview danhsachcauhoi
                dgvDanhSachCauHoiCuaDe.DataSource = CauHoi;
                dgvDanhSachCauHoiCuaDe.ClearSelection();
            }
        }

        private void btnXoaCauHoi_Click(object sender, EventArgs e)
        {
            if (cbbMaDe.SelectedValue != null)
            {
                using (var db = new DoAnDataContext())
                {
                    try
                    {
                        var deletecauhoi = (from i in db.chiTietDethis where i.maDethi.Substring(3) == cbbMaDe.SelectedValue.ToString() && i.maCauHoi == MACAUHOICUADEDANGCHON select i).Single();
                        db.chiTietDethis.DeleteOnSubmit(deletecauhoi);
                        db.SubmitChanges();
                        LOADDATACHODANHSACHCAUHOICUADE();
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng chọn câu hỏi cần xóa bên phải");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đề");
            }
        }

        private void btnXoaDe_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DoAnDataContext())
                {
                    //Lấy list cau hỏi để xóa
                    var listDelete = (from i in db.chiTietDethis where i.maDethi.Substring(3) == cbbMaDe.SelectedValue.ToString() select i).ToList();
                    db.chiTietDethis.DeleteAllOnSubmit(listDelete);


                    //Xóa đề
                    var deletedethi = (from i in db.deThis where i.ma.Substring(3) == cbbMaDe.SelectedValue.ToString() select i).Single();
                    db.deThis.DeleteOnSubmit(deletedethi);
                    MessageBox.Show("Bạn có chắc muốn xóa đề");
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                }
                txtKhoi.ResetText();
                txtMonHoc.ResetText();
                txtSoLuongCauHoi.ResetText();
                txtThoiGianLamBai.ResetText();
                LOADDATACHODANHSACHCAUHOI();
                LOADDATACHODANHSACHCAUHOICUADE();
                //LOAD DATA CHO Chỉnh sửa đề
                using (var db = new DoAnDataContext())
                {
                    cbbMaDe.DataSource = db.deThis.Select(i => i.ma.Substring(3));
                    cbbMaDe.DisplayMember = "ma";

                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn đề cần xóa");
            }
        }

        private void btnLuuDe_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DoAnDataContext())
                {
                    var listcauhoi = (from i in db.deThis where i.ma.Substring(3) == cbbMaDe.SelectedValue.ToString() select i);
                    foreach (deThi dethi in listcauhoi)
                    {
                        dethi.slCauHoi = int.Parse(txtSoLuongCauHoi.Text);
                        dethi.thoiGianLamBai_phut = int.Parse(txtThoiGianLamBai.Text);
                    }
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công");
                }
                //LOAD DATA CHO Chỉnh sửa đề
                using (var db = new DoAnDataContext())
                {
                    cbbMaDe.DataSource = db.deThis.Select(i => i.ma.Substring(3));
                    cbbMaDe.DisplayMember = "ma";

                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn đề cần lưu");
            }
        }

        private void dgvDanhSachCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            { 
                DataGridViewRow row = this.dgvDanhSachCauHoi.Rows[e.RowIndex];
                MACAUHOIDANGCHON = row.Cells["MACAUHOI"].Value.ToString();
            }
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                if (cbbMaDe.SelectedValue != null)
                {
                    if (MACAUHOIDANGCHON != null)
                    {
                        if (db.chiTietDethis.Where(x => x.maDethi == "K" + txtKhoi.Text + cbbMaDe.SelectedValue.ToString()).Select(i => i).Count() < int.Parse(txtSoLuongCauHoi.Text))
                        {
                            try
                            {
                                db.chiTietDethis.InsertOnSubmit(new chiTietDethi
                                {
                                    maDethi = "K" + txtKhoi.Text + cbbMaDe.SelectedValue.ToString(),
                                    maCauHoi = MACAUHOIDANGCHON,
                                    diem = (10.0 / int.Parse(txtSoLuongCauHoi.Text))
                                });
                                db.SubmitChanges();
                                MessageBox.Show("Thêm thành công");
                            }
                            catch
                            {
                                MessageBox.Show("Câu hỏi đã được thêm trước đó");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số lượng câu hỏi đã đủ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn câu hỏi cần thêm bên trái");
                    }
                    LOADDATACHODANHSACHCAUHOICUADE();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đề");
                } 
            }
        }

        private void dgvDanhSachCauHoiCuaDe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDanhSachCauHoiCuaDe.Rows[e.RowIndex];
                MACAUHOICUADEDANGCHON = row.Cells["MACAUHOICUADE"].Value.ToString();
            }
        }
    }
}
