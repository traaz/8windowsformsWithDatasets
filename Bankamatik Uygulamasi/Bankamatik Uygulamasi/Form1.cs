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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbBanka;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            Kayit form2 = new Kayit();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Kisiler where HesapNo=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.numara = maskedTextBox1.Text;
                anaSayfa.Show();
            }
            else
            {
                MessageBox.Show("Şifre Veya HesapNo Yanlış");
            }
            baglanti.Close();
            
        }
    }
}
