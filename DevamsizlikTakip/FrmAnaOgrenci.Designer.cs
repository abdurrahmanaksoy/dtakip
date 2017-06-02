namespace DevamsizlikTakip
{
    partial class FrmAnaOgrenci
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alınanDerslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alınanDerslerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.devamsızlıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devamsızlıkBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alınanDerslerToolStripMenuItem,
            this.devamsızlıkToolStripMenuItem,
            this.sınıfListesiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alınanDerslerToolStripMenuItem
            // 
            this.alınanDerslerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alınanDerslerToolStripMenuItem1});
            this.alınanDerslerToolStripMenuItem.Name = "alınanDerslerToolStripMenuItem";
            this.alınanDerslerToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.alınanDerslerToolStripMenuItem.Text = "Alınan Dersler";
            // 
            // alınanDerslerToolStripMenuItem1
            // 
            this.alınanDerslerToolStripMenuItem1.Name = "alınanDerslerToolStripMenuItem1";
            this.alınanDerslerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.alınanDerslerToolStripMenuItem1.Text = "Alınan Dersler";
            this.alınanDerslerToolStripMenuItem1.Click += new System.EventHandler(this.alınanDerslerToolStripMenuItem1_Click);
            // 
            // devamsızlıkToolStripMenuItem
            // 
            this.devamsızlıkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devamsızlıkBilgisiToolStripMenuItem});
            this.devamsızlıkToolStripMenuItem.Name = "devamsızlıkToolStripMenuItem";
            this.devamsızlıkToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.devamsızlıkToolStripMenuItem.Text = "Devamsızlık";
            // 
            // devamsızlıkBilgisiToolStripMenuItem
            // 
            this.devamsızlıkBilgisiToolStripMenuItem.Name = "devamsızlıkBilgisiToolStripMenuItem";
            this.devamsızlıkBilgisiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.devamsızlıkBilgisiToolStripMenuItem.Text = "Devamsızlık bilgisi";
            this.devamsızlıkBilgisiToolStripMenuItem.Click += new System.EventHandler(this.devamsızlıkBilgisiToolStripMenuItem_Click);
            // 
            // sınıfListesiToolStripMenuItem
            // 
            this.sınıfListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sınıfListesiToolStripMenuItem1});
            this.sınıfListesiToolStripMenuItem.Name = "sınıfListesiToolStripMenuItem";
            this.sınıfListesiToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sınıfListesiToolStripMenuItem.Text = "Sınıf listesi";
            // 
            // sınıfListesiToolStripMenuItem1
            // 
            this.sınıfListesiToolStripMenuItem1.Name = "sınıfListesiToolStripMenuItem1";
            this.sınıfListesiToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.sınıfListesiToolStripMenuItem1.Text = "Sınıf Listesi";
            this.sınıfListesiToolStripMenuItem1.Click += new System.EventHandler(this.sınıfListesiToolStripMenuItem1_Click);
            // 
            // FrmAnaOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 321);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaOgrenci";
            this.Text = "Öğrenci Ekranı";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alınanDerslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alınanDerslerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem devamsızlıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devamsızlıkBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfListesiToolStripMenuItem1;
    }
}