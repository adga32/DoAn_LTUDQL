namespace DoAn
{
    partial class LamBaiTracNghiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LamBaiTracNghiem));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblSoCauDaHoanThanh = new System.Windows.Forms.Label();
            this.lblHienThiCauDaHoanThanh = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.lblVitri = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.ucF = new DoAn.CauTraLoi();
            this.ucE = new DoAn.CauTraLoi();
            this.ucD = new DoAn.CauTraLoi();
            this.ucC = new DoAn.CauTraLoi();
            this.ucB = new DoAn.CauTraLoi();
            this.ucA = new DoAn.CauTraLoi();
            this.txtNoiDungCauHoi = new System.Windows.Forms.TextBox();
            this.lblThoiGianConLai = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMaDe = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblSoCauDaHoanThanh);
            this.splitContainer1.Panel1.Controls.Add(this.lblMonHoc);
            this.splitContainer1.Panel1.Controls.Add(this.lblMaDe);
            this.splitContainer1.Panel1.Controls.Add(this.lblHienThiCauDaHoanThanh);
            this.splitContainer1.Panel1.Controls.Add(this.lblThoiGian);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnNopBai);
            this.splitContainer1.Panel2.Controls.Add(this.lblVitri);
            this.splitContainer1.Panel2.Controls.Add(this.btnRight);
            this.splitContainer1.Panel2.Controls.Add(this.btnLeft);
            this.splitContainer1.Panel2.Controls.Add(this.ucF);
            this.splitContainer1.Panel2.Controls.Add(this.ucE);
            this.splitContainer1.Panel2.Controls.Add(this.ucD);
            this.splitContainer1.Panel2.Controls.Add(this.ucC);
            this.splitContainer1.Panel2.Controls.Add(this.ucB);
            this.splitContainer1.Panel2.Controls.Add(this.ucA);
            this.splitContainer1.Panel2.Controls.Add(this.txtNoiDungCauHoi);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 722);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblSoCauDaHoanThanh
            // 
            this.lblSoCauDaHoanThanh.AutoSize = true;
            this.lblSoCauDaHoanThanh.Location = new System.Drawing.Point(617, 22);
            this.lblSoCauDaHoanThanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoCauDaHoanThanh.Name = "lblSoCauDaHoanThanh";
            this.lblSoCauDaHoanThanh.Size = new System.Drawing.Size(46, 22);
            this.lblSoCauDaHoanThanh.TabIndex = 2;
            this.lblSoCauDaHoanThanh.Text = "0/60";
            // 
            // lblHienThiCauDaHoanThanh
            // 
            this.lblHienThiCauDaHoanThanh.AutoSize = true;
            this.lblHienThiCauDaHoanThanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiCauDaHoanThanh.Location = new System.Drawing.Point(415, 22);
            this.lblHienThiCauDaHoanThanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHienThiCauDaHoanThanh.Name = "lblHienThiCauDaHoanThanh";
            this.lblHienThiCauDaHoanThanh.Size = new System.Drawing.Size(186, 22);
            this.lblHienThiCauDaHoanThanh.TabIndex = 1;
            this.lblHienThiCauDaHoanThanh.Text = "Số câu đã hoàn thành: ";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(791, 22);
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(156, 22);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "Thời gian còn lại: ";
            // 
            // btnNopBai
            // 
            this.btnNopBai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.Location = new System.Drawing.Point(471, 531);
            this.btnNopBai.Margin = new System.Windows.Forms.Padding(4);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(124, 44);
            this.btnNopBai.TabIndex = 10;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = true;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // lblVitri
            // 
            this.lblVitri.AutoSize = true;
            this.lblVitri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitri.Location = new System.Drawing.Point(491, 491);
            this.lblVitri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVitri.Name = "lblVitri";
            this.lblVitri.Size = new System.Drawing.Size(82, 22);
            this.lblVitri.TabIndex = 9;
            this.lblVitri.Text = "Câu 1/60";
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRight.BackgroundImage")));
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRight.Location = new System.Drawing.Point(909, 478);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 52);
            this.btnRight.TabIndex = 8;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeft.BackgroundImage")));
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeft.Location = new System.Drawing.Point(48, 478);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 52);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // ucF
            // 
            this.ucF.CheckBox = false;
            this.ucF.Location = new System.Drawing.Point(583, 368);
            this.ucF.Margin = new System.Windows.Forms.Padding(5);
            this.ucF.Name = "ucF";
            this.ucF.NoiDung = "";
            this.ucF.Size = new System.Drawing.Size(427, 70);
            this.ucF.TabIndex = 6;
            this.ucF.Validator = false;
            // 
            // ucE
            // 
            this.ucE.CheckBox = false;
            this.ucE.Location = new System.Drawing.Point(48, 368);
            this.ucE.Margin = new System.Windows.Forms.Padding(5);
            this.ucE.Name = "ucE";
            this.ucE.NoiDung = "";
            this.ucE.Size = new System.Drawing.Size(427, 70);
            this.ucE.TabIndex = 5;
            this.ucE.Validator = false;
            // 
            // ucD
            // 
            this.ucD.CheckBox = false;
            this.ucD.Location = new System.Drawing.Point(583, 267);
            this.ucD.Margin = new System.Windows.Forms.Padding(5);
            this.ucD.Name = "ucD";
            this.ucD.NoiDung = "";
            this.ucD.Size = new System.Drawing.Size(427, 70);
            this.ucD.TabIndex = 4;
            this.ucD.Validator = false;
            // 
            // ucC
            // 
            this.ucC.CheckBox = false;
            this.ucC.Location = new System.Drawing.Point(48, 267);
            this.ucC.Margin = new System.Windows.Forms.Padding(5);
            this.ucC.Name = "ucC";
            this.ucC.NoiDung = "";
            this.ucC.Size = new System.Drawing.Size(427, 70);
            this.ucC.TabIndex = 3;
            this.ucC.Validator = false;
            // 
            // ucB
            // 
            this.ucB.CheckBox = false;
            this.ucB.Location = new System.Drawing.Point(583, 161);
            this.ucB.Margin = new System.Windows.Forms.Padding(5);
            this.ucB.Name = "ucB";
            this.ucB.NoiDung = "";
            this.ucB.Size = new System.Drawing.Size(427, 70);
            this.ucB.TabIndex = 2;
            this.ucB.Validator = false;
            // 
            // ucA
            // 
            this.ucA.CheckBox = false;
            this.ucA.Location = new System.Drawing.Point(48, 161);
            this.ucA.Margin = new System.Windows.Forms.Padding(5);
            this.ucA.Name = "ucA";
            this.ucA.NoiDung = "";
            this.ucA.Size = new System.Drawing.Size(427, 70);
            this.ucA.TabIndex = 1;
            this.ucA.Validator = false;
            // 
            // txtNoiDungCauHoi
            // 
            this.txtNoiDungCauHoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungCauHoi.Location = new System.Drawing.Point(48, 21);
            this.txtNoiDungCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiDungCauHoi.Multiline = true;
            this.txtNoiDungCauHoi.Name = "txtNoiDungCauHoi";
            this.txtNoiDungCauHoi.ReadOnly = true;
            this.txtNoiDungCauHoi.Size = new System.Drawing.Size(960, 117);
            this.txtNoiDungCauHoi.TabIndex = 0;
            // 
            // lblThoiGianConLai
            // 
            this.lblThoiGianConLai.AutoSize = true;
            this.lblThoiGianConLai.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianConLai.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGianConLai.Location = new System.Drawing.Point(951, 17);
            this.lblThoiGianConLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiGianConLai.Name = "lblThoiGianConLai";
            this.lblThoiGianConLai.Size = new System.Drawing.Size(93, 31);
            this.lblThoiGianConLai.TabIndex = 2;
            this.lblThoiGianConLai.Text = "00 : 00";
            // 
            // lblMaDe
            // 
            this.lblMaDe.AutoSize = true;
            this.lblMaDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDe.Location = new System.Drawing.Point(64, 24);
            this.lblMaDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDe.Name = "lblMaDe";
            this.lblMaDe.Size = new System.Drawing.Size(60, 22);
            this.lblMaDe.TabIndex = 1;
            this.lblMaDe.Text = "Mã đề";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(64, 61);
            this.lblMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(79, 22);
            this.lblMonHoc.TabIndex = 1;
            this.lblMonHoc.Text = "Môn học";
            // 
            // LamBaiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 722);
            this.Controls.Add(this.lblThoiGianConLai);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LamBaiTracNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LamBaiTracNghiem";
            this.Load += new System.EventHandler(this.LamBaiTracNghiem_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtNoiDungCauHoi;
        private CauTraLoi ucA;
        private System.Windows.Forms.Label lblVitri;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private CauTraLoi ucF;
        private CauTraLoi ucE;
        private CauTraLoi ucD;
        private CauTraLoi ucC;
        private CauTraLoi ucB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHienThiCauDaHoanThanh;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Label lblThoiGianConLai;
        private System.Windows.Forms.Label lblSoCauDaHoanThanh;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblMaDe;
    }
}