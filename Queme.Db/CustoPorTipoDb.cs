using MySql.Data.MySqlClient;
using Queme.Models;
using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class CustoPorTipoDb
    {
        public static void IncluirCustos(TabelaDePreco tabelaDePreco, Dictionary<TipoServico, double> custos)
        {
            int idTabelaDePreco = TabelaDePrecoDb.CapturarId(tabelaDePreco.DescricaoTabela);

            foreach(KeyValuePair<TipoServico, double> servicoCusto in custos)
            {
                string sql = @"INSERT INTO PrecosPorDisciplina(TipoServico, IdTabelaDePreco, ValorHora) values (@tipoServico,@idTabelaDePreco,@valorHora);";
                var cn = new MySqlConnection(Db.connect);
                var cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@tipoServico", servicoCusto.Key.ToString());
                cmd.Parameters.AddWithValue("@idTabelaDePreco", idTabelaDePreco);
                cmd.Parameters.AddWithValue("@valorHora", servicoCusto.Value);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
        }
    }
}
