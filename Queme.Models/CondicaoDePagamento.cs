using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class CondicaoDePagamento
    {
        public int Id { get; set; }
        public int OrcamentoId { get; set; }
        public double PercentualDeEntrada { get; set; }
        public int QuantidadeDeParcelas { get; set; }
        public int PeriodicidadeDeParcela { get; set; }
        public decimal ValorTotalOrcamento { get; set; }
        public double Desconto { get; set; }
        public decimal ValorParcela { get
            {
                return CalculosDeOrcamento.CalcularValorDaParcela(PercentualDeEntrada, ValorTotalOrcamento, Desconto, QuantidadeDeParcelas);
            }
            private set {} 
        }

        public decimal ValorEntrada { get 
            {
                if(PercentualDeEntrada < 0)
                {
                    return 0;
                }else
                {
                    return ValorTotalOrcamento* (decimal)(PercentualDeEntrada / 100);
                }
            }
            private set {} 
        }

        public CondicaoDePagamento(double percentualDeEntrada, int quantidadeDeParcelas, int periodicidadeDeParcela, decimal valorTotalOrcamento, double desconto, int orcamentoId)
        {
            PercentualDeEntrada = percentualDeEntrada;
            QuantidadeDeParcelas = quantidadeDeParcelas;
            PeriodicidadeDeParcela = periodicidadeDeParcela;
            ValorTotalOrcamento = valorTotalOrcamento;
            Desconto = desconto;
            OrcamentoId = orcamentoId;
        }
        //Este construtor será utilizando quando implementarmos o calculo de parcelas manual
        public CondicaoDePagamento(double percentualDeEntrada, int quantidadeDeParcelas, int periodicidadeDeParcela, decimal valorTotalOrcamento, double desconto, decimal valorParcela, int orcamentoId) : this(percentualDeEntrada, quantidadeDeParcelas, periodicidadeDeParcela, valorTotalOrcamento, desconto, orcamentoId)
        {
            ValorParcela = valorParcela;
        }

        public CondicaoDePagamento()
        {
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Forma de Pagamento: ");
            if(PercentualDeEntrada >0) 
            {
                sb.Append($"Entrada({(int)PercentualDeEntrada}%): {ValorEntrada.ToString("C",CultureInfo.GetCultureInfo("pt-BR"))}");
            }
            DateTime dataAtual = DateTime.Now;
            for(int i =1; i<= QuantidadeDeParcelas;i++)
            {
                dataAtual = dataAtual.AddDays(PeriodicidadeDeParcela);
                sb.Append($" / Parcela {i+1}({dataAtual.ToString("dd/MM")}): {ValorParcela.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
            }

            return sb.ToString();

            // Padrão de saída: Forma de pagamento: Entrada(40%): R$ XXX.XX / Parcela 2(15/10): R$ XXX.XX / Parcela 3(15/11): R$ XXX.XX
            
        }
    }
}
