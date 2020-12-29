
namespace DoAn.Admin
{
    partial class QuanLyHeThong
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPathBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRestore = new System.Windows.Forms.TextBox();
            this.buttonBrowesBackup = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonBrowesRestore = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBackup);
            this.panel1.Controls.Add(this.buttonBrowesBackup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPathBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 163);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRestore);
            this.panel2.Controls.Add(this.buttonBrowesRestore);
            this.panel2.Controls.Add(this.textBoxRestore);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 173);
            this.panel2.TabIndex = 1;
            // 
            // textBoxPathBackup
            // 
            this.textBoxPathBackup.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathBackup.Location = new System.Drawing.Point(72, 58);
            this.textBoxPathBackup.Name = "textBoxPathBackup";
            this.textBoxPathBackup.Size = new System.Drawing.Size(574, 22);
            this.textBoxPathBackup.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn nơi lưu file backup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn file để Restore ";
            // 
            // textBoxRestore
            // 
            this.textBoxRestore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRestore.Location = new System.Drawing.Point(72, 73);
            this.textBoxRestore.Name = "textBoxRestore";
            this.textBoxRestore.Size = new System.Drawing.Size(574, 22);
            this.textBoxRestore.TabIndex = 4;
            // 
            // buttonBrowesBackup
            // 
            this.buttonBrowesBackup.Location = new System.Drawing.Point(176, 120);
            this.buttonBrowesBackup.Name = "buttonBrowesBackup";
            this.buttonBrowesBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowesBackup.TabIndex = 2;
            this.buttonBrowesBackup.Text = "Browes";
            this.buttonBrowesBackup.UseVisualStyleBackColor = true;
            this.buttonBrowesBackup.Click += new System.EventHandler(this.buttonBrowesBackup_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(365, 120);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBackup.TabIndex = 3;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonBrowesRestore
            // 
            this.buttonBrowesRestore.Location = new System.Drawing.Point(176, 124);
            this.buttonBrowesRestore.Name = "buttonBrowesRestore";
            this.buttonBrowesRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowesRestore.TabIndex = 5;
            this.buttonBrowesRestore.Text = "Browes";
            this.buttonBrowesRestore.UseVisualStyleBackColor = true;
            this.buttonBrowesRestore.Click += new System.EventHandler(this.buttonBrowesRestore_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(365, 124);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonRestore.TabIndex = 6;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // QuanLyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyHeThong";
            this.Text = "QuanLyHeThong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonBrowesBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPathBackup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonBrowesRestore;
        private System.Windows.Forms.TextBox textBoxRestore;
        private System.Windows.Forms.Label label2;
    }
}