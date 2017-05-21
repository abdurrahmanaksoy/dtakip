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
    public partial class FrmDevamsizlikIslemler : Form
    {
        public FrmDevamsizlikIslemler()
        {
            InitializeComponent();
            cmbOgrAd.DataSource = Islemler.GetOgrenciGetir();
            cmbOgrAd.DisplayMember = "Ad";
            cmbOgrAd.ValueMember = "OgrenciId";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           Islemler.DevamsizlikEkle(Convert.ToInt32(cmbOgrAd.SelectedValue), dateTimePicker1.Value);
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int dersId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Islemler.OgretmenSil(dersId);
        }

        private void cmbOgrAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


      
    }
}
