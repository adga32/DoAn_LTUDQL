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
        Button[] arrBtn;

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

            //mang chua cac button
            arrBtn = new Button[] { btnLamBai, btnThongTinCaNhan, btnOnLuyenThiThu, btnDongGopCauHoi };

            this.Load += HocSinh_Load;
        }

        private void HocSinh_Load(object sender, EventArgs e)
        {
            bool[] arrChucNang = new bool[20]; // mảng chứa vị tri các chức năng tương ứng

            using (var db = new DoAnDataContext())
            {
                var IDhocSinh = db.taiKhoans.Where(tk => tk.username == nguoidunghientai)
                               .Select(tk => tk.idNguoiSoHuu).FirstOrDefault();

                var maPhanQuyenCuaHS = db.PhanQuyenChucNangs.Where(pq => pq.maNguoiDung == IDhocSinh)
                                .Select(pq => pq.quyenSuDung).FirstOrDefault();

                //đọc dữ liệu từ mã phân quyền
                string[] arrPhanQuyen = maPhanQuyenCuaHS.Split('-');

                //gán dữ liệu true/false tương ứng vào mảng arrChucNang
                for (int count1 = 0; count1 < arrPhanQuyen.Count(); count1++)
                {
                    int index;
                    if (int.TryParse(arrPhanQuyen[count1], out index))
                    {
                        arrChucNang[(index - 1)] = true;
                    }

                }

                //thiết lập các button với các chức năng tương ứng
                for(int count2=0;count2<arrBtn.Count();count2++)
                {
                    arrBtn[count2].Enabled = arrChucNang[count2];
                }
            }
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {   
            ThongTinHocSinh thongTinHocSinh = new ThongTinHocSinh();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(thongTinHocSinh.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);
            thongTinHocSinh.Show();
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            Thi frmThiTracNghiem = new Thi();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(frmThiTracNghiem.layNguoiDungHienTai);
            nguoiDungHienTai(nguoidunghientai);
            frmThiTracNghiem.Show();
  
        }

        private void btnOnLuyenThiThu_Click(object sender, EventArgs e)
        {
            OnLuyenThiThu frmOnLuyenThiThu = new OnLuyenThiThu();
            NguoiDungHienTai nguoiDungHienTai = new NguoiDungHienTai(frmOnLuyenThiThu.LayNguoiDungHienTai);
            nguoiDungHienTai(this.nguoidunghientai);
            frmOnLuyenThiThu.Show();
  
        }

        private void btnDongGopCauHoi_Click(object sender, EventArgs e)
        {
            DongGopCauHoi frmDongGopCauHoi = new DongGopCauHoi();
            NguoiDungHienTai layNguoiDungHienTai = new NguoiDungHienTai(frmDongGopCauHoi.LayNguoiDungHienTai);
            layNguoiDungHienTai(nguoidunghientai);
            frmDongGopCauHoi.Show();

        }
    }
}
