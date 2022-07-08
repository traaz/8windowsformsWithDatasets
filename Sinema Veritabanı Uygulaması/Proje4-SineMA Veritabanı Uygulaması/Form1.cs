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

namespace Proje4_SineMA_Veritabanı_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbSinema;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtPaun.Text) <= 10)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TblSinema (FilmAdi,FilmTuru,CikisTarih,Puan) values (@P1,@P2,@P3,@P4)", baglanti);
                komut.Parameters.AddWithValue("@P1", txtFilm.Text);
                komut.Parameters.AddWithValue("@P2", txttur.Text);
                komut.Parameters.AddWithValue("@P3", txtcikis.Text);
                komut.Parameters.AddWithValue("@P4", txtPaun.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Film Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen Doğru Doldurun");
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ismeGoreArama ismeGoreArama = new ismeGoreArama();
            ismeGoreArama.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PuanaGore puanaGore = new PuanaGore();
            puanaGore.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YilaGoreSirala yila=new YilaGoreSirala();
            yila.Show();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TureGoreSirala tureGoreSirala = new TureGoreSirala();
            tureGoreSirala.Show();  
        }
    }
}
