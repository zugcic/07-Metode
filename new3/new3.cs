using System;

namespace Vsite.CSharp
{
    // Primjer korištenja modifikatora new 

    // TODO: Prekopirati definicije klasa Bazna, Izvedena i NajIzvedena iz projekta new2. 
    // TODO: U klasu Bazna dodati virtualnu metodu void IspišiMiČlanove() te provjeriti što javlja prevoditelj
    // TODO: Dodati modifikator new u definiciji metode Izvedena.IspišiMiČlanove



    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Pokrenuti program, prekopirati ispis u datoteku new3.txt te dopisati obrazloženje

            Bazna[] niz = new Bazna[] { new Bazna(), new Izvedena(), new NajIzvedena() };

            foreach (Bazna b in niz)
            {
                b.PredstaviSe();
                Console.WriteLine();
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
