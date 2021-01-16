
namespace DoAn
{
    partial class ThongKeKyThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.TENHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiemTrungBinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaDe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKyThi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvThongKe);
            this.panel1.Controls.Add(this.txtDiemTrungBinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbMaDe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbKyThi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 523);
            this.panel1.TabIndex = 0;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENHS,
            this.DIEM,
            this.TENLOP});
            this.dgvThongKe.Location = new System.Drawing.Point(1, 153);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(541, 450);
            this.dgvThongKe.TabIndex = 13;
            // 
            // TENHS
            // 
            this.TENHS.DataPropertyName = "TENHS";
            this.TENHS.HeaderText = "Tên học sinh";
            this.TENHS.MinimumWidth = 6;
            this.TENHS.Name = "TENHS";
            this.TENHS.ReadOnly = true;
            // 
            // DIEM
            // 
            this.DIEM.DataPropertyName = "DIEM";
            this.DIEM.HeaderText = "Điểm";
            this.DIEM.MinimumWidth = 6;
            this.DIEM.Name = "DIEM";
            this.DIEM.ReadOnly = true;
            // 
            // TENLOP
            // 
            this.TENLOP.DataPropertyName = "TENLOP";
            this.TENLOP.HeaderText = "Lớp";
            this.TENLOP.MinimumWidth = 6;
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.ReadOnly = true;
            // 
            // txtDiemTrungBinh
            // 
            this.txtDiemTrungBinh.Location = new System.Drawing.Point(155, 89);
            this.txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            this.txtDiemTrungBinh.Size = new System.Drawing.Size(61, 30);
            this.txtDiemTrungBinh.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Điểm trung bình:";
            // 
            // cbbMaDe
            // 
            this.cbbMaDe.FormattingEnabled = true;
            this.cbbMaDe.Location = new System.Drawing.Point(352, 21);
            this.cbbMaDe.Name = "cbbMaDe";
            this.cbbMaDe.Size = new System.Drawing.Size(121, 30);
            this.cbbMaDe.TabIndex = 10;
            this.cbbMaDe.SelectedIndexChanged += new System.EventHandler(this.cbbMaDe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã đề:";
            // 
            // cbbKyThi
            // 
            this.cbbKyThi.FormattingEnabled = true;
            this.cbbKyThi.Location = new System.Drawing.Point(95, 18);
            this.cbbKyThi.Name = "cbbKyThi";
            this.cbbKyThi.Size = new System.Drawing.Size(121, 30);
            this.cbbKyThi.TabIndex = 8;
            this.cbbKyThi.SelectedIndexChanged += new System.EventHandler(this.cbbKyThi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kỳ thi:";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(422, 3);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // ThongKeKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 603);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKeKyThi";
            this.Text = "Thống kê kỳ thi";
            this.Load += new System.EventHandler(this.ThongKeKyThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.TextBox txtDiemTrungBinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKyThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOP;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}