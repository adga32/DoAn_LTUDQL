using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace DoAn.tool_GV_quan_ly_cau_hoi
{
    public partial class LayCauHoiTuExcel : Form
    {
        public LayCauHoiTuExcel()
        {
            InitializeComponent();
        }


        DataSet dsCauHoi = new DataSet();

        private void LayCauHoiTuExcel_Load(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Excel Files (.xls*)|*.xls*|All Files (*.*)|*.*";
                dlg.Multiselect = false;

                DialogResult dlgResult = dlg.ShowDialog();
                string strCon = "";
                if (dlgResult == DialogResult.OK)
                {
                    txtFilePath.Text = dlg.FileName;
                    if (txtFilePath.Text.Equals(""))
                    {
                        MessageBox.Show("Please Load File First!!!");
                        return;
                    }
                    if (!File.Exists(txtFilePath.Text))
                    {
                        MessageBox.Show("Can not Open File!!!");
                        return;
                    }
                    String filePath = txtFilePath.Text;

                    if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                    {
                        strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0";
                    }
                    else
                    {
                        strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0";
                    }

                }
                OleDbConnection olecon = new OleDbConnection();
                olecon.ConnectionString = strCon;
                olecon.Open();
                string strSQL = "SELECT * FROM [cauHoi$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsCauHoi);
                olecon.Close();
                dsCauHoi.Tables[0].TableName = "cauHoi";
                dataGridView1.DataSource = dsCauHoi.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_sql_Click_1(object sender, EventArgs e)
        {
            if (!ExecBulkCopy(dsCauHoi.Tables[0], "cauHoi"))
                MessageBox.Show("Không thành công!");
            else
                MessageBox.Show("Đã thực hiện thành công!");
        }

        public bool ExecBulkCopy(DataTable pDt, string pDesTableName = "")
        {
            try
            {
                if (pDesTableName.Length == 0)
                    pDesTableName = pDt.TableName;
                //tạo connect
                SqlConnection connection;
                var cnecStrS = ConfigurationManager.ConnectionStrings["DoAn.Properties.Settings.QLTTNConnectionString"];
                connection = new SqlConnection(cnecStrS.ConnectionString);
                //insert
                using (connection)
                {
                    connection.Open();
                    using (SqlBulkCopy sbc = new SqlBulkCopy(connection))
                    {
                        sbc.DestinationTableName = pDesTableName;
                        sbc.WriteToServer(pDt);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }






    }
}
