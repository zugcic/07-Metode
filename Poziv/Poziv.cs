using System;

namespace Vsite.CSharp
{
    // ilustracija kako se razlučuje metoda koja će biti pozvana
    class MojaKlasa
    {
        void Metoda1()
        {
            Console.WriteLine("Metoda1()");
        }

        public void Metoda2(double broj)
        {
            Console.WriteLine("Metoda2({0})", broj);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk = new MojaKlasa();
            // TODO: Napisati poziv člana Metoda1 i člana Metoda2 s proslijeđenim cijelim brojem te izvesti program 


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
