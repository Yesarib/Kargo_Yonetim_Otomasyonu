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
    public partial class PersonelYonetim : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I69MM9H\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        public void Göster()
        {
            da = new SqlDataAdapter("Select *from PYonet", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "PYonet");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["PYonet"];
            dataGridView1.ReadOnly = true;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public PersonelYonetim()
        {
            InitializeComponent();
            Göster();
        }
        public void Sil(int no)
        {
            string sql = "DELETE from PYonet where id=@id";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", no);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow draw in dataGridView1.SelectedRows)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seçili bir satır yok.");
                }
                else
                {
                    baglanti.Open();
                    SqlCommand verioku = new SqlCommand("select * from PYonet where id = '" + "'", baglanti);
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    DialogResult res = MessageBox.Show(id + "ID'e sahip personeli çıkarmak istediğinize emin misiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            personelEkle.Show();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tb1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from PYonet where p_TC like '%" + gunaTextBox1.Text + "%'", baglanti);
            da.Fill(tb1);
            baglanti.Close();
            dataGridView1.DataSource = tb1;
        }

        private void gunaTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gunaTextBox1.Clear();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string yetki, id;
            id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            yetki = gunaComboBox1.Text;
            SqlCommand komut = new SqlCommand("Update PYonet set p_Yetki='" + yetki + "' where id='" + id + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Göster();
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                gunaTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
