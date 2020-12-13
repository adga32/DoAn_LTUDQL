using DoAn.tool_GV_quan_ly_cau_hoi;
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
    public partial class GVquanlycauhoi : Form
    {
        public GVquanlycauhoi()
        {
            InitializeComponent();
        }

        private void button_layDulieuTuExcel_Click(object sender, EventArgs e)
        {
            LayCauHoiTuExcel FormlayCauHoiTuExcel = new LayCauHoiTuExcel();
            FormlayCauHoiTuExcel.ShowDialog();
            this.Close();
        }



    }
}
