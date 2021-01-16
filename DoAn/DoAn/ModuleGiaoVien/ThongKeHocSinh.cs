using DoAn;
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
    public partial class ThongKeHocSinh : MetroFramework.Forms.MetroForm
    {
        int TopDiemTB = 0;
        public ThongKeHocSinh()
        {
            InitializeComponent();
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ThongKeHocSinh_Load(object sender, EventArgs e)
        {
            using (var db = new DoAnDataContext())
            {
                cbbLop.DataSource = (from i in db.lops select i);
                cbbLop.DisplayMember = "ten";
                cbbLop.ValueMember = "ma"; 
            }

            //Tạo giá trị cho combobox khối
            var cbbtop = new Dictionary<string, int>();
            cbbtop.Add("Top 5", 5);
            cbbtop.Add("Top 10", 10);
            cbbtop.Add("Top 15", 15);

            cbbThongKe.DataSource = new BindingSource(cbbtop,null);
            cbbThongKe.DisplayMember = "Key";
            cbbThongKe.ValueMember = "Value";
            TopDiemTB = 5;
            LoadDSHOCSINH();
        }

        private void LoadDSHOCSINH()
        {
            using (var db = new DoAnDataContext())
            {

                var DiemTB = (from i in db.ketQuas
                              group i by i.maHs into groupResult
                              select new
                              {
                                  MaHS = groupResult.Key,
                                  TongMon = groupResult.Count(),
                                  Diem = groupResult.Sum(f => f.diem > 0 ? f.diem : f.diem)
                              } into g
                              select new
                              {
                                  MaHS = g.MaHS,
                                  DiemTB = g.Diem / g.TongMon
                              }).ToList().OrderByDescending(i=>i.DiemTB).Take(TopDiemTB);

                dgvLop.DataSource = (from k in DiemTB
                              join j in db.hocSinhs
                              on k.MaHS equals j.ma
                              select new
                              {
                                  TenHS = j.ten,
                                  NgaySinh = j.ngaySinh,
                                  DiemTB = k.DiemTB
                              }).ToList();
            }
        }

        private void cbbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbThongKe.SelectedIndex == 0)
            {
                TopDiemTB = 5;
            }
            else if(cbbThongKe.SelectedIndex == 1)
            {
                TopDiemTB = 10;
            }
            else
            {
                TopDiemTB = 15;
            }
            LoadDSHOCSINH();
            TopDiemTB = 0;
        }
    }
}
