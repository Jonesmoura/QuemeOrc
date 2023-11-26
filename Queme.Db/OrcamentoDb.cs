using MySql.Data.MySqlClient;
using Queme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class OrcamentoDb
    {
        public static List<Orcamento> getOrcamentosList(DateTime apartir, DateTime ate, string parametroDePesquisa, string status, string textoPesquisa)
        {
            List<Orcamento> orcamentos = new List<Orcamento>();
            string parte2StringSQL= "";
            switch (parametroDePesquisa)
            {
                case "Razão Social":
                    parte2StringSQL = "clientes.razaoSocial LIKE '%@textoPesquisa%'";
                    break;
                case "Nome (Pessoa Física)":
                    parte2StringSQL = "clientes.name LIKE '%@textoPesquisa%'";
                    break;
                case "Número (ID)":
                    int id = int.Parse(textoPesquisa);
                    parte2StringSQL = "orcamentos.id_orcamento ="+id.ToString();
                    break;

            }
            string sql = @"SELECT orcamentos.id_orcamento, orcamentos.status, orcamentos.data_criacao, clientes.razaoSocial, clientes.name FROM orcamentos INNER JOIN clientes ON orcamentos.id_cliente = clientes.id WHERE " + parte2StringSQL;
            //to:do conexão com o banco, leitura do data reader e salvar na lista orcamentos.

            Console.WriteLine(sql);

            return orcamentos;

        }

        public int Incluir(Orcamento orcamento)
        {
            int id=0;
            string sql = @"INSERT INTO orcamentos(status,id_cliente, data_criacao) values(@status,@id_cliente, @data_criacao)";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@status", orcamento.Status.ToString());
            cmd.Parameters.AddWithValue("@id_cliente", orcamento.Id_cliente);
            cmd.Parameters.AddWithValue("@data_criacao", orcamento.Data.ToString("yyyy-MM-dd"));
            cn.Open();
            cmd.ExecuteNonQuery();
            //capturar id salvo
            var cmdId = new MySqlCommand(@"SELECT LAST_INSERT_ID() as id_orcamento FROM orcamentos", cn);

            using (MySqlDataReader reader = cmdId.ExecuteReader())
            {
                try
                {
                    if(reader.Read())
                    {
                        id = Convert.ToInt32(reader["id_orcamento"]);
                    }
                }catch (Exception ex)
                {
                    // to-do: tratamento de erro deste método
                    throw new Exception(ex.Message);
                }
            }


            cn.Close();
            return id;
        }
    }
}
