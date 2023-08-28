using BibliotecaNumerosNarcisista;
using Xunit;
using FluentAssertions;

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
            resposta.Should().BeFalse();
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
            resposta.Should().BeTrue();
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
            NumeroDeDigitos.Should().Be(1);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(153)]
        [InlineData(370)]
        [InlineData(371)]
        [InlineData(407)]
        [InlineData(1634)]
        [InlineData(8208)]
        [InlineData(9474)]
        [InlineData(54748)]
        [InlineData(92727)]
        [InlineData(93084)]
        [InlineData(548834)]
        [InlineData(1741725)]
        [InlineData(4210818)]
        [InlineData(9800817)]
        [InlineData(9926315)]
        [InlineData(24678050)]
        [InlineData(24678051)]
        [InlineData(88593477)]
        [InlineData(146511208)]
        [InlineData(472335975)]
        [InlineData(534494836)]
        [InlineData(912985153)]
        [InlineData(4679307774)]
        [InlineData(32164049650)]
        [InlineData(32164049651)]
        [InlineData(40028394225)]
        [InlineData(42678290603)]
        [InlineData(44708635679)]
        [InlineData(49388550606)]
        [InlineData(82693916578)]
        [InlineData(94204591914)]
        [InlineData(28116440335967)]
        [InlineData(4338281769391370)]
        [InlineData(4338281769391371)]
        public void VerificacaoDeAlgunsNumerosNarcisistas(long n)
        {
            //Arrange
            bool resposta = false;

            //Act
            resposta = NumerosNarcisista.verificanumero(n);

            //Assert
            resposta.Should().BeTrue();
        }
    }
}