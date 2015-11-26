using System;

namespace Metode
{
    class Program
    {
        static void Zamijeni(ref object o1, ref object o2)
        {
            Object temp = o2;
            o2 = o1;
            o1 = temp;
        }

        static void Main(string[] args)
        {
            string prvi = "prvi";
            string drugi = "drugi";

            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
            
            // prevoditelj javlja da ref string ne može pretvoriti u ref object:
            //Zamijeni(ref prvi, ref drugi);

            // prilikom poziva moramo prvo dodijeliti tip Object:
            object obj1 = prvi;
            object obj2 = drugi;
            Zamijeni(ref obj1, ref obj2);
            // zamijenjenima vratimo tip string:
            prvi = (string)obj1;
            drugi = (string)obj2;

            Console.WriteLine("Nakon metode 'Zamijeni'");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
