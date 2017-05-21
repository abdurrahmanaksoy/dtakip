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
    public partial class FrmDersIslemleri : Form
    {
        public FrmDersIslemleri()
        {
            InitializeComponent();
            ListeyiGetir();
        }
        private void ListeyiGetir()
        {
            dataGridView1.DataSource = Islemler.GetDersGetir();
        }

        private void btnDersEkle_Click_1(object sender, EventArgs e)
        {
            Islemler.DersEkle(txtDersAdi.Text);
            ListeyiGetir();
        }

        private void brnDersSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int dersId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Islemler.DersSil(dersId);
            ListeyiGetir();
        }

    }
}
