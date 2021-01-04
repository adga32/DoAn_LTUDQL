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

namespace DoAn
{
    public partial class QuanLyNguoiDung : Form
    {

        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }


        private void buttonImport_Click(object sender, EventArgs e)
        {
            importDsHocSinhGiaoVien importDsHocSinhGiaoVien = new importDsHocSinhGiaoVien();
            importDsHocSinhGiaoVien.Show();
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTNDataSet1.hocSinh' table. You can move, or remove it, as needed.
            this.hocSinhTableAdapter.Fill(this.qLTTNDataSet1.hocSinh);
            // TODO: This line of code loads data into the 'qLTTNDataSet.giaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.qLTTNDataSet.giaoVien);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giaoVienBindingSource.EndEdit();
            this.giaoVienTableAdapter.Update(qLTTNDataSet.giaoVien);
            this.giaoVienTableAdapter.Fill(this.qLTTNDataSet.giaoVien);

            this.hocSinhBindingSource.EndEdit();
            this.hocSinhTableAdapter.Update(qLTTNDataSet1.hocSinh);
            this.hocSinhTableAdapter.Fill(this.qLTTNDataSet1.hocSinh);

            MessageBox.Show("thay đổi thành công ");
        }
    }
}
