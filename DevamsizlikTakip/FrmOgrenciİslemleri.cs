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
    public partial class FrmOgrenciİslemleri : Form
    {
        public FrmOgrenciİslemleri()
        {
            InitializeComponent();
            ListeyiGetir();

        }
        private void ListeyiGetir()
        {
            dataGridView1.DataSource = Islemler.GetOgrenciGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Islemler.OgrenciEkle(txtOgrAd.Text, txtOgrSoyad.Text, Convert.ToInt32(cmbSinif.SelectedValue));
            ListeyiGetir();
        }



    }
}
