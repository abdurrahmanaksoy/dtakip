﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DevamsizlikTakip
{
    public partial class FrmGiris : Form
    {

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ogrNo = Convert.ToInt32(txtOgrNo.Text);
            if (Islemler.OgrenciGirisYap(txtOgrTc.Text, ogrNo))
            {
                Veriler.OgrenciID = ogrNo;
                FrmAnaOgrenci frm = new FrmAnaOgrenci();
                frm.Show();
                Hide();
            }
            else MessageBox.Show("Hatalı Bilgiler Girdiniz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (Islemler.PersonelGirisYap(txtKullaniciAdi.Text, txtKullaniciSifre.Text))
            {
                FrmAnaPersonel frm = new FrmAnaPersonel();
                frm.Show();
                Hide();
            }

        }

        
      

    }
}
