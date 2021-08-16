using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooli_andmbaas
{
    class DBmy //klass, mis tegeleb mysql serveri connectioni toimimisega 
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;password=kohtla;database=kool");
        public void openconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) //kontrollib kas ühendus on
                connection.Open();
        }

        public void closeconnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) //kontrollib kas ühendus suletud
                connection.Close();
        }

        public MySqlConnection GetConnection() //kontrollib ühendavust tagastusfunkstiooga, sest puudub void 
        {
            return connection;
        }

    }
}
