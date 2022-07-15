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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbBanka;Integrated Security=True");
        bool durum;
        void kontrol()
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From Kisiler where Tc=@p1 or Telefon=@p2 or HesapNo=@p3", baglanti);
            sqlCommand.Parameters.AddWithValue("@p1", mskTc.Text);
            sqlCommand.Parameters.AddWithValue("@p2", mskTel.Text);
            sqlCommand.Parameters.AddWithValue("@p3", mskHesap.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kontrol();
            if (durum == true)
            {
                if(txtAd.Text.Length != 0 && txtSoyad.Text.Length != 0 && mskTc.Text.Length != 0 && mskTel.Text.Length != 0 && mskHesap.Text.Length != 0 && txtSifre.Text.Length != 0)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Kisiler (Ad,Soyad,Tc,Telefon,HesapNo,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", mskTc.Text);
                    komut.Parameters.AddWithValue("@p4", mskTel.Text);
                    komut.Parameters.AddWithValue("@p5", mskHesap.Text);
                    komut.Parameters.AddWithValue("@p6", txtSifre.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kişi eklendi");

                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("insert into Hesaplar (HesapNo,Bakiye) values (@p1,@p2)", baglanti);
                    komut2.Parameters.AddWithValue("@p1", mskHesap.Text);
                    komut2.Parameters.AddWithValue("@p2", 50);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("İlgili yerleri tam doldurunuz");
                }
                    
                                  
            }
            else
            {
                MessageBox.Show("Kayıtlı kişi bulunmaktadir", "Tekrar Deneyin");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int hesapNo = random.Next(10000, 1000000);
            mskHesap.Text = hesapNo.ToString();
        }
    }
}
