namespace mNotepad_GitHub
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAçCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriAlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silDekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepsiniSeçCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamanTarihF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.güncellemeleriKontrolEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textLayout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textLineC = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.ayarlarToolStripMenuItem1,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.dosyaAçCtrlOToolStripMenuItem,
            this.kaydetCtrlSToolStripMenuItem,
            this.yazdırCtrlPToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Dosya";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.yeniToolStripMenuItem.Text = "Yeni Dosya";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // dosyaAçCtrlOToolStripMenuItem
            // 
            this.dosyaAçCtrlOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dosyaAçCtrlOToolStripMenuItem.Name = "dosyaAçCtrlOToolStripMenuItem";
            this.dosyaAçCtrlOToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.dosyaAçCtrlOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.dosyaAçCtrlOToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.dosyaAçCtrlOToolStripMenuItem.Text = "Dosya Aç ";
            this.dosyaAçCtrlOToolStripMenuItem.Click += new System.EventHandler(this.dosyaAçCtrlOToolStripMenuItem_Click);
            // 
            // kaydetCtrlSToolStripMenuItem
            // 
            this.kaydetCtrlSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.kaydetCtrlSToolStripMenuItem.Name = "kaydetCtrlSToolStripMenuItem";
            this.kaydetCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetCtrlSToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.kaydetCtrlSToolStripMenuItem.Text = "Kaydet";
            this.kaydetCtrlSToolStripMenuItem.Click += new System.EventHandler(this.kaydetCtrlSToolStripMenuItem_Click);
            // 
            // yazdırCtrlPToolStripMenuItem
            // 
            this.yazdırCtrlPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.yazdırCtrlPToolStripMenuItem.Name = "yazdırCtrlPToolStripMenuItem";
            this.yazdırCtrlPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırCtrlPToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.yazdırCtrlPToolStripMenuItem.Text = "Yazdır ";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlCtrlZToolStripMenuItem,
            this.ileriAlMenuItem,
            this.kesCtrlXToolStripMenuItem,
            this.kopyalaCtrlCToolStripMenuItem,
            this.yapıştırCtrlVToolStripMenuItem,
            this.silDekToolStripMenuItem,
            this.hepsiniSeçCtrlAToolStripMenuItem,
            this.zamanTarihF5ToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ayarlarToolStripMenuItem.Text = "Düzenle";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // geriAlCtrlZToolStripMenuItem
            // 
            this.geriAlCtrlZToolStripMenuItem.Enabled = false;
            this.geriAlCtrlZToolStripMenuItem.Name = "geriAlCtrlZToolStripMenuItem";
            this.geriAlCtrlZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlCtrlZToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.geriAlCtrlZToolStripMenuItem.Text = "Geri Al";
            this.geriAlCtrlZToolStripMenuItem.Click += new System.EventHandler(this.geriAlCtrlZToolStripMenuItem_Click);
            // 
            // ileriAlMenuItem
            // 
            this.ileriAlMenuItem.Enabled = false;
            this.ileriAlMenuItem.Name = "ileriAlMenuItem";
            this.ileriAlMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.ileriAlMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ileriAlMenuItem.Text = "İleri Al";
            this.ileriAlMenuItem.Click += new System.EventHandler(this.ileriAlMenuItem_Click);
            // 
            // kesCtrlXToolStripMenuItem
            // 
            this.kesCtrlXToolStripMenuItem.Name = "kesCtrlXToolStripMenuItem";
            this.kesCtrlXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesCtrlXToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.kesCtrlXToolStripMenuItem.Text = "Kes (Ctrl + X)";
            // 
            // kopyalaCtrlCToolStripMenuItem
            // 
            this.kopyalaCtrlCToolStripMenuItem.Name = "kopyalaCtrlCToolStripMenuItem";
            this.kopyalaCtrlCToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.kopyalaCtrlCToolStripMenuItem.Text = "Kopyala (Ctrl + C)";
            // 
            // yapıştırCtrlVToolStripMenuItem
            // 
            this.yapıştırCtrlVToolStripMenuItem.Name = "yapıştırCtrlVToolStripMenuItem";
            this.yapıştırCtrlVToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.yapıştırCtrlVToolStripMenuItem.Text = "Yapıştır (Ctrl + V)";
            // 
            // silDekToolStripMenuItem
            // 
            this.silDekToolStripMenuItem.Name = "silDekToolStripMenuItem";
            this.silDekToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.silDekToolStripMenuItem.Text = "Sil (Del)";
            // 
            // hepsiniSeçCtrlAToolStripMenuItem
            // 
            this.hepsiniSeçCtrlAToolStripMenuItem.Name = "hepsiniSeçCtrlAToolStripMenuItem";
            this.hepsiniSeçCtrlAToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.hepsiniSeçCtrlAToolStripMenuItem.Text = "Ara (Ctrl + F)";
            // 
            // zamanTarihF5ToolStripMenuItem
            // 
            this.zamanTarihF5ToolStripMenuItem.Name = "zamanTarihF5ToolStripMenuItem";
            this.zamanTarihF5ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.zamanTarihF5ToolStripMenuItem.Text = "Zaman / Tarih (F5)";
            // 
            // ayarlarToolStripMenuItem1
            // 
            this.ayarlarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncellemeleriKontrolEtToolStripMenuItem,
            this.dilAyarlarıToolStripMenuItem});
            this.ayarlarToolStripMenuItem1.Name = "ayarlarToolStripMenuItem1";
            this.ayarlarToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.ayarlarToolStripMenuItem1.Text = "Ayarlar";
            // 
            // güncellemeleriKontrolEtToolStripMenuItem
            // 
            this.güncellemeleriKontrolEtToolStripMenuItem.Name = "güncellemeleriKontrolEtToolStripMenuItem";
            this.güncellemeleriKontrolEtToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.güncellemeleriKontrolEtToolStripMenuItem.Text = "Güncellemeleri Kontrol Et!";
            // 
            // dilAyarlarıToolStripMenuItem
            // 
            this.dilAyarlarıToolStripMenuItem.Name = "dilAyarlarıToolStripMenuItem";
            this.dilAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.dilAyarlarıToolStripMenuItem.Text = "Dil Ayarları";
            this.dilAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.dilAyarlarıToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.hakkındaToolStripMenuItem.Text = "Yardım";
            // 
            // textLayout
            // 
            this.textLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLayout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textLayout.Location = new System.Drawing.Point(5, 27);
            this.textLayout.Multiline = true;
            this.textLayout.Name = "textLayout";
            this.textLayout.Size = new System.Drawing.Size(791, 436);
            this.textLayout.TabIndex = 1;
            this.textLayout.TextChanged += new System.EventHandler(this.textLayout_TextChanged);
            this.textLayout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textLayout_KeyDown);
            this.textLayout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLayout_KeyPress);
            this.textLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textLayout_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font Size : 000";
            // 
            // textLineC
            // 
            this.textLineC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textLineC.AutoSize = true;
            this.textLineC.Location = new System.Drawing.Point(7, 466);
            this.textLineC.Name = "textLineC";
            this.textLineC.Size = new System.Drawing.Size(157, 13);
            this.textLineC.TabIndex = 3;
            this.textLineC.Text = "Yazı Karakter Sayısı : 0 karekter";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.textLineC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLayout);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adsız - mNotepad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silDekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepsiniSeçCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamanTarihF5ToolStripMenuItem;
        private System.Windows.Forms.TextBox textLayout;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncellemeleriKontrolEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilAyarlarıToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textLineC;
        private System.Windows.Forms.ToolStripMenuItem ileriAlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetCtrlSToolStripMenuItem;
    }
}

