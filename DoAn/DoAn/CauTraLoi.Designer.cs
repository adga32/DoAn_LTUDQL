namespace DoAn
{
    partial class CauTraLoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckBA = new System.Windows.Forms.CheckBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ckBA
            // 
            this.ckBA.AutoSize = true;
            this.ckBA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBA.Location = new System.Drawing.Point(4, 27);
            this.ckBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckBA.Name = "ckBA";
            this.ckBA.Size = new System.Drawing.Size(18, 17);
            this.ckBA.TabIndex = 0;
            this.ckBA.UseVisualStyleBackColor = true;
            this.ckBA.CheckedChanged += new System.EventHandler(this.ckBA_CheckedChanged);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(27, 0);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ReadOnly = true;
            this.txtNoiDung.Size = new System.Drawing.Size(399, 69);
            this.txtNoiDung.TabIndex = 1;
            // 
            // CauTraLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.ckBA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CauTraLoi";
            this.Size = new System.Drawing.Size(427, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckBA;
        private System.Windows.Forms.TextBox txtNoiDung;
    }
}
