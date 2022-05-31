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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public string eposta;
        private void Form1_Load(object sender, EventArgs e)
        {
            gunaTextBox1.Text = eposta;
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Sifreunuttum().Show();
        }
        public string yetki;
        public string tc;
        public string adsoyad;
        public string email;
        public string telefon;
        public void GirisYap()
        {
            try
            {
                if (gunaTextBox1.Text != "" && gunaTextBox2.Text != "")
                {
                    cmd = new SqlCommand();
                    baglanti.Open();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "select * from PYonet where p_Email='" + gunaTextBox1.Text + "' AND p_Password='" + gunaTextBox2.Text + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        yetki = dr["p_Yetki"].ToString().Trim();
                        tc = dr["p_TC"].ToString().Trim();
                        adsoyad = dr["p_AdSoyad"].ToString().Trim();
                        email = dr["p_Email"].ToString().Trim();
                        telefon = dr["p_Tel"].ToString().Trim();
                        new girisSayfa().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("E-posta yada şifre yanlış.");
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş. Lütfen kontrol ediniz.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void gunaLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new KayitOl().Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        { 
            gunaTextBox2.UseSystemPasswordChar = false;
            gunaButton4.Show();
            gunaButton3.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            gunaTextBox2.UseSystemPasswordChar = true;
            gunaButton4.Hide();
            gunaButton3.Show();
            
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
            gunaTextBox2.UseSystemPasswordChar = true;
        }
    }
}
