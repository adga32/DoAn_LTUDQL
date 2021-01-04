namespace DoAn
{
    partial class PhanQuyenNguoiDung
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
            this.dtgHS = new System.Windows.Forms.DataGridView();
            this.dtgGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuuPq = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHS
            // 
            this.dtgHS.AllowUserToAddRows = false;
            this.dtgHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHS.Location = new System.Drawing.Point(45, 92);
            this.dtgHS.Name = "dtgHS";
            this.dtgHS.RowTemplate.Height = 24;
            this.dtgHS.Size = new System.Drawing.Size(823, 321);
            this.dtgHS.TabIndex = 0;
            // 
            // dtgGV
            // 
            this.dtgGV.AllowUserToAddRows = false;
            this.dtgGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGV.Location = new System.Drawing.Point(45, 453);
            this.dtgGV.Name = "dtgGV";
            this.dtgGV.RowTemplate.Height = 24;
            this.dtgGV.Size = new System.Drawing.Size(823, 321);
            this.dtgGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(397, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thiết lập chức năng, phân quyền";
            // 
            // btnLuuPq
            // 
            this.btnLuuPq.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPq.Location = new System.Drawing.Point(896, 92);
            this.btnLuuPq.Name = "btnLuuPq";
            this.btnLuuPq.Size = new System.Drawing.Size(142, 50);
            this.btnLuuPq.TabIndex = 2;
            this.btnLuuPq.Text = "Lưu phân quyền";
            this.btnLuuPq.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(896, 729);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PhanQuyenNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 786);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLuuPq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgGV);
            this.Controls.Add(this.dtgHS);
            this.Name = "PhanQuyenNguoiDung";
            this.Text = "Thiết lập chức năng, phân quyền";
            this.Load += new System.EventHandler(this.PhanQuyenNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHS;
        private System.Windows.Forms.DataGridView dtgGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuuPq;
        private System.Windows.Forms.Button btnClose;
    }
}