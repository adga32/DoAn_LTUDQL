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
    public partial class SuaChiTietCauHoi : Form
    {
        RequiredFieldValidator requiedNoiDungCauHoi;
        CauTraLoi[] listCtrlDapAn;

        string maCH;

        HienThiCauHoiTuCSDL.sendmessage sendmess;

        public SuaChiTietCauHoi(HienThiCauHoiTuCSDL.sendmessage sendmess, string maCauHoi)
        {
            InitializeComponent();
            this.sendmess = sendmess;
            maCH = maCauHoi;

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

            loadcauhoi();

        }

        public void loadcauhoi()
        {
            //đưa dữ liệu câu hỏi vào form 


            //load mon hoc, khoi
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

            // load cau hoi
            using (var db = new DoAnDataContext())
            {
                //lamda syntax
                var cauHoi = db.cauHois.Where(ch => ch.ma == maCH).Single();
                try
                {
                    txtNoiDungCauHoi.Text = cauHoi.noiDung;
                    txtGoiY.Text = cauHoi.goiY;
                    cbbDoKho.Text = cauHoi.doKho;
                    cbbKhoi.SelectedValue =  cauHoi.makhoi;
                    cbbMonHoc.SelectedValue = cauHoi.maMonHoc;
                    requiedNoiDungCauHoi.CheckValidate = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            //load dapan cau hoi
            using (var db = new DoAnDataContext())
            {
                //lamda syntax
                var dsDapAncauHoi = db.dapAnCauhois.Where(dsDA => dsDA.maCauHoi == maCH)
                    .Select(dach => new {
                        dapAn = dach.dapAn,
                        check = dach.laDapAnDung
                    }).ToList();
                try
                {
                    if(dsDapAncauHoi.Count > 3)
                    {
                        ucA.NoiDung = dsDapAncauHoi[0].dapAn;
                        ucB.NoiDung = dsDapAncauHoi[1].dapAn;
                        ucC.NoiDung = dsDapAncauHoi[2].dapAn;
                        ucD.NoiDung = dsDapAncauHoi[3].dapAn;

                        ucA.CheckBox = dsDapAncauHoi[0].check != 0;
                        ucB.CheckBox = dsDapAncauHoi[1].check != 0;
                        ucC.CheckBox = dsDapAncauHoi[2].check != 0;
                        ucD.CheckBox = dsDapAncauHoi[3].check != 0;

                        ucA.Validator = true;
                        ucB.Validator = true;
                        ucC.Validator = true;
                        ucD.Validator = true;

                    }
                    if (dsDapAncauHoi.Count > 4)
                    {
                        ucE.NoiDung = dsDapAncauHoi[4].dapAn;
                        ucE.CheckBox = dsDapAncauHoi[4].check != 0;
                    }
                    if (dsDapAncauHoi.Count > 5)
                    {
                        ucF.NoiDung = dsDapAncauHoi[5].dapAn;
                        ucF.CheckBox = dsDapAncauHoi[5].check != 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }




        private void button_luu_Click(object sender, EventArgs e)
        {
            using (DoAnDataContext db = new DoAnDataContext())
            {
                if (requiedNoiDungCauHoi.CheckValidate == true && ucA.Validator == true && ucB.Validator == true
                    && ucC.Validator == true && ucD.Validator == true)
                {
                    listCtrlDapAn = new CauTraLoi[] { ucA, ucB, ucC, ucD, ucE, ucF };
                    for (int i = 0; i < listCtrlDapAn.Count() - 1; i++)
                    {
                        for (int j = i + 1; j < listCtrlDapAn.Count(); j++)
                        {
                            if (listCtrlDapAn[i].NoiDung == listCtrlDapAn[j].NoiDung && listCtrlDapAn[i].NoiDung != "" && listCtrlDapAn[j].NoiDung != "")
                            {
                                MessageBox.Show("Đáp án không được trùng nhau");
                                return;
                            }
                        }
                    }

                    var listToRemove = (from a in db.dapAnCauhois
                                    where a.maCauHoi == maCH
                                    select a).ToList();

                db.dapAnCauhois.DeleteAllOnSubmit(listToRemove);
                db.SubmitChanges();

                    var CauHoiRemove = (from a in db.cauHois
                                        where a.ma == maCH
                                        select a).ToList();
                    db.cauHois.DeleteAllOnSubmit(CauHoiRemove);
                    db.SubmitChanges();

                    //insert cau hoi
                    db.cauHois.InsertOnSubmit(new cauHoi
                    {
                        ma = maCH,
                        noiDung = txtNoiDungCauHoi.Text,
                        goiY = txtGoiY.Text,
                        maMonHoc = cbbMonHoc.SelectedValue.ToString(),
                        makhoi = cbbKhoi.SelectedValue.ToString(),
                        doKho = cbbDoKho.Text.ToString()
                    }); ;


                //Tạo 1 list để insert nguyên 1 list
                List<dapAnCauhoi> LSTDapAn = new List<dapAnCauhoi>();
                dapAnCauhoi cauA = new dapAnCauhoi();

                cauA.maCauHoi = maCH;

                cauA.dapAn = ucA.NoiDung;
                cauA.laDapAnDung = Convert.ToInt32(ucA.CheckBox);
                LSTDapAn.Add(cauA);

                dapAnCauhoi cauB = new dapAnCauhoi();
                cauB.maCauHoi = maCH ;
                cauB.dapAn = ucB.NoiDung;
                cauB.laDapAnDung = Convert.ToInt32(ucB.CheckBox);
                LSTDapAn.Add(cauB);

                dapAnCauhoi cauC = new dapAnCauhoi();

                cauC.maCauHoi = maCH ;

                cauC.dapAn = ucC.NoiDung;
                cauC.laDapAnDung = Convert.ToInt32(ucC.CheckBox);
                LSTDapAn.Add(cauC);

                dapAnCauhoi cauD = new dapAnCauhoi();

                cauD.maCauHoi = maCH ;

                cauD.dapAn = ucD.NoiDung;
                cauD.laDapAnDung = Convert.ToInt32(ucD.CheckBox);
                LSTDapAn.Add(cauD);


                if (ucE.Validator == true)
                {
                    dapAnCauhoi cauE = new dapAnCauhoi();

                    cauE.maCauHoi = maCH ;
                    cauE.dapAn = ucE.NoiDung;
                    cauE.laDapAnDung = Convert.ToInt32(ucE.CheckBox);
                    LSTDapAn.Add(cauE);
                }
                if (ucF.Validator == true)
                {
                    dapAnCauhoi cauF = new dapAnCauhoi();
                    cauF.maCauHoi = maCH;
                    cauF.dapAn = ucF.NoiDung;
                    cauF.laDapAnDung = Convert.ToInt32(ucF.CheckBox);
                    LSTDapAn.Add(cauF);
                }
                db.dapAnCauhois.InsertAllOnSubmit(LSTDapAn);
                db.SubmitChanges();
                MessageBox.Show("update thang cong thành công");
                    this.sendmess();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Câu hỏi phải có tối thiểu 4 đáp án");
                }

            }
        }
    }
}
