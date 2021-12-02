
namespace Aplikasi_Calculator_Windows_Form
{
    partial class frmHasil
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
            this.lblHasil = new System.Windows.Forms.Label();
            this.lstHasil = new System.Windows.Forms.ListView();
            this.btnHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHasil.Location = new System.Drawing.Point(33, 14);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(55, 17);
            this.lblHasil.TabIndex = 0;
            this.lblHasil.Text = "[ Hasil ]";
            // 
            // lstHasil
            // 
            this.lstHasil.HideSelection = false;
            this.lstHasil.Location = new System.Drawing.Point(23, 43);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(302, 216);
            this.lstHasil.TabIndex = 1;
            this.lstHasil.UseCompatibleStateImageBehavior = false;
            this.lstHasil.SelectedIndexChanged += new System.EventHandler(this.lstHasil_SelectedIndexChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(23, 273);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(302, 31);
            this.btnHitung.TabIndex = 2;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // frmHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 328);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.lblHasil);
            this.Name = "frmHasil";
            this.Text = "Hasil Perhitungan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.ListView lstHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}

