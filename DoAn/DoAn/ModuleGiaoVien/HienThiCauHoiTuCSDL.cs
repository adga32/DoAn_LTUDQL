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
            loadGVcauHoi();
        }

        public void loadGVcauHoi()
        {

            using (var db = new DoAnDataContext())
            {
                try
                {
                    var cauHoi = db.cauHois
                         .Select(dsCH => new
                         {
                             maCauHoi = dsCH.ma,
                             noiDung = dsCH.noiDung,
                             goiY = dsCH.goiY,
                             doKho = dsCH.doKho,
                             maMonHoc = dsCH.maMonHoc,
                             makhoi = dsCH.makhoi,
                             loaiCauHoi = dsCH.loaiCauHoi
                         });
                    dataGridView_CauHoi.DataSource = cauHoi ;
                }
                catch(Exception ex)
                { MessageBox.Show(ex.ToString()); }
            }
        }

        private void button_suaCauhoiSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView_CauHoi.CurrentCell.Selected == true)
            {
                SuaChiTietCauHoi form_sua = new SuaChiTietCauHoi(loadGVcauHoi, ma);
                form_sua.Show();
            }
        }

        private void dataGridView_CauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_CauHoi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView_CauHoi.CurrentRow.Selected = true;


                ma = dataGridView_CauHoi.Rows[e.RowIndex].Cells["maCauHoi"].FormattedValue.ToString();
                

            }
        }
    }
}
