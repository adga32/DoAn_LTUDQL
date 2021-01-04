using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLyHeThong : Form
    {
        public QuanLyHeThong()
        {
            InitializeComponent();
        }

        private void QuanLyHeThong_Load(object sender, EventArgs e)
        {

        }

        private void btnSaoLuuDatabse_Click(object sender, EventArgs e)
        {
            SaoLuuDatabase frmSaoLuuDatabase = new SaoLuuDatabase();
            frmSaoLuuDatabase.Show();
        }

        private void btnThietLapPhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyenNguoiDung frmPhanQuyen = new PhanQuyenNguoiDung();
            frmPhanQuyen.Show();

        }
    }
}
