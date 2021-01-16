
namespace DoAn.ModuleGiaoVien
{
    partial class ExportDatabaseCauHoi
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
            this.dtgDapAnCauHoi = new System.Windows.Forms.DataGridView();
            this.maCauHoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laDapAnDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnCauhoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTNDataSetDapAnCauHoi = new DoAn.QLTTNDataSetDapAnCauHoi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgCauHoi = new System.Windows.Forms.DataGridView();
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goiYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiCauHoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauHoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTNDataSetCauHoi = new DoAn.QLTTNDataSetCauHoi();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cauHoiTableAdapter = new DoAn.QLTTNDataSetCauHoiTableAdapters.cauHoiTableAdapter();
            this.dapAnCauhoiTableAdapter = new DoAn.QLTTNDataSetDapAnCauHoiTableAdapters.dapAnCauhoiTableAdapter();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDapAnCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dapAnCauhoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTNDataSetDapAnCauHoi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTNDataSetCauHoi)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgDapAnCauHoi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(27, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 506);
            this.panel1.TabIndex = 5;
            // 
            // dtgDapAnCauHoi
            // 
            this.dtgDapAnCauHoi.AllowUserToAddRows = false;
            this.dtgDapAnCauHoi.AllowUserToDeleteRows = false;
            this.dtgDapAnCauHoi.AutoGenerateColumns = false;
            this.dtgDapAnCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDapAnCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDapAnCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCauHoiDataGridViewTextBoxColumn,
            this.dapAnDataGridViewTextBoxColumn,
            this.laDapAnDungDataGridViewTextBoxColumn});
            this.dtgDapAnCauHoi.DataSource = this.dapAnCauhoiBindingSource;
            this.dtgDapAnCauHoi.Location = new System.Drawing.Point(0, 0);
            this.dtgDapAnCauHoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDapAnCauHoi.Name = "dtgDapAnCauHoi";
            this.dtgDapAnCauHoi.ReadOnly = true;
            this.dtgDapAnCauHoi.RowHeadersWidth = 51;
            this.dtgDapAnCauHoi.RowTemplate.Height = 24;
            this.dtgDapAnCauHoi.Size = new System.Drawing.Size(0, 0);
            this.dtgDapAnCauHoi.TabIndex = 0;
            // 
            // maCauHoiDataGridViewTextBoxColumn
            // 
            this.maCauHoiDataGridViewTextBoxColumn.DataPropertyName = "maCauHoi";
            this.maCauHoiDataGridViewTextBoxColumn.HeaderText = "maCauHoi";
            this.maCauHoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCauHoiDataGridViewTextBoxColumn.Name = "maCauHoiDataGridViewTextBoxColumn";
            this.maCauHoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dapAnDataGridViewTextBoxColumn
            // 
            this.dapAnDataGridViewTextBoxColumn.DataPropertyName = "dapAn";
            this.dapAnDataGridViewTextBoxColumn.HeaderText = "dapAn";
            this.dapAnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dapAnDataGridViewTextBoxColumn.Name = "dapAnDataGridViewTextBoxColumn";
            this.dapAnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laDapAnDungDataGridViewTextBoxColumn
            // 
            this.laDapAnDungDataGridViewTextBoxColumn.DataPropertyName = "laDapAnDung";
            this.laDapAnDungDataGridViewTextBoxColumn.HeaderText = "laDapAnDung";
            this.laDapAnDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.laDapAnDungDataGridViewTextBoxColumn.Name = "laDapAnDungDataGridViewTextBoxColumn";
            this.laDapAnDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dapAnCauhoiBindingSource
            // 
            this.dapAnCauhoiBindingSource.DataMember = "dapAnCauhoi";
            this.dapAnCauhoiBindingSource.DataSource = this.qLTTNDataSetDapAnCauHoi;
            // 
            // qLTTNDataSetDapAnCauHoi
            // 
            this.qLTTNDataSetDapAnCauHoi.DataSetName = "QLTTNDataSetDapAnCauHoi";
            this.qLTTNDataSetDapAnCauHoi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgCauHoi);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 476);
            this.panel2.TabIndex = 4;
            // 
            // dtgCauHoi
            // 
            this.dtgCauHoi.AllowUserToAddRows = false;
            this.dtgCauHoi.AllowUserToDeleteRows = false;
            this.dtgCauHoi.AutoGenerateColumns = false;
            this.dtgCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn,
            this.goiYDataGridViewTextBoxColumn,
            this.doKhoDataGridViewTextBoxColumn,
            this.maMonHocDataGridViewTextBoxColumn,
            this.makhoiDataGridViewTextBoxColumn,
            this.loaiCauHoiDataGridViewTextBoxColumn});
            this.dtgCauHoi.DataSource = this.cauHoiBindingSource;
            this.dtgCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCauHoi.Location = new System.Drawing.Point(0, 30);
            this.dtgCauHoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCauHoi.Name = "dtgCauHoi";
            this.dtgCauHoi.ReadOnly = true;
            this.dtgCauHoi.RowHeadersWidth = 51;
            this.dtgCauHoi.RowTemplate.Height = 24;
            this.dtgCauHoi.Size = new System.Drawing.Size(1013, 446);
            this.dtgCauHoi.TabIndex = 0;
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "ma";
            this.maDataGridViewTextBoxColumn.HeaderText = "ma";
            this.maDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            this.maDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "noiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "noiDung";
            this.noiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            this.noiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goiYDataGridViewTextBoxColumn
            // 
            this.goiYDataGridViewTextBoxColumn.DataPropertyName = "goiY";
            this.goiYDataGridViewTextBoxColumn.HeaderText = "goiY";
            this.goiYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goiYDataGridViewTextBoxColumn.Name = "goiYDataGridViewTextBoxColumn";
            this.goiYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doKhoDataGridViewTextBoxColumn
            // 
            this.doKhoDataGridViewTextBoxColumn.DataPropertyName = "doKho";
            this.doKhoDataGridViewTextBoxColumn.HeaderText = "doKho";
            this.doKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doKhoDataGridViewTextBoxColumn.Name = "doKhoDataGridViewTextBoxColumn";
            this.doKhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maMonHocDataGridViewTextBoxColumn
            // 
            this.maMonHocDataGridViewTextBoxColumn.DataPropertyName = "maMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.HeaderText = "maMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonHocDataGridViewTextBoxColumn.Name = "maMonHocDataGridViewTextBoxColumn";
            this.maMonHocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makhoiDataGridViewTextBoxColumn
            // 
            this.makhoiDataGridViewTextBoxColumn.DataPropertyName = "makhoi";
            this.makhoiDataGridViewTextBoxColumn.HeaderText = "makhoi";
            this.makhoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makhoiDataGridViewTextBoxColumn.Name = "makhoiDataGridViewTextBoxColumn";
            this.makhoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiCauHoiDataGridViewTextBoxColumn
            // 
            this.loaiCauHoiDataGridViewTextBoxColumn.DataPropertyName = "loaiCauHoi";
            this.loaiCauHoiDataGridViewTextBoxColumn.HeaderText = "loaiCauHoi";
            this.loaiCauHoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiCauHoiDataGridViewTextBoxColumn.Name = "loaiCauHoiDataGridViewTextBoxColumn";
            this.loaiCauHoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cauHoiBindingSource
            // 
            this.cauHoiBindingSource.DataMember = "cauHoi";
            this.cauHoiBindingSource.DataSource = this.qLTTNDataSetCauHoi;
            // 
            // qLTTNDataSetCauHoi
            // 
            this.qLTTNDataSetCauHoi.DataSetName = "QLTTNDataSetCauHoi";
            this.qLTTNDataSetCauHoi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 30);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin câu hỏi";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1013, 30);
            this.panel4.TabIndex = 5;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(3, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(131, 19);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Danh sách câu hỏi";
            // 
            // cauHoiTableAdapter
            // 
            this.cauHoiTableAdapter.ClearBeforeFill = true;
            // 
            // dapAnCauhoiTableAdapter
            // 
            this.dapAnCauhoiTableAdapter.ClearBeforeFill = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(438, 617);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(100, 44);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // ExportDatabaseCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExportDatabaseCauHoi";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Export danh sách câu hỏi";
            this.Load += new System.EventHandler(this.ExportDatabaseCauHoi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDapAnCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dapAnCauhoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTNDataSetDapAnCauHoi)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTNDataSetCauHoi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgDapAnCauHoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgCauHoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl1;
        private QLTTNDataSetCauHoi qLTTNDataSetCauHoi;
        private System.Windows.Forms.BindingSource cauHoiBindingSource;
        private QLTTNDataSetCauHoiTableAdapters.cauHoiTableAdapter cauHoiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goiYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiCauHoiDataGridViewTextBoxColumn;
        private QLTTNDataSetDapAnCauHoi qLTTNDataSetDapAnCauHoi;
        private System.Windows.Forms.BindingSource dapAnCauhoiBindingSource;
        private QLTTNDataSetDapAnCauHoiTableAdapters.dapAnCauhoiTableAdapter dapAnCauhoiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCauHoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laDapAnDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonExport;
    }
}