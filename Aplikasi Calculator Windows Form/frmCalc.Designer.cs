
namespace Aplikasi_Calculator_Windows_Form
{
    partial class frmCalc
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
            this.lblOperasi = new System.Windows.Forms.Label();
            this.lblNilaiA = new System.Windows.Forms.Label();
            this.lblNilaiB = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.tmrJalan = new System.Windows.Forms.Timer(this.components);
            this.lblWarn = new System.Windows.Forms.Label();
            this.tmrWarna = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblOperasi
            // 
            this.lblOperasi.AutoSize = true;
            this.lblOperasi.Location = new System.Drawing.Point(20, 26);
            this.lblOperasi.Name = "lblOperasi";
            this.lblOperasi.Size = new System.Drawing.Size(43, 13);
            this.lblOperasi.TabIndex = 0;
            this.lblOperasi.Text = "Operasi";
            // 
            // lblNilaiA
            // 
            this.lblNilaiA.AutoSize = true;
            this.lblNilaiA.Location = new System.Drawing.Point(20, 57);
            this.lblNilaiA.Name = "lblNilaiA";
            this.lblNilaiA.Size = new System.Drawing.Size(37, 13);
            this.lblNilaiA.TabIndex = 0;
            this.lblNilaiA.Text = "Nilai A";
            // 
            // lblNilaiB
            // 
            this.lblNilaiB.AutoSize = true;
            this.lblNilaiB.Location = new System.Drawing.Point(20, 88);
            this.lblNilaiB.Name = "lblNilaiB";
            this.lblNilaiB.Size = new System.Drawing.Size(37, 13);
            this.lblNilaiB.TabIndex = 0;
            this.lblNilaiB.Text = "Nilai B";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(131, 148);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 1;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(85, 55);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(121, 20);
            this.txtNilaiA.TabIndex = 2;
            this.txtNilaiA.TextChanged += new System.EventHandler(this.txtNilaiA_TextChanged);
            this.txtNilaiA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNilaiA_KeyPress);
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(85, 86);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(121, 20);
            this.txtNilaiB.TabIndex = 2;
            this.txtNilaiB.TextChanged += new System.EventHandler(this.txtNilaiA_TextChanged);
            this.txtNilaiB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNilaiB_KeyPress);
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Perkalian",
            "Pembagian",
            "Pengurangan",
            "Penambahan"});
            this.cmbOperasi.Location = new System.Drawing.Point(85, 23);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(121, 21);
            this.cmbOperasi.TabIndex = 3;
            // 
            // tmrJalan
            // 
            this.tmrJalan.Enabled = true;
            this.tmrJalan.Interval = 30;
            this.tmrJalan.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarn.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarn.Location = new System.Drawing.Point(220, 178);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(157, 13);
            this.lblWarn.TabIndex = 4;
            this.lblWarn.Text = "Note : Masukan Hanya Angka !";
            // 
            // tmrWarna
            // 
            this.tmrWarna.Enabled = true;
            this.tmrWarna.Interval = 110;
            this.tmrWarna.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 192);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.cmbOperasi);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.lblNilaiB);
            this.Controls.Add(this.lblNilaiA);
            this.Controls.Add(this.lblOperasi);
            this.Name = "frmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperasi;
        private System.Windows.Forms.Label lblNilaiA;
        private System.Windows.Forms.Label lblNilaiB;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.ComboBox cmbOperasi;
        private System.Windows.Forms.Timer tmrJalan;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Timer tmrWarna;
    }
}