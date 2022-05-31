using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciUI.Formlar
{
    public partial class PersonelEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand cmd;
        public PersonelEkle()
        {
            InitializeComponent();
        }
        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("yesari_yesari@hotmail.com");
            ePosta.To.Add(gunaTextBoxE.Text);
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
        public int Sifre()
        {
            Random random = new Random();
            int sifre = random.Next(10000, 99999);
            return sifre;
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (gunaTextBoxTC.Text != "" && gunaTextBoxTel.Text != "" && gunaTextBoxE.Text != "" && gunaTextBoxAD.Text != "")
            {
                baglanti.Open();
                string kayit = "insert into PYonet (p_Email,p_Password,p_TC,p_AdSoyad,p_Tel,p_Yetki) values (@email,@sifre,@tc,@adsoyad,@tel,@yetki)";
                cmd = new SqlCommand(kayit, baglanti);
                if (gunaTextBoxTC.TextLength==11 && gunaTextBoxTel.TextLength == 10)
                {
                    cmd.Parameters.AddWithValue("@email", gunaTextBoxE.Text);
                    gunaTextBoxSifre.Text = Sifre().ToString();
                    cmd.Parameters.AddWithValue("@sifre", gunaTextBoxSifre.Text);
                    cmd.Parameters.AddWithValue("@tc", gunaTextBoxTC.Text);
                    cmd.Parameters.AddWithValue("@adsoyad", gunaTextBoxAD.Text);
                    cmd.Parameters.AddWithValue("@tel", gunaTextBoxTel.Text);
                    cmd.Parameters.AddWithValue("@yetki", gunaComboBox1.Text);
                    gunaLabel2.Show();
                    gunaTextBoxSifre.Show();
                    cmd.ExecuteNonQuery();
                    //MailGonder("ESP Kargo Hoşgeldiniz", "Sisteme giriş yapabilmeniz için aşağıdaki şifre ile giriş yapabilir ve daha sonra şifreyi değiştirebilirsiniz." + "\n" + gunaTextBoxSifre.Text);
                    MessageBox.Show("Kişi Eklendi.\nŞifresi oluştu ve e-posta adresine iletildi.");
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri doğru giriniz.");
                }
                baglanti.Close();
                
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
