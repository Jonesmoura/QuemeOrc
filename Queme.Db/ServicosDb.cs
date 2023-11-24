using MySql.Data.MySqlClient;
using Queme.Models;
using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Queme.Db
{
    public class ServicosDb
    {
        public void IncluirServico(Servico servico)
        {
            string sql = @"INSERT INTO servicos(id_orcamento,tipo_servico, Etapa, qtd_horas, valor_hora, totalServico) values(@id_orcamento,@tipo_servico,@Etapa,@qtd_horas, @valor_hora, @totalServico )";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", servico.Id_orcamento);
            cmd.Parameters.AddWithValue("@tipo_servico", servico.TipoServico.ToString());
            cmd.Parameters.AddWithValue("@Etapa", servico.Etapa.ToString());
            cmd.Parameters.AddWithValue("@qtd_horas", servico.Qtd_horas);
            cmd.Parameters.AddWithValue("@valor_hora", servico.ValorHora);
            cmd.Parameters.AddWithValue("@totalServico", servico.TotalServico);


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public List<Servico> GetServicoList(int id_orcamento) 
        {
            string sql = @"SELECT tipo_servico, Etapa, qtd_horas, valor_hora, totalServico FROM servicos WHERE id_orcamento = @id_orcamento;";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", id_orcamento);

            List<Servico> servicos = new List<Servico>();

            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Servico servico = new Servico();
                servico.Etapa = Enum.Parse<EtapasServico>(reader["Etapa"].ToString());
                servico.TipoServico = Enum.Parse<TipoServico>(reader["tipo_servico"].ToString());
                servico.Qtd_horas = int.Parse(reader["qtd_horas"].ToString());
                servico.ValorHora = double.Parse(reader["valor_hora"].ToString(), CultureInfo.InvariantCulture);
                servico.TotalServico = double.Parse(reader["totalServico"].ToString(), CultureInfo.InvariantCulture);

                servicos.Add(servico);

            }

            reader.Close();
            cn.Close();
            return servicos;

        }
    }
}
