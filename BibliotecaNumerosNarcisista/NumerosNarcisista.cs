namespace BibliotecaNumerosNarcisista
{
    public class NumerosNarcisista
    {
        public static int numerodedigitos(int n)
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

        public static bool verificanumero(int n)
        {
            if (n == 0)
            {
                return false;
            }

            int numerodigitos = numerodedigitos(n);
            int numerooriginal = n;
            int soma = 0;

            for (int i = 0; i < numerodigitos; i++)
            {
                int ultimodigito = n % 10;
                n /= 10;
                soma = soma + (int)Math.Pow(ultimodigito, numerodigitos);
                
            }

            bool resposta = soma == numerooriginal;

            return resposta;
        }

    }
}