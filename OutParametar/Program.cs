using System;

namespace Metode
{
    class Program
    {
        static void InicijalizirajBrojNaDeset(out int x)
        {
            // postavlja vrijednost na koju referencira x na 10
            x = 10;
        }

        static void Main(string[] args)
        {
            int x;
            InicijalizirajBrojNaDeset(out x);
            Console.WriteLine("Nakon metode InicijalizirajBrojNaDeset: {0}", x);            // ispisuje 10

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
