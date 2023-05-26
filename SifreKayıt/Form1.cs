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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-96U1VL9;Initial Catalog=kisiler;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show();
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from giris where  tc_no='" + tcgiris.Text + "'and kızlık_soyad='" + soyadgiris.Text+"'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                main frm = new main();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc no veya Annenizin Kızlık Soyadı Hatalı");
            }

            baglanti.Close();
        }

        private void soyadgiris_TextChanged(object sender, EventArgs e)
        {
           soyadgiris.Text = soyadgiris.Text.ToUpper();
            soyadgiris.SelectionStart = soyadgiris.Text.Length;
        }
    }
}
