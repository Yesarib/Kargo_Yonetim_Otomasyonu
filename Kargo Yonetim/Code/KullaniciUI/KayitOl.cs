using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KullaniciUI
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand cmd;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        public void Ekle()
        {
            if (gunaTextBox1.Text!="" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "" && gunaTextBox4.Text != "")
            {
                baglanti.Open();
                string kayit = "insert into bilgi (email,sifre,ad,soyad) values (@email,@sifre,@ad,@soyad)";
                cmd = new SqlCommand(kayit, baglanti);
                cmd.Parameters.AddWithValue("@email", gunaTextBox3.Text);
                cmd.Parameters.AddWithValue("@sifre", gunaTextBox4.Text);
                cmd.Parameters.AddWithValue("@ad", gunaTextBox1.Text);
                cmd.Parameters.AddWithValue("@soyad", gunaTextBox2.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla kayıt oldunuz. Giriş yapabilirsiniz.");
            }
            else
            {
                MessageBox.Show("Lütfen boş bırakmayınız.");
            }
            

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
