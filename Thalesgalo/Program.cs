using BibliotecaNumerosNarcisista;

namespace numeronarcisista
{
    class program
    {
        static void Main(string[] args)
        {
            long n1, n2;

            do
            {
                Console.WriteLine("Informe o primeiro numero");
                n1 = long.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo numero");
                n2 = long.Parse(Console.ReadLine());

                Console.Clear();
            }
            while ((n1 > n2) && (n2 != 0));

            Console.Clear();
    
            Console.WriteLine("Numeros Narcisistas:");

            for (int i = 0; i <= 1000; i++)
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