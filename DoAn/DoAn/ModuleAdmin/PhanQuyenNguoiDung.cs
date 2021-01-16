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
    public partial class PhanQuyenNguoiDung : MetroFramework.Forms.MetroForm
    {
        public PhanQuyenNguoiDung()
        {
            InitializeComponent();
            btnLuuPq.Click += BtnLuuPq_Click;

        }

        private void BtnLuuPq_Click(object sender, EventArgs e)
        {
            LuuPhanQuyenHS();
            LuuPhanQuyenGV();
            MessageBox.Show("Thiết lập quyền người dùng thành công","Phân quyền chức năng");
            return;
        }

        private void LuuPhanQuyenGV()
        {
            using (var db = new DoAnDataContext())
            {
                // update giáo viên
                for (int i = 0; i < dtgGV.Rows.Count; i++)
                {
                    string maPhanQuyen = "";
                    if ((bool)dtgGV.Rows[i].Cells["cn1"].Value == true)
                    {
                        maPhanQuyen = "1";
                    }
                    if ((bool)dtgGV.Rows[i].Cells["cn2"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-2";
                    }
                    if ((bool)dtgGV.Rows[i].Cells["cn3"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-3";
                    }
                    if ((bool)dtgGV.Rows[i].Cells["cn4"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-4";
                    }
                    if ((bool)dtgGV.Rows[i].Cells["cn5"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-5";
                    }
                    if ((bool)dtgGV.Rows[i].Cells["cn6"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-6";
                    }

                    string IDNguoiDung = dtgGV.Rows[i].Cells[0].Value.ToString();
                    PhanQuyenChucNang phanQuyen = new PhanQuyenChucNang();
                    phanQuyen = db.PhanQuyenChucNangs.Single(pq => pq.maNguoiDung == IDNguoiDung);

                    phanQuyen.quyenSuDung = maPhanQuyen;

                }
                db.SubmitChanges();
            }
        }

        private void LuuPhanQuyenHS()
        {
            using (var db = new DoAnDataContext())
            {
                // update học sinh
                for (int i = 0; i < dtgHS.Rows.Count; i++)
                {
                    string maPhanQuyen = "";
                    if ((bool)dtgHS.Rows[i].Cells["cn1"].Value == true)
                    {
                        maPhanQuyen = "1";
                    }
                    if ((bool)dtgHS.Rows[i].Cells["cn2"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-2";
                    }
                    if ((bool)dtgHS.Rows[i].Cells["cn3"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-3";
                    }
                    if ((bool)dtgHS.Rows[i].Cells["cn4"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-4";
                    }
                    if ((bool)dtgHS.Rows[i].Cells["cn4"].Value == true)
                    {
                        maPhanQuyen = maPhanQuyen + "-4";
                    }

                    string IDNguoiDung = dtgHS.Rows[i].Cells[0].Value.ToString();
                    PhanQuyenChucNang phanQuyen = new PhanQuyenChucNang();
                    phanQuyen = db.PhanQuyenChucNangs.Single(pq => pq.maNguoiDung == IDNguoiDung);

                    phanQuyen.quyenSuDung = maPhanQuyen;

                }
                db.SubmitChanges();
            }
        }

        private void PhanQuyenNguoiDung_Load(object sender, EventArgs e)
        {
            initDataGridHS();
            initDataGridGV();
        }

        private void initDataGridGV()
        {
            dtgGV.Columns.Clear();

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "magv";
            col1.HeaderText = "Mã giáo viên";
            col1.Width = 70;
            col1.ReadOnly = true;
            dtgGV.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "ten";
            col2.HeaderText = "Họ tên";
            col2.Width = 80;
            col2.ReadOnly = true;
            dtgGV.Columns.Add(col2);

            DataGridViewCheckBoxColumn col4 = new DataGridViewCheckBoxColumn();
            col4.Name = "cn1";
            col4.HeaderText = "Các chức năng của học sinh";
            col4.Width = 70;
            dtgGV.Columns.Add(col4);

            DataGridViewCheckBoxColumn col5 = new DataGridViewCheckBoxColumn();
            col5.Name = "cn2";
            col5.HeaderText = "Quản lý câu hỏi";
            col5.Width = 70;
            dtgGV.Columns.Add(col5);

            DataGridViewCheckBoxColumn col6 = new DataGridViewCheckBoxColumn();
            col6.Name = "cn3";
            col6.HeaderText = "Quản lý đề thi";
            col6.Width = 70;
            dtgGV.Columns.Add(col6);

            DataGridViewCheckBoxColumn col7 = new DataGridViewCheckBoxColumn();
            col7.Name = "cn4";
            col7.HeaderText = "Quản lý kỳ thi";
            col7.Width = 70;
            dtgGV.Columns.Add(col7);

            DataGridViewCheckBoxColumn col8 = new DataGridViewCheckBoxColumn();
            col8.Name = "cn5";
            col8.HeaderText = "Quản lý kỳ thi ôn tập";
            col8.Width = 70;
            dtgGV.Columns.Add(col8);

            DataGridViewCheckBoxColumn col9 = new DataGridViewCheckBoxColumn();
            col9.Name = "cn6";
            col9.HeaderText = "Quản lý học sinh";
            col9.Width = 70;
            dtgGV.Columns.Add(col9);

            using (var db = new DoAnDataContext())
            {
                var DSPhanQuyenGiaoVien = db.giaoViens.Join(db.PhanQuyenChucNangs, gv => gv.ma, pq => pq.maNguoiDung, (gv, pq) => new { gv, pq })
                                .Select(pq => new
                                {
                                    maGV = pq.gv.ma,
                                    Ten = pq.gv.ten,
                                    maPhanQuyen = pq.pq.quyenSuDung
                                }).ToList();

                for (int i = 0; i < DSPhanQuyenGiaoVien.Count(); i++)
                {
                    bool[] arrChucNang = new bool[20];
                    //đọc dữ liệu từ mã phân quyền
                    string[] arrPhanQuyen = DSPhanQuyenGiaoVien[i].maPhanQuyen.Split('-');
                    for (int count1 = 0; count1 < arrPhanQuyen.Count(); count1++)
                    {
                        int index;
                        if (int.TryParse(arrPhanQuyen[count1], out index))
                        {
                            arrChucNang[(index - 1)] = true;
                        }
                    }

                    dtgGV.Rows.Add(DSPhanQuyenGiaoVien[i].maGV, DSPhanQuyenGiaoVien[i].Ten, arrChucNang[0], arrChucNang[1], arrChucNang[2], arrChucNang[3], arrChucNang[4], arrChucNang[5]);
                }
            }
        }


        private void initDataGridHS()
        {
            dtgHS.Columns.Clear();

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "masv";
            col1.HeaderText = "Mã học sinh";
            col1.Width = 70;
            col1.ReadOnly = true;
            dtgHS.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "ten";
            col2.HeaderText = "Tên học sinh";
            col2.Width = 80;
            col2.ReadOnly = true;
            dtgHS.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "lop";
            col3.HeaderText = "Lớp";
            col3.Width = 50;
            col3.ReadOnly = true;
            dtgHS.Columns.Add(col3);

            DataGridViewCheckBoxColumn col4 = new DataGridViewCheckBoxColumn();
            col4.Name = "cn1";
            col4.HeaderText = "Làm bài trắc nghiệm";
            col4.Width = 70;
            dtgHS.Columns.Add(col4);

            DataGridViewCheckBoxColumn col5 = new DataGridViewCheckBoxColumn();
            col5.Name = "cn2";
            col5.HeaderText = "Thông tin cá nhân";
            col5.Width = 70;
            dtgHS.Columns.Add(col5);

            DataGridViewCheckBoxColumn col6 = new DataGridViewCheckBoxColumn();
            col6.Name = "cn3";
            col6.HeaderText = "Ôn luyện thi thử";
            col6.Width = 70;
            dtgHS.Columns.Add(col6);

            DataGridViewCheckBoxColumn col7 = new DataGridViewCheckBoxColumn();
            col7.Name = "cn4";
            col7.HeaderText = "Đóng góp câu hỏi";
            col7.Width = 70;
            dtgHS.Columns.Add(col7);


            using (var db = new DoAnDataContext())
            {
                var DSPhanQuyenHocSinh = db.hocSinhs.Join(db.PhanQuyenChucNangs, hs => hs.ma, pq => pq.maNguoiDung, (hs, pq) => new { hs, pq })
                                        .Select(pq => new
                                        {
                                            MaHS = pq.hs.ma,
                                            Ten = pq.hs.ten,
                                            Lop = pq.hs.maLop,
                                            maPhanQuyen = pq.pq.quyenSuDung.ToString()
                                        }).ToList();

                for (int i = 0; i < DSPhanQuyenHocSinh.Count(); i++)
                {

                    bool[] arrChucNang = new bool[20]; // mảng chứa vị tri các chức năng tương ứng

                    //đọc dữ liệu từ mã phân quyền
                    string[] arrPhanQuyen = DSPhanQuyenHocSinh[i].maPhanQuyen.Split('-');

                    for (int count1 = 0; count1 < arrPhanQuyen.Count(); count1++)
                    {
                        int index;
                        if(int.TryParse(arrPhanQuyen[count1],out index))
                        {
                            arrChucNang[(index-1)] = true;
                        }
                      
                    }

                    dtgHS.Rows.Add(DSPhanQuyenHocSinh[i].MaHS, DSPhanQuyenHocSinh[i].Ten, DSPhanQuyenHocSinh[i].Lop, arrChucNang[0], arrChucNang[1], arrChucNang[2], arrChucNang[3]);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
