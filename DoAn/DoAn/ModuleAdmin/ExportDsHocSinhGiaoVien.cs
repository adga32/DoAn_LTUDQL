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

namespace DoAn.ModuleAdmin
{
    public partial class ExportDsHocSinhGiaoVien : MetroFramework.Forms.MetroForm
    {
        public ExportDsHocSinhGiaoVien()
        {
            InitializeComponent();
        }

        private void ExportDsHocSinhGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTNDataSetGiaoVien.giaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.qLTTNDataSetGiaoVien.giaoVien);
            // TODO: This line of code loads data into the 'qLTTNDataSetHocSinh.hocSinh' table. You can move, or remove it, as needed.
            this.hocSinhTableAdapter.Fill(this.qLTTNDataSetHocSinh.hocSinh);

        }

        private void buttonEXGV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx"})
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook xLWorkbook = new XLWorkbook())
                        {
                            xLWorkbook.Worksheets.Add(this.qLTTNDataSetGiaoVien.giaoVien.CopyToDataTable(), "giaoVien");
                            xLWorkbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Export giao vien thành công");

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void buttonEXHS_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook xLWorkbook = new XLWorkbook())
                        {
                            xLWorkbook.Worksheets.Add(this.qLTTNDataSetHocSinh.hocSinh.CopyToDataTable(), "hocSinh");
                            xLWorkbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Export Học sinh thành công");

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
