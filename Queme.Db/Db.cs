using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Queme.Db
{
    public static class Db
    {
        public static string connect
        {
            get
            {
                string servidor = "queme.com.br";
                string database = "quemec99_orcamentos";
                string usuario = "quemec99_admin";
                string senha = "j9r-tR3l?!N0";
                string porta = "3306";
                string connectionString = $"Server={servidor};Port={porta};Database={database};User={usuario};Password={senha};";

                return connectionString;
            }
        }
    }
}
