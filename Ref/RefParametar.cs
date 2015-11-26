using System;

namespace Vsite.CSharp
{
    // Ilustracija korištenja ref parametra vrijednosnog tipa

    class RefParametar
    {
        // TODO: Dodati modifikator tako da se argument x metodi prenosi po referenci

        static void DodajDeset(int x)
        {
            x += 10;
            Console.WriteLine("Unutar metode DodajDeset: {0}", x);
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Prije metode DodajDeset: {0}", n);

            // TODO: Napisati poziv metode DodajDeset, pokrenuti program i ispis prekopirati u datoteku RefParametar.txt 


            Console.WriteLine("Nakon metode DodajDeset: {0}", n);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
