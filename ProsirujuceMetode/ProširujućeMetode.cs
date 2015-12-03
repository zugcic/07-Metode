using System;

namespace Vsite.CSharp
{
    // TODO: dodati proširujuću metodu (extension method) BrojRiječi klasi string koja kao rezultat vraća broj riječi


    class Program
    {
        static void Main(string[] args)
        {
            string s = "Kako je počeo rat na mom otoku";
            int brojRiječi = s.BrojRiječi();

            Console.WriteLine(brojRiječi);
            Console.ReadKey();
        }
    }
}
