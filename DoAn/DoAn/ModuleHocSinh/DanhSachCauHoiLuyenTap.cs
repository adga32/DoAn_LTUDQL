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
    public partial class DanhSachCauHoiLuyenTap : MetroFramework.Forms.MetroForm
    {
        public DanhSachCauHoiLuyenTap()
        {
            InitializeComponent();
            
        }


        private void DanhSachCauHoiLuyenTap_Load(object sender, EventArgs e)
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
                                  LADAPANCAUHOI = GroupDSCH.LADAPANCAUHOI
                              } into GroupDSCHLT
                              where GroupDSCHLT.MaMon == cbbMonHoc.SelectedValue.ToString() && GroupDSCHLT.MaKhoi == cbbKhoi.SelectedValue.ToString()
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
                dgvDSCauHoi.DataSource = CauHoi;
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
            ucA.Enabled = true;
            ucB.Enabled = true;
            ucC.Enabled = true;
            ucD.Enabled = true;
            ucE.Enabled = true;
            ucF.Enabled = true;



            ucA.CheckBox = false;
            ucB.CheckBox = false;
            ucC.CheckBox = false;
            ucD.CheckBox = false;
            ucE.CheckBox = false;
            ucF.CheckBox = false;

            ucA.NoiDung = "";
            ucB.NoiDung = "";
            ucC.NoiDung = "";
            ucD.NoiDung = "";
            ucE.NoiDung = "";
            ucF.NoiDung = "";
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvDSCauHoi.Rows[e.RowIndex];
                txtNoiDungCauHoi.Text = row.Cells["NOIDUNGCAUHOI"].Value.ToString();

                ucA.NoiDung = row.Cells["DAPANCUACAUHOI1"].Value.ToString();
                ucB.NoiDung = row.Cells["DAPANCUACAUHOI2"].Value.ToString();
                ucC.NoiDung = row.Cells["DAPANCUACAUHOI3"].Value.ToString();
                ucD.NoiDung = row.Cells["DAPANCUACAUHOI4"].Value.ToString();
                if(string.IsNullOrEmpty(row.Cells["DAPANCUACAUHOI5"].Value as string) != true)
                {
                    ucE.NoiDung = row.Cells["DAPANCUACAUHOI5"].Value.ToString();
                    ucE.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUE"].Value);
                }
                if (string.IsNullOrEmpty(row.Cells["DAPANCUACAUHOI6"].Value as string) !=true)
                {
                    ucF.NoiDung = row.Cells["DAPANCUACAUHOI6"].Value.ToString();
                    ucF.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUF"].Value);
                }

                ucA.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUA"].Value);
                ucB.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUB"].Value);
                ucC.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUC"].Value);
                ucD.CheckBox = Convert.ToBoolean(row.Cells["LADAPANCAUD"].Value);
                if (Convert.ToInt32(row.Cells["DADUOCDUYETCHUA"].Value) == 1)
                {
                    lblDaDuocDuyet.Text = "Đã được duyệt";
                    lblDaDuocDuyet.BackColor = Color.Green;
                }
                else
                {
                    lblDaDuocDuyet.Text = "Chưa được duyệt";
                    lblDaDuocDuyet.BackColor = Color.Salmon;
                }
            }
        }
    }
}
