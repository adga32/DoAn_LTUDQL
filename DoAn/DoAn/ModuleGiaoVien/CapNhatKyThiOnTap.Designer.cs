namespace DoAn
{
    partial class CapNhatKyThiOnTap
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
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgHocSinh = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgDeThi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuuKyThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThi.Location = new System.Drawing.Point(26, 97);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayThi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày giới hạn";
            // 
            // cbKhoi
            // 
            this.cbKhoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(254, 97);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 27);
            this.cbKhoi.TabIndex = 10;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(420, 97);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(121, 27);
            this.cbMonHoc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khối";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Môn học";
            // 
            // dtgHocSinh
            // 
            this.dtgHocSinh.AllowUserToAddRows = false;
            this.dtgHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHocSinh.Location = new System.Drawing.Point(26, 187);
            this.dtgHocSinh.Name = "dtgHocSinh";
            this.dtgHocSinh.RowHeadersWidth = 51;
            this.dtgHocSinh.RowTemplate.Height = 24;
            this.dtgHocSinh.Size = new System.Drawing.Size(694, 416);
            this.dtgHocSinh.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách học sinh";
            // 
            // dtgDeThi
            // 
            this.dtgDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeThi.Location = new System.Drawing.Point(747, 187);
            this.dtgDeThi.Name = "dtgDeThi";
            this.dtgDeThi.RowHeadersWidth = 51;
            this.dtgDeThi.RowTemplate.Height = 24;
            this.dtgDeThi.Size = new System.Drawing.Size(434, 416);
            this.dtgDeThi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách đề thi";
            // 
            // btnLuuKyThi
            // 
            this.btnLuuKyThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKyThi.Location = new System.Drawing.Point(473, 644);
            this.btnLuuKyThi.Name = "btnLuuKyThi";
            this.btnLuuKyThi.Size = new System.Drawing.Size(119, 38);
            this.btnLuuKyThi.TabIndex = 13;
            this.btnLuuKyThi.Text = "Lưu kỳ thi";
            this.btnLuuKyThi.UseVisualStyleBackColor = true;
            // 
            // CapNhatKyThiOnTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 706);
            this.Controls.Add(this.btnLuuKyThi);
            this.Controls.Add(this.dtgDeThi);
            this.Controls.Add(this.dtgHocSinh);
            this.Controls.Add(this.cbKhoi);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayThi);
            this.Name = "CapNhatKyThiOnTap";
            this.Text = "Cập nhật kỳ thi ôn tập";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgHocSinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgDeThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuuKyThi;
    }
}