using MySql.Data.MySqlClient;
using Queme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class CustosAdicionaisDb
    {
        public static void IncluirCustoAdicional(CustoAdicional custoAdicional)
        {
            string sql = @"INSERT INTO custosAdicionais(id_orcamento,Categoria, Descricao, ValorUN, Quantidade, ValorTotal) values(@id_orcamento,@categoria,@descricao,@valorUN, @quantidade, @valorTotal )";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", custoAdicional.Id_orcamento);
            cmd.Parameters.AddWithValue("@categoria", custoAdicional.Categoria.ToString());
            cmd.Parameters.AddWithValue("@descricao",  custoAdicional.Descricao);
            cmd.Parameters.AddWithValue("@valorUN", custoAdicional.ValorUN);
            cmd.Parameters.AddWithValue("@quantidade", custoAdicional.Quantidade);
            cmd.Parameters.AddWithValue("@valorTotal", custoAdicional.ValorTotal);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
