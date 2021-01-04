namespace DoAn
{
    partial class Thi
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
            this.dtgKyThi = new System.Windows.Forms.DataGridView();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btnVaoThi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.made = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKyThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgKyThi
            // 
            this.dtgKyThi.AllowUserToAddRows = false;
            this.dtgKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKyThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.mon,
            this.made});
            this.dtgKyThi.Location = new System.Drawing.Point(52, 139);
            this.dtgKyThi.Name = "dtgKyThi";
            this.dtgKyThi.RowTemplate.Height = 24;
            this.dtgKyThi.Size = new System.Drawing.Size(555, 307);
            this.dtgKyThi.TabIndex = 0;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.Location = new System.Drawing.Point(48, 117);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(152, 19);
            this.lbThongBao.TabIndex = 1;
            this.lbThongBao.Text = "Các môn thi hôm nay";
            // 
            // btnVaoThi
            // 
            this.btnVaoThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaoThi.Location = new System.Drawing.Point(274, 482);
            this.btnVaoThi.Name = "btnVaoThi";
            this.btnVaoThi.Size = new System.Drawing.Size(98, 36);
            this.btnVaoThi.TabIndex = 2;
            this.btnVaoThi.Text = "Vào thi";
            this.btnVaoThi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(247, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thi trắc nghiệm";
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã kỳ thi";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // mon
            // 
            this.mon.HeaderText = "Môn thi";
            this.mon.Name = "mon";
            this.mon.ReadOnly = true;
            // 
            // made
            // 
            this.made.HeaderText = "Mã đề";
            this.made.Name = "made";
            this.made.ReadOnly = true;
            // 
            // Thi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 530);
            this.Controls.Add(this.btnVaoThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.dtgKyThi);
            this.Name = "Thi";
            this.Text = "Thi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgKyThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgKyThi;
        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.Button btnVaoThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn made;
    }
}