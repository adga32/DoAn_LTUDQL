namespace DoAn
{
    partial class PrintDanhSachHS
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptVDsHocSinh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongTinBangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinBangDiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptVDsHocSinh
            // 
            reportDataSource1.Name = "DsHocSinhDataSet";
            reportDataSource1.Value = this.ThongTinBangDiemBindingSource;
            this.rptVDsHocSinh.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVDsHocSinh.LocalReport.ReportEmbeddedResource = "DoAn.Reposts.DsHocSinh.rdlc";
            this.rptVDsHocSinh.Location = new System.Drawing.Point(12, 12);
            this.rptVDsHocSinh.Name = "rptVDsHocSinh";
            this.rptVDsHocSinh.ServerReport.BearerToken = null;
            this.rptVDsHocSinh.Size = new System.Drawing.Size(856, 476);
            this.rptVDsHocSinh.TabIndex = 0;
            // 
            // ThongTinBangDiemBindingSource
            // 
            this.ThongTinBangDiemBindingSource.DataSource = typeof(DoAn.ThongTinBangDiem);
            // 
            // PrintDanhSachHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 500);
            this.Controls.Add(this.rptVDsHocSinh);
            this.Name = "PrintDanhSachHS";
            this.Text = "PrintDanhSachHS";
            this.Load += new System.EventHandler(this.PrintDanhSachHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinBangDiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVDsHocSinh;
        private System.Windows.Forms.BindingSource ThongTinBangDiemBindingSource;
    }
}