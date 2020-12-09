using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class DangNhap : Form
    {
        static string[] arrHexa = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        public DangNhap()
        {
            InitializeComponent();


            var requiedTenDangNhap = new RequiredFieldValidator();
            requiedTenDangNhap.ControlToValidate = txtTenTaiKhoan;
            var requiedMatKhau = new RequiredFieldValidator();
            requiedMatKhau.ControlToValidate = txtMatKhau;

            var regexTenTaiKhoan = new RegExValidator();
            regexTenTaiKhoan.RegexStr = @"^[a-zA-Z]([a-zA-z0-9-_.]{6,15})$";
            regexTenTaiKhoan.ErrorMessage = "Ten tai khoan bat dau tu a-z hoac A-Z oi thieu 7 ki tu va khong co ki tu dac biet tru(-,.,_)";
            regexTenTaiKhoan.ControlToValidate = txtTenTaiKhoan;


            var regexMatKhau = new RegExValidator();
            regexMatKhau.RegexStr = @"^[\w](\w{5,20})$";
            regexMatKhau.ErrorMessage = "Mat khau toi thieu phai co 6 ki tu";
            regexMatKhau.ControlToValidate = txtMatKhau;


        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                btnPass.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            using (var db = new DoAnDataContext())
            {
                var user = (from i in db.taiKhoans where i.username == txtTenTaiKhoan.Text select i).FirstOrDefault();
                if (user != null)
                {
                    if (txtMatKhau.Text.Length > 0)
                    {
                        var sha1 = new SHA1CryptoServiceProvider();
                        var bytesPwhashSalt = StringToByteArray(user._password);
                        //SHA1 hash -> 20 byte => bytesPwhashSalt - 20 = byteSalt
                        var LenPwhash = 20;
                        var bytesPwhash = new byte[LenPwhash];
                        Array.Copy(bytesPwhashSalt, bytesPwhash, LenPwhash);

                        //hash password user input
                        var PwUserInput = Encoding.ASCII.GetBytes(txtMatKhau.Text);
                        var bytesPwUserHash = sha1.ComputeHash(PwUserInput);


                        var strPwhash = ArrByteToString(bytesPwhash);
                        var strPwUserIpHash = ArrByteToString(bytesPwUserHash);

                        if (strPwhash == strPwUserIpHash)
                        {
                            if(user.quyenNguoiDung==1)
                            {
                                this.Hide();
                                HocSinh hs = new HocSinh();
                                hs.Show();
                            }
                            else if(user.quyenNguoiDung==2)
                            {
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai pass");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại");
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangky = new DangKy();
            dangky.Show();
        }
        public string ArrByteToString(Byte[] arrByte)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte b in arrByte)
            {
                //get 4 bit first
                sb.Append(arrHexa[(b >> 4)]);
                //get 4 bit second
                sb.Append(arrHexa[(b & 15)]);
            }

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            return Enumerable.Range(0, str.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(str.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}