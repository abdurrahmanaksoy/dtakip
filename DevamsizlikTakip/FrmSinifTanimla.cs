using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevamsizlikTakip
{
    public partial class FrmSinifTanimla : Form
    {
        public FrmSinifTanimla()
        {
            InitializeComponent();
            ListeyiGetir();
        }

        private void ListeyiGetir()
        {
            dataGridView1.DataSource = Islemler.GetSinif();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Islemler.SinifKaydet(txtSinifAdi.Text);
            ListeyiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int SinifID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Islemler.SilSinif(SinifID);
            ListeyiGetir();
        }

       
    }
}
