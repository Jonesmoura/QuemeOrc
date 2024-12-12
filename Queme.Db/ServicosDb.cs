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
            string sql = @"SELECT tipo_servico, Etapa, qtd_horas, valor_hora, totalServico, idServico FROM servicos WHERE id_orcamento = @id_orcamento;";
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
                servico.Id = int.Parse(reader["idServico"].ToString());
                servico.ValorHora = double.Parse(reader["valor_hora"].ToString());
                servico.TotalServico = double.Parse(reader["totalServico"].ToString());

                servicos.Add(servico);

            }

            reader.Close();
            cn.Close();
            return servicos;

        }

        public void Excluir(Servico servicoExluir)
        {
            string sql = @"DELETE FROM servicos WHERE idServico = @id;";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue(@"id", servicoExluir.Id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public List<string> DisciplinasDoOrcamento(int id_orcamento)
        {
            List<string> disciplinas = new List<string>();
            string sql = @"SELECT tipo_servico FROM servicos WHERE id_orcamento = @id_orcamento;";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", id_orcamento);
            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                if (!disciplinas.Contains(reader["tipo_servico"].ToString()))
                {
                    disciplinas.Add(reader["tipo_servico"].ToString());
                }

            }

            reader.Close();
            cn.Close();
            return disciplinas;

        }
        //A função abaixo precisa ser refeita
        //public static Dictionary<string, decimal> CalcularSubtotais(int idOrcamento, PropostaComercial PropostaComercial)
        //{
        //    //refatorar essa solução 
        //    decimal valorPreEmbargos = OrcamentoDb.TotalCustosAdicionais(idOrcamento) + OrcamentoDb.TotalServicos(idOrcamento);
        //    Dictionary<string, decimal> indiceDisiplina = new Dictionary<string, decimal>();

        //    Dictionary<string, decimal> subTotais = new Dictionary<string, decimal>();

        //    foreach (string disciplina in Enum.GetNames(typeof(TipoServico)))
        //    {
        //        string sql = @"SELECT ";

        //        //@"SELECT SUM(totalServico) AS ValorTotalServicos FROM servicos WHERE id_orcamento=@idOrcamento GROUP BY tipo_servico";
        //    }

        //} 
    }
}
