using System;

namespace Metode
{
    class Program
    {
        static void DodajDeset(ref int x)
        {
            // uvećava vrijednost na koju referencira x za 10
            x += 10;
            Console.WriteLine("Unutar metode DodajDeset: {0}", x); // ispisuje 15
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Prije metode DodajDeset: {0}", n); // ispisuje 5

            DodajDeset(ref n);

            Console.WriteLine("Nakon metode DodajDeset: {0}", n); // ispisuje 15

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
