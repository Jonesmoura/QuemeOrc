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
        public void Incluir(PrecoPorDisciplina precoPorDisciplina, string descricaoTabela)
        {
            int idTabelaDePreco = TabelaDePrecoDb.CapturarId(descricaoTabela);
            string sql = @"INSERT INTO PrecosPorDisciplina(TipoServico, IdTabelaDePreco, ValorHora) values (@tipoServico,@idTabelaDePreco,@valorHora);";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@tipoServico", precoPorDisciplina.TipoServico.ToString());
            cmd.Parameters.AddWithValue("@idTabelaDePreco", idTabelaDePreco);
            cmd.Parameters.AddWithValue("@valorHora", precoPorDisciplina.ValorHora);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
