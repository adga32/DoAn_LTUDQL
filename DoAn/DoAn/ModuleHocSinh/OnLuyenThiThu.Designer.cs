namespace DoAn
{
    partial class OnLuyenThiThu
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
            this.dtgDeThi = new System.Windows.Forms.DataGridView();
            this.btnTest = new System.Windows.Forms.Button();
            this.dtgDapAn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDapAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDeThi
            // 
            this.dtgDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeThi.Location = new System.Drawing.Point(21, 154);
            this.dtgDeThi.Name = "dtgDeThi";
            this.dtgDeThi.RowTemplate.Height = 24;
            this.dtgDeThi.Size = new System.Drawing.Size(594, 249);
            this.dtgDeThi.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(498, 439);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(117, 38);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Vào thi";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // dtgDapAn
            // 
            this.dtgDapAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDapAn.Location = new System.Drawing.Point(648, 154);
            this.dtgDapAn.Name = "dtgDapAn";
            this.dtgDapAn.RowTemplate.Height = 24;
            this.dtgDapAn.Size = new System.Drawing.Size(461, 249);
            this.dtgDapAn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách đề thi ôn luyện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách câu hỏi và gợi ý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(446, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ôn luyện thi thử";
            // 
            // OnLuyenThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDapAn);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dtgDeThi);
            this.Name = "OnLuyenThiThu";
            this.Text = "OnLuyenThiThu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDapAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDeThi;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dtgDapAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}