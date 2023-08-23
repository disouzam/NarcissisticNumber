namespace BibliotecaNumerosNarcisista
{
    public class NumerosNarcisista
    {
        static int numerodedigitos(int n)
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
        static bool verificanumero(int n)
        {
            int ND = numerodedigitos(n);
            int numerooriginal = n;
            int soma = 0;


            while (ND > 0)
            {
                int digito = ND % 10;
                soma = soma + (int)Math.Pow(digito, ND);
                ND /= 10;

            }

            return soma == numerooriginal;



        }

    }
}