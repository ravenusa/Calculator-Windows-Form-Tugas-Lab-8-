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
    public partial class frmHasil : Form
    {
        private IList<Hitung> listOfMahasiswa = new List<Hitung>();
        public frmHasil()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lstHasil.View = View.Details;

            lstHasil.Columns.Add("Hasil Hitung Ke", 0, HorizontalAlignment.Center);
            lstHasil.Columns.Add("", 298, HorizontalAlignment.Left);
            
        }

        private void FrmEntry_OnCreate(Hitung mhs)
        {
            listOfMahasiswa.Add(mhs);

            int noUrut = lstHasil.Items.Count + 1;

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(mhs.Operasi);

            lstHasil.Items.Add(item);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            frmCalc frmEntry = new frmCalc("Calculator");

            frmEntry.OnCreate += FrmEntry_OnCreate;

            frmEntry.ShowDialog();
        }

        public void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}