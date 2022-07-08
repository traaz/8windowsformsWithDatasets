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
    public partial class YilaGoreSirala : Form
    {
        public YilaGoreSirala()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbSinema;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FilmAdi,FilmTuru,CikisTarih,Puan FROM TblSinema WHERE CikisTarih=@P1", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@P1", Convert.ToInt32(textBox1.Text));
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void YilaGoreSirala_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbSinemaDataSet9.TblSinema' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSinemaTableAdapter2.Fill(this.dbSinemaDataSet9.TblSinema);
            // TODO: Bu kod satırı 'dbSinemaDataSet4.TblSinema' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSinemaTableAdapter1.Fill(this.dbSinemaDataSet4.TblSinema);
            // TODO: Bu kod satırı 'dbSinemaDataSet3.TblSinema' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSinemaTableAdapter.Fill(this.dbSinemaDataSet3.TblSinema);

        }
    }
}
