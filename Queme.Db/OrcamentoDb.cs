using MySql.Data.MySqlClient;
using Queme.Models;
using Queme.Models.DTOs;
using Queme.Models.Enums;
using System.Globalization;
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

            string sql = @"SELECT orcamentos.id_orcamento, orcamentos.status, orcamentos.data_criacao, clientes.razaoSocial, clientes.name,orcamentos.IdTabelaDeCustos FROM orcamentos INNER JOIN clientes ON orcamentos.id_cliente = clientes.id WHERE " + parte2StringSql;
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cn.Open();


            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ReadOrcamentoDto orcamento = new ReadOrcamentoDto();
                orcamento.Id = int.Parse(reader["id_orcamento"].ToString());
                orcamento.Status = Enum.Parse<StatusOrcamento>(reader["status"].ToString());
                orcamento.DataCriacao = DateTime.Parse(reader["data_criacao"].ToString());
                orcamento.RazaoSocial = reader["razaoSocial"].ToString();
                orcamento.Nome = reader["name"].ToString();
                orcamento.IdTabelaDeCustos = int.Parse(reader["IdTabelaDeCustos"].ToString());

                orcamentos.Add(orcamento);

            }

            reader.Close();
            cn.Close();
            return orcamentos;

        }

        public int Incluir(Orcamento orcamento)
        {
            int id=0;
            string sql = @"INSERT INTO orcamentos(status,id_cliente, data_criacao, IdTabelaDeCustos) values(@status,@id_cliente, @data_criacao, @idTabelaDeCustos)";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@status", orcamento.Status.ToString());
            cmd.Parameters.AddWithValue("@id_cliente", orcamento.Id_cliente);
            cmd.Parameters.AddWithValue("@data_criacao", orcamento.Data.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@idTabelaDeCustos", orcamento.IdTabelaDeCustos);
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

        public static int GetIdCliente(int idOrc)
        {
            int idCliente = 0;
            string sql = @"SELECT id_cliente FROM orcamentos WHERE id_orcamento = @id_orcamento";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", idOrc);
            cn.Open();
            
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                idCliente = int.Parse(reader["id_cliente"].ToString());
            }
            cn.Close();
            return idCliente != 0 ? idCliente : throw new Exception("Id não encontrado.");
        }

        public List<Servico> GetServicoList(int id)
        {
            List<Servico> servicos = new List<Servico>();

            string sql = @"SELECT * FROM servicos WHERE id_orcamento=@id_orcamento";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id_orcamento", id); 
            cn.Open();

            //usando a sintaxe do using

            using(MySqlDataReader reader = cmd.ExecuteReader())
            {
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
            }
            cn.Close();
            return servicos;

        }

        public static ReadOrcamentoDto GetOrcamentoById(int idOrcamento)
        {
            //Capturando informações do orçamento
            ReadOrcamentoDto orcamento = new ReadOrcamentoDto();
            string sql = @"SELECT * FROM orcamentos INNER JOIN clientes ON orcamentos.id_cliente = clientes.id WHERE id_orcamento = @idOrcamento";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@idOrcamento", idOrcamento);
            cn.Open();

            using( MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    orcamento.Id = int.Parse(reader["id_orcamento"].ToString());
                    orcamento.Status = Enum.Parse<StatusOrcamento>(reader["status"].ToString());
                    orcamento.DataCriacao = DateTime.Parse(reader["data_criacao"].ToString());
                    orcamento.RazaoSocial = reader["razaoSocial"].ToString();
                    orcamento.Nome = reader["name"].ToString();
                    orcamento.TaxaImposto = double.Parse(reader["taxaImposto"].ToString(), CultureInfo.InvariantCulture);
                    orcamento.IdTabelaDeCustos = int.Parse(reader["IdTabelaDeCustos"].ToString());
                }
            }

            cn.Close();

            var servicosDb = new ServicosDb();
            orcamento.Servicos = servicosDb.GetServicoList(orcamento.Id);
            var clienteDb = new ClienteDb();
            orcamento.Cliente = clienteDb.buscarInfoCliente(GetIdCliente(orcamento.Id));

            return orcamento;

        }
    }
}
