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


namespace Proje2_SecimIstatistik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbSecimProje;Integrated Security=True");

        private void btnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)",baglanti);
            komut.Parameters.AddWithValue("@P1", txtilce.Text);
            komut.Parameters.AddWithValue("@P2", txtA.Text);
            komut.Parameters.AddWithValue("@P3", txtb.Text);
            komut.Parameters.AddWithValue("@P4", txtC.Text);
            komut.Parameters.AddWithValue("@P5", txtD.Text);
            komut.Parameters.AddWithValue("@P6", txtE.Text);
            komut.ExecuteNonQuery();//dataseti degistirirsek execute nonquery insert update delete
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler grafikler = new FrmGrafikler();
            grafikler.Show();
        }

       

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
