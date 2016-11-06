using System;

namespace Vsite.CSharp
{

    public class Params
    {
        // TODO: Napisati implementaciju metode tako da vrati zbroj svih proslijeđenih argumenata
        public static double Zbroji(params double[] pribrojnici)
        {
            return 0.0;
        }

        static void Main(string[] args)
        {
            double zbroj = Zbroji(1, 2, 3, 4);
            Console.WriteLine(zbroj);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

    }
}
