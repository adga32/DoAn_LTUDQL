
namespace DoAn
{
    partial class ThongKe
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
            this.btnThongKeHocSinh = new System.Windows.Forms.Button();
            this.btnThongKeKyThi = new System.Windows.Forms.Button();
            this.btnThongKeCauHoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThongKeHocSinh
            // 
            this.btnThongKeHocSinh.Location = new System.Drawing.Point(142, 82);
            this.btnThongKeHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKeHocSinh.Name = "btnThongKeHocSinh";
            this.btnThongKeHocSinh.Size = new System.Drawing.Size(195, 58);
            this.btnThongKeHocSinh.TabIndex = 0;
            this.btnThongKeHocSinh.Text = "Thống kê học sinh";
            this.btnThongKeHocSinh.UseVisualStyleBackColor = true;
            this.btnThongKeHocSinh.Click += new System.EventHandler(this.btnThongKeHocSinh_Click);
            // 
            // btnThongKeKyThi
            // 
            this.btnThongKeKyThi.Location = new System.Drawing.Point(142, 216);
            this.btnThongKeKyThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKeKyThi.Name = "btnThongKeKyThi";
            this.btnThongKeKyThi.Size = new System.Drawing.Size(195, 58);
            this.btnThongKeKyThi.TabIndex = 1;
            this.btnThongKeKyThi.Text = "Thống kê kỳ thi";
            this.btnThongKeKyThi.UseVisualStyleBackColor = true;
            this.btnThongKeKyThi.Click += new System.EventHandler(this.btnThongKeKyThi_Click);
            // 
            // btnThongKeCauHoi
            // 
            this.btnThongKeCauHoi.Location = new System.Drawing.Point(142, 356);
            this.btnThongKeCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKeCauHoi.Name = "btnThongKeCauHoi";
            this.btnThongKeCauHoi.Size = new System.Drawing.Size(195, 58);
            this.btnThongKeCauHoi.TabIndex = 2;
            this.btnThongKeCauHoi.Text = "Thống kê câu hỏi";
            this.btnThongKeCauHoi.UseVisualStyleBackColor = true;
            this.btnThongKeCauHoi.Click += new System.EventHandler(this.btnThongKeCauHoi_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 499);
            this.Controls.Add(this.btnThongKeCauHoi);
            this.Controls.Add(this.btnThongKeKyThi);
            this.Controls.Add(this.btnThongKeHocSinh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKe";
            this.Text = "Thống kê";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThongKeHocSinh;
        private System.Windows.Forms.Button btnThongKeKyThi;
        private System.Windows.Forms.Button btnThongKeCauHoi;
    }
}