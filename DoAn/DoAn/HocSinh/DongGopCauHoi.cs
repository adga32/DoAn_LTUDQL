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
    public partial class DongGopCauHoi : Form
    {
        string ID;
        string LoaiCauHoi="";

        //nhận thông tin nguoi dung từ form hoc sinh 
        public void LayNguoiDungHienTai(string userName)
        {
            using (var db = new DoAnDataContext())
            {
                ID = db.taiKhoans.Where(tk => tk.username == userName).Select(tk => tk.idNguoiSoHuu).Single();
            }

        }
        RequiredFieldValidator requiedNoiDungCauHoi;
        CauTraLoi[] listCtrlDapAn;
        public DongGopCauHoi()
        {
            InitializeComponent();

            //Mở cái readonly cho người dùng nhập câu hỏi đóng góp
            ucA.Readonly = false;
            ucB.Readonly = false;
            ucC.Readonly = false;
            ucD.Readonly = false;
            ucE.Readonly = false;
            ucF.Readonly = false;

            //Regex cho txtNoiDungCauHoi
            requiedNoiDungCauHoi = new RequiredFieldValidator();
            requiedNoiDungCauHoi.ControlToValidate = txtNoiDungCauHoi;

        }

        private void btnDongGop_Click(object sender, EventArgs e)
        {
            using (DoAnDataContext db = new DoAnDataContext())
            {
                
                if (requiedNoiDungCauHoi.CheckValidate == true && ucA.Validator ==true && ucB.Validator ==true
                    && ucC.Validator ==true && ucD.Validator ==true)
                {
                    listCtrlDapAn = new CauTraLoi[] { ucA, ucB, ucC, ucD, ucE, ucF };
                    for(int i = 0;i<listCtrlDapAn.Count()-1;i++)
                    {
                       for(int j = i +1;j<listCtrlDapAn.Count();j++)
                        {
                            if(listCtrlDapAn[i].NoiDung == listCtrlDapAn[j].NoiDung && listCtrlDapAn[i].NoiDung != "" && listCtrlDapAn[j].NoiDung != "")
                            {       
                                MessageBox.Show("Đáp án không được trùng nhau");
                                return;
                            }
                        }
                    }

                    int sotrongmacauhoi = 1;
                    string cauhoicuoi = (from i in db.cauHois select i.ma).ToList().LastOrDefault();
                    if (cauhoicuoi != null)
                    {
                        sotrongmacauhoi = int.Parse(cauhoicuoi.Substring(2)) + 1;
                    }

                    if (ID.Substring(0, 2) == "HS")
                    {
                        LoaiCauHoi = "LUYENTAP";
                    }
                    else if (ID.Substring(0, 2) == "GV")
                    {
                        LoaiCauHoi = cbbLoaiCauHoi.SelectedValue.ToString();
                    }
                    //INSERT CAU HOI
                    db.cauHois.InsertOnSubmit(new cauHoi
                    {
                        ma = "CH" + sotrongmacauhoi.ToString("000"),
                        noiDung = txtNoiDungCauHoi.Text,
                        goiY = txtGoiY.Text,
                        maMonHoc = cbbMonHoc.SelectedValue.ToString(),
                        makhoi = cbbKhoi.SelectedValue.ToString(),
                        doKho = cbbDoKho.SelectedValue.ToString(),
                        loaiCauHoi = LoaiCauHoi
                    });
                    db.cauHoiLuyentaps.InsertOnSubmit(new cauHoiLuyentap
                    {
                        maCauHoi = "CH" + sotrongmacauhoi.ToString("000"),
                        daDuocDuyet = 0
                    });



                    //Tạo 1 list để insert nguyên 1 list đáp án
                    List<dapAnCauhoi> LSTDapAn = new List<dapAnCauhoi>();
                    dapAnCauhoi cauA = new dapAnCauhoi();

                    cauA.maCauHoi = "CH" + sotrongmacauhoi.ToString("000");

                    cauA.dapAn = ucA.NoiDung;
                    cauA.laDapAnDung = Convert.ToInt32(ucA.CheckBox);
                    LSTDapAn.Add(cauA);

                    dapAnCauhoi cauB = new dapAnCauhoi();
                    cauB.maCauHoi = "CH" + sotrongmacauhoi.ToString("000");
                    cauB.dapAn = ucB.NoiDung;
                    cauB.laDapAnDung = Convert.ToInt32(ucB.CheckBox);
                    LSTDapAn.Add(cauB);

                    dapAnCauhoi cauC = new dapAnCauhoi();

                    cauC.maCauHoi = "CH" + sotrongmacauhoi.ToString("000");

                    cauC.dapAn = ucC.NoiDung;
                    cauC.laDapAnDung = Convert.ToInt32(ucC.CheckBox);
                    LSTDapAn.Add(cauC);

                    dapAnCauhoi cauD = new dapAnCauhoi();

                    cauD.maCauHoi = "CH" + sotrongmacauhoi.ToString("000");

                    cauD.dapAn = ucD.NoiDung;
                    cauD.laDapAnDung = Convert.ToInt32(ucD.CheckBox);
                    LSTDapAn.Add(cauD);


                    if (ucE.Validator == true)
                    {
                        dapAnCauhoi cauE = new dapAnCauhoi();

                        cauE.maCauHoi = "CH" + sotrongmacauhoi.ToString("000");
                        cauE.dapAn = ucE.NoiDung;
                        cauE.laDapAnDung = Convert.ToInt32(ucE.CheckBox);
                        LSTDapAn.Add(cauE);
                    }
                    if (ucF.Validator == true)
                    {
                        dapAnCauhoi cauF = new dapAnCauhoi();
                        cauF.maCauHoi = "CH" + sotrongmacauhoi.ToString("000");
                        cauF.dapAn = ucF.NoiDung;
                        cauF.laDapAnDung = Convert.ToInt32(ucF.CheckBox);
                        LSTDapAn.Add(cauF);
                    }
                    db.dapAnCauhois.InsertAllOnSubmit(LSTDapAn);
                    db.SubmitChanges();
                    MessageBox.Show("Đóng góp thành công");

                    ucA.CheckBox = false;
                    ucB.CheckBox = false;
                    ucC.CheckBox = false;
                    ucD.CheckBox = false;
                    ucE.CheckBox = false;
                    ucF.CheckBox = false;
                    ucA.NoiDung = "";
                    ucB.NoiDung = "";
                    ucC.NoiDung = "";
                    ucD.NoiDung = "";
                    ucE.NoiDung = "";
                    ucF.NoiDung = "";
                    txtNoiDungCauHoi.Text = "";
                    txtGoiY.Text = "";
                }
                else
                {
                    MessageBox.Show("Câu hỏi phải có tối thiểu 4 đáp án");
                }
            }
        }

        private void DongGopCauHoi_Load(object sender, EventArgs e)
        {
            //Tạo giá trị cho combo box độ khó
            var cbbDokho = new Dictionary<int, string>();
            cbbDokho.Add(1, "Dễ");
            cbbDokho.Add(2, "Trung bình");
            cbbDokho.Add(3, "Khó");
            cbbDokho.Add(4, "Cực khó");

            cbbDoKho.DataSource = new BindingSource(cbbDokho, null);
            cbbDoKho.DisplayMember = "Value";
            cbbDoKho.ValueMember = "Key";


            //Nếu là học sinh thì ẩn ko cho chọn loại câu hỏi
            if (ID.Substring(0, 2) == "HS")
            {
                lblLoaiCauHoi.Hide();
                cbbLoaiCauHoi.Hide();
            }
            else
            {
                var ccbLoaicauhoi = new Dictionary<string, string>();
                ccbLoaicauhoi.Add("LUYENTAP", "Luyện tập");
                ccbLoaicauhoi.Add("THI", "Thi");

                cbbLoaiCauHoi.DataSource = new BindingSource(ccbLoaicauhoi, null);
                cbbLoaiCauHoi.DisplayMember = "Value";
                cbbLoaiCauHoi.ValueMember = "Key";
            }

            //Truy vấn để lấy giá trị cho combo box môn học v khối
            using (var db = new DoAnDataContext())
            {
                var monhoc = (from i in db.monHocs select i);

                cbbMonHoc.DataSource = monhoc.ToList();
                cbbMonHoc.ValueMember = "ma";
                cbbMonHoc.DisplayMember = "ten";


                var khoi = (from i in db.khois select i); 

                cbbKhoi.DataSource = khoi.ToList();
                cbbKhoi.ValueMember = "ma";
                cbbKhoi.DisplayMember = "ten";
            }
        }

        private void btnXemDanhSachCauHoiDongGop_Click(object sender, EventArgs e)
        {
            DanhSachCauHoiLuyenTap danhSachCauHoiLuyenTap = new DanhSachCauHoiLuyenTap();
            danhSachCauHoiLuyenTap.ShowDialog();
            this.Close();
        }
    }
}
