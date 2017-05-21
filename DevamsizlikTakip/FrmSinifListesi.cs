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
    public partial class FrmSinifListesi : Form
    {
        public FrmSinifListesi()
        {
            InitializeComponent();
            ListeyiGetir();
        }
        private void ListeyiGetir()
        {
            dataGridView1.DataSource = Islemler.GetSinifListesi();
        }
    }
}
