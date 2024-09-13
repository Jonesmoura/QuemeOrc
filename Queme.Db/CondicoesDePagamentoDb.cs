using MySql.Data.MySqlClient;
using Queme.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class CondicoesDePagamentoDb
    {
        public static List<CondicaoDePagamento> GetListCondicoes(int idOrcamento)
        {
            string sql = @"SELECT Id, IdOrcamento, PercentualDeEntrada,QuantidadeDeParcelas,PeriodicidadeDasParcelas,Desconto,ValorDaParcela,ValorDaEntrada, ValorTotal FROM condicoesDePagamento WHERE 	IdOrcamento = @idOrcamento;";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@idOrcamento", idOrcamento);

            List<CondicaoDePagamento> condicoesDePagamento = new List<CondicaoDePagamento>();

            cn.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader()) 
            {
                while (reader.Read())
                {
                    CondicaoDePagamento condicaoDePagamento = new CondicaoDePagamento();
                    condicaoDePagamento.Id = int.Parse(reader["Id"].ToString());
                    condicaoDePagamento.OrcamentoId = int.Parse(reader["IdOrcamento"].ToString());
                    condicaoDePagamento.PercentualDeEntrada = double.Parse(reader["PercentualDeEntrada"].ToString());
                    condicaoDePagamento.QuantidadeDeParcelas = int.Parse(reader["QuantidadeDeParcelas"].ToString());
                    condicaoDePagamento.PeriodicidadeDeParcela = int.Parse(reader["PeriodicidadeDasParcelas"].ToString());
                    condicaoDePagamento.Desconto = double.Parse(reader["Desconto"].ToString());
                    condicaoDePagamento.ValorTotalOrcamento = decimal.Parse(reader["ValorTotal"].ToString());
                    //condicaoDePagamento.ValorEntrada = decimal.Parse(reader["ValorDaEntrada"].ToString());
                    //condicaoDePagamento.ValorParcela = decimal.Parse(reader["valordaparcela"].ToString());

                    condicoesDePagamento.Add(condicaoDePagamento);
                } 
            }

            cn.Close();
            return condicoesDePagamento;

        }

        public static void Incluir(int idOrcamento, CondicaoDePagamento condicaoDePagamento)
        {
            string sql = @"INSERT INTO condicoesDePagamento(idOrcamento, PercentualDeEntrada, QuantidadeDeParcelas, PeriodicidadeDasParcelas, Desconto, ValorDaParcela, ValorDaEntrada, ValorTotal, ValorTotalComDesconto, Descricao)                  
                        VALUES(@IdOrcamento, @PercentualDeEntrada, @QuantidadeDeParcelas,@PeriodicidadeDeParcelas, @Desconto, @ValorDaParcela, @ValorDaEntrada, @ValorTotal, @ValorTotalComDesconto, @Descricao)";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@idOrcamento", condicaoDePagamento.OrcamentoId);
            cmd.Parameters.AddWithValue("@PercentualDeEntrada", condicaoDePagamento.PercentualDeEntrada);
            cmd.Parameters.AddWithValue("@QuantidadeDeParcelas", condicaoDePagamento.QuantidadeDeParcelas);
            cmd.Parameters.AddWithValue("@PeriodicidadeDeParcelas", condicaoDePagamento.PeriodicidadeDeParcela);
            cmd.Parameters.AddWithValue("@Desconto", condicaoDePagamento.Desconto);
            cmd.Parameters.AddWithValue("@ValorDaParcela", condicaoDePagamento.ValorParcela);
            cmd.Parameters.AddWithValue("@ValorDaEntrada", condicaoDePagamento.ValorEntrada);
            cmd.Parameters.AddWithValue("@ValorTotal", condicaoDePagamento.ValorTotalOrcamento);
            cmd.Parameters.AddWithValue("@ValorTotalComDesconto", condicaoDePagamento.ValorTotalComDesconto);
            cmd.Parameters.AddWithValue("@Descricao", condicaoDePagamento.DescricaoCondicao);


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            
        }

        public static void Excluir(int idCondicao)
        {
            string sql = @"DELETE FROM condicoesDePagamento WHERE Id = @idCondicao";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql,cn);
            cmd.Parameters.AddWithValue("idCondicao", idCondicao);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
