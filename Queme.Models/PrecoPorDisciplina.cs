using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class PrecoPorDisciplina
    {
        public int IdPreco { get; set; }
        public TipoServico TipoServico { get; set; }
        public int IdTabelaDePreco { get; set; }
        public double ValorHora { get; set; }

        public PrecoPorDisciplina() { }

        public PrecoPorDisciplina(TipoServico tipoServico, double valorHora)
        {
            TipoServico = tipoServico;
            ValorHora = valorHora;
        }
        public PrecoPorDisciplina(TipoServico tipoServico, int idTabelaDePreco, double valorHora)
        {
            TipoServico = tipoServico;
            IdTabelaDePreco = idTabelaDePreco;
            ValorHora = valorHora;
        }
    }
}
