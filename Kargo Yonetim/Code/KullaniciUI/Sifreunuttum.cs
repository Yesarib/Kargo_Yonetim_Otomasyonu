using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace KullaniciUI
{
    public partial class Sifreunuttum : Form
    {
        public Sifreunuttum()
        {
            InitializeComponent();
        }
        
        
        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("yesari_yesari@hotmail.com");
            ePosta.To.Add(gunaTextBox1.Text);
            ePosta.Subject = konu;
            ePosta.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("yesari_yesari@hotmail.com", "byesari_142536");
            smtp.Port = 587;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;
            smtp.Send(ePosta);
            object us = true;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);                
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;
        }
        string sifre;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select * from bilgi where email='" + gunaTextBox1.Text + "'");
                komut.Connection = baglanti;
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    sifre = oku["sifre"].ToString();
                    MailGonder("Şifre Hatırlatma", "Şifreniz" + "" + sifre);
                    MessageBox.Show("Şifreniz e-postanıza gönderildi. Giriş yapabilirsiniz.");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Girmiş olduğunuz eposta adresi sistemde kayıtlı değil");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Mail gönderme hatası");
            }
        }
    }
}
