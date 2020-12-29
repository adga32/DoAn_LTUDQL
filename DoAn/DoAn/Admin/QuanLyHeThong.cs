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

namespace DoAn.Admin
{
    public partial class QuanLyHeThong : Form
    {
        public QuanLyHeThong()
        {
            InitializeComponent();
        }

        private void buttonBrowesBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathBackup.Text = folderBrowserDialog.SelectedPath;
                buttonBackup.Enabled = true;
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            //tạo connect
            SqlConnection con;
            var cnecStrS = ConfigurationManager.ConnectionStrings["DoAn.Properties.Settings.QLTTNConnectionString"];
            con = new SqlConnection(cnecStrS.ConnectionString);
            con.Open();
            String database = con.Database.ToString();
            try
            {
                if (textBoxPathBackup.Text == string.Empty)
                {
                    //  s.Speak("please enter the valid backup file location");
                    MessageBox.Show("please enter the backup file location");
                }
                else
                {

                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + textBoxPathBackup.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(q, con);
                    scmd.ExecuteNonQuery();
                    // s.Speak("Backup taken successfully");
                    MessageBox.Show("Backup taken successfully", "Backup successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonBackup.Enabled = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonBrowesRestore_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*bak";
            openFileDialog.Title = "Database Restore";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxRestore.Text = openFileDialog.FileName;
                buttonBrowesRestore.Enabled = true;
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            //tạo connect
            SqlConnection con;
            var cnecStrS = ConfigurationManager.ConnectionStrings["DoAn.Properties.Settings.QLTTNConnectionString"];
            con = new SqlConnection(cnecStrS.ConnectionString);
            con.Open();
            String database = con.Database.ToString();
            try
            {

                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBoxRestore.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();
                // s.Speak("Database Restored successfully");
                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonRestore.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
