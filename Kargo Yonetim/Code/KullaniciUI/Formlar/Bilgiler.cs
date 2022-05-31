using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciUI.Formlar
{
    public partial class Bilgiler : Form
    {
        public Bilgiler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        
        private void Bilgiler_Load(object sender, EventArgs e)
        {
            bilgiGetir();
            try
            {
                SqlCommand mevcutsifre = new SqlCommand();
                baglanti.Open();
                mevcutsifre.Connection = baglanti;
                mevcutsifre.CommandText = "select * from PYonet where p_Password='" + gunaTextBoxES.Text + "'";
                SqlDataReader dr = mevcutsifre.ExecuteReader();
                if (dr.Read())
                {
                    gunaTextBoxES.Text = dr["p_Passowrd"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void bilgiGetir()
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            gunaTextBox1.Text = form1.tc ;
            gunaTextBox2.Text = form1.adsoyad;
            gunaTextBox3.Text = form1.email;
            gunaTextBox4.Text = form1.telefon;

        }

        private void gunaLineTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        public void Degistir()
        {
            try
            {
                baglanti.Open();
                string kayit = "update PYonet set p_Password=@p1 where p_Email='" + gunaTextBox3.Text + "'";
                SqlCommand guncelle = new SqlCommand(kayit, baglanti);
                guncelle.Parameters.AddWithValue("@p1", gunaTextBoxYS.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(gunaTextBoxES.Text !="" && gunaTextBoxYS.Text != "" && gunaTextBoxYST.Text != "")
            {                
                if(gunaTextBoxYS.Text == gunaTextBoxYST.Text)
                {
                    Degistir();
                }
            }
        }
    }
}
