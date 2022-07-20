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

namespace KitapKayitYedek_Trigger_
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti=new SqlConnection(@"Data Source=TALI;Initial Catalog=KitapDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Kitaplar",baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Sayac", baglanti);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                kitapSayilbl.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitaplar (AD,YAZAR,SAYFA,YAYINEVI,TUR) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p4", txtyayinevi.Text);
            komut.Parameters.AddWithValue("@p5", txttur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi");
            listele();
            sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtyayinevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txttur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Kitaplar where Id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi");
            listele();
            sayac();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textId.Clear();
            txtAd.Clear();
            txtYazar.Clear();
            txtSayfa.Clear();
            txtyayinevi.Clear();
            txttur.Clear();
        }
    }
}
