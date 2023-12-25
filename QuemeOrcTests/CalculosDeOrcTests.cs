using Queme.Models;
using System.Globalization;

namespace QuemeOrcTests
{
    public class CalculosDeOrcTests
    {
        [Fact]
        public void OrcamentoSemImpostosDescontosEComissao()
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
        public void OrcamentoComImpostoSemDescontoEComissao()
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
    }
}