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

    }

}