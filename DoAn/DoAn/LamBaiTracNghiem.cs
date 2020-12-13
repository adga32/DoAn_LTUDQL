using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn
{
    public partial class LamBaiTracNghiem : Form
    {
        string nguoidunghientaiLamBai;
        public void LayNguoiDungHienTai(string value)
        {
            nguoidunghientaiLamBai = value;
        }
        int index = 0;
        int TongCau;
        int S = 60;
        int M = 59;
        string MaCauHoi;


        public LamBaiTracNghiem()
        {
            InitializeComponent();
        }


        private void LamBaiTracNghiem_Load(object sender, EventArgs e)
        {
            //Timer thời gian còn lại
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();



            //using (var db = new DoAnDataContext())
            //{
            //    string nguoidunghientai = NguoiDungHienTai;
            //    var manguoidunghientai = (from i in db.taiKhoans where i.username == nguoidunghientai select i.idNguoiSoHuu).FirstOrDefault();
            //    var thoigianlambai = (from i in db.deThis where i.ma == "101" select i.thoiGianLamBai_phut).First();
            //    M = int.Parse(thoigianlambai.ToString()) - 1;
            //    db.tinhTrangBaiLams.InsertOnSubmit(new tinhTrangBaiLam
            //    {
            //        maHs = "HS0001",
            //        maDe = "101",
            //        maKythi = "KT01",
            //        maCauHoi = "CH0001",
            //        cautraloi1 = false.ToString(),
            //        cautraloi2 = false.ToString(),
            //        cautraloi3 = false.ToString(),
            //        cautraloi4 = false.ToString(),
            //        cautraloi5 = false.ToString(),
            //        cautraloi6 = false.ToString()
            //    });
            //    db.SubmitChanges();

            //}



            ////Data binding
            //if (sqlCon == null)
            //{
            //    sqlCon = new SqlConnection(strCon);
            //}
            //string sql = @"SELECT * FROM(((deThi dt join chiTietDethi ctdt ON dt.ma = ctdt.maDethi) join cauHoi ch ON ch.ma = ctdt.maCauHoi) join dapAnCauhoi dach ON ch.ma = dach.maCauHoi) join tinhTrangBaiLam ttbl on ttbl.maDe = ctdt.maDethi";
            //adapter = new SqlDataAdapter(sql, sqlCon);
            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //ds = new DataSet();
            //adapter.Fill(ds, "tblCauHoi");


            //bs = new BindingSource(ds, "tblCauHoi");
            //txtNoiDungCauHoi.DataBindings.Add("Text", bs, "noiDung");
            //ucA.DataBindings.Add("NoiDung", bs, "dapAn1");
            //ucB.DataBindings.Add("NoiDung", bs, "dapAn2");
            //ucC.DataBindings.Add("NoiDung", bs, "dapAn3");
            //ucD.DataBindings.Add("NoiDung", bs, "dapAn4");
            //ucE.DataBindings.Add("NoiDung", bs, "dapAn5");
            //ucF.DataBindings.Add("NoiDung", bs, "dapAn6");
            //if (ucE.NoiDung.Length == 0)
            //{
            //    ucE.Hide();
            //}
            //else
            //{
            //    ucE.Show();
            //}

            //if (ucF.NoiDung.Length == 0)
            //{
            //    ucF.Hide();
            //}
            //else
            //{
            //    ucF.Show();
            //}
            //lblVitri.Text = "Câu " + (bs.Position + 1) + "/ " + bs.Count;

            //ucA.DataBindings.Add("CheckBox", bs, "cautraloi1");
            //ucB.DataBindings.Add("CheckBox", bs, "cautraloi2");
            //ucC.DataBindings.Add("CheckBox", bs, "cautraloi3");
            //ucD.DataBindings.Add("CheckBox", bs, "cautraloi4");
            //ucE.DataBindings.Add("CheckBox", bs, "cautraloi5");
            //ucF.DataBindings.Add("CheckBox", bs, "cautraloi6");





            //Linq de hien thi thoi gian lam bai
            //Chua xet ma de thi nao
            using (var db = new DoAnDataContext())
            {
                var thongtindethi = (from i in db.deThis select new { i.thoiGianLamBai_phut, i.slCauHoi }).First();
                M = int.Parse(thongtindethi.thoiGianLamBai_phut.ToString()) - 1;
                TongCau = int.Parse(thongtindethi.slCauHoi.ToString());
                //Lay ma nguoi dung hien tai
                var DSCauHoi = (from i in db.cauHois select i.ma).ToList();
                var Manguoidung = (from i in db.taiKhoans where i.username == nguoidunghientaiLamBai select i.idNguoiSoHuu).First().ToString();


                //Insert ds cauhoi vao tinhtrang bai lam
                //Chua xet maDe va Ma ki thi
                //for (int i = 0; i < TongCau; i++)
                //{
                //    db.tinhTrangBaiLams.InsertOnSubmit(new tinhTrangBaiLam
                //    {
                //        maHs = Manguoidung,
                //        maDe = "101",
                //        maKythi = "KT01",
                //        maCauHoi = DSCauHoi[i]
                //    });
                //    db.SubmitChanges();
                //}
            }
            //Linq to SQL De hien thi cau hoi

            Load_CauHoi();
        }


        //Chua load cau hoi cua de thi nao
        private void Load_CauHoi()
        {
            using (var db = new DoAnDataContext())
            {
                var CauHoi = (from i in db.cauHois
                              join j in db.dapAnCauhois
                              on i.ma equals j.maCauHoi
                              select new
                              {
                                  Ma = i.ma,
                                  NoiDung = i.noiDung,
                                  DapAn = j.dapAn
                              } into GroupDSCH
                              group GroupDSCH.DapAn by new { GroupDSCH.Ma, GroupDSCH.NoiDung } into DSCAUHOI
                              select new
                              {
                                  MACAUHOI = DSCAUHOI.Key.Ma,
                                  NOIDUNGCAUHOI = DSCAUHOI.Key.NoiDung,
                                  DAPANCUACAUHOI = DSCAUHOI.ToList()
                              }).ToList();

                MaCauHoi = CauHoi[index].MACAUHOI;
                TongCau = CauHoi.Count;

                txtNoiDungCauHoi.Text = CauHoi[index].NOIDUNGCAUHOI;
                ucA.NoiDung = "";
                ucB.NoiDung = "";
                ucC.NoiDung = "";
                ucD.NoiDung = "";
                ucE.NoiDung = "";
                ucF.NoiDung = "";
                int SoDapAn = CauHoi[index].DAPANCUACAUHOI.Count;
                ucA.NoiDung = CauHoi[index].DAPANCUACAUHOI[0];
                ucB.NoiDung = CauHoi[index].DAPANCUACAUHOI[1];
                ucC.NoiDung = CauHoi[index].DAPANCUACAUHOI[2];
                ucD.NoiDung = CauHoi[index].DAPANCUACAUHOI[3];
                if (SoDapAn == 5)
                {
                    ucE.NoiDung = CauHoi[index].DAPANCUACAUHOI[4];
                }
                else if (SoDapAn == 6)
                {
                    ucF.NoiDung = CauHoi[index].DAPANCUACAUHOI[5];
                }

                if (ucE.NoiDung.Length == 0)
                {
                    ucE.Hide();
                }
                if (ucF.NoiDung.Length == 0)
                {
                    ucF.Hide();
                }

                lblVitri.Text = "Câu " + (index + 1) + "/ " + TongCau;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            S--;
            if (M < 10)
            {
                if (S < 10)
                {
                    lblThoiGianConLai.Text = "0" + M + " : 0" + S;
                }
                else
                {
                    lblThoiGianConLai.Text = "0" + M + " : " + S;
                }
            }
            else
            {
                if (S < 10)
                {
                    lblThoiGianConLai.Text = M + " : 0" + S;
                }
                else
                {
                    lblThoiGianConLai.Text = M + " : " + S;
                }
            }

            if (M == 0 && S == 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết thời gian làm bài");
            }

            if (S == 0)
            {
                S = 60;
                M--;
            }

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Load_CauHoi();
            }
            lblVitri.Text = "Câu " + (index + 1) + "/ " + TongCau;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index < TongCau - 1)
            {
                index++;
                Load_CauHoi();
            }
            lblVitri.Text = "Câu " + (index + 1) + "/ " + TongCau;
        }
    }
}
