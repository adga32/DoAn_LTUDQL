﻿
namespace DoAn.ModuleAdmin
{
    partial class ExportDsHocSinhGiaoVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgHocSinh = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtgGiaoVien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.qLTTNDataSetHocSinh = new DoAn.QLTTNDataSetHocSinh();
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocSinhTableAdapter = new DoAn.QLTTNDataSetHocSinhTableAdapters.hocSinhTableAdapter();
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLTTNDataSetGiaoVien = new DoAn.QLTTNDataSetGiaoVien();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoVienTableAdapter = new DoAn.QLTTNDataSetGiaoVienTableAdapters.giaoVienTableAdapter();
            this.maDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEXGV = new System.Windows.Forms.Button();
            this.buttonEXHS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGiaoVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTNDataSetHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTNDataSetGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 411);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 200);
            this.panel5.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgHocSinh);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 24);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 176);
            this.panel8.TabIndex = 3;
            // 
            // dtgHocSinh
            // 
            this.dtgHocSinh.AllowUserToAddRows = false;
            this.dtgHocSinh.AllowUserToDeleteRows = false;
            this.dtgHocSinh.AutoGenerateColumns = false;
            this.dtgHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDataGridViewTextBoxColumn1,
            this.tenDataGridViewTextBoxColumn1,
            this.ngaySinhDataGridViewTextBoxColumn1});
            this.dtgHocSinh.DataSource = this.giaoVienBindingSource;
            this.dtgHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgHocSinh.Location = new System.Drawing.Point(0, 0);
            this.dtgHocSinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtgHocSinh.Name = "dtgHocSinh";
            this.dtgHocSinh.ReadOnly = true;
            this.dtgHocSinh.RowTemplate.Height = 24;
            this.dtgHocSinh.Size = new System.Drawing.Size(800, 176);
            this.dtgHocSinh.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 24);
            this.panel6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Học sinh";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 187);
            this.panel2.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtgGiaoVien);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 24);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(800, 163);
            this.panel7.TabIndex = 1;
            // 
            // dtgGiaoVien
            // 
            this.dtgGiaoVien.AllowUserToAddRows = false;
            this.dtgGiaoVien.AllowUserToDeleteRows = false;
            this.dtgGiaoVien.AutoGenerateColumns = false;
            this.dtgGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn,
            this.maKhoiDataGridViewTextBoxColumn});
            this.dtgGiaoVien.DataSource = this.hocSinhBindingSource;
            this.dtgGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.dtgGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.dtgGiaoVien.Name = "dtgGiaoVien";
            this.dtgGiaoVien.ReadOnly = true;
            this.dtgGiaoVien.RowTemplate.Height = 24;
            this.dtgGiaoVien.Size = new System.Drawing.Size(800, 163);
            this.dtgGiaoVien.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 24);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giáo viên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 24);
            this.panel4.TabIndex = 5;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(2, 0);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(136, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Danh sách người dùng";
            // 
            // qLTTNDataSetHocSinh
            // 
            this.qLTTNDataSetHocSinh.DataSetName = "QLTTNDataSetHocSinh";
            this.qLTTNDataSetHocSinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataMember = "hocSinh";
            this.hocSinhBindingSource.DataSource = this.qLTTNDataSetHocSinh;
            // 
            // hocSinhTableAdapter
            // 
            this.hocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "ma";
            this.maDataGridViewTextBoxColumn.HeaderText = "ma";
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            this.maDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "maLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "maLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maKhoiDataGridViewTextBoxColumn
            // 
            this.maKhoiDataGridViewTextBoxColumn.DataPropertyName = "maKhoi";
            this.maKhoiDataGridViewTextBoxColumn.HeaderText = "maKhoi";
            this.maKhoiDataGridViewTextBoxColumn.Name = "maKhoiDataGridViewTextBoxColumn";
            this.maKhoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qLTTNDataSetGiaoVien
            // 
            this.qLTTNDataSetGiaoVien.DataSetName = "QLTTNDataSetGiaoVien";
            this.qLTTNDataSetGiaoVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "giaoVien";
            this.giaoVienBindingSource.DataSource = this.qLTTNDataSetGiaoVien;
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // maDataGridViewTextBoxColumn1
            // 
            this.maDataGridViewTextBoxColumn1.DataPropertyName = "ma";
            this.maDataGridViewTextBoxColumn1.HeaderText = "ma";
            this.maDataGridViewTextBoxColumn1.Name = "maDataGridViewTextBoxColumn1";
            this.maDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenDataGridViewTextBoxColumn1
            // 
            this.tenDataGridViewTextBoxColumn1.DataPropertyName = "ten";
            this.tenDataGridViewTextBoxColumn1.HeaderText = "ten";
            this.tenDataGridViewTextBoxColumn1.Name = "tenDataGridViewTextBoxColumn1";
            this.tenDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn1
            // 
            this.ngaySinhDataGridViewTextBoxColumn1.DataPropertyName = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.HeaderText = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.Name = "ngaySinhDataGridViewTextBoxColumn1";
            this.ngaySinhDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // buttonEXGV
            // 
            this.buttonEXGV.Location = new System.Drawing.Point(29, 417);
            this.buttonEXGV.Name = "buttonEXGV";
            this.buttonEXGV.Size = new System.Drawing.Size(75, 23);
            this.buttonEXGV.TabIndex = 5;
            this.buttonEXGV.Text = "ExportGv";
            this.buttonEXGV.UseVisualStyleBackColor = true;
            this.buttonEXGV.Click += new System.EventHandler(this.buttonEXGV_Click);
            // 
            // buttonEXHS
            // 
            this.buttonEXHS.Location = new System.Drawing.Point(171, 417);
            this.buttonEXHS.Name = "buttonEXHS";
            this.buttonEXHS.Size = new System.Drawing.Size(75, 23);
            this.buttonEXHS.TabIndex = 6;
            this.buttonEXHS.Text = "ExportHs";
            this.buttonEXHS.UseVisualStyleBackColor = true;
            this.buttonEXHS.Click += new System.EventHandler(this.buttonEXHS_Click);
            // 
            // ExportDsHocSinhGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEXHS);
            this.Controls.Add(this.buttonEXGV);
            this.Controls.Add(this.panel1);
            this.Name = "ExportDsHocSinhGiaoVien";
            this.Text = "ExportDsHocSinhGiaoVien";
            this.Load += new System.EventHandler(this.ExportDsHocSinhGiaoVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHocSinh)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGiaoVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTNDataSetHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTNDataSetGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgHocSinh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dtgGiaoVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl1;
        private QLTTNDataSetHocSinh qLTTNDataSetHocSinh;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private QLTTNDataSetHocSinhTableAdapters.hocSinhTableAdapter hocSinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoiDataGridViewTextBoxColumn;
        private QLTTNDataSetGiaoVien qLTTNDataSetGiaoVien;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private QLTTNDataSetGiaoVienTableAdapters.giaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonEXGV;
        private System.Windows.Forms.Button buttonEXHS;
    }
}