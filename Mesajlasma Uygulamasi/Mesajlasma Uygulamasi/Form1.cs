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
    public partial class MesajApp : Form
    {
        public MesajApp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbMesajlasma;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Kisiler where Numara=@P1 AND Sifre=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            komut.Parameters.AddWithValue("@P2", textBox2.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                AnaSayfa ana = new AnaSayfa();
                ana.numara = textBox1.Text;
                ana.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            baglanti.Close();
        }
    }
}
