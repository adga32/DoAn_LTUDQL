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
   //đang code
    public partial class QuanLyNguoiDung : Form
    {
        // sử dụng data binding
        DataSet dsGiaoVien = new DataSet();
        DataSet dsHocSinh = new DataSet();


        public QuanLyNguoiDung()
        {
            InitializeComponent();

            this.Load += QuanLyNguoiDung_Load;
        }

        //private void initDtgHocSinh()
        //{
        //    dtgHocSinh.Columns.Clear();

        //    DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
        //    col1.Name = "Mã học sinh";

        //    DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
        //    col1.Name = "Tên học sinh";

        //    DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
        //    col1.Name = "Ngày sinh";

        //    DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
        //    col1.Name = "Mã lớp";


        //}
        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            string tbHsRelation="hocSinh_NguoiDung_relation";
            string tbGvRelation = "giaoVien_NguoiDung_relation";


            var conecStrs = ConfigurationManager.ConnectionStrings["DoAn.Properties.Settings.QLTTNConnectionString"];
            var connection = new SqlConnection(conecStrs.ConnectionString);
            var SelectCommand1 = new SqlCommand("SELECT * FROM hocSinh", connection);
            var SelectCommand2 = new SqlCommand("SELECT * FROM NguoiDung", connection);
            var adapter = new SqlDataAdapter(SelectCommand1);
            adapter.Fill(dsHocSinh,"hocSinh");

            adapter = new SqlDataAdapter(SelectCommand2);
            adapter.Fill(dsHocSinh, "NguoiDung");

            DataRelation dr = new DataRelation(tbHsRelation, dsHocSinh.Tables["NguoiDung"].Columns["manguoidung"], dsHocSinh.Tables["hocSinh"].Columns["ma"],  true);
            dsHocSinh.Relations.Add(dr);

            BindingSource dbsHocSinh = new BindingSource(dsHocSinh,"hocSinh");
            dtgHocSinh.DataSource = dbsHocSinh;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            importDsHocSinhGiaoVien importDsHocSinhGiaoVien = new importDsHocSinhGiaoVien();
            importDsHocSinhGiaoVien.ShowDialog();
        }
    }
}
