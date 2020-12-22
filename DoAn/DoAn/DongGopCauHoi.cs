﻿using System;
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
        RequiredFieldValidator requiedNoiDungCauHoi;
        public DongGopCauHoi()
        {
            InitializeComponent();
            ucA.Readonly = false;
            ucB.Readonly = false;
            ucC.Readonly = false;
            ucD.Readonly = false;
            ucE.Readonly = false;
            ucF.Readonly = false;

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
                    int sotrongmacauhoi = 1;
                    string cauhoicuoi = (from i in db.cauHois select i.ma).ToList().LastOrDefault();
                    if (cauhoicuoi != null)
                    {
                        sotrongmacauhoi = int.Parse(cauhoicuoi.Substring(2)) + 1;
                    }

                    //insert cau hoi
                    db.cauHois.InsertOnSubmit(new cauHoi
                    {
                        ma = "CH" + sotrongmacauhoi.ToString("000"),
                        noiDung = txtNoiDungCauHoi.Text,
                        goiY = txtGoiY.Text,
                        maMonHoc = cbbMonHoc.SelectedValue.ToString(),
                        makhoi = cbbKhoi.SelectedValue.ToString()

                    });
                    db.cauHoiLuyentaps.InsertOnSubmit(new cauHoiLuyentap
                    {
                        maCauHoi = "CH" + sotrongmacauhoi.ToString("000"),
                        daDuocDuyet = 0
                    });
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

        private void btnXenDanhSachCauHoiDongGop_Click(object sender, EventArgs e)
        {
            DanhSachCauHoiLuyenTap danhSachCauHoiLuyenTap = new DanhSachCauHoiLuyenTap();
            danhSachCauHoiLuyenTap.ShowDialog();
            this.Close();
        }
    }
}
