using System;

namespace Metode
{
    struct MojaStruktura {
        public MojaStruktura(int n) 
        { 
            N = n; 
        }
        
        public int N;
    }

    class Program
    {
        static void Uvecaj(MojaStruktura ms)
        {
            ms.N += 1;
            Console.WriteLine("Unutar metode Uvecaj: {0}", ms.N);
        }

        static void Main(string[] args)
        {
            MojaStruktura ms = new MojaStruktura(20);
            Console.WriteLine("Prije metode Uvecaj: {0}", ms.N);    // ispisat će 20
            Uvecaj(ms);                                             // ispisat će 21
            Console.WriteLine("Nakon metode Uvecaj: {0}", ms.N);    // ispisat će 20

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
   }
}
