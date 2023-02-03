using MarketBarkod.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod
{
    public partial class btnMainPage : Form
    {
        public btnMainPage()
        {
            InitializeComponent();
        }
        public void loadProducts()
        {
            SqlCommand commandProducts = new SqlCommand("Select ProductId, ProductName, ProductPrice, ProductBarcode, CategoryName From Products inner join  Categories on Products.ProductCategory = Categories.CategoryID", SqlConnectionClass.connection);
            SqlConnectionClass.checkConnection(SqlConnectionClass.connection);
            SqlDataAdapter da = new SqlDataAdapter(commandProducts);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridProduct.DataSource = dt;
        }
        public void loadCategories()
        {
            SqlCommand commandCategories = new SqlCommand("Select * From Categories", SqlConnectionClass.connection);
            SqlConnectionClass.checkConnection(SqlConnectionClass.connection);
            cmBoxCategory.ValueMember = "CategoryID";
            cmBoxCategory.DisplayMember = "CategoryName";

            SqlDataAdapter da = new SqlDataAdapter(commandCategories);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmBoxCategory.DataSource= dt;
            
        }
        private void AdminUrun_Load(object sender, EventArgs e)
        {
            loadProducts();
            loadCategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPName.Text.Length == 0 || tPprice.Text.Length == 0 || tPBarcode.Text.Length ==0)
            {
                MessageBox.Show("İlgili Alanları Giriniz");
            }
            else
            {
                SqlCommand commandAdd = new SqlCommand("insert into Products (ProductName, ProductCategory, ProductPrice,ProductBarcode) values (@pname,@category,@price,@barcode)", SqlConnectionClass.connection);
                SqlConnectionClass.checkConnection (SqlConnectionClass.connection);
                commandAdd.Parameters.AddWithValue("@pname", txtPName.Text);
                commandAdd.Parameters.AddWithValue("@category", Convert.ToInt32(cmBoxCategory.SelectedValue)); //categoryId aldik
                commandAdd.Parameters.AddWithValue("@price", tPprice.Text);
                commandAdd.Parameters.AddWithValue("@barcode", tPBarcode.Text);
                commandAdd.ExecuteNonQuery();
                increaseCategoryCount();
                loadProducts();
                MessageBox.Show("Ürün Eklendi");
                dataGridProduct.FirstDisplayedScrollingRowIndex = dataGridProduct.Rows.Count - 1;
                txtPName.Text = "";
                tPprice.Text = "";
                tPBarcode.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete From Products where ProductId=@id", SqlConnectionClass.connection);
            SqlConnectionClass.checkConnection(SqlConnectionClass.connection);
            commandDelete.Parameters.AddWithValue("@id", Convert.ToInt32(selectedId));
            commandDelete.ExecuteNonQuery();
            reduceCategoryCount();
            loadProducts();
            MessageBox.Show("Ürün Silindi");
        }
        string selectedId;
        private void dataGridProduct_SelectionChanged(object sender, EventArgs e)
        {
            selectedId = dataGridProduct.CurrentRow.Cells["ProductId"].Value.ToString();
            labelDelete.Text = selectedId;
        }
        public  void increaseCategoryCount()
        {
            SqlCommand commandIncrease = new SqlCommand("update Categories set CategoryCount +=1 where CategoryID=@id", SqlConnectionClass.connection);
            SqlConnectionClass.checkConnection(SqlConnectionClass.connection);
            commandIncrease.Parameters.AddWithValue("@id", Convert.ToInt32(cmBoxCategory.SelectedValue));
            commandIncrease.ExecuteNonQuery();


        }
        public void reduceCategoryCount()
        {
            SqlCommand commandReduce = new SqlCommand("update Categories set CategoryCount -= 1 where CategoryID=@id", SqlConnectionClass.connection);
            SqlConnectionClass.checkConnection(SqlConnectionClass.connection);
            commandReduce.Parameters.AddWithValue("@id", Convert.ToInt32(cmBoxCategory.SelectedValue));
            commandReduce.ExecuteNonQuery();
        }
    }
}
