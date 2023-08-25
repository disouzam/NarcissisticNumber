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
        [Fact]
        public void VerificaComprimentoDoZero()
        {
            //Arrange
            int valor = 0;
            int NumeroDeDigitos = 0;

            //Act
            NumeroDeDigitos = NumerosNarcisista.numerodedigitos(valor);

            //Assert
            Assert.Equal(1, NumeroDeDigitos);
        }

    }
}