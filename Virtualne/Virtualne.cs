using System;

namespace Vsite.CSharp
{
    // Primjer s virtualnim metodama

    class Bazna
    {
        public virtual void PredstaviSe()
        {
            Console.WriteLine("Ja sam Bazna");
        }
    }

    class Izvedena : Bazna
    {
        // TODO: pregaziti virtualnu metodu PredstaviSe tako da ispiše ime klase

    }

    class Izvedena2 : Bazna
    {
        // TODO: pregaziti virtualnu metodu PredstaviSe tako da ispiše ime klase

    }

    class Program
    {

        static void Main(string[] args)
        {
            // TODO: Izvesti program, ispis prekopirati u datoteku Virtualne.txt te dopisati obrazloženje
            Bazna[] bazne = new Bazna[] { new Bazna(), new Izvedena(), new Izvedena2()};
            foreach (Bazna b in bazne)
            {
                b.PredstaviSe();
                Console.WriteLine();
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
