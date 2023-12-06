using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class CustoAdicional
    {
        public int Id_orcamento { get; set; }
        public CategoriaDeCustoAdicional Categoria { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUN { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public CustoAdicional()
        {

        }

        public CustoAdicional(int id_orcamento, CategoriaDeCustoAdicional categoria, string descricao, decimal valorUN, int quantidade, decimal valorTotal)
        {
            Id_orcamento = id_orcamento;
            Categoria = categoria;
            Descricao = descricao;
            ValorUN = valorUN;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
        }


    }
}
