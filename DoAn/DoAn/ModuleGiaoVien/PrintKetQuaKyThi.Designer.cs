﻿namespace DoAn
{
    partial class PrintKetQuaKyThi
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
            this.ThongTinBangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinBangDiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongTinBangDiemBindingSource
            // 
            this.ThongTinBangDiemBindingSource.DataSource = typeof(DoAn.ThongTinBangDiem);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "KQKyThiDataset";
            reportDataSource1.Value = this.ThongTinBangDiemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn.Reposts.KetQuaKyThi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // PrintKetQuaKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintKetQuaKyThi";
            this.Text = "In kết quả kỳ thi";
            this.Load += new System.EventHandler(this.PrintKetQuaKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinBangDiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongTinBangDiemBindingSource;
    }
}