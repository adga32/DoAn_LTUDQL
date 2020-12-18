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
        DataSet dsdapAnCauHoi = new DataSet();
        OleDbConnection olecon = new OleDbConnection();

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
               
                olecon.ConnectionString = strCon;
                olecon.Open();
                string strSQL = "SELECT * FROM [cauHoi$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsCauHoi);
                olecon.Close();
                dsCauHoi.Tables[0].TableName = "cauHoi";
                dataGridView1.DataSource = dsCauHoi.Tables[0];
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_sql_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (!ExecBulkCopy(dsCauHoi.Tables[0], "cauHoi"))
                    MessageBox.Show("Không thành công!");
                else
                    MessageBox.Show("Đã thực hiện thành công!");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (!ExecBulkCopy(dsdapAnCauHoi.Tables[0], "dapAnCauHoi"))
                    MessageBox.Show("Không thành công!");
                else
                    MessageBox.Show("Đã thực hiện thành công!");
            }
        }

        public bool ExecBulkCopy(DataTable pDt, string pDesTableName = "")
        {
            try
            {
                //tạo connect
                SqlConnection connection;
                var cnecStrS = ConfigurationManager.ConnectionStrings["DoAn.Properties.Settings.QLTTNConnectionString"];
                connection = new SqlConnection(cnecStrS.ConnectionString);
                if (pDesTableName.Length == 0)
                    pDesTableName = pDt.TableName;
                //insert table cuaHoi
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex == 0)
            {
                string strSQL = "SELECT * FROM [cauHoi$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsCauHoi);
                olecon.Close();
                dsCauHoi.Tables[0].TableName = "cauHoi";
                dataGridView1.DataSource = dsCauHoi.Tables[0];
            }
            else if (cb.SelectedIndex == 1)
            {
                string strSQL = "SELECT * FROM [dapAnCauHoi$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsdapAnCauHoi);
                olecon.Close();
                dsdapAnCauHoi.Tables[0].TableName = "dapAnCauHoi";
                dataGridView1.DataSource = dsdapAnCauHoi.Tables[0];
            }
        }
    }
}
