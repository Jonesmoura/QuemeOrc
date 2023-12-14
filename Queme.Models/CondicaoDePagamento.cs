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
        public double Desconto { get; set; }
        public decimal ValorParcela { get
            {
                return ValorParcela = CalculosDeOrcamento.CalcularValorDaParcela(PercentualDeEntrada, ValorTotalOrcamento, Desconto, QuantidadeDeParcelas);
            }
            private set {} 
        }

        public CondicaoDePagamento(double percentualDeEntrada, int quantidadeDeParcelas, int periodicidadeDeParcela, decimal valorTotalOrcamento, double desconto)
        {
            PercentualDeEntrada = percentualDeEntrada;
            QuantidadeDeParcelas = quantidadeDeParcelas;
            PeriodicidadeDeParcela = periodicidadeDeParcela;
            ValorTotalOrcamento = valorTotalOrcamento;
            Desconto = desconto;
        }

        public CondicaoDePagamento()
        {
            
        }



        //Override no toString para retornar a forma de pagamento a ser exibida no Form
    }
}
