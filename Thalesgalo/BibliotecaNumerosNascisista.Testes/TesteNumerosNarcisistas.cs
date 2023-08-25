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
    }
}