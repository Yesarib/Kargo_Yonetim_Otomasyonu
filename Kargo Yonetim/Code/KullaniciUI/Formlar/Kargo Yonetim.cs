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
    public partial class KargoYonetim : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        public KargoYonetim()
        {
            InitializeComponent();
        }
        public void Göster()
        {

            da = new SqlDataAdapter("Select *from KYonetim", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "KYonetim");
            baglanti.Close();
            gunaDataGridView1.DataSource = ds.Tables["KYonetim"];
            gunaDataGridView1.ReadOnly = true;
        }
        private void KargoYonetim_Load(object sender, EventArgs e)
        {
            Göster();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            KargoEkle kargoEkle = new KargoEkle();
            kargoEkle.Show();
        }


        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tb1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KYonetim where TakipNo like '%"+ gunaTextBox1.Text + "%'",baglanti);
            da.Fill(tb1);
            baglanti.Close();
            gunaDataGridView1.DataSource = tb1;
        }

        private void gunaTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gunaTextBox1.Clear();
        }
        public void Sil(int no)
        {
            string sql = "DELETE from KYonetim where TakipNo=@tno";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@tno", no);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow draw in gunaDataGridView1.SelectedRows)
            {
                if (gunaDataGridView1.SelectedRows.Count==0) 
                {
                    MessageBox.Show("Seçili bir satır yok.");
                }
                else
                {
                    baglanti.Open();
                    SqlCommand verioku = new SqlCommand("select * from KYonetim where TakipNo = '" +"'",baglanti);
                    int id = (int)gunaDataGridView1.SelectedRows[0].Cells[0].Value;
                    DialogResult res = MessageBox.Show(id + " Numaralı kargoyu silmek istediğinize emin misiniz ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        int numara = Convert.ToInt32(draw.Cells[0].Value);
                        Sil(numara);
                        Göster();
                        baglanti.Close();
                    }
                    if (res == DialogResult.No)
                    {
                        baglanti.Close();
                    }

                }
            }
           
            
        }
        
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string durum,tno;
            tno = gunaDataGridView1.CurrentRow.Cells["TakipNo"].Value.ToString();
            durum = gunaComboBox1.Text;
            SqlCommand komut = new SqlCommand("Update KYonetim set Durum='"+durum+"' where TakipNo='"+tno+"'",baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Göster();
        }
        private void gunaDataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gunaTextBox2.Text = gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
