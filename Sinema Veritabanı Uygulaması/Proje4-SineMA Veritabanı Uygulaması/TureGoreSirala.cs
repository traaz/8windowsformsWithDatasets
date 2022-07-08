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
    public partial class TureGoreSirala : Form
    {
        public TureGoreSirala()
        {
            InitializeComponent();
        }

        private void TureGoreSirala_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbSinemaDataSet7.TblSinema' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSinemaTableAdapter2.Fill(this.dbSinemaDataSet7.TblSinema);
            // TODO: Bu kod satırı 'dbSinemaDataSet6.TblSinema' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSinemaTableAdapter1.Fill(this.dbSinemaDataSet6.TblSinema);
            // TODO: Bu kod satırı 'dbSinemaDataSet5.TblSinema' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSinemaTableAdapter.Fill(this.dbSinemaDataSet5.TblSinema);

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbSinema;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FilmAdi,FilmTuru,CikisTarih,Puan FROM TblSinema WHERE FilmTuru=@P1", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@P1", textBox1.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }
    }
}
