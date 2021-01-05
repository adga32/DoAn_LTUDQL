using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.ModuleGiaoVien
{
    public partial class ExportDatabaseCauHoi : Form
    {
        public ExportDatabaseCauHoi()
        {
            InitializeComponent();
        }

        private void ExportDatabaseCauHoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTNDataSetDapAnCauHoi.dapAnCauhoi' table. You can move, or remove it, as needed.
            this.dapAnCauhoiTableAdapter.Fill(this.qLTTNDataSetDapAnCauHoi.dapAnCauhoi);
            // TODO: This line of code loads data into the 'qLTTNDataSetCauHoi.cauHoi' table. You can move, or remove it, as needed.
            this.cauHoiTableAdapter.Fill(this.qLTTNDataSetCauHoi.cauHoi);

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook xLWorkbook = new XLWorkbook())
                        {
                            xLWorkbook.Worksheets.Add(this.qLTTNDataSetCauHoi.cauHoi.CopyToDataTable(), "cauHoi");
                            xLWorkbook.Worksheets.Add(this.qLTTNDataSetDapAnCauHoi.dapAnCauhoi.CopyToDataTable(), "dapAnCauHoi");
                            xLWorkbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Export danh sách câu hỏi thành công.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
