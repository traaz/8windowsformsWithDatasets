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

namespace SifreliKayitUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=SifreliKayit;Integrated Security=True");
        void sifreliListele()
        {
            SqlDataAdapter da=new SqlDataAdapter("Select * From Kisiler",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void sifresizListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From KisilerSifresiz", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            string ad = textBox1.Text;
            byte[] adDizi=ASCIIEncoding.ASCII.GetBytes(ad);
            string adSifre=Convert.ToBase64String(adDizi);

            string soyad = textBox2.Text;
            byte[] soyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadSifre = Convert.ToBase64String(soyadDizi);

            string mail = textBox3.Text;
            byte[] mailDizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailSifre = Convert.ToBase64String(mailDizi);

            string sifre = textBox4.Text;
            byte[] sfireDizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreSifre = Convert.ToBase64String(sfireDizi);

            string hesapNo = textBox5.Text;
            byte[] hesapNoDizi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string hesapNoSifre = Convert.ToBase64String(hesapNoDizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kisiler (Ad,Soyad,Mail,Sifre,HesapNo) values (@P1,@P2,@P3,@P4,@P5)", baglanti);
            komut.Parameters.AddWithValue("@P1",adSifre);
            komut.Parameters.AddWithValue("@P2", soyadSifre);
            komut.Parameters.AddWithValue("@P3", mailSifre);
            komut.Parameters.AddWithValue("@P4", sifreSifre);
            komut.Parameters.AddWithValue("@P5", hesapNoSifre);

            komut.ExecuteNonQuery();
            baglanti.Close();
            sifreliListele();
           
            
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into KisilerSifresiz (Ad,Soyad,Mail,Sifre,HesapNo) values (@P1,@P2,@P3,@P4,@P5)", baglanti);
            komut2.Parameters.AddWithValue("@P1", textBox1.Text);
            komut2.Parameters.AddWithValue("@P2", textBox2.Text);
            komut2.Parameters.AddWithValue("@P3", textBox3.Text);
            komut2.Parameters.AddWithValue("@P4", textBox4.Text);
            komut2.Parameters.AddWithValue("@P5", textBox5.Text);

            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi eklendi");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sifreliListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifresizListele();

        }
    }
}
