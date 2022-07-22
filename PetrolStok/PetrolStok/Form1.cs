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

namespace PetrolStok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=PetrolStok;Integrated Security=True");

        void Kasa()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Kasa", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label23.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        void Listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Petroller where PetrolTur='Kursunsuz 95'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                label21.Text = reader[2].ToString();
                label8.Text = reader[3].ToString();
                progressBar1.Value = Convert.ToInt16(reader[4].ToString());
                label17.Text = reader[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From Petroller where PetrolTur='Dizel'", baglanti);
            SqlDataReader reader2 = komut2.ExecuteReader();
            while (reader2.Read())
            {
                label24.Text = reader2[2].ToString();
                label9.Text = reader2[3].ToString();
                progressBar2.Value = Convert.ToInt16(reader2[4].ToString());
                label18.Text = reader2[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From Petroller where PetrolTur='Pro Dizel'", baglanti);
            SqlDataReader reader3 = komut3.ExecuteReader();
            while (reader3.Read())
            {
                label25.Text = reader3[2].ToString();
                label10.Text = reader3[3].ToString();
                progressBar3.Value = Convert.ToInt16(reader3[4].ToString());
                label19.Text = reader3[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From Petroller where PetrolTur='Gaz'", baglanti);
            SqlDataReader reader4 = komut4.ExecuteReader();
            while (reader4.Read())
            {
                label26.Text = reader4[2].ToString();
                label11.Text = reader4[3].ToString();
                progressBar4.Value = Convert.ToInt16(reader4[4].ToString());
                label20.Text = reader4[4].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            Kasa();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //kursunsuz95
            int litre;
            double tutar;
            double kursunsuz95;

            kursunsuz95 = Convert.ToDouble(label8.Text);
            litre = Convert.ToInt32(numericUpDown1.Value);

            tutar = kursunsuz95 * litre;

            textBox1.Text=tutar.ToString();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //dizel
            int litre;
            double tutar;
            double dizel;

            dizel = Convert.ToDouble(label9.Text);
            litre = Convert.ToInt32(numericUpDown2.Value);

            tutar = dizel * litre;

            textBox2.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //prodizel
            int litre;
            double tutar;
            double dizel;

            dizel = Convert.ToDouble(label10.Text);
            litre = Convert.ToInt32(numericUpDown3.Value);

            tutar = dizel * litre;

            textBox3.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            //gaz
            int litre;
            double tutar;
            double dizel;

            dizel = Convert.ToDouble(label11.Text);
            litre = Convert.ToInt32(numericUpDown4.Value);

            tutar = dizel * litre;

            textBox4.Text = tutar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text.Length != 0)
            {
                if(numericUpDown1.Value != 0)//kursunsuz 95
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("insert into Satislar (Plaka,BenzinTur,Litre,Fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                    komut2.Parameters.AddWithValue("@p1", textBox5.Text);
                    komut2.Parameters.AddWithValue("@p2", label3.Text);
                    komut2.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                    komut2.Parameters.AddWithValue("@p4", Convert.ToDecimal(textBox1.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();

                   
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Petroller set Stok=Stok-@p1 where PetrolTur='Kursunsuz 95'", baglanti);
                    komut.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                   
                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update Kasa set Miktar=Miktar+@p1", baglanti);
                    komut3.Parameters.AddWithValue("@p1", Convert.ToDecimal(textBox1.Text));
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Satış Yapıldı");
                    Listele();
                    Kasa();
                }

                if (numericUpDown2.Value != 0)//dizel
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("insert into Satislar (Plaka,BenzinTur,Litre,Fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                    komut2.Parameters.AddWithValue("@p1", textBox5.Text);
                    komut2.Parameters.AddWithValue("@p2", label4.Text);
                    komut2.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                    komut2.Parameters.AddWithValue("@p4", Convert.ToDecimal(textBox2.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();


                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Petroller set Stok=Stok-@p1 where PetrolTur='Dizel'", baglanti);
                    komut.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update Kasa set Miktar=Miktar+@p1", baglanti);
                    komut3.Parameters.AddWithValue("@p1", Convert.ToDecimal(textBox2.Text));
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Satış Yapıldı");
                    Listele();
                    Kasa();
                }
                if (numericUpDown3.Value != 0)//prodizel
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("insert into Satislar (Plaka,BenzinTur,Litre,Fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                    komut2.Parameters.AddWithValue("@p1", textBox5.Text);
                    komut2.Parameters.AddWithValue("@p2", label5.Text);
                    komut2.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                    komut2.Parameters.AddWithValue("@p4", Convert.ToDecimal(textBox3.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();


                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Petroller set Stok=Stok-@p1 where PetrolTur='Pro Dizel'", baglanti);
                    komut.Parameters.AddWithValue("@p1", numericUpDown3.Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update Kasa set Miktar=Miktar+@p1", baglanti);
                    komut3.Parameters.AddWithValue("@p1", Convert.ToDecimal(textBox3.Text));
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Satış Yapıldı");
                    Listele();
                    Kasa();
                }
                if (numericUpDown4.Value != 0)//gaz
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("insert into Satislar (Plaka,BenzinTur,Litre,Fiyat) values (@p1,@p2,@p3,@p4)", baglanti);
                    komut2.Parameters.AddWithValue("@p1", textBox5.Text);
                    komut2.Parameters.AddWithValue("@p2", label6.Text);
                    komut2.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                    komut2.Parameters.AddWithValue("@p4", Convert.ToDecimal(textBox4.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();


                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update Petroller set Stok=Stok-@p1 where PetrolTur='Gaz'", baglanti);
                    komut.Parameters.AddWithValue("@p1", numericUpDown4.Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand komut3 = new SqlCommand("update Kasa set Miktar=Miktar+@p1", baglanti);
                    komut3.Parameters.AddWithValue("@p1", Convert.ToDecimal(textBox4.Text));
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Satış Yapıldı");
                    Listele();
                    Kasa();
                }



            }
            else
            {
                MessageBox.Show("Lütfen Plaka Giriniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int eklenecekLitre;
            double alisFiyat;
            double fiyat;
            eklenecekLitre = Convert.ToInt32(textBox6.Text);
            alisFiyat = Convert.ToDouble(label21.Text);
            fiyat = alisFiyat * eklenecekLitre;
            if (progressBar1.Value+eklenecekLitre>10000)
            {
                MessageBox.Show("Ekleme Başarısız...Depo maksimum 10.000 Litre Benzin Alır.");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Petroller set Stok=Stok+@p1 where PetrolTur='Kursunsuz 95'", baglanti);
                komut2.Parameters.AddWithValue("@p1", textBox6.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Kasa set Miktar=Miktar-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", fiyat);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satın alma gerçekleşti\n" + fiyat + " TL.");
                Listele();
                Kasa();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int eklenecekLitre;
            double alisFiyat;
            double fiyat;
            eklenecekLitre = Convert.ToInt32(textBox7.Text);
            alisFiyat = Convert.ToDouble(label24.Text);
            fiyat = alisFiyat * eklenecekLitre;
            if (progressBar2.Value + eklenecekLitre > 10000)
            {
                MessageBox.Show("Ekleme Başarısız...Depo maksimum 10.000 Litre Benzin Alır.");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Petroller set Stok=Stok+@p1 where PetrolTur='Dizel'", baglanti);
                komut2.Parameters.AddWithValue("@p1", textBox7.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Kasa set Miktar=Miktar-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", fiyat);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satın alma gerçekleşti\n" + fiyat + " TL.");
                Listele();
                Kasa();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int eklenecekLitre;
            double alisFiyat;
            double fiyat;
            eklenecekLitre = Convert.ToInt32(textBox8.Text);
            alisFiyat = Convert.ToDouble(label25.Text);
            fiyat = alisFiyat * eklenecekLitre;
            if (progressBar3.Value + eklenecekLitre > 10000)
            {
                MessageBox.Show("Ekleme Başarısız...Depo maksimum 10.000 Litre Benzin Alır.");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Petroller set Stok=Stok+@p1 where PetrolTur='Pro Dizel'", baglanti);
                komut2.Parameters.AddWithValue("@p1", textBox8.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Kasa set Miktar=Miktar-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", fiyat);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satın alma gerçekleşti\n" + fiyat + " TL.");
                Listele();
                Kasa();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int eklenecekLitre;
            double alisFiyat;
            double fiyat;
            eklenecekLitre = Convert.ToInt32(textBox9.Text);
            alisFiyat = Convert.ToDouble(label26.Text);
            fiyat = alisFiyat * eklenecekLitre;
            if (progressBar4.Value + eklenecekLitre > 10000)
            {
                MessageBox.Show("Ekleme Başarısız...Depo maksimum 10.000 Litre Benzin Alır.");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Petroller set Stok=Stok+@p1 where PetrolTur='Gaz'", baglanti);
                komut2.Parameters.AddWithValue("@p1", textBox9.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Kasa set Miktar=Miktar-@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", fiyat);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satın alma gerçekleşti\n" + fiyat + " TL.");
                Listele();
                Kasa();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
