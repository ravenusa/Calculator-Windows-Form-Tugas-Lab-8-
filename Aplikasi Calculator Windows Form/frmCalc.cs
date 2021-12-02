using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Calculator_Windows_Form
{
    public partial class frmCalc : Form
    {
        public delegate void CreateUpdateEventHandler(Hitung mhs);

        public event CreateUpdateEventHandler OnCreate;

        public event CreateUpdateEventHandler OnUpdate;

        private bool isNewData = true;

        private Hitung mhs;
        public frmCalc()
        {
            InitializeComponent();
        }
        public frmCalc(string title)
            : this()
        {
            this.Text = title;
        }

        
        public frmCalc(string title, Hitung obj)
            : this()
        {
            this.Text = title;

            isNewData = false; 
            mhs = obj; 

            txtNilaiA.Text = mhs.Nilai_A;
            txtNilaiB.Text = mhs.Nilai_B;
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void Calc()
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            if (cmbOperasi.Text == "Penambahan")
            {
                mhs.Operasi = "Hasil Penambahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + Penambahan(a, b).ToString();
            }
             else if (cmbOperasi.Text == "Pengurangan")
             {
                mhs.Operasi = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + Pengurangan(a, b).ToString();
            }
             else if (cmbOperasi.Text == "Perkalian")
             {
                mhs.Operasi = "Hasil Perkalian " + txtNilaiA.Text + " X " + txtNilaiB.Text + " = " + Perkalian(a, b).ToString();
            }
             else if (cmbOperasi.Text == "Pembagian")
             {
                mhs.Operasi = "Hasil Pembagian " + txtNilaiA.Text + " / " + txtNilaiB.Text + " = " + Pembagian(a, b).ToString();
            }
            else
            {
                MessageBox.Show("Operasi Belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        
        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) mhs = new Hitung();

            mhs.Nilai_A = txtNilaiA.Text;
            mhs.Nilai_B = txtNilaiB.Text;

            if (isNewData)
            {
                Calc();
                OnCreate(mhs);

                txtNilaiA.Clear();
                txtNilaiB.Clear();
            }
        }
        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";

            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }

                return false;
            }
            else
                return false;
        }
        private void txtNilaiA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNilaiA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void txtNilaiB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {        
            lblWarn.Left -= 1;
            if (lblWarn.Left < -lblWarn.Width) lblWarn.Left= this.Width;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            lblWarn.ForeColor = Color.FromArgb((int)Rnd.Next(255), (int)Rnd.Next(255), (int)Rnd.Next(255));
        }
    }
}
