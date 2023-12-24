using Queme.Models;

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
    }
}