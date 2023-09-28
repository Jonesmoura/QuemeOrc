using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class Servico
    {
        public int Id_orcamento { get; set; }
        public int Id_cliente { get; set; }
        public int Qtd_horas { get; set; }
        public TipoServico TipoServico { get; set; }
        public EtapasServico Etapa {get; set; }
        public double ValorHora { get; set; }

    }
}
