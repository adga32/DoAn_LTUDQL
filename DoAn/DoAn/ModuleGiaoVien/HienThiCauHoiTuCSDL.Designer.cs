
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
            this.buttonSearchNext = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSCauHoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_CauHoi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // button_suaCauhoiSelected
            // 
            this.button_suaCauhoiSelected.Location = new System.Drawing.Point(615, 12);
            this.button_suaCauhoiSelected.Margin = new System.Windows.Forms.Padding(4);
            this.button_suaCauhoiSelected.Name = "button_suaCauhoiSelected";
            this.button_suaCauhoiSelected.Size = new System.Drawing.Size(100, 28);
            this.button_suaCauhoiSelected.TabIndex = 1;
            this.button_suaCauhoiSelected.Text = "Sửa";
            this.button_suaCauhoiSelected.UseVisualStyleBackColor = true;
            this.button_suaCauhoiSelected.Click += new System.EventHandler(this.button_suaCauhoiSelected_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khối:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Môn học:";
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.Location = new System.Drawing.Point(417, 10);
            this.cbbKhoi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.Size = new System.Drawing.Size(160, 30);
            this.cbbKhoi.TabIndex = 5;
            this.cbbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbbKhoi_SelectedIndexChanged);
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Items.AddRange(new object[] {
            ""});
            this.cbbMonHoc.Location = new System.Drawing.Point(125, 10);
            this.cbbMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(201, 30);
            this.cbbMonHoc.TabIndex = 4;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSearchNext);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.txtSearchBox);
            this.panel1.Controls.Add(this.cmbSearchType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(27, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 102);
            this.panel1.TabIndex = 8;
            // 
            // buttonSearchNext
            // 
            this.buttonSearchNext.Location = new System.Drawing.Point(753, 59);
            this.buttonSearchNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchNext.Name = "buttonSearchNext";
            this.buttonSearchNext.Size = new System.Drawing.Size(100, 28);
            this.buttonSearchNext.TabIndex = 12;
            this.buttonSearchNext.Text = "Search Next";
            this.buttonSearchNext.UseVisualStyleBackColor = true;
            this.buttonSearchNext.Click += new System.EventHandler(this.buttonSearchNext_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(615, 59);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(417, 63);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(157, 22);
            this.txtSearchBox.TabIndex = 10;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(125, 64);
            this.cmbSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(200, 24);
            this.cmbSearchType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button_suaCauhoiSelected);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbbMonHoc);
            this.panel3.Controls.Add(this.cbbKhoi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 47);
            this.panel3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSCauHoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(27, 176);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 353);
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
            this.dgvDSCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSCauHoi.Name = "dgvDSCauHoi";
            this.dgvDSCauHoi.ReadOnly = true;
            this.dgvDSCauHoi.RowHeadersWidth = 51;
            this.dgvDSCauHoi.Size = new System.Drawing.Size(1013, 353);
            this.dgvDSCauHoi.TabIndex = 0;
            this.dgvDSCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCauHoi_CellClick);
            // 
            // HienThiCauHoiTuCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HienThiCauHoiTuCSDL";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Hiển thị câu hỏi từ CSDL";
            this.Load += new System.EventHandler(this.HienThiCauHoiTuCSDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_CauHoi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchNext;
    }
}