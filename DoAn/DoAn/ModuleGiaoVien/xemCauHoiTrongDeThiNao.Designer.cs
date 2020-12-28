
namespace DoAn.ModuleGiaoVien
{
    partial class xemCauHoiTrongDeThiNao
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
            this.dataGridViewDethi = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSCauHoi = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSearchNext = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowALL = new System.Windows.Forms.Button();
            this.button_suaCauhoiSelected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbbKhoi = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDethi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCauHoi)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDethi);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 551);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewDethi
            // 
            this.dataGridViewDethi.AllowUserToAddRows = false;
            this.dataGridViewDethi.AllowUserToDeleteRows = false;
            this.dataGridViewDethi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDethi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDethi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDethi.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewDethi.Name = "dataGridViewDethi";
            this.dataGridViewDethi.ReadOnly = true;
            this.dataGridViewDethi.Size = new System.Drawing.Size(612, 451);
            this.dataGridViewDethi.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(612, 100);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSCauHoi);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(612, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 551);
            this.panel2.TabIndex = 1;
            // 
            // dgvDSCauHoi
            // 
            this.dgvDSCauHoi.AllowUserToAddRows = false;
            this.dgvDSCauHoi.AllowUserToDeleteRows = false;
            this.dgvDSCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCauHoi.Location = new System.Drawing.Point(0, 100);
            this.dgvDSCauHoi.Name = "dgvDSCauHoi";
            this.dgvDSCauHoi.ReadOnly = true;
            this.dgvDSCauHoi.Size = new System.Drawing.Size(639, 451);
            this.dgvDSCauHoi.TabIndex = 1;
            this.dgvDSCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCauHoi_CellClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonSearchNext);
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.txtSearchBox);
            this.panel3.Controls.Add(this.cmbSearchType);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonShowALL);
            this.panel3.Controls.Add(this.button_suaCauhoiSelected);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbbMonHoc);
            this.panel3.Controls.Add(this.cbbKhoi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 100);
            this.panel3.TabIndex = 0;
            // 
            // buttonSearchNext
            // 
            this.buttonSearchNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchNext.Location = new System.Drawing.Point(556, 54);
            this.buttonSearchNext.Name = "buttonSearchNext";
            this.buttonSearchNext.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchNext.TabIndex = 22;
            this.buttonSearchNext.Text = "Search Next";
            this.buttonSearchNext.UseVisualStyleBackColor = true;
            this.buttonSearchNext.Click += new System.EventHandler(this.buttonSearchNext_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(452, 54);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(304, 57);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(119, 20);
            this.txtSearchBox.TabIndex = 20;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(85, 58);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(151, 21);
            this.cmbSearchType.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search By:";
            // 
            // buttonShowALL
            // 
            this.buttonShowALL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowALL.Location = new System.Drawing.Point(555, 14);
            this.buttonShowALL.Name = "buttonShowALL";
            this.buttonShowALL.Size = new System.Drawing.Size(75, 23);
            this.buttonShowALL.TabIndex = 17;
            this.buttonShowALL.Text = "Show All";
            this.buttonShowALL.UseVisualStyleBackColor = true;
            this.buttonShowALL.Click += new System.EventHandler(this.buttonShowALL_Click);
            // 
            // button_suaCauhoiSelected
            // 
            this.button_suaCauhoiSelected.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_suaCauhoiSelected.Location = new System.Drawing.Point(451, 14);
            this.button_suaCauhoiSelected.Name = "button_suaCauhoiSelected";
            this.button_suaCauhoiSelected.Size = new System.Drawing.Size(75, 23);
            this.button_suaCauhoiSelected.TabIndex = 13;
            this.button_suaCauhoiSelected.Text = "Sửa";
            this.button_suaCauhoiSelected.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Môn học:";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Items.AddRange(new object[] {
            ""});
            this.cbbMonHoc.Location = new System.Drawing.Point(84, 12);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(152, 27);
            this.cbbMonHoc.TabIndex = 14;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(303, 12);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(121, 27);
            this.cbbKhoi.TabIndex = 15;
            this.cbbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbbKhoi_SelectedIndexChanged);
            // 
            // xemCauHoiTrongDeThiNao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "xemCauHoiTrongDeThiNao";
            this.Text = "xemCauHoiTrongDeThiNao";
            this.Load += new System.EventHandler(this.xemCauHoiTrongDeThiNao_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDethi)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCauHoi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDethi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSCauHoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSearchNext;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowALL;
        private System.Windows.Forms.Button button_suaCauhoiSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.ComboBox cbbKhoi;
    }
}