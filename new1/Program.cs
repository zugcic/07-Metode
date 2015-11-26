using System;

namespace new1
{
    class Bazna
    {
        public void NapisiMe()
        {
            Console.WriteLine("Bazna klasa");
        }
    }
    class Izvedena : Bazna
    {
        // ako ne stavimo new, prevoditelj će javiti upozorenje:
        //public void NapisiMe()
        public new void NapisiMe()
        {
            Console.Write("Izvedena klasa, izvedena iz: ");
            base.NapisiMe();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bazna b = new Bazna();
            b.NapisiMe();
            b = new Izvedena();
            b.NapisiMe();
            Izvedena i = new Izvedena();
            i.NapisiMe();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
