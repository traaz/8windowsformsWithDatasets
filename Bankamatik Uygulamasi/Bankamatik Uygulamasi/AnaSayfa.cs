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

namespace Bankamatik_Uygulamasi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbBanka;Integrated Security=True");
        bool durum;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        void kontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Kisiler where HesapNo=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                durum= true;
            }
            else
            {
                durum= false;
            }
            baglanti.Close();
        }
        void bakiyeAl()
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Bakiye From Hesaplar where HesapNo=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                lblBakiye.Text = dr2[0].ToString();
            }
            baglanti.Close();

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            lblHesap.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Ad,Soyad,Tc,Telefon From Kisiler where HesapNo=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblAd.Text = dr[0].ToString();
                lblSoyad.Text= dr[1].ToString();
                lblTc.Text = dr[2].ToString();
                lblTel.Text= dr[3].ToString();

            }
            baglanti.Close();


            bakiyeAl();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kontrol();
            if (durum == true)
            {
                //gönderilen hesabin para artisi
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Hesaplar set Bakiye=Bakiye+@p1 where HesapNo=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", decimal.Parse(textBox1.Text));
                komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                

                //gönderen hesabin para azalisi
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Hesaplar set Bakiye=Bakiye-@p1 where HesapNo=@p2", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(textBox1.Text));
                komut2.Parameters.AddWithValue("@p2", numara);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Para Gönderildi.");
                bakiyeAl();

                //hesap ozeti
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into Hareketler (GonderenHesapNp,AliciHesapNo,Tutar) values (@p1,@p2,@p3)", baglanti);
                komut3.Parameters.AddWithValue("@p1", numara);
                komut3.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
                komut3.Parameters.AddWithValue("@p3", decimal.Parse(textBox1.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Böyle Bir HesapNo Sisteme kayıtlı değil..");
            }
        }
    }
}
