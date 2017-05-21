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
    public partial class FrmAnaPersonel : Form
    {
        public FrmAnaPersonel()
        {
            InitializeComponent();
        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDersIslemleri frm = new FrmDersIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void devamsızlıkGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevamsizlikIslemler frm = new FrmDevamsizlikIslemler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciİslemleri frm = new FrmOgrenciİslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sınıfTanımlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSinifTanimla frm = new FrmSinifTanimla();
            frm.MdiParent = this;
            frm.Show();
        }

        private void öğretmenTanımlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmOgretmenTanimla frm = new FrmOgretmenTanimla();
            frm.MdiParent = this;
            frm.Show();
        }
    }
} 