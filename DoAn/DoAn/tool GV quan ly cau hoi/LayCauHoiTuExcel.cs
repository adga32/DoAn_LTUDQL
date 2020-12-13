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
                /*             = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\phan mem\\PTUDCSDL\\DoAn_LTUDQL_duPhong\\database.xls;Extended Properties=Excel 8.0";
                */
                olecon.ConnectionString = strCon;
                olecon.Open();
                string strSQL = "SELECT * FROM [cauHoi$]";
                OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
                oleda.Fill(dsCauHoi);
                olecon.Close();
                dsCauHoi.Tables[0].TableName = "cauHoi";
                dataGridView1.DataSource = dsCauHoi.Tables[0];
            }catch(Exception ex)
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

 


        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.Filter = "Excel Files (.xls*)|*.xls*|All Files (*.*)|*.*";
        //    dlg.Multiselect = false;

        //    DialogResult dlgResult = dlg.ShowDialog();
        //    if (dlgResult == DialogResult.OK)
        //    {
        //        txtFilePath.Text = dlg.FileName;
        //        if (txtFilePath.Text.Equals(""))
        //        {
        //            lblMsg.Text = "Please Load File First!!!";
        //            return;
        //        }
        //        if (!File.Exists(txtFilePath.Text))
        //        {
        //            lblMsg.Text = "Can not Open File!!!";
        //            return;
        //        }
        //        String filePath = txtFilePath.Text;
        //        string excelcon;
        //        if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
        //        {
        //            excelcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=NO;IMEX=1'";
        //        }
        //        else
        //        {
        //            excelcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1'";
        //        }
        //        OleDbConnection conexcel = new OleDbConnection(excelcon);

        //        try
        //        {
        //            conexcel.Open();
        //            DataTable dtExcel = conexcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
        //            string sheetName = dtExcel.Rows[0]["Table_Name"].ToString();
        //            OleDbCommand cmdexcel1 = new OleDbCommand();
        //            cmdexcel1.Connection = conexcel;
        //            cmdexcel1.CommandText = "select * from[" + sheetName + "]";
        //            DataTable dt = new DataTable();
        //            OleDbDataAdapter da = new OleDbDataAdapter();
        //            da.SelectCommand = cmdexcel1;
        //            da.Fill(dt);
        //            conexcel.Close();
        //            gridviewImportExcel.DataSource = dt;
        //            gridviewImportExcel.Rows.RemoveAt(0);
        //        }
        //        catch (Exception ex)
        //        {
        //            conexcel.Close();
        //            MessageBox.Show(ex.ToString());
        //        }
        //    }
        //}

    }
}
