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
    public partial class HocSinh : Form
    {
        string nguoidunghientai;
        public void LayNguoiDungHienTai(TextBox txtTenTaiKhoan)
        {
            nguoidunghientai = txtTenTaiKhoan.Text;
        }
        public delegate void NguoiDungHienTai(string userName);

        //delegate mục đích truyền dấu hiệu nhận biết là thi thật hay luyện tập tới form Làm bài trắc nghiệm 
        public delegate void LoaiHinhBaiThi(bool loaiBaiThi,string maDeThi); 

        public HocSinh()
        {
            InitializeComponent();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {   
            ThongTinHocSinh thongTinHocSinh = new ThongTinHocSinh();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(thongTinHocSinh.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);
            thongTinHocSinh.ShowDialog();
            this.Close();
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            //chưa xử lí nhận đề thi (đề thi này do giáo viên chọn)
            LamBaiTracNghiem lamBaiTracNghiem = new LamBaiTracNghiem();

            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(lamBaiTracNghiem.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);

            LoaiHinhBaiThi loai = new LoaiHinhBaiThi(lamBaiTracNghiem.ThongTinBaiThiTracNghiem);
            loai(true,"101");
            lamBaiTracNghiem.ShowDialog();
            this.Close();
        }

        private void btnOnLuyenThiThu_Click(object sender, EventArgs e)
        {
            OnLuyenThiThu frmOnLuyenThiThu = new OnLuyenThiThu();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(frmOnLuyenThiThu.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);
            frmOnLuyenThiThu.ShowDialog();
            this.Close();
        }

        private void btnDongGopCauHoi_Click(object sender, EventArgs e)
        {
            DongGopCauHoi frmDongGopCauHoi = new DongGopCauHoi();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(frmDongGopCauHoi.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);
            frmDongGopCauHoi.ShowDialog();
            this.Close();
        }
    }
}
