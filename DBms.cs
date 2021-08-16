using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kooli_andmbaas
{
    class DBms //klass, mis tegeleb sql serveri connectioni toimimisega
    {
       SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=kool;Integrated Security=True");
        public void openconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeconnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection getconnection()
        {
            return connection;
        }

    }
}
