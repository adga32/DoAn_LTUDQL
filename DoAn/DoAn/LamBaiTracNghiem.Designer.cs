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
            this.txtNoiDungCauHoi = new System.Windows.Forms.TextBox();
            this.lblThoiGianConLai = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucF = new DoAn.CauTraLoi();
            this.ucE = new DoAn.CauTraLoi();
            this.ucD = new DoAn.CauTraLoi();
            this.ucC = new DoAn.CauTraLoi();
            this.ucB = new DoAn.CauTraLoi();
            this.ucA = new DoAn.CauTraLoi();
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
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblSoCauDaHoanThanh);
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 550);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblSoCauDaHoanThanh
            // 
            this.lblSoCauDaHoanThanh.AutoSize = true;
            this.lblSoCauDaHoanThanh.Location = new System.Drawing.Point(184, 18);
            this.lblSoCauDaHoanThanh.Name = "lblSoCauDaHoanThanh";
            this.lblSoCauDaHoanThanh.Size = new System.Drawing.Size(37, 19);
            this.lblSoCauDaHoanThanh.TabIndex = 2;
            this.lblSoCauDaHoanThanh.Text = "0/60";
            // 
            // lblHienThiCauDaHoanThanh
            // 
            this.lblHienThiCauDaHoanThanh.AutoSize = true;
            this.lblHienThiCauDaHoanThanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThiCauDaHoanThanh.Location = new System.Drawing.Point(32, 18);
            this.lblHienThiCauDaHoanThanh.Name = "lblHienThiCauDaHoanThanh";
            this.lblHienThiCauDaHoanThanh.Size = new System.Drawing.Size(146, 19);
            this.lblHienThiCauDaHoanThanh.TabIndex = 1;
            this.lblHienThiCauDaHoanThanh.Text = "Số câu đã hoàn thành: ";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(593, 18);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(114, 19);
            this.lblThoiGian.TabIndex = 0;
            this.lblThoiGian.Text = "Thời gian còn lại: ";
            // 
            // btnNopBai
            // 
            this.btnNopBai.Location = new System.Drawing.Point(358, 432);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(93, 36);
            this.btnNopBai.TabIndex = 10;
            this.btnNopBai.Text = "Nộp bài";
            this.btnNopBai.UseVisualStyleBackColor = true;
            // 
            // lblVitri
            // 
            this.lblVitri.AutoSize = true;
            this.lblVitri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitri.Location = new System.Drawing.Point(368, 399);
            this.lblVitri.Name = "lblVitri";
            this.lblVitri.Size = new System.Drawing.Size(66, 19);
            this.lblVitri.TabIndex = 9;
            this.lblVitri.Text = "Câu 1/60";
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRight.BackgroundImage")));
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRight.Location = new System.Drawing.Point(682, 388);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 42);
            this.btnRight.TabIndex = 8;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeft.BackgroundImage")));
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeft.Location = new System.Drawing.Point(36, 388);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 42);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // txtNoiDungCauHoi
            // 
            this.txtNoiDungCauHoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungCauHoi.Location = new System.Drawing.Point(36, 17);
            this.txtNoiDungCauHoi.Multiline = true;
            this.txtNoiDungCauHoi.Name = "txtNoiDungCauHoi";
            this.txtNoiDungCauHoi.ReadOnly = true;
            this.txtNoiDungCauHoi.Size = new System.Drawing.Size(721, 96);
            this.txtNoiDungCauHoi.TabIndex = 0;
            // 
            // lblThoiGianConLai
            // 
            this.lblThoiGianConLai.AutoSize = true;
            this.lblThoiGianConLai.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianConLai.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGianConLai.Location = new System.Drawing.Point(713, 14);
            this.lblThoiGianConLai.Name = "lblThoiGianConLai";
            this.lblThoiGianConLai.Size = new System.Drawing.Size(71, 24);
            this.lblThoiGianConLai.TabIndex = 2;
            this.lblThoiGianConLai.Text = "00 : 00";
            // 
            // ucF
            // 
            this.ucF.CheckBox = false;
            this.ucF.Location = new System.Drawing.Point(437, 299);
            this.ucF.Name = "ucF";
            this.ucF.NoiDung = "";
            this.ucF.Size = new System.Drawing.Size(320, 57);
            this.ucF.TabIndex = 6;
            // 
            // ucE
            // 
            this.ucE.CheckBox = false;
            this.ucE.Location = new System.Drawing.Point(36, 299);
            this.ucE.Name = "ucE";
            this.ucE.NoiDung = "";
            this.ucE.Size = new System.Drawing.Size(320, 57);
            this.ucE.TabIndex = 5;
            // 
            // ucD
            // 
            this.ucD.CheckBox = false;
            this.ucD.Location = new System.Drawing.Point(437, 217);
            this.ucD.Name = "ucD";
            this.ucD.NoiDung = "";
            this.ucD.Size = new System.Drawing.Size(320, 57);
            this.ucD.TabIndex = 4;
            // 
            // ucC
            // 
            this.ucC.CheckBox = false;
            this.ucC.Location = new System.Drawing.Point(36, 217);
            this.ucC.Name = "ucC";
            this.ucC.NoiDung = "";
            this.ucC.Size = new System.Drawing.Size(320, 57);
            this.ucC.TabIndex = 3;
            // 
            // ucB
            // 
            this.ucB.CheckBox = false;
            this.ucB.Location = new System.Drawing.Point(437, 131);
            this.ucB.Name = "ucB";
            this.ucB.NoiDung = "";
            this.ucB.Size = new System.Drawing.Size(320, 57);
            this.ucB.TabIndex = 2;
            // 
            // ucA
            // 
            this.ucA.CheckBox = false;
            this.ucA.Location = new System.Drawing.Point(36, 131);
            this.ucA.Name = "ucA";
            this.ucA.NoiDung = "";
            this.ucA.Size = new System.Drawing.Size(320, 57);
            this.ucA.TabIndex = 1;
            // 
            // LamBaiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblThoiGianConLai);
            this.Controls.Add(this.splitContainer1);
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
    }
}