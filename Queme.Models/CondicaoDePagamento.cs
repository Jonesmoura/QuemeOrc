using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class CondicaoDePagamento
    {
        public double PercentualDeEntrada { get; set; }
        public int QuantidadeDeParcelas { get; set; }
        public int PeriodicidadeDeParcela { get; set; }
        public decimal ValorTotalOrcamento { get; set; }

        //Override no toString para retornar a forma de pagamento a ser exibida no Form
    }
}
