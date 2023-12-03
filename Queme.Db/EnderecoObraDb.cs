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
        public void IncluirEndereco(int idOrcamento, EnderecoServico enderecoServico)
        {
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
    }
}
