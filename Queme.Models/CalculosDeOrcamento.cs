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
            //Refatorar para melhorar a legibilidade (Muitos If's)
            decimal valorTotal = servicos+custosAdicionais;
            if(incluirArt && imposto > 0)
            {
                decimal constanteImposto = (decimal)(1 - imposto / 100);
                if (valorTotal + ValoresArt.TarifaFaixa1 <= ValoresArt.valorMaximoFaixa1)
                {
                    valorTotal += ValoresArt.TarifaFaixa1;
                }
                else
                {
                    valorTotal += ValoresArt.TarifaFaixa2;
                }
                if (comissao > 0)
                {
                    decimal constanteComissaoComImposto = (decimal)(comissao / 100) / constanteImposto;
                    valorTotal = valorTotal / (constanteImposto - constanteComissaoComImposto);
                }
                else
                {
                    valorTotal /= constanteImposto;
                }
                //Verifica se após a inserção do imposto/comissão o orçamento passou da faixa 1 para a faixa 2 da ART
                if(servicos + custosAdicionais+ ValoresArt.TarifaFaixa1 <= 15000 && valorTotal >15000)
                {
                    // adiciona a diferença do valor da ART
                    valorTotal += ((ValoresArt.TarifaFaixa2-ValoresArt.TarifaFaixa1) / constanteImposto);
                }

            }else if (imposto > 0)
            {
                //Constante utilizada para dividir o valor total por ela e chegar no custo com imposto embutido
                decimal constanteImposto = (decimal)(1 - imposto / 100);
                if (comissao > 0)
                {
                    decimal PercentualComissao = (decimal)(comissao / 100);
                    valorTotal = valorTotal / (constanteImposto - PercentualComissao);
                }
                else
                {
                    valorTotal /= constanteImposto;
                }
            }else if (incluirArt)
            {
                if (valorTotal + ValoresArt.TarifaFaixa1 <= ValoresArt.valorMaximoFaixa1)
                {
                    valorTotal += ValoresArt.TarifaFaixa1;
                }
                else
                {
                    valorTotal += ValoresArt.TarifaFaixa2;
                }
                if (comissao > 0)
                {
                    decimal constanteComissao = (decimal)(comissao / 100);
                    //valorTotal += valorTotal * constanteComissao;
                    valorTotal = valorTotal / (1 - constanteComissao);
                }
                //Verifica se após a inserção da comissão o orçamento passou da faixa 1 para a faixa 2 da ART
                if (servicos + custosAdicionais + ValoresArt.TarifaFaixa1 <= 15000 && valorTotal > 15000)
                {
                    // adiciona a diferença do valor da ART
                    valorTotal += ValoresArt.TarifaFaixa2 - ValoresArt.TarifaFaixa1;
                }

            }
            else if(comissao > 0)
            {
                decimal constanteComissao = (decimal)(comissao / 100);
                valorTotal = valorTotal / (1 - constanteComissao);  

            }
            return valorTotal;
        }

        public static decimal CalcularValorDaParcela(double percentualDeEntrada,decimal valorTotalOrcamento, double desconto, int QuantidadeDeParcelas)
        {
            decimal valorTotalComDesconto = valorTotalOrcamento;
            decimal montanteParaParcelas;
            if (desconto > 0)
            {
                valorTotalComDesconto = valorTotalOrcamento - valorTotalOrcamento * (decimal)(desconto / 100);
            }
            montanteParaParcelas = valorTotalComDesconto - valorTotalComDesconto * (decimal)(percentualDeEntrada / 100);
            decimal valorParcela = montanteParaParcelas / QuantidadeDeParcelas;
            return valorParcela;
        }
    }
}
