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
            string sql = "INSERT INTO clientes(name,email,tel) Values(@Name,@Email, @Tel)";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Name", cliente.Name);
            cmd.Parameters.AddWithValue("@Tel", cliente.Tel);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
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
            string sql = "SELECT id, name, tel, email FROM clientes";
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
