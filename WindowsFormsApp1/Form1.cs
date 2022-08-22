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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void VeriGetir()
        {
            baglanti = new SqlConnection("Data Source=axdbserver;Initial Catalog=test;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Table_2", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
           
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yas.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string sorgu = "INSERT INTO Table_2(ad,soyad,yas) values(@ad,@soyad,@yas)";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@ad", ad.Text);
                komut.Parameters.AddWithValue("@soyad", soyad.Text);
                komut.Parameters.AddWithValue("@yas", yas.Text);

    
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veriler Eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                VeriGetir();
            }
            catch(Exception error)
            {
                MessageBox.Show("Hata meydana geldi." + error.Message);
            }
         

        }

        private void sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Table_2 WHERE ad=@ad";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", ad.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Silindi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            VeriGetir();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Table_2 SET soyad=@soyad,yas=@yas WHERE ad=@ad";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", ad.Text);
            komut.Parameters.AddWithValue("@soyad", soyad.Text);
            komut.Parameters.AddWithValue("@yas", yas.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            VeriGetir();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
