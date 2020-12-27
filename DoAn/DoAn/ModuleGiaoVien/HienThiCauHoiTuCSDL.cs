using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn;

namespace DoAn
{
    public partial class HienThiCauHoiTuCSDL : Form
    {

        public string ma;


        public delegate void sendmessage();
        public HienThiCauHoiTuCSDL()
        {
            InitializeComponent();
        }

        private void HienThiCauHoiTuCSDL_Load(object sender, EventArgs e)
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

            loadGVcauHoi();
        }

        public void loadGVcauHoi()
        {
            //using (var db = new DoAnDataContext())
            //{
            //    try
            //    {
            //        var cauHoi = db.cauHois
            //             .Select(dsCH => new
            //             {
            //                 maCauHoi = dsCH.ma,
            //                 noiDung = dsCH.noiDung,
            //                 goiY = dsCH.goiY,
            //                 doKho = dsCH.doKho,
            //                 maMonHoc = dsCH.maMonHoc,
            //                 makhoi = dsCH.makhoi,
            //                 loaiCauHoi = dsCH.loaiCauHoi
            //             });
            //        dataGridView_CauHoi.DataSource = cauHoi;
            //    }
            //    catch (Exception ex)
            //    { MessageBox.Show(ex.ToString()); }
            //}

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
                              where GroupDSCH.MaMon == cbbMonHoc.SelectedValue.ToString() && GroupDSCH.MaKhoi == cbbKhoi.SelectedValue.ToString() &&(GroupDSCH.LoaiCauhoi == "THILUYENTAP" || GroupDSCH.LoaiCauhoi == "THI")
                              group new { GroupDSCH.DapAn, GroupDSCH.LADAPANCAUHOI } by new { GroupDSCH.Ma, GroupDSCH.NoiDung, GroupDSCH.GoiY, GroupDSCH.MaMon, GroupDSCH.MaKhoi } into DSCAUHOI
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

                //Gắn data source vào data gridview
                dgvDSCauHoi.DataSource = CauHoi;

                //Ẩn mấy cái không cần thiết hiển thị trên data gridview
                dgvDSCauHoi.Columns["MACAUHOI"].Visible = false;
                dgvDSCauHoi.Columns["MaMon"].Visible = false;
                dgvDSCauHoi.Columns["MaKhoi"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUA"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUB"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUC"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUD"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUE"].Visible = false;
                dgvDSCauHoi.Columns["LADAPANCAUF"].Visible = false;
            }

        }

        private void button_suaCauhoiSelected_Click(object sender, EventArgs e)
        {
            if (dgvDSCauHoi.CurrentCell.Selected == true)
            {
                SuaChiTietCauHoi form_sua = new SuaChiTietCauHoi(loadGVcauHoi, ma);
                form_sua.Show();
            }
        }

        //private void dataGridView_CauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView_CauHoi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    {
        //        dataGridView_CauHoi.CurrentRow.Selected = true;


        //        ma = dataGridView_CauHoi.Rows[e.RowIndex].Cells["maCauHoi"].FormattedValue.ToString();


        //    }
        //}

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedValue != null && cbbKhoi.SelectedValue != null)
            {
                loadGVcauHoi();
            }
        }

        private void cbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedValue != null && cbbKhoi.SelectedValue != null)
            {
                loadGVcauHoi();
            }
        }

        private void dgvDSCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                dgvDSCauHoi.CurrentRow.Selected = true;
                ma = dgvDSCauHoi.Rows[e.RowIndex].Cells["maCauHoi"].FormattedValue.ToString();
        }
    }
}
