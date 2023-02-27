
namespace Sifre_ureticisi
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numSifreKarakter = new System.Windows.Forms.NumericUpDown();
            this.cmbBuyukHarf = new System.Windows.Forms.ComboBox();
            this.txtHarfTercih = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSifreKarakter)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(293, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Şifre Karakter Sayısı ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(14, 12);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 24);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Şifre Tipleri";
            // 
            // numSifreKarakter
            // 
            this.numSifreKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSifreKarakter.Location = new System.Drawing.Point(293, 69);
            this.numSifreKarakter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numSifreKarakter.Name = "numSifreKarakter";
            this.numSifreKarakter.Size = new System.Drawing.Size(261, 24);
            this.numSifreKarakter.TabIndex = 2;
            // 
            // cmbBuyukHarf
            // 
            this.cmbBuyukHarf.Enabled = false;
            this.cmbBuyukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBuyukHarf.FormattingEnabled = true;
            this.cmbBuyukHarf.Items.AddRange(new object[] {
            "Harflerin Hepsi Küçük",
            "Harflerin Hepsi Büyük",
            "Sadece Baştaki Harf Büyük",
            "Sadece Sondaki Harf Büyük",
            "Büyük/Küçük Harf Karışık"});
            this.cmbBuyukHarf.Location = new System.Drawing.Point(13, 177);
            this.cmbBuyukHarf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBuyukHarf.Name = "cmbBuyukHarf";
            this.cmbBuyukHarf.Size = new System.Drawing.Size(261, 26);
            this.cmbBuyukHarf.TabIndex = 4;
            this.cmbBuyukHarf.SelectedIndexChanged += new System.EventHandler(this.cmbBuyukHarf_SelectedIndexChanged);
            // 
            // txtHarfTercih
            // 
            this.txtHarfTercih.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtHarfTercih.Enabled = false;
            this.txtHarfTercih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarfTercih.Location = new System.Drawing.Point(13, 119);
            this.txtHarfTercih.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHarfTercih.Name = "txtHarfTercih";
            this.txtHarfTercih.Size = new System.Drawing.Size(261, 24);
            this.txtHarfTercih.TabIndex = 0;
            this.txtHarfTercih.Text = "Büyük/Küçük Harf Tercihleri";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOlustur.Location = new System.Drawing.Point(325, 131);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(191, 62);
            this.btnOlustur.TabIndex = 5;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(13, 288);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(721, 31);
            this.txtSifre.TabIndex = 6;
            // 
            // btnKopyala
            // 
            this.btnKopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKopyala.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnKopyala.Location = new System.Drawing.Point(543, 131);
            this.btnKopyala.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(191, 62);
            this.btnKopyala.TabIndex = 7;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // cmbTip
            // 
            this.cmbTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Harf ve Sayı",
            "Harf ve Özel Karakter",
            "Sayı ve Özel Karakter",
            "Harf, Sayı ve Özel Karakter",
            "Sadece Sayı",
            "Sadece Harf",
            "Sadece Özel Karakter"});
            this.cmbTip.Location = new System.Drawing.Point(16, 69);
            this.cmbTip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(260, 26);
            this.cmbTip.TabIndex = 8;
            this.cmbTip.SelectedIndexChanged += new System.EventHandler(this.cmbTip_SelectedIndexChanged);
            this.cmbTip.TextChanged += new System.EventHandler(this.cmbTip_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(771, 397);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.cmbBuyukHarf);
            this.Controls.Add(this.numSifreKarakter);
            this.Controls.Add(this.txtHarfTercih);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Şifre Üreticisi";
            ((System.ComponentModel.ISupportInitialize)(this.numSifreKarakter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numSifreKarakter;
        private System.Windows.Forms.ComboBox cmbBuyukHarf;
        private System.Windows.Forms.TextBox txtHarfTercih;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.ComboBox cmbTip;
    }
}

