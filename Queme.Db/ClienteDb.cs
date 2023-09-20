using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Queme.Models;
using Queme.Db;

namespace Queme.Db
{
    public class ClienteDb
    {
        public void Incluir(Cliente cliente)
        {

            string sql = "INSERT INTO clientes(name,email,tel,razaoSocial,CNPJ,CPF) Values(@Name,@Email, @Tel, @razaoSocial, @CNPJ, @CPF);";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Name", cliente.Name);
            cmd.Parameters.AddWithValue("@Tel", cliente.Tel);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@razaoSocial", cliente.razaoSocial);
            cmd.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            IncluirEnderecoCliente(cliente);

        }

        public void IncluirEnderecoCliente(Cliente cliente)
        {
            string sql = "INSERT INTO endereco_cliente (id_cliente, CEP,logradouro, bairro, UF, numero, complemento) VALUES((SELECT MAX(id) from clientes), @CEP, @logradouro, @bairro, @UF, @numero, @complemento);";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            // parametros do endereço
            //cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
            //cmd.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
            //cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
            //cmd.Parameters.AddWithValue("@UF", cliente.UF);
            //cmd.Parameters.AddWithValue("@numero", cliente.Numero);
            //cmd.Parameters.AddWithValue("@complemento", cliente.Complemento);

            // teste hardCoded, remover apos criar campos no formulário:
            cmd.Parameters.AddWithValue("@CEP", "09350550");
            cmd.Parameters.AddWithValue("@logradouro", "Rua Argentina");
            cmd.Parameters.AddWithValue("@bairro", "Parque das Américas");
            cmd.Parameters.AddWithValue("@UF", "SP");
            cmd.Parameters.AddWithValue("@numero", 201);
            cmd.Parameters.AddWithValue("@complemento", "Casa Rosa");

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();


        }

        public void Alterar(Cliente cliente)
        {
            string sql = @"UPDATE clientes SET name=@Name,email=@Email,tel=@Tel WHERE id=@ID";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID", cliente.ID);
            cmd.Parameters.AddWithValue("@Name", cliente.Name);
            cmd.Parameters.AddWithValue("@Tel", cliente.Tel);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void Excluir(int id)
        {
            string sql = @"DELETE FROM clientes WHERE id=@ID";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public List<Cliente> Listar() 
        {
            string sql = "SELECT id, name,razaoSocial,CNPJ,CPF, tel, email FROM clientes";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);

            List<Cliente> lista = new List<Cliente>();

            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new Cliente();
                cliente.ID = Convert.ToInt32(reader["ID"]);
                cliente.Name = reader["Name"].ToString();
                cliente.razaoSocial = reader["razaoSocial"].ToString();
                cliente.CNPJ = reader["CNPJ"].ToString();
                cliente.CPF = reader["CPF"].ToString();
                cliente.Tel = reader["Tel"].ToString();
                cliente.Email = reader["Email"].ToString();


                lista.Add(cliente);

            }

            reader.Close();
            cn.Close ();

            return lista;

        }

        public void teste() // método para teste de conexão com o DB
        {
            string sql = @"DELETE FROM clientes WHERE id=@ID";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID", 3);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close(); 

        }

    }
}
