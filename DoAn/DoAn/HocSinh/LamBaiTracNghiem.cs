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
        // chưa xử lí nhận đề thi
        string maDeThi;

        //mảng chứa các control câu trả lời
        CauTraLoi[] listCtrlDapAn;

        //mảng chứa vị trí các câu đã làm 
        List<int> listCauDaHoanThanh = new List<int>();

        // ma trận chứa vị trí các đáp án mà người dùng chọn dùng cho việc truy xuất 
        bool[,] matrixDapAnChon;

        // ma trận(bool) 
        //                  0(A) 1(B) 2(C) 3(D) 4(E) 5(F) -> đáp án trả lời
        //   chỉ số câu->0
        //               1
        //               2
        //               3
        //               4	
        // khi người dùng chọn đáp án sẽ gán giá trị bằng true vào vị trí câu hỏi và đáp án chọn tương ứng 
        //-> nhằm cho việc truy xuất lại đáp án đã chọn của câu hỏi khi người dùng di chuyển đến câu hỏi đó

        // biến toàn cục form
        string nguoiDungHienTaiLamBai;
        bool laKiemTraChinhThuc = false;

        int viTriCauHoiHienTai = 0;
        int TongCau;
        int giay = 60;
        int phut = 59;
        string MaCauHoi;


        //các hàm delegate
        //nhận thông tin nguoi dung từ form đăng nhập 
        public void LayNguoiDungHienTai(string value) //loaiBaiThi là biến kiểm tra người dùng ôn tập hoặc thi thật
        {
            nguoiDungHienTaiLamBai = value;
        }

        public void ThongTinBaiThiTracNghiem(bool loaiBaiThi,string maDe)
        {
            laKiemTraChinhThuc = loaiBaiThi;
            maDeThi = maDe;
        }

        public LamBaiTracNghiem()
        {
            InitializeComponent();

            listCtrlDapAn = new CauTraLoi[] { ucA, ucB, ucC, ucD, ucE, ucF };

            // khởi tạo sự kiện check cho control đáp án và xử lí khi người dùng chọn dáp án
            for (int i = 0; i < 6; i++)
            {
                listCtrlDapAn[i].CheckBoxChange += LamBaiTracNghiem_CheckBoxChange;
            }

        }

        private void LamBaiTracNghiem_CheckBoxChange(object sender, EventArgs e)
        {
            var uc = (CauTraLoi)sender;
            int viTriDapAn;

            if (uc == ucA)
            {
                viTriDapAn = 0;
            }
            else if (uc == ucB)
            {
                viTriDapAn = 1;
            }
            else if (uc == ucC)
            {
                viTriDapAn = 2;
            }
            else if (uc == ucD)
            {
                viTriDapAn = 3;
            }
            else if (uc == ucE)
            {
                viTriDapAn = 4;
            }
            else if (uc == ucF)
            {
                viTriDapAn = 5;
            }
            else
            { viTriDapAn = -1; }

            //kiểm tra dáp án nào được chọn/bỏ chọn và đánh dấu là chọn/bỏ chọn đáp án này
            matrixDapAnChon[viTriCauHoiHienTai, viTriDapAn] = uc.CheckBox;

        }

        private void LamBaiTracNghiem_Load(object sender, EventArgs e)
        {
            lblMaDe.Text = "Mã đề: " + maDeThi;


            //Timer thời gian còn lại
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            //Linq de hien thi thoi gian lam bai
            //Chua xet ma de thi nao
            using (var db = new DoAnDataContext())
            {
                var thongtindethi = (from i in db.deThis
                                     join j in db.monHocs on i.monHoc equals j.ma
                                     select new { i.thoiGianLamBai_phut, i.slCauHoi, j.ten }).First();

                phut = int.Parse(thongtindethi.thoiGianLamBai_phut.ToString()) - 1;
                TongCau = int.Parse(thongtindethi.slCauHoi.ToString());
                lblMonHoc.Text = "Môn học: " + thongtindethi.ten.ToString();

                //Lay ma nguoi dung hien tai
                var DSCauHoi = (from i in db.cauHois select i.ma).ToList();
                var Manguoidung = (from i in db.taiKhoans where i.username == nguoiDungHienTaiLamBai select i.idNguoiSoHuu).First().ToString();


            }

            lblSoCauDaHoanThanh.Text = listCauDaHoanThanh.Count.ToString() + "/" + TongCau;

            matrixDapAnChon = new bool[TongCau, 6];

            //Linq to SQL De hien thi cau hoi

            Load_CauHoi(maDeThi);

        }


   
        private void Load_CauHoi(string maDeThi)
        {
            lblSoCauDaHoanThanh.Text = listCauDaHoanThanh.Count.ToString() + "/" + TongCau;

            //reset các control
            for (int i = 0; i < 6; i++)
            {
                listCtrlDapAn[i].NoiDung = "";
                listCtrlDapAn[i].CheckBox = false; // phép gán này cũng sẽ chạy event của checkbox
                listCtrlDapAn[i].Show();
            }



            
            using (var db = new DoAnDataContext())
            {
                var CauHoi = (from i in db.cauHois
                              join j in db.dapAnCauhois
                              on i.ma equals j.maCauHoi
                              join ct in db.chiTietDethis
                              on i.ma equals ct.maCauHoi
                              where ct.maDethi == maDeThi
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

                MaCauHoi = CauHoi[viTriCauHoiHienTai].MACAUHOI;
                TongCau = CauHoi.Count;


                txtNoiDungCauHoi.Text = CauHoi[viTriCauHoiHienTai].NOIDUNGCAUHOI;

                int SoDapAn = CauHoi[viTriCauHoiHienTai].DAPANCUACAUHOI.Count;

                //khởi tạo danh sách đáp án
                for (int i = 0; i < SoDapAn; i++)
                {
                    listCtrlDapAn[i].NoiDung = CauHoi[viTriCauHoiHienTai].DAPANCUACAUHOI[i];

                    //hiển thị lại các câu mà người dùng đã chọn nếu người dùng đã chọn đáp án cho câu hỏi này
                    if (matrixDapAnChon[viTriCauHoiHienTai, i] == true)
                    {
                        listCtrlDapAn[i].CheckBox = true;// phép gán này cũng sẽ chạy event của checkbox
                    }
                }

                //ẩn các ô đáp án còn lại
                for (int i = SoDapAn; i < 6; i++)
                {
                    listCtrlDapAn[i].Hide();
                }

                lblVitri.Text = "Câu " + (viTriCauHoiHienTai + 1) + "/ " + TongCau;

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            giay--;
            if (phut < 10)
            {
                if (giay < 10)
                {
                    lblThoiGianConLai.Text = "0" + phut + " : 0" + giay;
                }
                else
                {
                    lblThoiGianConLai.Text = "0" + phut + " : " + giay;
                }
            }
            else
            {
                if (giay < 10)
                {
                    lblThoiGianConLai.Text = phut + " : 0" + giay;
                }
                else
                {
                    lblThoiGianConLai.Text = phut + " : " + giay;
                }
            }

            if (phut == 0 && giay == 0)
            {
                timer1.Stop();
                MessageBox.Show("Hết thời gian làm bài");
            }

            if (giay == 0)
            {
                giay = 60;
                phut--;
            }

        }

        private bool daChonDapAn()
        {
            for (int i = 0; i < 6; i++)
            {
                if (matrixDapAnChon[viTriCauHoiHienTai, i] == true)
                    return true;
            }
            return false;
        }
        private int CauHoiDaHoanThanh() // return 1 -> hoàn thành thêm 1 câu, return -1 -> bỏ 1 câu hoàn thành, retrun 0 chưa hoàn thành câu hỏi
        {
            int index = listCauDaHoanThanh.IndexOf(viTriCauHoiHienTai);

            //nếu câu hỏi chưa làm
            if (index == -1)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (daChonDapAn())
                    {
                        return 1;
                    }
                }
            }
            //nếu câu hỏi đã làm kiểm tra xem có bỏ chọn
            else
            {
                if (daChonDapAn())
                { }
                else
                {
                    return -1;
                }
            }
            return 0;

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (viTriCauHoiHienTai > 0)
            {
                if (CauHoiDaHoanThanh() == 1)
                {
                    listCauDaHoanThanh.Add(viTriCauHoiHienTai);
                }
                else if (CauHoiDaHoanThanh() == -1)
                {
                    listCauDaHoanThanh.Remove(viTriCauHoiHienTai);
                }
                else { }

                viTriCauHoiHienTai--;
                Load_CauHoi(maDeThi);
            }



            lblVitri.Text = "Câu " + (viTriCauHoiHienTai + 1) + "/ " + TongCau;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (viTriCauHoiHienTai < TongCau - 1)
            {

                if (CauHoiDaHoanThanh() == 1)
                {
                    listCauDaHoanThanh.Add(viTriCauHoiHienTai);
                }
                else if (CauHoiDaHoanThanh() == -1)
                {
                    listCauDaHoanThanh.Remove(viTriCauHoiHienTai);
                }
                else { }

                viTriCauHoiHienTai++;
                Load_CauHoi(maDeThi);
            }
            lblVitri.Text = "Câu " + (viTriCauHoiHienTai + 1) + "/ " + TongCau;
        }


        // xử lí dữ liệu, gửi kết quả bài làm cho người dùng và lưu kết quả xuống database
        private void btnNopBai_Click(object sender, EventArgs e)
        {
            float Diem = 0;
            int soCauDung = 0;

            using (var db = new DoAnDataContext())
            {
                var danhSachCauHoi = db.chiTietDethis.Where(ctdt => ctdt.maDethi == maDeThi).ToList();

                //xét kết quả của từng đáp án
                for (int i = 0; i < danhSachCauHoi.Count; i++)
                {
                    var danhSachDapAn = db.dapAnCauhois.Where(dach => dach.maCauHoi == danhSachCauHoi[i].maCauHoi).ToList();

                    bool dung_sai = true;

                    for (int j = 0; j < danhSachDapAn.Count; j++)
                    {
                        //kiểm tra nếu kết quả đáp án không trùng khớp với người dùng chọn
                        if (danhSachDapAn[j].laDapAnDung == 1 && matrixDapAnChon[i, j] == false
                            || danhSachDapAn[j].laDapAnDung == 0 && matrixDapAnChon[i, j] == true)
                        {
                            dung_sai = false;
                            break;
                        }

                    }

                    if (dung_sai == true)
                    {
                        soCauDung += 1;
                        Diem += float.Parse(danhSachCauHoi[i].diem.ToString());

                    }
                }

                //nếu là thi thật thì lưu kết quả, thi thử thì không
                if (laKiemTraChinhThuc)
                {
                    luuKetQuaBaiLam(soCauDung, TongCau);
                }

                MessageBox.Show("đúng: " + soCauDung + "/" + TongCau + "--" + Diem);
                return;

            };
        }

        private void luuKetQuaBaiLam(int slCauDung, float Diem)
        {

            string ID_NguoiDung;

            using (var db = new DoAnDataContext())
            {
                ID_NguoiDung = db.taiKhoans.Where(tk => tk.username == nguoiDungHienTaiLamBai).Select(tk => tk.idNguoiSoHuu).Single();

                db.ketQuas.InsertOnSubmit(new ketQua
                {
                    maHs = ID_NguoiDung,
                    maDe = maDeThi,
                    maKythi = null,
                    soCauDung = slCauDung,
                    diem = Diem
                });

                db.SubmitChanges();
            }
        }

    }
}
