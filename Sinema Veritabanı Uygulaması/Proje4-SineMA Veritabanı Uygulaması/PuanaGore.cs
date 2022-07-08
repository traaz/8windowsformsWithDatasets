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
    public partial class PuanaGore : Form
    {
        public PuanaGore()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbSinema;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FilmAdi,FilmTuru,CikisTarih,Puan FROM TblSinema WHERE Puan=@P1", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@P1",Convert.ToInt32(textBox1.Text));
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void PuanaGore_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbSinemaDataSet8.TblSinema' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSinemaTableAdapter1.Fill(this.dbSinemaDataSet8.TblSinema);

        }
    }
}
