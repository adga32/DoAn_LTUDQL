﻿
namespace DoAn
{
    partial class GVquanlycauhoi
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
            this.button_layDulieuTuExcel = new System.Windows.Forms.Button();
            this.button_HienThiCauHoiTuCSDL = new System.Windows.Forms.Button();
            this.button_DuyetCauHOiDongGop = new System.Windows.Forms.Button();
            this.buttonXemCauHoiTrongDeThiNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_layDulieuTuExcel
            // 
            this.button_layDulieuTuExcel.Location = new System.Drawing.Point(33, 29);
            this.button_layDulieuTuExcel.Name = "button_layDulieuTuExcel";
            this.button_layDulieuTuExcel.Size = new System.Drawing.Size(75, 67);
            this.button_layDulieuTuExcel.TabIndex = 0;
            this.button_layDulieuTuExcel.Text = "Lấy Dữ liệu Excel Có sẳn";
            this.button_layDulieuTuExcel.UseVisualStyleBackColor = true;
            this.button_layDulieuTuExcel.Click += new System.EventHandler(this.button_layDulieuTuExcel_Click);
            // 
            // button_HienThiCauHoiTuCSDL
            // 
            this.button_HienThiCauHoiTuCSDL.Location = new System.Drawing.Point(142, 29);
            this.button_HienThiCauHoiTuCSDL.Name = "button_HienThiCauHoiTuCSDL";
            this.button_HienThiCauHoiTuCSDL.Size = new System.Drawing.Size(75, 67);
            this.button_HienThiCauHoiTuCSDL.TabIndex = 1;
            this.button_HienThiCauHoiTuCSDL.Text = "Hien Thi CauHoi Tu CSDL";
            this.button_HienThiCauHoiTuCSDL.UseVisualStyleBackColor = true;
            this.button_HienThiCauHoiTuCSDL.Click += new System.EventHandler(this.button_HienThiCauHoiTuCSDL_Click);
            // 
            // button_DuyetCauHOiDongGop
            // 
            this.button_DuyetCauHOiDongGop.Location = new System.Drawing.Point(263, 29);
            this.button_DuyetCauHOiDongGop.Name = "button_DuyetCauHOiDongGop";
            this.button_DuyetCauHOiDongGop.Size = new System.Drawing.Size(75, 67);
            this.button_DuyetCauHOiDongGop.TabIndex = 2;
            this.button_DuyetCauHOiDongGop.Text = "Duyet Cau hoi";
            this.button_DuyetCauHOiDongGop.UseVisualStyleBackColor = true;
            this.button_DuyetCauHOiDongGop.Click += new System.EventHandler(this.button_DuyetCauHOiDongGop_Click);
            // 
            // buttonXemCauHoiTrongDeThiNao
            // 
            this.buttonXemCauHoiTrongDeThiNao.Location = new System.Drawing.Point(373, 29);
            this.buttonXemCauHoiTrongDeThiNao.Name = "buttonXemCauHoiTrongDeThiNao";
            this.buttonXemCauHoiTrongDeThiNao.Size = new System.Drawing.Size(75, 67);
            this.buttonXemCauHoiTrongDeThiNao.TabIndex = 3;
            this.buttonXemCauHoiTrongDeThiNao.Text = "Xem câu hỏi đã trong kỳ thi nào ";
            this.buttonXemCauHoiTrongDeThiNao.UseVisualStyleBackColor = true;
            this.buttonXemCauHoiTrongDeThiNao.Click += new System.EventHandler(this.buttonXemCauHoiTrongDeThiNao_Click);
            // 
            // GVquanlycauhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonXemCauHoiTrongDeThiNao);
            this.Controls.Add(this.button_DuyetCauHOiDongGop);
            this.Controls.Add(this.button_HienThiCauHoiTuCSDL);
            this.Controls.Add(this.button_layDulieuTuExcel);
            this.Name = "GVquanlycauhoi";
            this.Text = "GVquanlycauhoi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_layDulieuTuExcel;
        private System.Windows.Forms.Button button_HienThiCauHoiTuCSDL;
        private System.Windows.Forms.Button button_DuyetCauHOiDongGop;
        private System.Windows.Forms.Button buttonXemCauHoiTrongDeThiNao;
    }
}