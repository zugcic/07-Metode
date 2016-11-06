using System;

namespace Metode
{
    class Program
    {
        static void Uvecaj(int n)
        {
            n += 1;
            Console.WriteLine("U metodi Uvecaj: {0}", n);
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Prije metode Uvecaj: {0}", n);   // ispisat će 5

            Uvecaj(n);                                          // ispisat će 6

            Console.WriteLine("Nakon metode Uvecaj: {0}", n);   // ispisat će 5

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
