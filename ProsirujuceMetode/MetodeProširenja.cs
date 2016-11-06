using System;

namespace Vsite.CSharp
{
    // TODO: Dodati metodu proširenja (extension method) BrojRiječi klasi string koja kao rezultat vraća broj riječi

    

    public class MetodeProširenja
    {
        public static int DajBrojRiječi(string tekst)
        {
            // TODO: Zamijenite povratnu vrijednost rezultatom metode proširenja BrojRiječi.
            return 0;
        }

        static void Main(string[] args)
        {
            string s = "Kako je počeo rat na mom otoku?";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            s = "Jedna, dva, tri!";
            Console.WriteLine("U '{0}' ima {1} riječi.", s, DajBrojRiječi(s));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
