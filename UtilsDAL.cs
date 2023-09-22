using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Crud2023.DAL
{
    class UtilsDAL
    {

        // Método que realiza a conexão com o banco de dados

        public static MySqlConnection GetConnection()
        {
            //criar objeto que construa a conexão

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cad_usuario",
                UserID = "root",
                Password = ""
            };

            //criar conexão com o banco

            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            conn.Open(); // abre a conexão
            return conn;
        }

    }
}
