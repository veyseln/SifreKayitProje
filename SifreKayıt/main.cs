using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SifreKayıt
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        int[] zorluk;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96U1VL9;Initial Catalog=sifreler;Integrated Security=True");
        private void btn_olustur_Click(object sender, EventArgs e)
        {
            btn_kaydet.Enabled = true;
            txt_olusan_sfire.Text = "";
            int sifre;
            string karakter = "";




            Random rastgele = new Random();
            if (cmb_zorluk.SelectedIndex >= 0)
            {
                switch (cmb_zorluk.SelectedIndex)
                {

                    case 0: zorluk = new int[] { 65, 90 }; break;

                    case 1: zorluk = new int[] { 97, 122 }; break;

                    case 2: zorluk = new int[] { 48, 57 }; break;

                    case 3: zorluk = new int[] { 33, 64 }; break;

                    case 4: zorluk = new int[] { 58, 122 }; break;

                    case 5: zorluk = new int[] { 33, 122 }; break;
                }

                for (int i = 0; i < nud_sifre_karakter_adet.Value; i++)
                {
                    sifre = rastgele.Next(zorluk[0], zorluk[1]);
                    karakter += Convert.ToChar(sifre).ToString();
                }
                
                    txt_olusan_sfire.Text = karakter;
            }
            else
            {
                MessageBox.Show("Zorluk seçmelisiniz.");
            }
        }

        private void btn_olustur_ozel_Click(object sender, EventArgs e)
        {
            btn_kaydet.Enabled = true;
            string cumle = txt_cumle.Text;
            string[] parcalar = cumle.Split(' ');
            string sifre = "", karakter = "";
            int random_Secim = 0;
            Random rastgele = new Random();
            zorluk = new int[] { 33, 47 };

            for (int i = 0; i < parcalar.Count(); i++)
            {
                random_Secim = rastgele.Next(zorluk[0], zorluk[1]);
                karakter = Convert.ToChar(random_Secim).ToString();

                if (SayiMi(parcalar[i]))
                {
                    if (parcalar[i].Length > 3)
                        sifre += parcalar[i].Substring(0, 2) + karakter + parcalar[i].Substring(2, 2);
                }
                else
                {
                    if (rastgele.Next(0, 2) == 0)
                    {
                        sifre += parcalar[i].Substring(0, 1).ToLower();
                        if (rastgele.Next(0, 2) == 1)
                            sifre += karakter;
                    }
                    else
                    {
                        sifre += parcalar[i].Substring(0, 1).ToUpper();
                        if (rastgele.Next(0, 2) == 0)
                            sifre += karakter;
                    }
                }
            }
            sifre += karakter;

           
            
                txt_olusan_sfire.Text = sifre;
        }

        

        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "insert into sifreler(sifre_adi,sifre)values(@sifre_adi,@sifre)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@sifre_adi", txt_nerenin_sifresi.Text);
                komut.Parameters.AddWithValue("@sifre", txt_olusan_sfire.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                btn_kaydet.Enabled = false;
                MessageBox.Show("Kayıt Başarılı!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Kaydedilemedi" + Environment.NewLine + ex.Message);
            }
            baglanti.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifreler frm = new sifreler();
            frm.Show();
            this.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        { 
            string tc = textBox1.Text;
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96U1VL9;Initial Catalog=kisiler;Integrated Security=True");
            SqlCommand kayıtsil = new SqlCommand("DELETE FROM giris Where tc_no=" + tc + "", baglanti);
            baglanti.Open();
            kayıtsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label5.Visible = false;
        }
    }
}
