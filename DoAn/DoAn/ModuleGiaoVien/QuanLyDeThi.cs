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
    public partial class QuanLyDeThi : Form
    {
        RequiredFieldValidator RequiredFieldValidatorMaDe;
        RequiredFieldValidator RequiredFieldValidatorSoLuongCauHoi;
        RequiredFieldValidator RequiredFieldValidatorThoiGianLamBai;
        public QuanLyDeThi()
        {
            InitializeComponent();
            RequiredFieldValidatorMaDe = new RequiredFieldValidator();
            RequiredFieldValidatorMaDe.ControlToValidate = txtMaDe;

            RequiredFieldValidatorSoLuongCauHoi = new RequiredFieldValidator();
            RequiredFieldValidatorSoLuongCauHoi.ControlToValidate = txtSoLuongCauHoi;

            RequiredFieldValidatorThoiGianLamBai = new RequiredFieldValidator();
            RequiredFieldValidatorThoiGianLamBai.ControlToValidate = txtThoiGianLamBai;
        }

        private void QuanLyDeThi_Load(object sender, EventArgs e)
        {
            // Load giá trị cho cbb Monhoc
            using (var db = new DoAnDataContext())
            {

                cbbMonHoc.DataSource = db.monHocs.Select(i => i).ToList();
                cbbMonHoc.ValueMember = "ma";
                cbbMonHoc.DisplayMember = "ten";
            }
            //Tạo giá trị cho combobox khối
            var cbbkhoi = new Dictionary<string, string>();
            cbbkhoi.Add("K10", "10");
            cbbkhoi.Add("K11", "11");
            cbbkhoi.Add("K12", "12");

            cbbKhoi.DataSource = new BindingSource(cbbkhoi, null);
            cbbKhoi.DisplayMember = "Value";
            cbbKhoi.ValueMember = "Key";
        }

        private void btnTaoDe_Click(object sender, EventArgs e)
        {
            if (RequiredFieldValidatorMaDe.CheckValidate == true && RequiredFieldValidatorSoLuongCauHoi.CheckValidate == true &&
                RequiredFieldValidatorThoiGianLamBai.CheckValidate == true)
            {
                //thiếu if kt đã có trong csdl chưa
                using (var db = new DoAnDataContext())
                {
                    string makhoi = cbbKhoi.SelectedValue.ToString();
                    string temp = cbbMonHoc.SelectedValue.ToString();
                    db.deThis.InsertOnSubmit(new deThi
                    {
                        ma = makhoi + txtMaDe.Text.ToString(),
                        maMonHoc = cbbMonHoc.SelectedValue.ToString(),
                        slCauHoi = int.Parse(txtSoLuongCauHoi.Text.ToString()),
                        thoiGianLamBai_phut = int.Parse(txtThoiGianLamBai.Text.ToString())
                    });
                    db.SubmitChanges();
                    MessageBox.Show("Tạo đề thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnChinhSuaDe_Click(object sender, EventArgs e)
        {
            ChinhSuaDe frmquanLyDeThi = new ChinhSuaDe();
            frmquanLyDeThi.ShowDialog();
        }
    }
}
