using MySql.Data.MySqlClient;
using Queme.Models;
using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

        public static List<CustoAdicional> GetCustosAdicionaisList(int id_orcamento)
        {
            List<CustoAdicional> custosAdicionais = new List<CustoAdicional> ();
            string sql = @"SELECT * FROM custosAdicionais WHERE id_orcamento = @idOrcamento";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@idOrcamento", id_orcamento);

            cn.Open();

            using(MySqlDataReader reader = cmd.ExecuteReader() )
            {
                while (reader.Read())
                {
                    CustoAdicional custoAdicional = new CustoAdicional();
                    custoAdicional.IdCustoAdicional = int.Parse(reader["Id"].ToString());
                    custoAdicional.Id_orcamento = int.Parse(reader["id_orcamento"].ToString());
                    custoAdicional.Categoria = Enum.Parse<CategoriaDeCustoAdicional>(reader["Categoria"].ToString());
                    custoAdicional.Descricao = reader["Descricao"].ToString();
                    custoAdicional.ValorUN = decimal.Parse(reader["ValorUN"].ToString());
                    custoAdicional.Quantidade = int.Parse(reader["Quantidade"].ToString());
                    custoAdicional.ValorTotal = decimal.Parse(reader["ValorTotal"].ToString());

                    custosAdicionais.Add(custoAdicional);

                }

                cn.Close();
                return custosAdicionais;
            }
        }

        public static void Excluir(CustoAdicional custoExcluir)
        {
            string sql = @"DELETE FROM custosAdicionais WHERE Id=@IdCustoAdicional";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@IdCustoAdicional", custoExcluir.IdCustoAdicional);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
