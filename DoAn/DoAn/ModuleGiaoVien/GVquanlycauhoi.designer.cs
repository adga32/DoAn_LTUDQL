
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
            this.BTTExportDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_layDulieuTuExcel
            // 
            this.button_layDulieuTuExcel.Location = new System.Drawing.Point(218, 78);
            this.button_layDulieuTuExcel.Margin = new System.Windows.Forms.Padding(4);
            this.button_layDulieuTuExcel.Name = "button_layDulieuTuExcel";
            this.button_layDulieuTuExcel.Size = new System.Drawing.Size(240, 82);
            this.button_layDulieuTuExcel.TabIndex = 0;
            this.button_layDulieuTuExcel.Text = "Lấy Dữ liệu Excel Có sẳn";
            this.button_layDulieuTuExcel.UseVisualStyleBackColor = true;
            this.button_layDulieuTuExcel.Click += new System.EventHandler(this.button_layDulieuTuExcel_Click);
            // 
            // button_HienThiCauHoiTuCSDL
            // 
            this.button_HienThiCauHoiTuCSDL.Location = new System.Drawing.Point(218, 185);
            this.button_HienThiCauHoiTuCSDL.Margin = new System.Windows.Forms.Padding(4);
            this.button_HienThiCauHoiTuCSDL.Name = "button_HienThiCauHoiTuCSDL";
            this.button_HienThiCauHoiTuCSDL.Size = new System.Drawing.Size(240, 82);
            this.button_HienThiCauHoiTuCSDL.TabIndex = 1;
            this.button_HienThiCauHoiTuCSDL.Text = "Hiển thị câu hỏi từ CSDL";
            this.button_HienThiCauHoiTuCSDL.UseVisualStyleBackColor = true;
            this.button_HienThiCauHoiTuCSDL.Click += new System.EventHandler(this.button_HienThiCauHoiTuCSDL_Click);
            // 
            // button_DuyetCauHOiDongGop
            // 
            this.button_DuyetCauHOiDongGop.Location = new System.Drawing.Point(218, 294);
            this.button_DuyetCauHOiDongGop.Margin = new System.Windows.Forms.Padding(4);
            this.button_DuyetCauHOiDongGop.Name = "button_DuyetCauHOiDongGop";
            this.button_DuyetCauHOiDongGop.Size = new System.Drawing.Size(240, 82);
            this.button_DuyetCauHOiDongGop.TabIndex = 2;
            this.button_DuyetCauHOiDongGop.Text = "Duyệt câu hỏi";
            this.button_DuyetCauHOiDongGop.UseVisualStyleBackColor = true;
            this.button_DuyetCauHOiDongGop.Click += new System.EventHandler(this.button_DuyetCauHOiDongGop_Click);
            // 
            // buttonXemCauHoiTrongDeThiNao
            // 
            this.buttonXemCauHoiTrongDeThiNao.Location = new System.Drawing.Point(218, 402);
            this.buttonXemCauHoiTrongDeThiNao.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXemCauHoiTrongDeThiNao.Name = "buttonXemCauHoiTrongDeThiNao";
            this.buttonXemCauHoiTrongDeThiNao.Size = new System.Drawing.Size(240, 82);
            this.buttonXemCauHoiTrongDeThiNao.TabIndex = 3;
            this.buttonXemCauHoiTrongDeThiNao.Text = "Xem câu hỏi đã trong kỳ thi nào ";
            this.buttonXemCauHoiTrongDeThiNao.UseVisualStyleBackColor = true;
            this.buttonXemCauHoiTrongDeThiNao.Click += new System.EventHandler(this.buttonXemCauHoiTrongDeThiNao_Click);
            // 
            // BTTExportDatabase
            // 
            this.BTTExportDatabase.Location = new System.Drawing.Point(218, 509);
            this.BTTExportDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.BTTExportDatabase.Name = "BTTExportDatabase";
            this.BTTExportDatabase.Size = new System.Drawing.Size(240, 82);
            this.BTTExportDatabase.TabIndex = 4;
            this.BTTExportDatabase.Text = "Export Dữ liệu câu hỏi vào Excel";
            this.BTTExportDatabase.UseVisualStyleBackColor = true;
            this.BTTExportDatabase.Click += new System.EventHandler(this.BTTExportDatabase_Click);
            // 
            // GVquanlycauhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 633);
            this.Controls.Add(this.BTTExportDatabase);
            this.Controls.Add(this.buttonXemCauHoiTrongDeThiNao);
            this.Controls.Add(this.button_DuyetCauHOiDongGop);
            this.Controls.Add(this.button_HienThiCauHoiTuCSDL);
            this.Controls.Add(this.button_layDulieuTuExcel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GVquanlycauhoi";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Quản lí câu hỏi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_layDulieuTuExcel;
        private System.Windows.Forms.Button button_HienThiCauHoiTuCSDL;
        private System.Windows.Forms.Button button_DuyetCauHOiDongGop;
        private System.Windows.Forms.Button buttonXemCauHoiTrongDeThiNao;
        private System.Windows.Forms.Button BTTExportDatabase;
    }
}