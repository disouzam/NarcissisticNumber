namespace BibliotecaNumerosNarcisista
{
    public class NumerosNarcisista
    {
        public static int NumeroDeDigitos(long n)
        {
            var cont = 0;

            if (n == 0)
            {
                return 1;
            }

            while (n != 0)
            {
                n /= 10;

                cont++;
            }

            return cont;
        }

        public static bool VerificaNumero(long n)
        {
            if (n == 0)
            {
                return false;
            }

            var numerodigitos = NumeroDeDigitos(n);
            var numerooriginal = n;
            long soma = 0;

            while (n > 0) 
            {
                var ultimodigito = n % 10;
                n /= 10;
                soma = soma + (long)Math.Pow(ultimodigito, numerodigitos);
            }

            var resposta = soma == numerooriginal;

            return resposta;
        }

    }
}