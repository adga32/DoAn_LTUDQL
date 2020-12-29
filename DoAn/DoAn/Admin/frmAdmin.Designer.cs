namespace DoAn
{
    partial class frmAdmin
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
            this.btnQuanLyNguoiDung = new System.Windows.Forms.Button();
            this.btnQuanLyHeThong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyNguoiDung
            // 
            this.btnQuanLyNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNguoiDung.Location = new System.Drawing.Point(218, 63);
            this.btnQuanLyNguoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanLyNguoiDung.Name = "btnQuanLyNguoiDung";
            this.btnQuanLyNguoiDung.Size = new System.Drawing.Size(180, 59);
            this.btnQuanLyNguoiDung.TabIndex = 0;
            this.btnQuanLyNguoiDung.Text = "Quản lý người dùng";
            this.btnQuanLyNguoiDung.UseVisualStyleBackColor = true;
            this.btnQuanLyNguoiDung.Click += new System.EventHandler(this.btnQuanLyNguoiDung_Click);
            // 
            // btnQuanLyHeThong
            // 
            this.btnQuanLyHeThong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHeThong.Location = new System.Drawing.Point(218, 159);
            this.btnQuanLyHeThong.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanLyHeThong.Name = "btnQuanLyHeThong";
            this.btnQuanLyHeThong.Size = new System.Drawing.Size(180, 57);
            this.btnQuanLyHeThong.TabIndex = 0;
            this.btnQuanLyHeThong.Text = "Quản lý hệ thống";
            this.btnQuanLyHeThong.UseVisualStyleBackColor = true;
            this.btnQuanLyHeThong.Click += new System.EventHandler(this.btnQuanLyHeThong_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnQuanLyHeThong);
            this.Controls.Add(this.btnQuanLyNguoiDung);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyNguoiDung;
        private System.Windows.Forms.Button btnQuanLyHeThong;
    }
}