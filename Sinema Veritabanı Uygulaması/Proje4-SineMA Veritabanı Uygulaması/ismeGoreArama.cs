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
    public partial class ismeGoreArama : Form
    {
        public ismeGoreArama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbSinema;Integrated Security=True");
        private void ismeGoreArama_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbSinemaDataSet.TblSinema' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSinemaTableAdapter.Fill(this.dbSinemaDataSet.TblSinema);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TblSinema WHERE FilmAdi=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", txtFilmAdi.Text);
            SqlDataReader reader=komut.ExecuteReader();
            while (reader.Read())
            {
                txtTur.Text = reader[2].ToString();
                txtCikis.Text = reader[3].ToString();
                txtPuan.Text=reader[4].ToString();
            }
            
            baglanti.Close();
            
            
        }
    }
}
