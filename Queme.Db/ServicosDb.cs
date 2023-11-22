using MySql.Data.MySqlClient;
using Queme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class ServicosDb
    {
        public void IncluirServico(Servico servico)
        {
            string sql = @"INSERT INTO servicos(id_orcamento,tipo_servico, Etapa, qtd_horas, valor_hora) values(@id_orcamento,@tipo_servico,@Etapa,@qtd_horas, @valor_hora )";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", servico.Id_orcamento);
            cmd.Parameters.AddWithValue("@tipo_servico", servico.TipoServico.ToString());
            cmd.Parameters.AddWithValue("@Etapa", servico.Etapa.ToString());
            cmd.Parameters.AddWithValue("@qtd_horas", servico.Qtd_horas);
            cmd.Parameters.AddWithValue("@valor_hora", servico.ValorHora);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
