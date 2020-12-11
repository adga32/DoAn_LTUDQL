namespace DoAn
{
    partial class HocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLamBai = new System.Windows.Forms.Button();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.btnDongGopCauHoi = new System.Windows.Forms.Button();
            this.btnOnLuyenThiThu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLamBai
            // 
            this.btnLamBai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamBai.Location = new System.Drawing.Point(102, 64);
            this.btnLamBai.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamBai.Name = "btnLamBai";
            this.btnLamBai.Size = new System.Drawing.Size(428, 49);
            this.btnLamBai.TabIndex = 0;
            this.btnLamBai.Text = "Làm bài trắc nghiệm";
            this.btnLamBai.UseVisualStyleBackColor = true;
            this.btnLamBai.Click += new System.EventHandler(this.btnLamBai_Click);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(102, 179);
            this.btnThongTinCaNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(428, 49);
            this.btnThongTinCaNhan.TabIndex = 1;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnDongGopCauHoi
            // 
            this.btnDongGopCauHoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongGopCauHoi.Location = new System.Drawing.Point(102, 407);
            this.btnDongGopCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongGopCauHoi.Name = "btnDongGopCauHoi";
            this.btnDongGopCauHoi.Size = new System.Drawing.Size(428, 49);
            this.btnDongGopCauHoi.TabIndex = 3;
            this.btnDongGopCauHoi.Text = "Đóng góp câu hỏi";
            this.btnDongGopCauHoi.UseVisualStyleBackColor = true;
            // 
            // btnOnLuyenThiThu
            // 
            this.btnOnLuyenThiThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnLuyenThiThu.Location = new System.Drawing.Point(102, 292);
            this.btnOnLuyenThiThu.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnLuyenThiThu.Name = "btnOnLuyenThiThu";
            this.btnOnLuyenThiThu.Size = new System.Drawing.Size(428, 49);
            this.btnOnLuyenThiThu.TabIndex = 2;
            this.btnOnLuyenThiThu.Text = "Ôn luyện thi thử\r\n";
            this.btnOnLuyenThiThu.UseVisualStyleBackColor = true;
            // 
            // HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 547);
            this.Controls.Add(this.btnDongGopCauHoi);
            this.Controls.Add(this.btnOnLuyenThiThu);
            this.Controls.Add(this.btnThongTinCaNhan);
            this.Controls.Add(this.btnLamBai);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLamBai;
        private System.Windows.Forms.Button btnThongTinCaNhan;
        private System.Windows.Forms.Button btnDongGopCauHoi;
        private System.Windows.Forms.Button btnOnLuyenThiThu;
    }
}