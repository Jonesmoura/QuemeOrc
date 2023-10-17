using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class TabelaDePreco
    {
        public int IdTabelaDePreco { get; set; }
        public string DescricaoTabela { get; set; }
        public string ObsDaTabela { get; set; }

        public TabelaDePreco() { }

        public TabelaDePreco(string descricaoTabela, string obsDaTabela)
        {
            DescricaoTabela = descricaoTabela;
            ObsDaTabela = obsDaTabela;
        }
    }
}
