using MySql.Data.MySqlClient;
using Queme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class OrcamentoDb
    {
        public int Incluir(Orcamento orcamento)
        {
            int id=0;
            string sql = @"INSERT INTO orcamentos(status,id_cliente, data_criacao) values(@status,@id_cliente, @data_criacao)";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@status", orcamento.Status.ToString());
            cmd.Parameters.AddWithValue("@id_cliente", orcamento.Id_cliente);
            cmd.Parameters.AddWithValue("@data_criacao", orcamento.Data.ToString("yyyy-MM-dd"));
            cn.Open();
            cmd.ExecuteNonQuery();
            //capturar id salvo
            var cmdId = new MySqlCommand(@"SELECT LAST_INSERT_ID() as id_orcamento FROM orcamentos", cn);

            using (MySqlDataReader reader = cmdId.ExecuteReader())
            {
                try
                {
                    if(reader.Read())
                    {
                        id = Convert.ToInt32(reader["id_orcamento"]);
                    }
                }catch (Exception ex)
                {
                    // to-do: tratamento de erro deste método
                    throw new Exception(ex.Message);
                }
            }


            cn.Close();
            return id;
        }
    }
}
