
namespace DoAn
{
    partial class SaoLuuDatabase
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
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonBrowesBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPathBackup = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonBrowesRestore = new System.Windows.Forms.Button();
            this.textBoxRestore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 201);
            this.panel1.TabIndex = 0;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackup.Location = new System.Drawing.Point(487, 135);
            this.buttonBackup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(100, 41);
            this.buttonBackup.TabIndex = 3;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonBrowesBackup
            // 
            this.buttonBrowesBackup.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowesBackup.Location = new System.Drawing.Point(235, 135);
            this.buttonBrowesBackup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowesBackup.Name = "buttonBrowesBackup";
            this.buttonBrowesBackup.Size = new System.Drawing.Size(100, 41);
            this.buttonBrowesBackup.TabIndex = 2;
            this.buttonBrowesBackup.Text = "Browes";
            this.buttonBrowesBackup.UseVisualStyleBackColor = true;
            this.buttonBrowesBackup.Click += new System.EventHandler(this.buttonBrowesBackup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn nơi lưu file backup";
            // 
            // textBoxPathBackup
            // 
            this.textBoxPathBackup.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathBackup.Location = new System.Drawing.Point(96, 71);
            this.textBoxPathBackup.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPathBackup.Name = "textBoxPathBackup";
            this.textBoxPathBackup.Size = new System.Drawing.Size(764, 26);
            this.textBoxPathBackup.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRestore);
            this.panel2.Controls.Add(this.buttonBrowesRestore);
            this.panel2.Controls.Add(this.textBoxRestore);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 201);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 213);
            this.panel2.TabIndex = 1;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestore.Location = new System.Drawing.Point(487, 143);
            this.buttonRestore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(100, 38);
            this.buttonRestore.TabIndex = 6;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonBrowesRestore
            // 
            this.buttonBrowesRestore.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowesRestore.Location = new System.Drawing.Point(235, 143);
            this.buttonBrowesRestore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowesRestore.Name = "buttonBrowesRestore";
            this.buttonBrowesRestore.Size = new System.Drawing.Size(100, 38);
            this.buttonBrowesRestore.TabIndex = 5;
            this.buttonBrowesRestore.Text = "Browes";
            this.buttonBrowesRestore.UseVisualStyleBackColor = true;
            this.buttonBrowesRestore.Click += new System.EventHandler(this.buttonBrowesRestore_Click);
            // 
            // textBoxRestore
            // 
            this.textBoxRestore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRestore.Location = new System.Drawing.Point(96, 90);
            this.textBoxRestore.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRestore.Name = "textBoxRestore";
            this.textBoxRestore.Size = new System.Drawing.Size(764, 26);
            this.textBoxRestore.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn file để Restore ";
            // 
            // SaoLuuDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 414);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaoLuuDatabase";
            this.Text = "Sao lưu database";
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