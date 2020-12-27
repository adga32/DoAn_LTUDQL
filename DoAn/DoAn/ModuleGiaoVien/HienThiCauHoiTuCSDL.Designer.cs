
namespace DoAn
{
    partial class HienThiCauHoiTuCSDL
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
            this.bindingSource_CauHoi = new System.Windows.Forms.BindingSource(this.components);
            this.button_suaCauhoiSelected = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSCauHoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_CauHoi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // button_suaCauhoiSelected
            // 
            this.button_suaCauhoiSelected.Location = new System.Drawing.Point(603, 25);
            this.button_suaCauhoiSelected.Name = "button_suaCauhoiSelected";
            this.button_suaCauhoiSelected.Size = new System.Drawing.Size(75, 23);
            this.button_suaCauhoiSelected.TabIndex = 1;
            this.button_suaCauhoiSelected.Text = "Sửa";
            this.button_suaCauhoiSelected.UseVisualStyleBackColor = true;
            this.button_suaCauhoiSelected.Click += new System.EventHandler(this.button_suaCauhoiSelected_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khối:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Môn học:";
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(390, 21);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(121, 27);
            this.cbbKhoi.TabIndex = 5;
            this.cbbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbbKhoi_SelectedIndexChanged);
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Items.AddRange(new object[] {
            ""});
            this.cbbMonHoc.Location = new System.Drawing.Point(115, 21);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(152, 27);
            this.cbbMonHoc.TabIndex = 4;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbMonHoc);
            this.panel1.Controls.Add(this.button_suaCauhoiSelected);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbKhoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 83);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSCauHoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 367);
            this.panel2.TabIndex = 9;
            // 
            // dgvDSCauHoi
            // 
            this.dgvDSCauHoi.AllowUserToAddRows = false;
            this.dgvDSCauHoi.AllowUserToDeleteRows = false;
            this.dgvDSCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCauHoi.Location = new System.Drawing.Point(0, 0);
            this.dgvDSCauHoi.Name = "dgvDSCauHoi";
            this.dgvDSCauHoi.ReadOnly = true;
            this.dgvDSCauHoi.Size = new System.Drawing.Size(800, 367);
            this.dgvDSCauHoi.TabIndex = 0;
            this.dgvDSCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCauHoi_CellClick);
            // 
            // HienThiCauHoiTuCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HienThiCauHoiTuCSDL";
            this.Text = "HienThiCauHoiTuCSDL";
            this.Load += new System.EventHandler(this.HienThiCauHoiTuCSDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_CauHoi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCauHoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource_CauHoi;
        private System.Windows.Forms.Button button_suaCauhoiSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKhoi;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSCauHoi;
    }
}