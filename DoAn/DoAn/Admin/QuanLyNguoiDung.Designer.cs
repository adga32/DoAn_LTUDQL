namespace DoAn.Admin
{
    partial class QuanLyNguoiDung
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
            this.dtgGiaoVien = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgHocSinh = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGiaoVien
            // 
            this.dtgGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGiaoVien.Location = new System.Drawing.Point(38, 101);
            this.dtgGiaoVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgGiaoVien.Name = "dtgGiaoVien";
            this.dtgGiaoVien.RowTemplate.Height = 24;
            this.dtgGiaoVien.Size = new System.Drawing.Size(415, 292);
            this.dtgGiaoVien.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(35, 22);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(136, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Danh sách người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giáo viên";
            // 
            // dtgHocSinh
            // 
            this.dtgHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHocSinh.Location = new System.Drawing.Point(481, 101);
            this.dtgHocSinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgHocSinh.Name = "dtgHocSinh";
            this.dtgHocSinh.RowTemplate.Height = 24;
            this.dtgHocSinh.Size = new System.Drawing.Size(394, 292);
            this.dtgHocSinh.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Học sinh";
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.Location = new System.Drawing.Point(69, 416);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(180, 59);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "Import danh sách học sinh giáo viên";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 486);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgHocSinh);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dtgGiaoVien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyNguoiDung";
            this.Text = "QuanLyNguoiDung";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGiaoVien;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgHocSinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonImport;
    }
}