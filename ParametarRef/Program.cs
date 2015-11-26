using System;

namespace Metode
{

    class Program
    {
        class MojaKlasa {
            public int N = 10;
        }

        static void Uvecaj(MojaKlasa mk)
        {
            mk.N += 1;
            Console.WriteLine("Unutar metode Uvecaj: {0}", mk.N);
        }

        static void Main(string[] args)
        {
            MojaKlasa mk = new MojaKlasa();
            Console.WriteLine("Prije metode Uvecaj: {0}", mk.N);    // ispisat će 10
            Uvecaj(mk);                                             // ispisat će 11
            Console.WriteLine("Nakon metode Uvecaj: {0}", mk.N);    // ispisat će 11

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
