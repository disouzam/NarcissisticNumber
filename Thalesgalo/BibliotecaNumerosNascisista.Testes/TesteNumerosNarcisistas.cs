using BibliotecaNumerosNarcisista;
using Xunit;

namespace BibliotecaNumerosNascisista.Testes
{
    public class TesteNumerosNarcisistas
    {
        [Fact]
        public void ZeroNaoENarcisista()
        {
            //Arrange
            int zero = 0;
            bool resposta = true;

            //Act
            resposta = NumerosNarcisista.verificanumero(zero);

            //Assert
            Assert.False(resposta);
        }

        [Fact]
        public void CentoECinquentaEtresENarcisista()
        {
            //Arrange
            int valor = 153;
            bool resposta = false;

            //Act
            resposta = NumerosNarcisista.verificanumero(valor);

            //Assert
            Assert.True(resposta);
        }
    }
}