using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Admin
{
    public partial class importDsHocSinhGiaoVien : Form
    {
        public importDsHocSinhGiaoVien()
        {
            InitializeComponent();
        }

        DataSet dsGiaoVien = new DataSet();
        DataSet dsHocSinh= new DataSet();
        OleDbConnection olecon = new OleDbConnection();




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
                //insert table giao vine
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



        private void importDsHocSinhGiaoVien_Load(object sender, EventArgs e)
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
                string strSQL = "SELECT * FROM [giaoVien$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsGiaoVien);
                olecon.Close();
                dsGiaoVien.Tables[0].TableName = "giaoVien";
                dataGridView1.DataSource = dsGiaoVien.Tables[0];
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex == 0)
            {
                string strSQL = "SELECT * FROM [giaoVien$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsGiaoVien);
                olecon.Close();
                dsGiaoVien.Tables[0].TableName = "giaoVien";
                dataGridView1.DataSource = dsGiaoVien.Tables[0];
            }
            else if (cb.SelectedIndex == 1)
            {
                string strSQL = "SELECT * FROM [hocSinh$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsHocSinh);
                olecon.Close();
                dsHocSinh.Tables[0].TableName = "hocSinh";
                dataGridView1.DataSource = dsHocSinh.Tables[0];
            }
        }

        private void button_sql_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                if (!ExecBulkCopy(dsGiaoVien.Tables[0], "giaoVien"))
                    MessageBox.Show("Không thành công!");
                else
                    MessageBox.Show("Đã thực hiện thành công!");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (!ExecBulkCopy(dsHocSinh.Tables[0], "hocSinh"))
                    MessageBox.Show("Không thành công!");
                else
                    MessageBox.Show("Đã thực hiện thành công!");
            }
        }
    }
}
