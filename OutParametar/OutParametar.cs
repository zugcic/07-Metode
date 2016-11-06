using System;

namespace Vsite.CSharp
{
    public class OutParametar
    {
        // TODO: Dodati parametru metode modifikator out te promijeniti metodu PozivInicijalizacijeOutParametrom tako da se može prevesti i izvesti.
        static void InicijalizirajBrojNaDeset(int x)
        {
            x = 10;
        }

        public static void PozivInicijalizacijeOutParametrom()
        {
            int x = 0;
            InicijalizirajBrojNaDeset(x);
            Console.WriteLine(string.Format("Nakon InicijalizirajBrojNaDeset: {0}", x));
        }

        static void Main(string[] args)
        {
            PozivInicijalizacijeOutParametrom();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
