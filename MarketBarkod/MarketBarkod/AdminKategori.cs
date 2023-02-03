using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MarketBarkod.Classes;

namespace MarketBarkod
{
    public partial class AdminKategori : Form
    {
        public AdminKategori()
        {
            InitializeComponent();
        }
        public void loadCategories()
        {
            SqlCommand commandCategories = new SqlCommand("Select * From Categories", SqlConnectionClass.connection);
            SqlConnectionClass.checkConnection(SqlConnectionClass.connection);
            SqlDataAdapter da = new SqlDataAdapter(commandCategories);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void AdminKategori_Load(object sender, EventArgs e)
        {
            loadCategories();

        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            SqlCommand commandAddCategory = new SqlCommand("insert into Categories (CategoryName) values (@pname)", SqlConnectionClass.connection);
            SqlConnectionClass.checkConnection(SqlConnectionClass.connection);
            commandAddCategory.Parameters.AddWithValue("@pname", textBoxCategory.Text);
            commandAddCategory.ExecuteNonQuery();
            loadCategories();
            MessageBox.Show("Kategori Eklendi");
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            textBoxCategory.Text = "";
        }
        string selectedId;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete From Categories where CategoryID=@id", SqlConnectionClass.connection);
            SqlConnectionClass.checkConnection(SqlConnectionClass.connection);
            commandDelete.Parameters.AddWithValue("@id", Convert.ToInt32(selectedId));
            commandDelete.ExecuteNonQuery();
            loadCategories();
            MessageBox.Show("Kategori Silindi");

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedId = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();   
            labelSelectedId.Text = selectedId;
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
