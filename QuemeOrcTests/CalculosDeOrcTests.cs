using MySqlX.XDevAPI.Common;
using Queme.Models;
using System.Globalization;

namespace QuemeOrcTests
{
    public class CalculosDeOrcTests
    {
        [Fact]
        public void OrcamentoSemImpostosEComissaoAbaixo15k()
        {
            //arrange
            decimal servicos = 1000;
            decimal custosAdicionais = 200;
            bool incluirArt = true;
            decimal expectedResult = 1000m + 200m + 96.62m;

            //Act
            decimal result = CalculosDeOrcamento.ValorTotalOrcamento(servicos, custosAdicionais, incluirArt);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void OrcamentoComImpostoESemComissaoAbaixo15k()
        {
            //Arrange
            decimal servicos = 2000;
            decimal custosAdicionais = 554.44m;
            bool incluirArt = true;
            double imposto = 10.00;
            decimal expectedResult = 2945.622222m;

            //Act
            decimal result = CalculosDeOrcamento.ValorTotalOrcamento(servicos, custosAdicionais, incluirArt, imposto);

            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }
        [Fact]
        public void OrcamentoComImpostoSemComissaoAcimaDe15kTotal()
        {
            //Arrange
            decimal servicos = 12700.22m;
            decimal custosAdicionais = 723.44m;
            bool incluirArt = true;
            double imposto = 10.00;
            decimal expectedResult = 15198.05556m;  
                        
            //Act
            decimal result = CalculosDeOrcamento.ValorTotalOrcamento(servicos,custosAdicionais,incluirArt, imposto);

            //Asert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }
        [Fact]
        public void OrcamentoComImpostoESemComissaoAbaixoDe15k()
        {
            //Arrange
            decimal servicos = 1777.33m;
            decimal custosAdicionais = 222.53m;
            bool incluirArt = true;
            double imposto = 16.00;
            decimal expectedResult = 2495.809524m;

            //Act
            decimal result = CalculosDeOrcamento.ValorTotalOrcamento(servicos, custosAdicionais, incluirArt, imposto);

            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }

        [Fact]
        public void OrcamentoComImpostoEcomissaoAcimaDe15kSemArt()
        {
            //Arrange
            decimal servicos = 14000.22m;
            decimal custosAdicionais = 1233.22m;
            bool incluirArt = false;
            double imposto = 16.00;
            double comissao = 10;
            decimal expectedResult = 21129.60534m;         
            
            //Act
            decimal result = CalculosDeOrcamento.ValorTotalOrcamento(servicos,custosAdicionais,incluirArt, imposto,comissao);
            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }
        [Fact]
        public void OrcamentoComImpostoESemComissaoAcimaDe15kSemArt()
        {
            //Arrange
            decimal servicos = 14000.22m;
            decimal custosAdicionais = 1233.22m;
            bool incluirArt = false;
            double imposto = 16.00;
            decimal expectedResult = 18135.04762m;

            //Act
            decimal result = CalculosDeOrcamento.ValorTotalOrcamento(servicos, custosAdicionais, incluirArt, imposto);
            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }

        [Fact]
        public void OrcamentoSemImpostosEComissaoAbaixoDe15kSemArt()
        {
            //Arrange
            decimal servicos = 2000m;
            decimal custosAdicionais = 300m;
            bool incluirArt = false;
            decimal expectedResult = 2300m;

            //Act
            decimal result = CalculosDeOrcamento.ValorTotalOrcamento(servicos, custosAdicionais, incluirArt);

            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }

        [Fact]
        public void OrcamentoComImpostoComissaoArtAcimaDe15k()
        {
            //Arrange
            decimal servicos = 13000.33m;
            decimal custosAdicionais = 3200.44m;
            bool incluirArt = true;
            double imposto = 16;
            double comissao = 10;
            decimal expectedResult = 22824.47556m;
            //New value 21862.12114

            //Act
            decimal result = CalculosDeOrcamento.ValorTotalOrcamento(servicos,custosAdicionais,incluirArt, imposto, comissao);
            
            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));

        }

        [Fact]

        public void CalculoParcelaOrcamentoSemEntradaEm2x()
        {
            //Arrange
            double percentualEntrada = 0;
            decimal valorTotal = 12000m;
            double desconto = 0;
            int qtdParcelas = 2;
            decimal expectedResult = 6000;
            
            //Act
            decimal result = CalculosDeOrcamento.CalcularValorDaParcela(percentualEntrada, valorTotal, desconto, qtdParcelas);
            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }

        [Fact]

        public void CalculoParcelaOrcamento33dot33DeEntradaEm3x()
        {
            //Arrange
            double percentualEntrada = 33.33;
            decimal valorTotal = 10000m;
            double desconto = 0;
            int qtdParcelas = 3;
            decimal expectedResult = 2222.333333m;

            //Act
            decimal result = CalculosDeOrcamento.CalcularValorDaParcela(percentualEntrada,valorTotal,desconto, qtdParcelas);
            
            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")),result.ToString("C",CultureInfo.GetCultureInfo("pt-BR")));
        }

        [Fact]
        public void CalculoParcelaSemEntrada7deDesconto1Parcela()
        {
            //Arrange
            double percentualEntrada = 0;
            decimal valorTotal = 11324.22m;
            double desconto = 7;
            int qtdParcelas = 1;
            decimal expectedResult = 10531.5246m;

            //Act
            decimal result = CalculosDeOrcamento.CalcularValorDaParcela(percentualEntrada,valorTotal,desconto, qtdParcelas);

            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));

        }

        [Fact]
        public void CalculoParcela25DeEntradaE10DescontoEm4x()
        {
            //Arrange
            double percentualEntrada = 25;
            decimal valorTotal = 11234.45m;
            double desconto = 10;
            int qtdParcelas = 4;
            decimal expectedResult = 1895.813438m;

            //Act
            decimal result = CalculosDeOrcamento.CalcularValorDaParcela(percentualEntrada,valorTotal,desconto,qtdParcelas);

            //Assert
            Assert.Equal(expectedResult.ToString("C", CultureInfo.GetCultureInfo("pt-BR")), result.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
        }


    }

}