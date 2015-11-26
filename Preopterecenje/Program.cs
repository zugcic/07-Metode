using System;

namespace Preopterecenje
{
    class Program
    {
        public static void MojaMetoda()
        {
            Console.WriteLine("MojaMetoda()");
        }

        private static void MojaMetoda(int broj)
        {
            Console.WriteLine("MojaMetoda(int {0})", broj);
        }

        protected static void MojaMetoda(int broj1, int broj2)
        {
            Console.WriteLine("MojaMetoda(int {0}, int {1})", broj1, broj2);
        }

        protected static void MojaMetoda(double broj1, int broj2)
        {
            Console.WriteLine("MojaMetoda(double {0}, int {1})", broj1, broj2);
        }

        protected static void MojaMetoda(double broj1, double broj2)
        {
            Console.WriteLine("MojaMetoda(double {0}, double {1})", broj1, broj2);
        }


        /*
        // na ovu metodu prevoditelj će javiti pogrešku da već postoji MojaMetoda s istim potpisom
        private double MojaMetoda()
        {
            return 0;
        }
         */

        static void Main(string[] args)
        {
            int i1 = 1;
            int i2 = 2;
            double d1 = 3;
            double d2 = 4;
            MojaMetoda(i1, d1);
            MojaMetoda(d1, d2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
