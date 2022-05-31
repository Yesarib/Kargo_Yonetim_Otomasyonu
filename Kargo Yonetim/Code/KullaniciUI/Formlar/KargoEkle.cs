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
    public partial class KargoEkle : Form
    {
        public KargoEkle()
        {
            InitializeComponent();
        }
        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("yesari_yesari@hotmail.com");
            ePosta.To.Add(gunaTextBox9.Text);
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
        public int takipNo()
        {
            Random random = new Random();
            int takipNo = random.Next(100000000,999999999);
            return takipNo;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        SqlCommand cmd;
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "insert into KYonetim (TakipNo,G_TC,A_TC,G_Ad,A_Ad,G_Email,A_Email,G_Tel,A_Tel,Adres,Durum,Ucret,Ağırlık) values (@takipNo,@gtc,@atc,@gad,@aad,@gmail,@amail,@gtel,@atel,@adres,@durum,@ucret,@agırlık)";
            cmd = new SqlCommand(kayit, baglanti);
            if(gunaTextBox1.Text != "" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "" && gunaTextBox4.Text != "" && gunaTextBox5.Text != "" && gunaTextBox6.Text != "" && gunaTextBox7.Text != "" && gunaTextBox8.Text != "" && gunaTextBox9.Text != ""  && gunaTextBox11.Text != "") 
            {
                if(gunaTextBox4.Text.Length == 11 && gunaTextBox7.Text.Length==11 && gunaTextBox2.Text.Length ==10 && gunaTextBox5.Text.Length == 10)
                {
                    cmd.Parameters.AddWithValue("@gtc", gunaTextBox4.Text);
                    cmd.Parameters.AddWithValue("@atc", gunaTextBox7.Text);
                    cmd.Parameters.AddWithValue("@gad", gunaTextBox1.Text);
                    cmd.Parameters.AddWithValue("@aad", gunaTextBox6.Text);
                    cmd.Parameters.AddWithValue("@gmail", gunaTextBox8.Text);
                    cmd.Parameters.AddWithValue("@amail", gunaTextBox9.Text);
                    cmd.Parameters.AddWithValue("@gtel", gunaTextBox2.Text);
                    cmd.Parameters.AddWithValue("@atel", gunaTextBox5.Text);
                    cmd.Parameters.AddWithValue("@adres", gunaTextBox3.Text);
                    String durum = "Kargo Alındı";
                    cmd.Parameters.AddWithValue("@durum", durum);
                    string ucret = gunaComboBox1.Text;
                    cmd.Parameters.AddWithValue("@ucret", ucret);
                    cmd.Parameters.AddWithValue("@agırlık", gunaTextBox11.Text);
                    gunaTextBox10.Text = takipNo().ToString();
                    cmd.Parameters.AddWithValue("@takipNo", gunaTextBox10.Text);
                    //MailGonder("ESP Kargo Takip No", "Gönderdiğiniz kargonun takip numarası aşağıda yer almaktadır." + "\n" + gunaTextBox10.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kargo Eklendi.\nTakip No üretildi.");
                }
                else
                {
                    MessageBox.Show("Bilgileri doğru giriniz.");
                }                
            }
            else
            {
                MessageBox.Show("Bilgileri doldurunuz.");
            }
            baglanti.Close();
                
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
