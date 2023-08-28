namespace BibliotecaNumerosNarcisista
{
    public class NumerosNarcisista
    {
        public static int numerodedigitos(long n)
        {
            int cont = 0;

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

        public static bool verificanumero(long n)
        {
            if (n == 0)
            {
                return false;
            }

            int numerodigitos = numerodedigitos(n);
            long numerooriginal = n;
            long soma = 0;

            for (int i = 0; i < numerodigitos; i++)
            {
                long ultimodigito = n % 10;
                n /= 10;
                soma = soma + (long)Math.Pow(ultimodigito, numerodigitos);
            }

            bool resposta = soma == numerooriginal;

            return resposta;
        }

    }
}