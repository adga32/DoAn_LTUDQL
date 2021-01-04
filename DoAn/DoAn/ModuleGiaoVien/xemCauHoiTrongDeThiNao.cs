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
    public partial class xemCauHoiTrongDeThiNao : Form
    {
        public string ma;
        public List<int> ListrowIndex = new List<int>();
        public xemCauHoiTrongDeThiNao()
        {
            InitializeComponent();
        }


        private DataTable covertDGVtoDataTable(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                {
                    dt.Columns.Add(column.DataPropertyName.ToString());
                }
            }



            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            dt.Columns.Remove("MACAUHOI");
            dt.Columns.Remove("MaMon");
            dt.Columns.Remove("MaKhoi");
            dt.Columns.Remove("LADAPANCAUA");
            dt.Columns.Remove("LADAPANCAUB");
            dt.Columns.Remove("LADAPANCAUC");
            dt.Columns.Remove("LADAPANCAUD");
            dt.Columns.Remove("LADAPANCAUE");
            dt.Columns.Remove("LADAPANCAUF");

            dt.Columns.Remove("DAPANCUACAUHOI1");
            dt.Columns.Remove("DAPANCUACAUHOI2");
            dt.Columns.Remove("DAPANCUACAUHOI3");
            dt.Columns.Remove("DAPANCUACAUHOI4");
            dt.Columns.Remove("DAPANCUACAUHOI5");
            dt.Columns.Remove("DAPANCUACAUHOI6");
            return dt;
        }

        public void loadGVcauHoi()
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
                              where GroupDSCH.MaMon == cbbMonHoc.SelectedValue.ToString() && GroupDSCH.MaKhoi == cbbKhoi.SelectedValue.ToString() && (GroupDSCH.LoaiCauhoi == "THILUYENTAP" || GroupDSCH.LoaiCauhoi == "THI")
                              group new { GroupDSCH.DapAn, GroupDSCH.LADAPANCAUHOI } by new { GroupDSCH.Ma, GroupDSCH.NoiDung, GroupDSCH.GoiY, GroupDSCH.MaMon, GroupDSCH.MaKhoi } into DSCAUHOI
                              select new
                              {
                                  MACAUHOI = DSCAUHOI.Key.Ma,
                                  NOIDUNGCAUHOI = DSCAUHOI.Key.NoiDung,
                                  GOIY = DSCAUHOI.Key.GoiY,
                                  DAPANCUACAUHOI1 = DSCAUHOI.Take(1).First().DapAn,
                                  DAPANCUACAUHOI2 = DSCAUHOI.Skip(1).Take(1).First().DapAn,
                                  DAPANCUACAUHOI3 = DSCAUHOI.Skip(2).Take(1).First().DapAn,
                                  DAPANCUACAUHOI4 = DSCAUHOI.Skip(3).Take(1).First().DapAn,
                                  DAPANCUACAUHOI5 = DSCAUHOI.Skip(4).Take(1).First().DapAn,
                                  DAPANCUACAUHOI6 = DSCAUHOI.Skip(5).Take(1).First().DapAn,

                                  MaMon = DSCAUHOI.Key.MaMon,
                                  MaKhoi = DSCAUHOI.Key.MaKhoi,
                                  LADAPANCAUA = DSCAUHOI.Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUB = DSCAUHOI.Skip(1).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUC = DSCAUHOI.Skip(2).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUD = DSCAUHOI.Skip(3).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUE = DSCAUHOI.Skip(4).Take(1).First().LADAPANCAUHOI,
                                  LADAPANCAUF = DSCAUHOI.Skip(5).Take(1).First().LADAPANCAUHOI
                              }).ToList();

                DataTable boundTable = new DataTable();

                //Gắn data source vào data gridview
                dgvDSCauHoi.DataSource = CauHoi;

                // tao datatable tu dGV
                DataTable dtSource = covertDGVtoDataTable(dgvDSCauHoi);


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

                try
                {
                    cmbSearchType.Items.Clear();
                    string[] ColNameList = dtSource.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
                    cmbSearchType.Items.AddRange(ColNameList);
                    if (cmbSearchType.Items.Count > 0) cmbSearchType.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xemCauHoiTrongDeThiNao_Load(object sender, EventArgs e)
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ListrowIndex.Clear();
            string searchValue = txtSearchBox.Text;
            int rowIndex = -1;
            dgvDSCauHoi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDSCauHoi.Rows)
                {
                    if (row.Cells[dgvDSCauHoi.Columns[cmbSearchType.Text].Index].Value != null)
                        if (row.Cells[dgvDSCauHoi.Columns[cmbSearchType.Text].Index].Value.ToString().Contains(searchValue)) //
                        {
                            rowIndex = row.Index;
                            dgvDSCauHoi.ClearSelection();

                            ListrowIndex.Add(rowIndex);
                        }
                }
                dgvDSCauHoi.Rows[ListrowIndex[0]].Selected = true;
                dgvDSCauHoi.FirstDisplayedScrollingRowIndex = ListrowIndex[0];//
                dgvDSCauHoi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonShowALL_Click(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                try
                {
                    var cauHoi = db.cauHois
                         .Select(dsCH => new
                         {
                             maCauHoi = dsCH.ma,
                             NOIDUNGCAUHOI = dsCH.noiDung,
                             GOIY = dsCH.goiY,
                             DOKHO = dsCH.doKho,
                             MaMon = dsCH.maMonHoc,
                             MaKhoi = dsCH.makhoi,
                         });
                    dgvDSCauHoi.DataSource = cauHoi;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); }
            }
        }

        private void buttonSearchNext_Click(object sender, EventArgs e)
        {
            int nowRowFocus = dgvDSCauHoi.SelectedRows[0].Index;
            for (int i = 0; i < ListrowIndex.Count; i++)
                if (ListrowIndex[i] == nowRowFocus)
                {
                    nowRowFocus = i;
                    break;
                }


            if (dgvDSCauHoi.SelectedRows[0].Index != ListrowIndex[ListrowIndex.Count - 1])
            {
                dgvDSCauHoi.Rows[ListrowIndex[nowRowFocus]].Selected = false;
                dgvDSCauHoi.Rows[ListrowIndex[nowRowFocus + 1]].Selected = true;
                dgvDSCauHoi.FirstDisplayedScrollingRowIndex = ListrowIndex[nowRowFocus + 1];
                dgvDSCauHoi.Focus();
            }
            else { MessageBox.Show("hết"); }
        }

        private void dgvDSCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvDSCauHoi.CurrentRow.Selected = true;
            ma = dgvDSCauHoi.Rows[e.RowIndex].Cells["maCauHoi"].FormattedValue.ToString();

            using (var db = new DoAnDataContext())
            {
                try
                {
                    var DsDt = (from i in db.chiTietDethis
                                join j in db.deThis
                                on i.maDethi equals j.ma
                                where i.maCauHoi == ma
                                select new
                                {
                                    MaDe = j.ma,
                                    soLuongCauHoi = j.slCauHoi,
                                    maMonHoc = j.maMonHoc,
                                    thoiGianLamBai = j.thoiGianLamBai_phut
                                }).ToList();

                    dataGridViewDethi.DataSource = DsDt;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); }
            }

            

        }
    }
}
