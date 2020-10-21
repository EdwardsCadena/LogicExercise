using System;

namespace NumberRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, i, a;
            for (e = 0; e < 10; e++)
            {
                for (i = 0; i < 10; i++) ;
                Console.WriteLine("Ingrese un numero del 0 al 9");
                a = Convert.ToInt32(Console.ReadLine());
                a = (a + (i / 2)) % i;
                Console.WriteLine(a);
            }
        }
    }
}
