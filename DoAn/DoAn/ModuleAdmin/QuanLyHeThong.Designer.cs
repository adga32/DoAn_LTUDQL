namespace DoAn
{
    partial class QuanLyHeThong
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
            this.btnThietLapPhanQuyen = new System.Windows.Forms.Button();
            this.btnSaoLuuDatabse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThietLapPhanQuyen
            // 
            this.btnThietLapPhanQuyen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietLapPhanQuyen.Location = new System.Drawing.Point(338, 107);
            this.btnThietLapPhanQuyen.Name = "btnThietLapPhanQuyen";
            this.btnThietLapPhanQuyen.Size = new System.Drawing.Size(177, 80);
            this.btnThietLapPhanQuyen.TabIndex = 0;
            this.btnThietLapPhanQuyen.Text = "Thiết lập chức năng, phân quyền";
            this.btnThietLapPhanQuyen.UseVisualStyleBackColor = true;
            this.btnThietLapPhanQuyen.Click += new System.EventHandler(this.btnThietLapPhanQuyen_Click);
            // 
            // btnSaoLuuDatabse
            // 
            this.btnSaoLuuDatabse.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuuDatabse.Location = new System.Drawing.Point(118, 107);
            this.btnSaoLuuDatabse.Name = "btnSaoLuuDatabse";
            this.btnSaoLuuDatabse.Size = new System.Drawing.Size(174, 80);
            this.btnSaoLuuDatabse.TabIndex = 1;
            this.btnSaoLuuDatabse.Text = "Sao lưu, phục hồi databse";
            this.btnSaoLuuDatabse.UseVisualStyleBackColor = true;
            this.btnSaoLuuDatabse.Click += new System.EventHandler(this.btnSaoLuuDatabse_Click);
            // 
            // QuanLyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 298);
            this.Controls.Add(this.btnSaoLuuDatabse);
            this.Controls.Add(this.btnThietLapPhanQuyen);
            this.Name = "QuanLyHeThong";
            this.Text = "Quản lý hệ thống";
            this.Load += new System.EventHandler(this.QuanLyHeThong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThietLapPhanQuyen;
        private System.Windows.Forms.Button btnSaoLuuDatabse;
    }
}