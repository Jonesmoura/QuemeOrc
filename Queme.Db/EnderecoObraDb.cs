using MySql.Data.MySqlClient;
using Queme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class EnderecoObraDb
    {
        public static void IncluirEndereco(int idOrcamento, EnderecoServico enderecoServico)
        {
            // to:do criar esta tabela no banco
            string sql = @"INSERT INTO enderecoObras(id_orcamento, CEP, complementeo) values (@id_orcamento, @CEP, @complemento)";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", idOrcamento);
            cmd.Parameters.AddWithValue("@CEP", enderecoServico.CEP);
            cmd.Parameters.AddWithValue("@complemento", enderecoServico.Complemento);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public static EnderecoServico IncluirEndereco(int idOrcamento, string cep, string? complemento, int numero)
        {
            int id = 0;
            string sql = @"INSERT INTO enderecoObras(id_orcamento, CEP, numero, complemento) values (@id_orcamento, @CEP,@numero, @complemento)";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", idOrcamento);
            cmd.Parameters.AddWithValue("@CEP", cep);
            cmd.Parameters.AddWithValue("@complemento", complemento);
            cmd.Parameters.AddWithValue("@numero", numero);
            cn.Open();
            cmd.ExecuteNonQuery();

            var cmdId = new MySqlCommand(@"SELECT LAST_INSERT_ID() as id_endereco FROM enderecoObras", cn);

            using (MySqlDataReader reader = cmdId.ExecuteReader())
            {
                try
                {
                    if (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id_endereco"]);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            cn.Close();
            EnderecoServico enderecoServico = new EnderecoServico(id, cep, numero, complemento);

            return enderecoServico;
        }

    }
}
