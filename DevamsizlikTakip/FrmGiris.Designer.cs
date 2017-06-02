namespace DevamsizlikTakip
{
    partial class FrmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.öğrenci = new System.Windows.Forms.TabPage();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.txtOgrTc = new System.Windows.Forms.TextBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.öğrenci.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // öğrenci
            // 
            this.öğrenci.BackColor = System.Drawing.Color.MistyRose;
            this.öğrenci.Controls.Add(this.btnOgrenciGiris);
            this.öğrenci.Controls.Add(this.txtOgrTc);
            this.öğrenci.Controls.Add(this.txtOgrNo);
            this.öğrenci.Controls.Add(this.label2);
            this.öğrenci.Controls.Add(this.label1);
            this.öğrenci.Location = new System.Drawing.Point(4, 22);
            this.öğrenci.Name = "öğrenci";
            this.öğrenci.Padding = new System.Windows.Forms.Padding(3);
            this.öğrenci.Size = new System.Drawing.Size(210, 122);
            this.öğrenci.TabIndex = 0;
            this.öğrenci.Text = "öğrenci";
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciGiris.Location = new System.Drawing.Point(130, 84);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(77, 35);
            this.btnOgrenciGiris.TabIndex = 4;
            this.btnOgrenciGiris.Text = "giriş";
            this.btnOgrenciGiris.UseVisualStyleBackColor = true;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOgrTc
            // 
            this.txtOgrTc.Location = new System.Drawing.Point(115, 48);
            this.txtOgrTc.Name = "txtOgrTc";
            this.txtOgrTc.Size = new System.Drawing.Size(93, 20);
            this.txtOgrTc.TabIndex = 3;
            this.txtOgrTc.Text = "1";
            this.txtOgrTc.UseSystemPasswordChar = true;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(115, 22);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(92, 20);
            this.txtOgrNo.TabIndex = 2;
            this.txtOgrNo.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "öğrenci tc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "öğrenci no:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.öğrenci);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(218, 148);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.btnGiris);
            this.tabPage2.Controls.Add(this.txtKullaniciSifre);
            this.tabPage2.Controls.Add(this.txtKullaniciAdi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(210, 122);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "personel";
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Location = new System.Drawing.Point(124, 76);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(77, 35);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(109, 40);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(93, 20);
            this.txtKullaniciSifre.TabIndex = 8;
            this.txtKullaniciSifre.Text = "2";
            this.txtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(109, 14);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(92, 20);
            this.txtKullaniciAdi.TabIndex = 7;
            this.txtKullaniciAdi.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "kullanıcı adı:";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 148);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmGiris";
            this.Text = "Giriş Ekranı";
            this.öğrenci.ResumeLayout(false);
            this.öğrenci.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage öğrenci;
        private System.Windows.Forms.Button btnOgrenciGiris;
        private System.Windows.Forms.TextBox txtOgrTc;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}