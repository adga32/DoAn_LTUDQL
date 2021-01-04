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
    public partial class DangKy : Form
    {
        static string[] arrHexa = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        RequiredFieldValidator requiedMaNguoiDung = new RequiredFieldValidator();
        RequiredFieldValidator requiedTenDangNhap = new RequiredFieldValidator();
        RequiredFieldValidator requiedMatKhau = new RequiredFieldValidator();
        RequiredFieldValidator requiedConfirmPass = new RequiredFieldValidator();
        RegExValidator regexTenTaiKhoan = new RegExValidator();
        RegExValidator regexMatKhau = new RegExValidator();
        public DangKy()
        {
            InitializeComponent();
           
            requiedMaNguoiDung.ControlToValidate = txtMaNguoiDung;

           
            requiedTenDangNhap.ControlToValidate = txtTenTaiKhoan;

            
            requiedMatKhau.ControlToValidate = txtMatKhau;

           
            requiedConfirmPass.ControlToValidate = txtConfirmPass;

           
            regexTenTaiKhoan.RegexStr = @"^[a-zA-Z]([a-zA-z0-9-_.]{6,15})$";
            regexTenTaiKhoan.ErrorMessage = "Tên tài khoản bắt đầu từ a-z hoặc A-Z tối thiểu 7 kí tự và không có kí tự đặc biệt trừ(-,.,_)";
            regexTenTaiKhoan.ControlToValidate = txtTenTaiKhoan;


            
            regexMatKhau.RegexStr = @"^[\w](\w{5,20})$";
            regexMatKhau.ErrorMessage = "Mật khẩu phải có tối thiểu 6 kí tự";
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

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '*')
            {
                btnHideConfirmPass.BringToFront();
                txtConfirmPass.PasswordChar = '\0';
            }
        }

        private void btnHideConfirmPass_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '\0')
            {
                btnConfirmPass.BringToFront();
                txtConfirmPass.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (requiedTenDangNhap.CheckValidate == true && requiedMatKhau.CheckValidate == true && regexTenTaiKhoan.CheckValidate == true && regexMatKhau.CheckValidate == true)
            {
                var MaNguoiDung = txtMaNguoiDung.Text;
                var Username = txtTenTaiKhoan.Text;
                var password = txtMatKhau.Text;
                var confirmPass = txtConfirmPass.Text;

                var sha1 = new SHA1CryptoServiceProvider();
                var bytesPw = Encoding.ASCII.GetBytes(password);
                //salt
                var salt = DateTime.Now.Millisecond.ToString();
                var bytesSalt = Encoding.ASCII.GetBytes(salt);

                //
                //hash
                var bytesPwhashed = sha1.ComputeHash(bytesPw);

                //gắn salt lưu xuống database
                var bytesResult = new byte[bytesPwhashed.Length + bytesSalt.Length];
                Array.Copy(bytesPwhashed, bytesResult, bytesPwhashed.Length);
                Array.Copy(bytesSalt, 0, bytesResult, bytesPwhashed.Length, bytesSalt.Length);


                var strPwHash = ArrByteToString(bytesResult);
                using (var db = new DoAnDataContext())
                {
                    if (password.Equals(confirmPass))
                    {
                        var nguoidung = (from i in db.NguoiDungs where i.manguoidung == MaNguoiDung select i).FirstOrDefault();
                        if (nguoidung != null)
                        {
                            var p = (from i in db.taiKhoans where i.username == txtTenTaiKhoan.Text select i).FirstOrDefault();
                            //
                            var q = (from i in db.taiKhoans where i.idNguoiSoHuu == MaNguoiDung select i).Count();
                            if (q == 0)
                            {
                                if (p == null)
                                {
                                    db.taiKhoans.InsertOnSubmit(new taiKhoan
                                    {
                                        username = Username,
                                        _password = strPwHash,
                                        idNguoiSoHuu = MaNguoiDung,
                                    });
                                    if (MaNguoiDung.Substring(0, 2) == "HS")
                                    {
                                        db.hocSinhs.InsertOnSubmit(new hocSinh
                                        {
                                            ma = MaNguoiDung
                                        });

                                        //lưu phân quyền
                                        db.PhanQuyenChucNangs.InsertOnSubmit(new PhanQuyenChucNang
                                        {
                                            maNguoiDung = MaNguoiDung,
                                            quyenSuDung = "1-2-3-4"
                                        });
                                    }
                                    else if (MaNguoiDung.Substring(0, 2) == "GV")
                                    {
                                        db.giaoViens.InsertOnSubmit(new giaoVien
                                        {
                                            ma = MaNguoiDung
                                        });

                                        //lưu phân quyền
                                        db.PhanQuyenChucNangs.InsertOnSubmit(new PhanQuyenChucNang
                                        {
                                            maNguoiDung = MaNguoiDung,
                                            quyenSuDung = "1-2-3-4-5-6"
                                        });
                                    }
                                    else
                                    {
                                        db.adminns.InsertOnSubmit(new adminn
                                        {
                                            ma = MaNguoiDung
                                        });
                                    }
                                    db.SubmitChanges();
                                    MessageBox.Show("Đăng ký thành công");
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Tên tài khoản đã tồn tại");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Người dùng này đã có tài khoản");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã người dùng không hợp lệ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác thực lại không trùng khớp");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản và mật khẩu phải đúng định dạng");
            }
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
    }
}
