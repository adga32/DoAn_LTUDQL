﻿namespace DoAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLamBai
            // 
            this.btnLamBai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamBai.Location = new System.Drawing.Point(102, 96);
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
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(102, 211);
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
            this.btnDongGopCauHoi.Location = new System.Drawing.Point(102, 439);
            this.btnDongGopCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongGopCauHoi.Name = "btnDongGopCauHoi";
            this.btnDongGopCauHoi.Size = new System.Drawing.Size(428, 49);
            this.btnDongGopCauHoi.TabIndex = 3;
            this.btnDongGopCauHoi.Text = "Đóng góp câu hỏi";
            this.btnDongGopCauHoi.UseVisualStyleBackColor = true;
            this.btnDongGopCauHoi.Click += new System.EventHandler(this.btnDongGopCauHoi_Click);
            // 
            // btnOnLuyenThiThu
            // 
            this.btnOnLuyenThiThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnLuyenThiThu.Location = new System.Drawing.Point(102, 324);
            this.btnOnLuyenThiThu.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnLuyenThiThu.Name = "btnOnLuyenThiThu";
            this.btnOnLuyenThiThu.Size = new System.Drawing.Size(428, 49);
            this.btnOnLuyenThiThu.TabIndex = 2;
            this.btnOnLuyenThiThu.Text = "Ôn luyện thi thử\r\n";
            this.btnOnLuyenThiThu.UseVisualStyleBackColor = true;
            this.btnOnLuyenThiThu.Click += new System.EventHandler(this.btnOnLuyenThiThu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(269, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Học sinh";
            // 
            // HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDongGopCauHoi);
            this.Controls.Add(this.btnOnLuyenThiThu);
            this.Controls.Add(this.btnThongTinCaNhan);
            this.Controls.Add(this.btnLamBai);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân hệ học sinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamBai;
        private System.Windows.Forms.Button btnThongTinCaNhan;
        private System.Windows.Forms.Button btnDongGopCauHoi;
        private System.Windows.Forms.Button btnOnLuyenThiThu;
        private System.Windows.Forms.Label label1;
    }
}