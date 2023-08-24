using BibliotecaNumerosNarcisista;

namespace numeronarcisista
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Narcisistas:");

            for (int i = 0; i <= 100000; i++)
            {
                if (NumerosNarcisista.verificanumero(i))
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey(true);
        }
    }
}