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
    public partial class FrmOgretmenTanimla : Form
    {
        public FrmOgretmenTanimla()
        {
            InitializeComponent();
            ListeyiGetir();
           
        }
        private void ListeyiGetir()
        {
            dataGridView1.DataSource = Islemler.GetOgretmenGetir();
        }
        private void FrmOgretmenTanimla_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Islemler.OgretmenEkle(txtOgrtmnIsim.Text, Convert.ToInt32(cmbOgrtmnSinif.SelectedValue));
            ListeyiGetir();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            ListeyiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int sinifId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Islemler.OgretmenSil(sinifId);
            ListeyiGetir();
        }

    }
}
