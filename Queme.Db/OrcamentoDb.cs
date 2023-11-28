using MySql.Data.MySqlClient;
using Queme.Models;
using Queme.Models.DTOs;
using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class OrcamentoDb
    {
        public static List<ReadOrcamentoDto> getOrcamentosList(DateTime apartir, DateTime ate, string parametroDePesquisa, string status, string textoPesquisa)
        {
            List<ReadOrcamentoDto> orcamentos = new List<ReadOrcamentoDto>();
            string parte2StringSql= "";
            switch (parametroDePesquisa)
            {
                case "Razão Social":
                    parte2StringSql = "clientes.razaoSocial LIKE '%"+textoPesquisa+ "%' AND clientes.razaoSocial IS NOT NULL";
                    break;
                case "Nome (Pessoa Física)":
                    parte2StringSql = "clientes.name LIKE '%" + textoPesquisa + "%' AND clientes.razaoSocial IS NULL";
                    break;
                case "Número (ID)":
                    int id = int.Parse(textoPesquisa);
                    parte2StringSql = "orcamentos.id_orcamento ="+id.ToString();
                    break;
            }

            if(status != string.Empty &&  status != "Todos")
            {
                parte2StringSql += " AND status ="+ "'"+status+"'";
            }

            parte2StringSql += " AND orcamentos.data_criacao BETWEEN " + "'"+apartir.ToString("yyyy-MM-dd") + "'" + " AND " + "'" + ate.ToString("yyyy-MM-dd")+ "'" + ";";

            string sql = @"SELECT orcamentos.id_orcamento, orcamentos.status, orcamentos.data_criacao, clientes.razaoSocial, clientes.name FROM orcamentos INNER JOIN clientes ON orcamentos.id_cliente = clientes.id WHERE " + parte2StringSql;
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cn.Open();

            Console.WriteLine(sql);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadOrcamentoDto orcamento = new ReadOrcamentoDto();
                orcamento.Id = int.Parse(reader["id_orcamento"].ToString());
                orcamento.Status = Enum.Parse<StatusOrcamento>(reader["status"].ToString());
                orcamento.DataCriacao = DateTime.Parse(reader["data_criacao"].ToString());
                orcamento.RazaoSocial = reader["razaoSocial"].ToString();
                orcamento.Nome = reader["name"].ToString();

                orcamentos.Add(orcamento);

            }

            reader.Close();
            cn.Close();
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
