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
            string sql = "INSERT INTO endereco_cliente (id_cliente, CEP,logradouro, bairro, localidade, UF, numero, complemento) VALUES((SELECT MAX(id) from clientes), @CEP, @logradouro, @bairro, @localidade, @UF, @numero, @complemento);";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
            cmd.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
            cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@localidade", cliente.localidade);
            cmd.Parameters.AddWithValue("@UF", cliente.UF);
            cmd.Parameters.AddWithValue("@numero", cliente.Numero);
            cmd.Parameters.AddWithValue("@complemento", cliente.Complemento);

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

            AlterarEndereco(cliente);

        }

        public void AlterarEndereco(Cliente cliente)
        {
            string sql = @"UPDATE endereco_cliente SET CEP=@CEP,logradouro=@logradouro, bairro=@bairro, localidade=@localidade, UF=@UF, numero=@numero, complemento=@complemento WHERE id_cliente=@ID;";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID", cliente.ID);
            cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
            cmd.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
            cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@localidade", cliente.localidade);
            cmd.Parameters.AddWithValue("@UF", cliente.UF);
            cmd.Parameters.AddWithValue("@numero", cliente.Numero);
            cmd.Parameters.AddWithValue("@complemento", cliente.Complemento);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void ExcluirEnderecoCliente( int id)
        {
            string sql = @"DELETE FROM endereco_cliente WHERE id_cliente=@ID";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void Excluir(int id)
        {
            // excluir seu cadastro de endereço antes
            ExcluirEnderecoCliente(id);
            string sql = @"DELETE FROM clientes WHERE id=@ID";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        //O método não funcionará se o cliente não tem endereço cadastrado (Obrigatoriamente o cliente deve ter um endereço cadastrado)
        //to-do: Regra para obrigatoriedade de cadastro de endereço de cliente
        public Cliente buscarInfoCliente(int id)
        {
            var cliente = new Cliente();
            string sql = "SELECT * FROM clientes INNER JOIN endereco_cliente ON clientes.id = endereco_cliente.id_cliente WHERE clientes.id = @ID";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ID", id);
            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                cliente.ID = Convert.ToInt32(reader["ID"]);
                cliente.Name = reader["Name"].ToString();
                cliente.razaoSocial = reader["razaoSocial"].ToString();
                cliente.CNPJ = reader["CNPJ"].ToString();
                cliente.CPF = reader["CPF"].ToString();
                cliente.Tel = reader["Tel"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.CEP = reader["CEP"].ToString();
                cliente.Logradouro = reader["logradouro"].ToString();
                cliente.Bairro = reader["bairro"].ToString();
                cliente.localidade = reader["localidade"].ToString();
                cliente.UF = reader["UF"].ToString();
                cliente.Numero =  Convert.ToInt32(reader["numero"]);
                cliente.Complemento = reader["complemento"].ToString();

            }

            reader.Close();
            cn.Close();

            return cliente;

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

        public List <Cliente> BuscarClientesOrc(string razao, string nome, bool pfChecked) 
        {

            List<Cliente> lista = new List<Cliente>();

            if(razao == "" &&  nome == "")
            {
                if (pfChecked)
                {
                    string sql = @"SELECT id, name, CNPJ, CPF, email,tel FROM clientes WHERE CNPJ IS NULL;";
                    var cn = new MySqlConnection(Db.connect);
                    var cmd = new MySqlCommand(sql, cn);

                    cn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var cliente = new Cliente();
                        cliente.ID = Convert.ToInt32(reader["ID"]);
                        cliente.Name = reader["Name"].ToString();
                        cliente.CPF = reader["CPF"].ToString();
                        cliente.Tel = reader["Tel"].ToString();
                        cliente.Email = reader["Email"].ToString();

                        lista.Add(cliente);

                    }

                    reader.Close();
                    cn.Close();
                }
                else
                {
                    string sql = @"SELECT id, razaoSocial,name, CNPJ, email,tel FROM clientes WHERE razaoSocial IS NOT NULL;";
                    var cn = new MySqlConnection(Db.connect);
                    var cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@RazaoBusca", "%" + razao + "%");

                    cn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var cliente = new Cliente();
                        cliente.ID = Convert.ToInt32(reader["ID"]);
                        cliente.razaoSocial = reader["razaoSocial"].ToString();
                        cliente.Name = reader["Name"].ToString();
                        cliente.CNPJ = reader["CNPJ"].ToString();
                        cliente.Tel = reader["Tel"].ToString();
                        cliente.Email = reader["Email"].ToString();

                        lista.Add(cliente);

                    }

                    reader.Close();
                    cn.Close();
                }
            }

            if (razao != "")
            {
                string sql = @"SELECT id, razaoSocial,name, CNPJ, email,tel FROM clientes WHERE razaoSocial LIKE @RazaoBusca;";
                var cn = new MySqlConnection(Db.connect);
                var cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@RazaoBusca", "%" + razao + "%");

                cn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    var cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.razaoSocial = reader["razaoSocial"].ToString();
                    cliente.Name = reader["Name"].ToString();
                    cliente.CNPJ = reader["CNPJ"].ToString();
                    cliente.Tel = reader["Tel"].ToString();
                    cliente.Email = reader["Email"].ToString();

                    lista.Add(cliente);

                }

                reader.Close();
                cn.Close();

            }
            else if(nome != "")
            {
                string sql = @"SELECT id, name, CNPJ, CPF, email,tel FROM clientes WHERE name LIKE @NomeBusca AND CNPJ IS NULL;";
                var cn = new MySqlConnection(Db.connect);
                var cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@NomeBusca", "%" + nome + "%");

                cn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Name = reader["Name"].ToString();
                    cliente.CPF = reader["CPF"].ToString();
                    cliente.Tel = reader["Tel"].ToString();
                    cliente.Email = reader["Email"].ToString();

                    lista.Add(cliente);

                }

                reader.Close();
                cn.Close();

            }

            return lista;

        }

    }
}
