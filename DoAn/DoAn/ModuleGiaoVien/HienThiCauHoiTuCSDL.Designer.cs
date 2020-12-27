
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
            this.dataGridView_CauHoi = new System.Windows.Forms.DataGridView();
            this.bindingSource_CauHoi = new System.Windows.Forms.BindingSource(this.components);
            this.button_suaCauhoiSelected = new System.Windows.Forms.Button();
            this.maCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goiY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_CauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CauHoi
            // 
            this.dataGridView_CauHoi.AllowDrop = true;
            this.dataGridView_CauHoi.AllowUserToAddRows = false;
            this.dataGridView_CauHoi.AllowUserToDeleteRows = false;
            this.dataGridView_CauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCauHoi,
            this.noiDung,
            this.goiY,
            this.doKho,
            this.maMonHoc,
            this.makhoi,
            this.loaiCauHoi});
            this.dataGridView_CauHoi.Location = new System.Drawing.Point(67, 43);
            this.dataGridView_CauHoi.Name = "dataGridView_CauHoi";
            this.dataGridView_CauHoi.ReadOnly = true;
            this.dataGridView_CauHoi.Size = new System.Drawing.Size(634, 348);
            this.dataGridView_CauHoi.TabIndex = 0;
            this.dataGridView_CauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CauHoi_CellClick);
            // 
            // button_suaCauhoiSelected
            // 
            this.button_suaCauhoiSelected.Location = new System.Drawing.Point(313, 16);
            this.button_suaCauhoiSelected.Name = "button_suaCauhoiSelected";
            this.button_suaCauhoiSelected.Size = new System.Drawing.Size(75, 23);
            this.button_suaCauhoiSelected.TabIndex = 1;
            this.button_suaCauhoiSelected.Text = "Sửa";
            this.button_suaCauhoiSelected.UseVisualStyleBackColor = true;
            this.button_suaCauhoiSelected.Click += new System.EventHandler(this.button_suaCauhoiSelected_Click);
            // 
            // maCauHoi
            // 
            this.maCauHoi.DataPropertyName = "maCauHoi";
            this.maCauHoi.HeaderText = "Mã";
            this.maCauHoi.Name = "maCauHoi";
            this.maCauHoi.ReadOnly = true;
            // 
            // noiDung
            // 
            this.noiDung.DataPropertyName = "noiDung";
            this.noiDung.HeaderText = "Nội dung";
            this.noiDung.Name = "noiDung";
            this.noiDung.ReadOnly = true;
            // 
            // goiY
            // 
            this.goiY.DataPropertyName = "goiY";
            this.goiY.HeaderText = "Gợi Ý";
            this.goiY.Name = "goiY";
            this.goiY.ReadOnly = true;
            // 
            // doKho
            // 
            this.doKho.DataPropertyName = "doKho";
            this.doKho.HeaderText = "Độ Khó";
            this.doKho.Name = "doKho";
            this.doKho.ReadOnly = true;
            // 
            // maMonHoc
            // 
            this.maMonHoc.DataPropertyName = "maMonHoc";
            this.maMonHoc.HeaderText = "Mã môn học";
            this.maMonHoc.Name = "maMonHoc";
            this.maMonHoc.ReadOnly = true;
            // 
            // makhoi
            // 
            this.makhoi.DataPropertyName = "makhoi";
            this.makhoi.HeaderText = "Mã khối";
            this.makhoi.Name = "makhoi";
            this.makhoi.ReadOnly = true;
            // 
            // loaiCauHoi
            // 
            this.loaiCauHoi.DataPropertyName = "loaiCauHoi";
            this.loaiCauHoi.HeaderText = "Loại";
            this.loaiCauHoi.Name = "loaiCauHoi";
            this.loaiCauHoi.ReadOnly = true;
            // 
            // HienThiCauHoiTuCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_suaCauhoiSelected);
            this.Controls.Add(this.dataGridView_CauHoi);
            this.Name = "HienThiCauHoiTuCSDL";
            this.Text = "HienThiCauHoiTuCSDL";
            this.Load += new System.EventHandler(this.HienThiCauHoiTuCSDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_CauHoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_CauHoi;
        private System.Windows.Forms.BindingSource bindingSource_CauHoi;
        private System.Windows.Forms.Button button_suaCauhoiSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn goiY;
        private System.Windows.Forms.DataGridViewTextBoxColumn doKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiCauHoi;
    }
}