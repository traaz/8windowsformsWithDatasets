using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MarketBarkod.Classes
{
    public class SqlConnectionClass
    {
       public static SqlConnection connection = new SqlConnection(@"Data Source=TALI;Initial Catalog=MarketDb;Integrated Security=True");
       public static void checkConnection(SqlConnection tempConnenction)
        {
            if(tempConnenction.State == System.Data.ConnectionState.Closed)
            {
                tempConnenction.Open();
            }
        }
    
    
    }
}
