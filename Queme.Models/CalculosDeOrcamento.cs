using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queme.Models
{
    public class CalculosDeOrcamento
    {
        public static decimal ValorTotalOrcamento( decimal servicos, decimal custosAdicionais, bool incluirArt, double imposto = 0, double comissao = 0)
        {
            decimal valorTotal = servicos+custosAdicionais;
            if(incluirArt && imposto > 0)
            {
                decimal constanteImposto = (decimal)(1 - imposto / 100);
                if (comissao > 0)
                {
                    decimal constanteComissaoComImposto = (decimal)(comissao / 100) / constanteImposto;
                    valorTotal = valorTotal / (constanteImposto - constanteComissaoComImposto);
                }
                else
                {
                    valorTotal /= constanteImposto;
                }
                if (valorTotal + ValoresArt.TarifaFaixa1/constanteImposto <= ValoresArt.valorMaximoFaixa1)
                {
                    valorTotal += ValoresArt.TarifaFaixa1 / constanteImposto;
                }
                else
                {
                    valorTotal += ValoresArt.TarifaFaixa2 / constanteImposto;
                }
            }else if (imposto > 0)
            {
                //Constante utilizada para dividir o valor total por ela e chegar no custo com imposto embutido
                decimal constanteImposto = (decimal)(1 - imposto / 100);
                if (comissao > 0)
                {
                    decimal constanteComissaoComImposto = (decimal)(comissao / 100) / constanteImposto;
                    valorTotal = valorTotal / (constanteImposto - constanteComissaoComImposto);
                }
                else
                {
                    valorTotal /= constanteImposto;
                }
            }else if (incluirArt)
            {
                if (comissao > 0)
                {
                    decimal constanteComissao = (decimal)(comissao / 100);
                    valorTotal = valorTotal / constanteComissao;
                }
                if (valorTotal + ValoresArt.TarifaFaixa1 <= ValoresArt.valorMaximoFaixa1)
                {
                    valorTotal += ValoresArt.TarifaFaixa1;
                }
                else
                {
                    valorTotal += ValoresArt.TarifaFaixa2;
                }
            }
            else if(comissao > 0)
            {
                decimal constanteComissao = (decimal)(comissao / 100);
                valorTotal = valorTotal / constanteComissao;
            }
            
            return valorTotal;
        }

        internal static decimal CalcularValorDaParcela(double percentualDeEntrada,decimal valorTotalOrcamento, double desconto, int QuantidadeDeParcelas)
        {
            decimal valorTotalComDesconto = valorTotalOrcamento - valorTotalOrcamento * (decimal)(percentualDeEntrada / 100) - valorTotalOrcamento* (decimal)(desconto/100);
            decimal valorParcela = valorTotalComDesconto / QuantidadeDeParcelas;
            return valorParcela;
        }
    }
}
