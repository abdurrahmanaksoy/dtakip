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
    public partial class FrmDevamsizlikBilgisi : Form
    {
        public int ogrNo;
        public FrmDevamsizlikBilgisi()
        {
            InitializeComponent();
            this.ogrNo = FrmAnaOgrenci.OgrenciId;
            dataGridView1.DataSource = Islemler.DevamsizlikBilgisiGetir(this.ogrNo);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
