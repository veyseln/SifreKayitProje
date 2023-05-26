using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SifreKayıt
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96U1VL9;Initial Catalog=kisiler;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into giris(tc_no,kızlık_soyad)values(@tc_no,@kızlık_soyad)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc_no", textBox1.Text);
            komut.Parameters.AddWithValue("@kızlık_soyad", textBox2.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı!");
            textBox1.Clear();
            textBox2.Clear();
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.SelectionStart = textBox2.Text.Length;
        }
    }
}
