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
namespace RehberUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=Rehber;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            this.kisilerTableAdapter.Fill(this.rehberDataSet.Kisiler);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kisiler (AD,SOYAD,TELEFON,MAIL) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", mskPhone.Text);
            komut.Parameters.AddWithValue("@P4", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Eklendi");
            this.kisilerTableAdapter.Fill(this.rehberDataSet.Kisiler);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskPhone.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Kisiler where ID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Silindi");
            this.kisilerTableAdapter.Fill(this.rehberDataSet.Kisiler);
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  Kisiler set AD=@P1,SOYAD=@P2,TELEFON=@P3,MAIL=@P4 where ID=@P5", baglanti);
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", mskPhone.Text);
            komut.Parameters.AddWithValue("@P4", txtMail.Text);
            komut.Parameters.AddWithValue("@P5", txtId.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi bilgisi güncellendi");
            this.kisilerTableAdapter.Fill(this.rehberDataSet.Kisiler);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'rehberDataSet.Kisiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kisilerTableAdapter.Fill(this.rehberDataSet.Kisiler);

        }
    }
}
