using MySql.Data.MySqlClient;
using Queme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Db
{
    public class TabelaDePrecoDb
    {

        public void Incluir(TabelaDePreco tabelaDePreco)
        {
            string sql = @"INSERT INTO tabelasDePrecos(DescricaoTabela,ObsDaTabela) values(@DescricaoTabela,@ObsDaTabela)";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@DescricaoTabela", tabelaDePreco.DescricaoTabela);
            cmd.Parameters.AddWithValue("@ObsDaTabela", tabelaDePreco.ObsDaTabela);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static int CapturarId(string DescricaoTabela)    
        {
            int Id = 0;
            string sql = @"SELECT idTabelaDePreco FROM tabelasDePrecos WHERE DescricaoTabela = @DescricaoTabela";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@DescricaoTabela", DescricaoTabela);
            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Id = Convert.ToInt32(reader["idTabelaDePreco"]);
            }
            return Id;

        }

        public static List<string> getTabelas()
        {
            string sql = @"SELECT DISTINCT DescricaoTabela FROM tabelasDePrecos;";
            var cn = new MySqlConnection(Db.connect);
            var cmd = new MySqlCommand(sql, cn);
            List<string> tabelas = new List<string>();
            cn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string tabelaDePreco = reader["DescricaoTabela"].ToString();
                tabelas.Add(tabelaDePreco);
            }

            reader.Close();
            cn.Close();

            return tabelas;

        }
    }
}
