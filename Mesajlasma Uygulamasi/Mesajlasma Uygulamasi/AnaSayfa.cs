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

namespace Mesajlasma_Uygulamasi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti=new SqlConnection(@"Data Source=TALI;Initial Catalog=DbMesajlasma;Integrated Security=True");
        
        void GelenKutusu()
        {
            SqlDataAdapter da=new SqlDataAdapter("Select (Ad+' '+Soyad) AS Gonderen,Baslik,Icerik From Mesajlasma inner join Kisiler on Mesajlasma.Gonderen = Kisiler.Numara Where Alici = " +numara,baglanti);
            DataTable dt1=new DataTable();  
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            
        }
        void GidenKutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select (Ad+' '+Soyad) AS Alici,Baslik,Icerik From Mesajlasma inner join Kisiler on Mesajlasma.Alici = Kisiler.Numara Where Gonderen = " + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            GelenKutusu();
            GidenKutusu();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Ad,Soyad From Kisiler where Numara="+ numara,baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                label8.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlasma (Gonderen,Alici,Baslik,Icerik) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            komut.Parameters.AddWithValue("@P2", textBox1.Text);
            komut.Parameters.AddWithValue("@P3", textBox2.Text);

            komut.Parameters.AddWithValue("@P4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesaj Gönderildi");
            GidenKutusu();


        }

    }
}
