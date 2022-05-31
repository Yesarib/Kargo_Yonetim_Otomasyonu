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

namespace KullaniciUI.Formlar
{
    public partial class KargoTakip : Form
    {
        public KargoTakip()
        {
            InitializeComponent();
            gunaTextBox2.Enter += (s, e) => { gunaTextBox2.Parent.Focus(); };
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;      

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void line3_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTransfarantPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void KargoTakip_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            gunaTextBox1.Clear();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text != " ")
            {
                cmd = new SqlCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "select * from KYonetim where TakipNo='" + gunaTextBox1.Text + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int a = Convert.ToInt32(dr["TakipNo"].ToString());
                    label1.Text = dr["Durum"].ToString();
                    gunaElipsePanel2.Show();
                    yolCizgi.Show();
                    gunaSa.Show();
                    gunaTeslim.Show();
                    gunaYol.Show();
                    gunaLabel2.Show();
                    gunaTextBox2.Text = a.ToString();
                    gunaTextBox2.Show();
                    gunaTextBox2.ReadOnly = true;
                    //gunaLabel3.Text = a.ToString();
                    //gunaLabel3.Show();
                    String durum = "";
                    durum = label1.Text;
                    if (durum.Trim().Equals("Kargo Alındı"))
                    {
                        gunaSa.ForeColor = Color.Green;
                        gunaTransfarantPictureBox3.Show();
                    }
                    if (durum.Trim().Equals("Yolda"))
                    {
                        gunaYol.ForeColor = Color.Green;
                        gunaSa.ForeColor = Color.Green;
                        gunaTransfarantPictureBox2.Show();
                    }
                    if (durum.Trim().Equals("Teslim Edildi"))
                    {
                        gunaTeslim.ForeColor = Color.Green;
                        gunaYol.ForeColor = Color.Green;
                        gunaSa.ForeColor = Color.Green;
                        gunaTransfarantPictureBox1.Show();
                    }
                }                
                baglanti.Close();
            }

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void gunaButton1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gunaTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gunaTextBox1.Clear();
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
