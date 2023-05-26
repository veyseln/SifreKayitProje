
namespace SifreKayıt
{
    partial class main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_zorluk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_sifre_karakter_adet = new System.Windows.Forms.NumericUpDown();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_olustur_ozel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cumle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_nerenin_sifresi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_olusan_sfire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sifre_karakter_adet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_zorluk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_sifre_karakter_adet);
            this.groupBox1.Controls.Add(this.btn_olustur);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 89);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standart Şifre Oluşturucu";
            // 
            // cmb_zorluk
            // 
            this.cmb_zorluk.FormattingEnabled = true;
            this.cmb_zorluk.Items.AddRange(new object[] {
            "Sadece Büyük Harf",
            "Sadece Küçük Harf",
            "Sadece Rakam",
            "Rakam ve Özel Karakterler",
            "Harfler (B/K) ve Özel Karakterler",
            "Tamamı Karışık"});
            this.cmb_zorluk.Location = new System.Drawing.Point(152, 27);
            this.cmb_zorluk.Name = "cmb_zorluk";
            this.cmb_zorluk.Size = new System.Drawing.Size(187, 21);
            this.cmb_zorluk.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifre Kaç Karakter Olacak?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zorluk Seçin";
            // 
            // nud_sifre_karakter_adet
            // 
            this.nud_sifre_karakter_adet.Location = new System.Drawing.Point(152, 54);
            this.nud_sifre_karakter_adet.Name = "nud_sifre_karakter_adet";
            this.nud_sifre_karakter_adet.Size = new System.Drawing.Size(67, 20);
            this.nud_sifre_karakter_adet.TabIndex = 8;
            this.nud_sifre_karakter_adet.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btn_olustur
            // 
            this.btn_olustur.Location = new System.Drawing.Point(345, 27);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(138, 33);
            this.btn_olustur.TabIndex = 10;
            this.btn_olustur.Text = "Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_olustur_ozel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_cumle);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 101);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Özel Şifre Oluşturucu";
            // 
            // btn_olustur_ozel
            // 
            this.btn_olustur_ozel.Location = new System.Drawing.Point(345, 34);
            this.btn_olustur_ozel.Name = "btn_olustur_ozel";
            this.btn_olustur_ozel.Size = new System.Drawing.Size(138, 33);
            this.btn_olustur_ozel.TabIndex = 23;
            this.btn_olustur_ozel.Text = "Oluştur";
            this.btn_olustur_ozel.UseVisualStyleBackColor = true;
            this.btn_olustur_ozel.Click += new System.EventHandler(this.btn_olustur_ozel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Şifre Üretilecek Cümle";
            // 
            // txt_cumle
            // 
            this.txt_cumle.Location = new System.Drawing.Point(152, 34);
            this.txt_cumle.Multiline = true;
            this.txt_cumle.Name = "txt_cumle";
            this.txt_cumle.Size = new System.Drawing.Size(187, 33);
            this.txt_cumle.TabIndex = 22;
            this.txt_cumle.Text = "Üretmek İstediğiniz Şifreye  Ait İpuçları";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 35;
            this.button1.Text = "Şifre Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(173, 337);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(138, 33);
            this.btn_kaydet.TabIndex = 31;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_nerenin_sifresi
            // 
            this.txt_nerenin_sifresi.Location = new System.Drawing.Point(152, 260);
            this.txt_nerenin_sifresi.Name = "txt_nerenin_sifresi";
            this.txt_nerenin_sifresi.Size = new System.Drawing.Size(187, 20);
            this.txt_nerenin_sifresi.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Neyin Şifresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Oluşan Şifre";
            // 
            // txt_olusan_sfire
            // 
            this.txt_olusan_sfire.Location = new System.Drawing.Point(152, 286);
            this.txt_olusan_sfire.Multiline = true;
            this.txt_olusan_sfire.Name = "txt_olusan_sfire";
            this.txt_olusan_sfire.Size = new System.Drawing.Size(187, 33);
            this.txt_olusan_sfire.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(503, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Üyeliğimi Sil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "Silmek İstediğiniz Tc\'yi giriniz";
            this.textBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(503, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Üyeliğimi Sil";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_nerenin_sifresi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_olusan_sfire);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sifre_karakter_adet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_zorluk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_sifre_karakter_adet;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_olustur_ozel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cumle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_nerenin_sifresi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_olusan_sfire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}