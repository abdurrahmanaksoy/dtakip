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
    public partial class FrmAnaOgrenci : Form
    {
        public static int OgrenciId;
        public FrmAnaOgrenci()
        {
            InitializeComponent();
        }

        private void alınanDerslerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlinanDersler frm = new FrmAlinanDersler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dersProgramıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDersProgrami frm = new FrmDersProgrami();
            frm.MdiParent = this;
            frm.Show();
        }

        private void devamsızlıkBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevamsizlikBilgisi frm = new FrmDevamsizlikBilgisi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sınıfListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSinifListesi frm = new FrmSinifListesi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
