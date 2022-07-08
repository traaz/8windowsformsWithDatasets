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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=TALI;Initial Catalog=DbSecimProje;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //ilçe adlarını combobaxa çekmek
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT ILCEAD FROM TBLILCE", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]); //o. indeks çunku yukaridaki sorgudan bir tane sutun dondurulur               
            }
            baglanti.Close();


            //grafige veri çekmek
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) FROM TBLILCE",baglanti);
            SqlDataReader reader2=komut2.ExecuteReader();
            while(reader2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", reader2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", reader2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", reader2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", reader2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", reader2[4]);
            }
            baglanti.Close();

          
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLILCE WHERE ILCEAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader reader=komut.ExecuteReader();
            while (reader.Read())
            {
                progressBar1.Value = int.Parse(reader[2].ToString());
                progressBar2.Value = int.Parse(reader[3].ToString());
                progressBar3.Value = int.Parse(reader[4].ToString());
                progressBar4.Value = int.Parse(reader[5].ToString());
                progressBar5.Value = int.Parse(reader[6].ToString());

                lblA.Text = reader[2].ToString();
                lblB.Text = reader[3].ToString();
                lblC.Text = reader[4].ToString();
                lblD.Text = reader[5].ToString();
                lblE.Text = reader[6].ToString();
               

            }
            baglanti.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
