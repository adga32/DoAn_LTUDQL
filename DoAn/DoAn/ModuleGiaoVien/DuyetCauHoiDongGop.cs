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
    public partial class DuyetCauHoiDongGop : Form
    {

        string maCauHoiHienTai;
        public DuyetCauHoiDongGop()
        {
            InitializeComponent();
        }

        private void DuyetCauHoiDongGop_Load(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                var dsmonhoc = (from i in db.monHocs select i).ToList();
                cbbMonHoc.DataSource = dsmonhoc;
                var dskhoi = (from i in db.khois select i).ToList();
                cbbKhoi.DataSource = dskhoi;

                cbbMonHoc.ValueMember = "ma";
                cbbMonHoc.DisplayMember = "ten";

                cbbKhoi.ValueMember = "ma";
                cbbKhoi.DisplayMember = "ten";
            }
        }

        private void Load_Data()
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
                                  LoaiCauhoi = i.loaiCauHoi,
                                  LADAPANCAUHOI = j.laDapAnDung
                              } into GroupDSCH
                              join a in db.cauHoiLuyentaps
                              on GroupDSCH.Ma equals a.maCauHoi
                              select new
                              {
                                  Ma = GroupDSCH.Ma,
                                  NoiDung = GroupDSCH.NoiDung,
                                  DADUOCDUYET = a.daDuocDuyet,
                                  DapAn = GroupDSCH.DapAn,
                                  GoiY = GroupDSCH.GoiY,
                                  MaMon = GroupDSCH.MaMon,
                                  MaKhoi = GroupDSCH.MaKhoi,
                                  LADAPANCAUHOI = GroupDSCH.LADAPANCAUHOI,
                                  LOAICAUHOI = GroupDSCH.LoaiCauhoi
                              } into GroupDSCHLT
                              where GroupDSCHLT.MaMon == cbbMonHoc.SelectedValue.ToString() && GroupDSCHLT.MaKhoi == cbbKhoi.SelectedValue.ToString() && GroupDSCHLT.LOAICAUHOI == "LUYENTAP"
                              group new { GroupDSCHLT.DapAn, GroupDSCHLT.LADAPANCAUHOI } by new { GroupDSCHLT.Ma, GroupDSCHLT.NoiDung, GroupDSCHLT.DADUOCDUYET, GroupDSCHLT.GoiY, GroupDSCHLT.MaMon, GroupDSCHLT.MaKhoi } into DSCAUHOI
                              select new
                              {
                                  MACAUHOI = DSCAUHOI.Key.Ma,
                                  NOIDUNGCAUHOI = DSCAUHOI.Key.NoiDung,
                                  DADUOCDUYETCHUA = DSCAUHOI.Key.DADUOCDUYET,
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

                //Gắn data source vào data gridview
                dgvDSCauHoi.DataSource = CauHoi;

                //Ẩn mấy cái không cần thiết hiển thị trên data gridview
                dgvDSCauHoi.Columns["MACAUHOI"].Visible = false;
                dgvDSCauHoi.Columns["DADUOCDUYETCHUA"].Visible = false;
                dgvDSCauHoi.Columns["MaMon"].Visible = false;
                dgvDSCauHoi.Columns["MaKhoi"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUA"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUB"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUC"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUD"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUE"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUF"].Visible = false;
                dgvDSCauHoi.Columns["DAPANCUACAUHOI1"].Visible = false;
                dgvDSCauHoi.Columns["DAPANCUACAUHOI2"].Visible = false;
                dgvDSCauHoi.Columns["DAPANCUACAUHOI3"].Visible = false;
                dgvDSCauHoi.Columns["DAPANCUACAUHOI4"].Visible = false;
                dgvDSCauHoi.Columns["DAPANCUACAUHOI5"].Visible = false;
                dgvDSCauHoi.Columns["DAPANCUACAUHOI6"].Visible = false;
                dgvDSCauHoi.Columns["GOIY"].Visible = false;
            }
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedValue != null && cbbKhoi.SelectedValue != null)
            {
                Load_Data();
            }
        }

        private void cbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedValue != null && cbbKhoi.SelectedValue != null)
            {
                Load_Data();
            }
        }

        private void dgvDSCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gán Mấy Đáp án bằng rỗng
            txtNoiDungCauHoi.Text = "";
            ucA.Enabled = true;
            ucB.Enabled = true;
            ucC.Enabled = true;
            ucD.Enabled = true;
            ucE.Enabled = true;
            ucF.Enabled = true;

            //Tắt check của mấy câu đúng để cho sự kiện cell click mới hiển thị đúng ko bị còn check mấy câu của cell click cũ

            ucA.CheckBox = false;
            ucB.CheckBox = false;
            ucC.CheckBox = false;
            ucD.CheckBox = false;
            ucE.CheckBox = false;
            ucF.CheckBox = false;

            // Giống trên gán nội dung = rỗng
            ucA.NoiDung = "";
            ucB.NoiDung = "";
            ucC.NoiDung = "";
            ucD.NoiDung = "";
            ucE.NoiDung = "";
            ucF.NoiDung = "";

            if (e.RowIndex >= 0)
            {
               

                DataGridViewRow row = this.dgvDSCauHoi.Rows[e.RowIndex];
                // gán biến riêng để sử dụng lại cho các thao tác khác
                maCauHoiHienTai = row.Cells["MACAUHOI"].Value.ToString();

                //Gán dữ liệu từ datagrid view vào txtNoiDungCauHoi
                txtNoiDungCauHoi.Text = row.Cells["NOIDUNGCAUHOI"].Value.ToString();

                //Gán dữ liệu từ datagrid view vào txtGoiYCauHoi
                txtGoiYCauHoi.Text = row.Cells["GOIY"].Value.ToString();

                //Gán Nội dung Đáp án vào từ data gridview
                ucA.NoiDung = row.Cells["DAPANCUACAUHOI1"].Value.ToString();
                ucB.NoiDung = row.Cells["DAPANCUACAUHOI2"].Value.ToString();
                ucC.NoiDung = row.Cells["DAPANCUACAUHOI3"].Value.ToString();
                ucD.NoiDung = row.Cells["DAPANCUACAUHOI4"].Value.ToString();

                //Kiểm tra nếu đáp án 5,6 trong datagridview khác rỗng thì mới gán vào check box ko sẽ bị lỗi
                if (string.IsNullOrEmpty(row.Cells["DAPANCUACAUHOI5"].Value as string) != true)
                {
                    ucE.NoiDung = row.Cells["DAPANCUACAUHOI5"].Value.ToString();
                    ucE.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUE"].Value);
                }
                if (string.IsNullOrEmpty(row.Cells["DAPANCUACAUHOI6"].Value as string) != true)
                {
                    ucF.NoiDung = row.Cells["DAPANCUACAUHOI6"].Value.ToString();
                    ucF.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUF"].Value);
                }
                //Gán checkbox xem có check hay chưa vào từ datagrid view
                ucA.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUA"].Value);
                ucB.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUB"].Value);
                ucC.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUC"].Value);
                ucD.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUD"].Value);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            // Update câu hỏi dược duyệt 
            using (var db = new DoAnDataContext())
            {
                cauHoiLuyentap cauHoiLuyentap = db.cauHoiLuyentaps.Single(CH => CH.maCauHoi == maCauHoiHienTai);

                cauHoiLuyentap.daDuocDuyet = 1;
                db.SubmitChanges();
            }

            // Update loại câu hỏi cho câu hỏi
            using (var db = new DoAnDataContext())
            {
                cauHoi cauHoi = db.cauHois.Single(CH => CH.ma == maCauHoiHienTai);

                cauHoi.loaiCauHoi = "THILUYENTAP";
                db.SubmitChanges();
            }

            MessageBox.Show("đã duyệt");
            Load_Data();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            using (DoAnDataContext db = new DoAnDataContext())
            {
                //xoa trong list dapAnCauhois
                var listToRemove = (from a in db.dapAnCauhois
                                    where a.maCauHoi == maCauHoiHienTai
                                    select a).ToList();

                db.dapAnCauhois.DeleteAllOnSubmit(listToRemove);
                db.SubmitChanges();

                //xoa trong list cauHoiLuyentap
                var CauHoiLuyenTapRemove = (from a in db.cauHoiLuyentaps
                                    where a.maCauHoi == maCauHoiHienTai
                                    select a).ToList();
                db.cauHoiLuyentaps.DeleteAllOnSubmit(CauHoiLuyenTapRemove);
                db.SubmitChanges();

                //xoa trong list Cauhois
                var CauHoiRemove = (from a in db.cauHois
                                    where a.ma == maCauHoiHienTai
                                    select a).ToList();
                db.cauHois.DeleteAllOnSubmit(CauHoiRemove);
                db.SubmitChanges();

                MessageBox.Show("đã xóa");
                Load_Data();
            }
        }
    }
}
